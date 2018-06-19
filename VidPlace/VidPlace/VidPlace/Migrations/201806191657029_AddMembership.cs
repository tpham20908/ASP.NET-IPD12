namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembership : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Memberships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MembershipId", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "Membership_Id", c => c.Int());
            CreateIndex("dbo.Customers", "Membership_Id");
            AddForeignKey("dbo.Customers", "Membership_Id", "dbo.Memberships", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Membership_Id", "dbo.Memberships");
            DropIndex("dbo.Customers", new[] { "Membership_Id" });
            DropColumn("dbo.Customers", "Membership_Id");
            DropColumn("dbo.Customers", "MembershipId");
            DropTable("dbo.Memberships");
        }
    }
}
