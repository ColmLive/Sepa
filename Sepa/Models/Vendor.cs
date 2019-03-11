using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sepa.Models
{
    public enum Country
    {
        [Display(Name = "Ireland")] IRL,
        [Display(Name = "United Kingdom")] UK,
        [Display(Name = "Japan")] JPN,
        [Display(Name = "USA")] USA,
        [Display(Name = "Australia")] AUS
    }

    public enum Currency
    {
        [Display(Name = "Euros")] EUR,
        [Display(Name = "Sterling")] STG,
        [Display(Name = "Yen")] YEN,
        [Display(Name = "Dollars")] USD,
        [Display(Name = "Australian Dollar")] AUD
    }
    public class Vendor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        //[ConcurrencyCheck, MaxLength(4, ErrorMessage = "Vendor code must be 4 Char long."), MinLength(4)]
        [Required(ErrorMessage = "Please enter ID")]
        public int Vendor_ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3)]
        public string Vendor_Name { get; set; }

        [Required(ErrorMessage = "At least 1 line of address is required")]
        [StringLength(50, MinimumLength = 3)]
        public string Vendor_Address { get; set; }

        //[Required]
        public string Vendor_Address2 { get; set; }

        [Required(ErrorMessage = "Please enter City")]
        [StringLength(50, MinimumLength = 3)]
        public string Vendor_City { get; set; }

        [Required(ErrorMessage = "Please enter Country Code")]
        public Country Vendor_Country { get; set; }

        [Required(ErrorMessage = "Please enter Currency Code")]
        public Currency Vendor_Currency { get; set; }
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Vendor_Email { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 9)]
        [Display(Name = "Phone Number")]
        [Phone]
        public string Vendor_Phone { get; set; }

        // Navigation Properties
        /*
        public ICollection<Work> Building_Works { get; set; }

        public Nullable<int> WorkId { get; set; }
        */
        //CJC - Add Navigation to Invoice / BIC / Payment as appropriate
        // Constructor
        public Vendor(int Vendor_ID, string Vendor_Name, string Vendor_Address, string Vendor_Address2, string Vendor_City, Country Vendor_Country, Currency Vendor_Currency, string Vendor_Email, string Vendor_Phone)
        {
            this.Vendor_ID = Vendor_ID;
            this.Vendor_Name = Vendor_Name;
            this.Vendor_Address = Vendor_Address;
            this.Vendor_Address2 = Vendor_Address2;
            this.Vendor_City = Vendor_City;
            this.Vendor_Country = Vendor_Country;
            this.Vendor_Currency = Vendor_Currency;
            this.Vendor_Email = Vendor_Email;
            this.Vendor_Phone = Vendor_Phone;
        }

        public Vendor()
        {
        }
    }
}

