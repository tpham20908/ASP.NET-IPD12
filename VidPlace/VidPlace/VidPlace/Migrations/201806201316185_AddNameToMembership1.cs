namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembership1 : DbMigration
    {
        public override void Up()
        {
            Sql(
                "UPDATE Memberships SET Name = 'Pay as you go' WHERE Id = 1 " +
                "UPDATE Memberships SET Name = 'Monthly' WHERE Id = 2 " +
                "UPDATE Memberships SET Name = 'Quarterly' WHERE Id = 3 " +
                "UPDATE Memberships SET Name = 'Annual' WHERE Id = 4"
                );
        }
        
        public override void Down()
        {
        }
    }
}
