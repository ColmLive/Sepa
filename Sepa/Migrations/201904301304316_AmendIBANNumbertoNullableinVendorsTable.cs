namespace Sepa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AmendIBANNumbertoNullableinVendorsTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vendors", "Vendor_IBAN", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendors", "Vendor_IBAN", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
