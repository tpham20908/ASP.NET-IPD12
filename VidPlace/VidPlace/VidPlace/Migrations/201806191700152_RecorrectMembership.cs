namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecorrectMembership : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Membership_Id", "dbo.Memberships");
            DropIndex("dbo.Customers", new[] { "Membership_Id" });
            DropColumn("dbo.Customers", "MembershipId");
            RenameColumn(table: "dbo.Customers", name: "Membership_Id", newName: "MembershipId");
            DropPrimaryKey("dbo.Memberships");
            AlterColumn("dbo.Customers", "MembershipId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Memberships", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Memberships", "Id");
            CreateIndex("dbo.Customers", "MembershipId");
            AddForeignKey("dbo.Customers", "MembershipId", "dbo.Memberships", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipId", "dbo.Memberships");
            DropIndex("dbo.Customers", new[] { "MembershipId" });
            DropPrimaryKey("dbo.Memberships");
            AlterColumn("dbo.Memberships", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Customers", "MembershipId", c => c.Int());
            AddPrimaryKey("dbo.Memberships", "Id");
            RenameColumn(table: "dbo.Customers", name: "MembershipId", newName: "Membership_Id");
            AddColumn("dbo.Customers", "MembershipId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "Membership_Id");
            AddForeignKey("dbo.Customers", "Membership_Id", "dbo.Memberships", "Id");
        }
    }
}
