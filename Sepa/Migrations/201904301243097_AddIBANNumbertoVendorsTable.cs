namespace Sepa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIBANNumbertoVendorsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vendors", "Vendor_IBAN", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vendors", "Vendor_IBAN");
        }
    }
}
