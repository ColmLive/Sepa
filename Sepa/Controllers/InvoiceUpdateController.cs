using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;
using System.IO;
using Sepa.DAL;
using System.Xml;
using Sepa.Models;

namespace Sepa.Controllers
{
    public class InvoiceUpdateController : Controller
    {
        private SepaContext db = new SepaContext();
        // GET: InvoiceUpdate
        public ActionResult Index()
        {

            //var inv = db.Invoices.Include(w => w.Invoice_ID).Where(w => w.Invoice_ID > 1);
            var inv = from item in db.Invoices

                       where item.Invoice_ID < 10800
                       orderby item.Vendor_ID, item.Invoice_ID
                       select item;

            using (XmlWriter writer = XmlWriter.Create(@"c:\temp\test.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Invoices");

                foreach (Invoice invoice in inv)
                {
                    writer.WriteStartElement("Invoice");

                    writer.WriteElementString("ID", invoice.Invoice_ID.ToString());
                    writer.WriteElementString("Currency", invoice.Currency_Code);
                    //writer.WriteElementString("Vendor", invoice.Vendors.Vendor_Name);


                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
           
            return View();
        }
    }
}

