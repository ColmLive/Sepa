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
        // GET: InvoiceUpdate
        [HttpGet]
        public ActionResult Index(string searchBy, string search)
        {

            var data = from item in db.Invoices

                       where item.Invoice_ID < 10800
                       orderby item.Vendor_ID, item.Invoice_ID

                       select item;

            return View(data.ToList());
        }
              /*
            if (searchBy == "Status")

            {
                //   return View(db.Invoices.Where(x => x.StatusCode = search)).ToList());
            }
            else
            {
                //return View(db.Invoices.Where(x => x.Vendors.Vendor_Name.StartsWith(search).ToList());
            }
            return View();
        }
        */

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
    }
}

