using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using Sepa.DAL;
using Sepa.Models;

namespace Sepa.Controllers
{
    public class InvoiceSearchController : Controller
    {
        public SepaContext db = new SepaContext();

        [HttpGet]
        public ActionResult Index(string SearchBy, string search)

        {

            var inv = from invoice in db.Invoices

                      where invoice.Vendors.Vendor_Name.StartsWith(search)
                      orderby invoice.Vendor_ID, invoice.Invoice_ID

                      select invoice;

            if (SearchBy == "Entered") 

            { return View(db.Invoices.Where(x => x.StatusCode==(Status.Entered)).ToList());
            }
            else if (SearchBy == "SEPA")
            {
                return View(db.Invoices.Where(x => x.StatusCode == (Status.SEPA)).ToList());
            }
            else if (SearchBy == "Posted")
            {
                return View(db.Invoices.Where(x => x.StatusCode == (Status.Posted)).ToList());
            }
            else if (SearchBy == "Completed")
            {
                return View(db.Invoices.Where(x => x.StatusCode == (Status.Completed)).ToList());
            }
            else
            { return View(db.Invoices.Where(x => x.Vendors.Vendor_Name.StartsWith(search)).ToList()); }
        }
 
        [HttpPost]

        public ActionResult Index(List<Invoice> invoices)

        {

            foreach (Invoice inv in invoices)
            {

                Invoice invoice = db.Invoices.Find(inv.Invoice_ID);
                
                invoice.Due_Date = inv.Due_Date;

                invoice.Posting_Desc = inv.Posting_Desc;

                invoice.Invoice_Value = inv.Invoice_Value;

                invoice.StatusCode = inv.StatusCode;


            }
            db.SaveChanges();

            //return RedirectToAction("Index");
            return View();

        }
    }
}

