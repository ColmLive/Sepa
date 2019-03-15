namespace Sepa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRequiredFieldsVendorModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vendors", "Vendor_City", c => c.String());
            AlterColumn("dbo.Vendors", "Vendor_Email", c => c.String());
            AlterColumn("dbo.Vendors", "Vendor_Phone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendors", "Vendor_Phone", c => c.String(nullable: true, maxLength: 30));
            AlterColumn("dbo.Vendors", "Vendor_Email", c => c.String(nullable: true));
            AlterColumn("dbo.Vendors", "Vendor_City", c => c.String(nullable: true, maxLength: 50));
        }
    }
}
