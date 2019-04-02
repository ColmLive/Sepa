using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using Sepa.DAL;
using Sepa.Models;
using System.Xml.Serialization;
using System.IO;

namespace Sepa.Controllers
{
    public class PaymentXMLController : Controller
    {
        public SepaContext db = new SepaContext();
        // GET: InvoiceUpdate
        public ActionResult Index()
        {

            var data = from item in db.Invoices
                       group item by item.Vendor_ID into PaymentXML
                       select new {
                          VendorID = PaymentXML.Key,
                          VendorAmount = PaymentXML.Sum(s=>s.Vendor_ID)

                       };

                       

            return View(data.ToList());
        }

        /*
        [HttpPost]

        public ActionResult Index(List<Invoice> invoices)

        {


            foreach (Invoice inv in invoices)
            {

                Invoice invoice = db.Invoices.Find(inv.Invoice_ID);

                invoice.Posting_Date = inv.Posting_Date;

                invoice.Posting_Desc = inv.Posting_Desc;

                invoice.StatusCode = inv.StatusCode;


            }
            db.SaveChanges();

            return RedirectToAction("Index");
            //return View();

        }
        */
    }
}

