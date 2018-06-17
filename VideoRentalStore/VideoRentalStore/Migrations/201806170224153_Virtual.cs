namespace VideoRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Virtual : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.RentalRecords", new[] { "Customer_ID" });
            CreateIndex("dbo.RentalRecords", "customer_ID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.RentalRecords", new[] { "customer_ID" });
            CreateIndex("dbo.RentalRecords", "Customer_ID");
        }
    }
}
