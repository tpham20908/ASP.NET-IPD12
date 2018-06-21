namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDisplayNameAndImageUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Phones", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Phones", "ImageUrl");
        }
    }
}
