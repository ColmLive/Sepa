namespace Sepa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInvoice_ValueColumToInvoiceTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "Invoice_Value", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Invoices", "Invoice_Value");
        }
    }
}
