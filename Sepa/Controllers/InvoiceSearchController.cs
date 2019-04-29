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
        public ActionResult Index(string searchBy, string search)
 
        {

            var inv = from invoice in db.Invoices

                       where invoice.Vendors.Vendor_Name.StartsWith(search) 
                       orderby invoice.Vendor_ID, invoice.Invoice_ID

                       select invoice;

            return View(inv.ToList());
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

            //return RedirectToAction("Index");
            return View();

        }
    }
}

