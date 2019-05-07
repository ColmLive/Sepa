using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sepa.DAL;
using Sepa.Models;

namespace Sepa.Controllers
{
    public class InvController : Controller
    {
        public SepaContext db = new SepaContext();

        public ActionResult Index()
        {
            var model = new InvSelectionViewModel();
            foreach (var Invoice in db.Invoices)
            {
                var editorViewModel = new SelectInvoiceEditorViewModel()
                {
                    Invoice_ID = Invoice.Invoice_ID,
                    Name = string.Format("{0} {1}", Invoice.Posting_Desc, Invoice.Vendors.Vendor_Name),
                    Selected = true
                };
                model.Inv.Add(editorViewModel);
            }
            return View(model);
        }


        [HttpPost]
        public ActionResult SubmitSelected(InvSelectionViewModel model)
        {
            // get the ids of the items selected:
            var selectedIds = model.getSelectedIds();

            // Use the ids to retrieve the records for the selected Inv
            // from the database:
            var selectedInv = from x in db.Invoices
                                 where selectedIds.Contains(x.Invoice_ID)
                                 select x;

            // Process according to your requirements:
            foreach (var Invoice in selectedInv)
            {
                System.Diagnostics.Debug.WriteLine(
                    string.Format("{0} {1}", Invoice.Posting_Desc, Invoice.Vendors.Vendor_Name));
            }

            // Redirect somewhere meaningful (probably to somewhere showing 
            // the results of your processing):
            return RedirectToAction("Index");
        }
    }
}