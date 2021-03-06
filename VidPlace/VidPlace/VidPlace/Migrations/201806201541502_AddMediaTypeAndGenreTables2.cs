namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMediaTypeAndGenreTables2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MediaTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Media", "Genres_Id", c => c.Byte());
            AddColumn("dbo.Media", "MediaType_Id", c => c.Byte());
            CreateIndex("dbo.Media", "Genres_Id");
            CreateIndex("dbo.Media", "MediaType_Id");
            AddForeignKey("dbo.Media", "Genres_Id", "dbo.Genres", "Id");
            AddForeignKey("dbo.Media", "MediaType_Id", "dbo.MediaTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Media", "MediaType_Id", "dbo.MediaTypes");
            DropForeignKey("dbo.Media", "Genres_Id", "dbo.Genres");
            DropIndex("dbo.Media", new[] { "MediaType_Id" });
            DropIndex("dbo.Media", new[] { "Genres_Id" });
            DropColumn("dbo.Media", "MediaType_Id");
            DropColumn("dbo.Media", "Genres_Id");
            DropTable("dbo.MediaTypes");
            DropTable("dbo.Genres");
        }
    }
}
