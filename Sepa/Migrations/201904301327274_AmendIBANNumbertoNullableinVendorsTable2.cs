namespace Sepa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AmendIBANNumbertoNullableinVendorsTable2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vendors", "Vendor_IBAN", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendors", "Vendor_IBAN", c => c.String(maxLength: 20));
        }
    }
}
