using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Sepa.Models
{
    public class InvSelectionViewModel
    {
        public List<SelectInvoiceEditorViewModel> Inv { get; set; }
        public InvSelectionViewModel()
        {
            this.Inv = new List<SelectInvoiceEditorViewModel>();
        }


        public IEnumerable<int> getSelectedIds()
        {
            // Return an Enumerable containing the Id's of the selected Invoices:
            return (from p in this.Inv where p.Selected select p.Invoice_ID).ToList();
        }
    }
}