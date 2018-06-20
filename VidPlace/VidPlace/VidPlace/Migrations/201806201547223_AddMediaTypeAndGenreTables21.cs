namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMediaTypeAndGenreTables21 : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Media", "Genres_Id", "dbo.Genres");
            //DropForeignKey("dbo.Media", "MediaType_Id", "dbo.MediaTypes");
            //DropIndex("dbo.Media", new[] { "Genres_Id" });
            //DropIndex("dbo.Media", new[] { "MediaType_Id" });
            //AlterColumn("dbo.Media", "Genres_Id", c => c.Byte(nullable: false));
            //AlterColumn("dbo.Media", "MediaType_Id", c => c.Byte(nullable: false));
            //AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            //AlterColumn("dbo.MediaTypes", "Name", c => c.String(nullable: false, maxLength: 255));
            //CreateIndex("dbo.Media", "Genres_Id");
            //CreateIndex("dbo.Media", "MediaType_Id");
            //AddForeignKey("dbo.Media", "Genres_Id", "dbo.Genres", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.Media", "MediaType_Id", "dbo.MediaTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Media", "MediaType_Id", "dbo.MediaTypes");
            //DropForeignKey("dbo.Media", "Genres_Id", "dbo.Genres");
            //DropIndex("dbo.Media", new[] { "MediaType_Id" });
            //DropIndex("dbo.Media", new[] { "Genres_Id" });
            //AlterColumn("dbo.MediaTypes", "Name", c => c.String());
            //AlterColumn("dbo.Genres", "Name", c => c.String());
            //AlterColumn("dbo.Media", "MediaType_Id", c => c.Byte());
            //AlterColumn("dbo.Media", "Genres_Id", c => c.Byte());
            //CreateIndex("dbo.Media", "MediaType_Id");
            //CreateIndex("dbo.Media", "Genres_Id");
            //AddForeignKey("dbo.Media", "MediaType_Id", "dbo.MediaTypes", "Id");
            //AddForeignKey("dbo.Media", "Genres_Id", "dbo.Genres", "Id");
        }
    }
}
