using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using Sepa.DAL;
using Sepa.Models;

namespace Sepa.Controllers
{
    public class InvoiceEditController : Controller
    {
        public SepaContext db = new SepaContext();
        // GET: InvoiceUpdate
             public ActionResult Index()
              {

              var data = from item in db.Invoices

              where item.Invoice_ID < 10953
              orderby item.Vendor_ID,item.Invoice_ID

              select item;

              return View(data.ToList());
              }

         
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

