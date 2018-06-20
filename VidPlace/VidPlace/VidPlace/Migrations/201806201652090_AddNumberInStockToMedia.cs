namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberInStockToMedia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Media", "NumberInStock", c => c.Int(nullable: false));
            DropColumn("dbo.Media", "Type");
            DropColumn("dbo.Media", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Media", "Genre", c => c.String());
            AddColumn("dbo.Media", "Type", c => c.String());
            DropColumn("dbo.Media", "NumberInStock");
        }
    }
}
