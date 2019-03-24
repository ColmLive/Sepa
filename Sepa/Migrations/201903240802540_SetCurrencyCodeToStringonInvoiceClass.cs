namespace Sepa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetCurrencyCodeToStringonInvoiceClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Invoices", "Currency_Code", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Invoices", "Currency_Code", c => c.Int(nullable: false));
        }
    }
}
