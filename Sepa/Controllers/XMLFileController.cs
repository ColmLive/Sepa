using Sepa.DAL;
using Sepa.Models;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Xml;

namespace Sepa.Controllers
{
    public class XMLFileController : Controller
    {
        private SepaContext db = new SepaContext();
        // GET: InvoiceUpdate
        public ActionResult Index()
        {

            //*** Generate Transaction File to post to Financial System ***//
            var inv = from item in db.Invoices

                      where item.StatusCode == Status.SEPA
                      orderby item.Vendor_ID, item.Invoice_ID
                      select item;

            using (XmlWriter writer = XmlWriter.Create(@"c:\temp\test.xml"))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("Invoices");

                foreach (Invoice invoice in inv)
                {
                    writer.WriteStartElement("Invoice");

                    writer.WriteElementString("InvoiceID", invoice.Invoice_ID.ToString());
                    writer.WriteElementString("InvoiceValue", invoice.Invoice_Value.ToString());
                    writer.WriteElementString("PostingDate", invoice.Posting_Date.ToString());
                    writer.WriteElementString("PostingDesc", invoice.Posting_Desc.ToString());
                    writer.WriteElementString("VendorID", invoice.Vendor_ID.ToString());
                    writer.WriteElementString("VendorInvNo", invoice.Vendor_InvNo.ToString());
                    writer.WriteElementString("Currency", invoice.Currency_Code);
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            //*** Generate Payment File to post to SEPA System ***//

            //*** Part 1 - Generate Summary Totals for XML File ***//
            var query = db.Invoices.GroupBy(g => new
            {
                g.StatusCode
            })
             .Select(group => new
             {
                 StatusCode = group.Key.StatusCode,
                 TotalAmount = group.Sum(a => a.Invoice_Value),
                 TotalCount = group.Count()
             });

            //*** Write SEPA Totals to XML File ***//

            using (XmlWriter writer = XmlWriter.Create(@"c:\temp\pay.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Payments");
                writer.WriteStartElement("Summary");

                //*** Select only SEPA Status ***//

                foreach (var item in query.Where(a => a.StatusCode == Status.SEPA))
                {
                    writer.WriteElementString("Totals", item.TotalAmount.ToString());
                    writer.WriteElementString("Totals", item.TotalCount.ToString());
                    writer.WriteElementString("Totals", item.StatusCode.ToString());

                }
                writer.WriteEndElement();

                //*** Part 2 - Generate Summary Totals for Payment Information Block ***//
                var query2 = db.Invoices.GroupBy(g => new
                {
                    g.StatusCode
                })
                 .Select(group => new
                 {
                     StatusCode = group.Key.StatusCode,
                     TotalAmount = group.Sum(a => a.Invoice_Value),
                     TotalCount = group.Count()
                 });

                //*** Write Payment Information Totals to XML File ***//
                {
                    //writer.WriteStartDocument();
                    writer.WriteStartElement("PIB");
                    writer.WriteStartElement("Summary");

                    //*** Select only SEPA Status ***//

                    foreach (var item in query2.Where(a => a.StatusCode == Status.SEPA))
                    {
                        writer.WriteElementString("PIBTotals", item.TotalAmount.ToString());
                        writer.WriteElementString("PIBTotals", item.TotalCount.ToString());
                        writer.WriteElementString("PIBTotals", item.StatusCode.ToString());

                    }
                    writer.WriteEndElement();

                    //*** Part 3 - Generate a single payment foe each Payee ***//
                    var query3 = db.Invoices.GroupBy(g => new
                    {
                        g.StatusCode,g.Vendors.Vendor_Name
                    })
                     .Select(group => new
                     {
                         StatusCode = group.Key.StatusCode,
                         VendorCode = group.Key.Vendor_Name,
                         TotalAmount = group.Sum(a => a.Invoice_Value),
                         TotalCount = group.Count()
                     });

                    //*** Write Payment Information Totals to XML File ***//

                    {
                        //writer.WriteStartDocument();
                        writer.WriteStartElement("Dbtr");
                        //writer.WriteStartElement("Summary");

                        //*** Select only SEPA Status ***//

                        foreach (var item in query3.Where(a => a.StatusCode == Status.SEPA))
                        {
                            writer.WriteElementString("DtrAmount", item.TotalAmount.ToString());
                            writer.WriteElementString("DtrCount", item.TotalCount.ToString());
                            writer.WriteElementString("DtrName", item.VendorCode.ToString());

                        }
                        writer.WriteEndElement();


                        writer.WriteEndDocument();
                    }

                    return View();
                }
            }
        }
    }
}


