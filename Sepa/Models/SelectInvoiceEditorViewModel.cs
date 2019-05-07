using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sepa.Models
{
    public class SelectInvoiceEditorViewModel
    {
        public bool Selected { get; set; }
        public int Invoice_ID { get; set; }
        public string Posting_Desc { get; set; }
        public double? Invoice_Value { get; set; }
        public string Name { get; set; }
    }
}