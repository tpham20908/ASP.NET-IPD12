namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConstrainsToTables : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Brands", "BrandName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Phones", "PhoneName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Phones", "ScreenSize", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PhoneTypes", "Type", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.PhoneTypes", "OS", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PhoneTypes", "OS", c => c.String());
            AlterColumn("dbo.PhoneTypes", "Type", c => c.String());
            AlterColumn("dbo.Phones", "ScreenSize", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Phones", "PhoneName", c => c.String());
            AlterColumn("dbo.Brands", "BrandName", c => c.String());
        }
    }
}
