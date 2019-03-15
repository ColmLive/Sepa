namespace Sepa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CountryandCurrencytoStringVendorClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vendors", "Vendor_Country", c => c.String(nullable: false));
            AlterColumn("dbo.Vendors", "Vendor_Currency", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendors", "Vendor_Currency", c => c.Int(nullable: false));
            AlterColumn("dbo.Vendors", "Vendor_Country", c => c.Int(nullable: false));
        }
    }
}
