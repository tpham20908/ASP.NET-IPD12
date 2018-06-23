namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCustomerAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "address");
        }
    }
}
