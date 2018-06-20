namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTypeAndGenreToMedia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Media", "Type", c => c.String());
            AddColumn("dbo.Media", "Genre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Media", "Genre");
            DropColumn("dbo.Media", "Type");
        }
    }
}
