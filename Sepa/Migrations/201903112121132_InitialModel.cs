namespace Sepa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        Vendor_ID = c.Int(nullable: false, identity: true),
                        Vendor_Name = c.String(nullable: false, maxLength: 50),
                        Vendor_Address = c.String(nullable: false, maxLength: 50),
                        Vendor_Address2 = c.String(),
                        Vendor_City = c.String(nullable: false, maxLength: 50),
                        Vendor_Country = c.Int(nullable: false),
                        Vendor_Currency = c.Int(nullable: false),
                        Vendor_Email = c.String(nullable: false),
                        Vendor_Phone = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Vendor_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vendors");
        }
    }
}
