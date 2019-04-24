using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sepa.Models
{
    [Serializable]
    public class Invoice
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[ConcurrencyCheck, MaxLength(4, ErrorMessage = "Vendor code must be 4 Char long."), MinLength(4)]
        //[Required(ErrorMessage = "Please enter ID")]
        [Key]
        public int Invoice_ID { get; set; }
        public string Currency_Code { get; set; }
        public double Discount { get; set; }
        public DateTime? Due_Date { get; set; }
        public DateTime? Posting_Date { get; set; }
        public string Posting_Desc { get; set; }
        public Status StatusCode { get; set; }
        public int          Vendor_ID { get; set; }
        public string       Vendor_InvNo { get; set; }

        //Collective Navigation Property
        public virtual Vendor Vendors { get; set; }

        // Constructor
        public Invoice(string Currency, double Discount, DateTime? Due_Date, DateTime? Posting_Date, string Posting_Desc, Status StatusCode, int Vendor_ID,  string Vendor_InVNo)
        {
            this.Currency_Code = Currency_Code;
            this.Discount = Discount;
            this.Due_Date = Due_Date;
            this.Posting_Date = Posting_Date;
            this.Posting_Desc = Posting_Desc;
            this.StatusCode = StatusCode;
            this.Vendor_ID = Vendor_ID;
            this.Vendor_InvNo = Vendor_InvNo;
        }

        public Invoice()
        {
        }
    }
}

