namespace Sepa.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Sepa.Models;
    
   


    internal sealed class Configuration : DbMigrationsConfiguration<Sepa.DAL.SepaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Sepa.DAL.SepaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var vendor = new List<Vendor>
            {
 //               new Models.Vendor { Vendor_ID = 1, Vendor_Name = "Vendor 1" , Vendor_Address = "Add1", Vendor_Address2 = "Add2", Vendor_City = "Dublin", Vendor_Country = "Ireland", Vendor_Currency = "EUR", Vendor_Email = "v1@test.com", Vendor_Phone = "012314444" },
 //               new Models.Vendor { Vendor_ID = 2, Vendor_Name = "Vendor 2" , Vendor_Address = "Add3", Vendor_Address2 = "Add4", Vendor_City = "London", Vendor_Country = "UK", Vendor_Currency = "STG", Vendor_Email = "v2@test.com", Vendor_Phone = "004412315555" },
 //               new Models.Vendor { Vendor_ID = 3, Vendor_Name = "Vendor 3" , Vendor_Address = "Add5", Vendor_Address2 = "Add6", Vendor_City = "New York", Vendor_Country = "USA", Vendor_Currency = "USD/PL", Vendor_Email = "v3@test.com", Vendor_Phone = "0015552316666" },
            };    
            
           
           vendor.ForEach(s => context.Vendors.Add(s));
        
            context.SaveChanges();
        }
    }
}
