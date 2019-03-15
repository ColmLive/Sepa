namespace Sepa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateInvoiceClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Invoice_ID = c.Int(nullable: false, identity: true),
                        Currency_Code = c.Int(nullable: false),
                        Discount = c.Double(nullable: false),
                        Due_Date = c.DateTime(),
                        Posting_Date = c.DateTime(),
                        Posting_Desc = c.String(),
                        StatusCode = c.Int(nullable: false),
                        Vendor_ID = c.Int(nullable: false),
                        Vendor_InvNo = c.String(),
                    })
                .PrimaryKey(t => t.Invoice_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Invoices");
        }
    }
}
