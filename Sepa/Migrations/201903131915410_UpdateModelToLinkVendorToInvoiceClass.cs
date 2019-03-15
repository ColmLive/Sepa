namespace Sepa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModelToLinkVendorToInvoiceClass : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Invoices", "Vendor_ID");
            AddForeignKey("dbo.Invoices", "Vendor_ID", "dbo.Vendors", "Vendor_ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoices", "Vendor_ID", "dbo.Vendors");
            DropIndex("dbo.Invoices", new[] { "Vendor_ID" });
        }
    }
}
