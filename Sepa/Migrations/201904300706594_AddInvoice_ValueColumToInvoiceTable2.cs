namespace Sepa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInvoice_ValueColumToInvoiceTable2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Invoices", "Invoice_Value", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Invoices", "Invoice_Value", c => c.Double(nullable: false));
        }
    }
}
