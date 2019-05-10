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
            var data = from b in db.Invoices
                       where b.StatusCode == Status.SEPA
                       group b by b.StatusCode   into g
                       select new Group<string, Invoice> { Key = g.Key.ToString(), Values = g };
            using (XmlWriter writer = XmlWriter.Create(@"c:\temp\pay.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Payments");
                writer.WriteStartElement("Summary");
                writer.WriteElementString("Totals", .ToString());

                writer.WriteEndElement();
                

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

            return View();
        }
    }
}


