namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'32e93dcf-dc5a-4791-ae65-1b808f2378f1', N'tp@email.com', 0, N'AH8uWF3Mbr1WghVS/EPNP9IxMOflC2I+A2jsqbav0yGkWf+eEpUFW0duETMKs+GcGQ==', N'357c03a2-d03b-4e66-a6e5-5a6a4bea68ba', NULL, 0, 0, NULL, 1, 0, N'tp@email.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'88247507-7232-4a57-91a3-3383e93091bc', N'admin@email.com', 0, N'ANFUdGJ97zAt6IawqESmTexiuBDB7q4HOhimt37IF3FhbBnI2wjT9iPFdsXHo7g58A==', N'ec1a0885-813c-4c18-a5ea-33f6cf4c2fc2', NULL, 0, 0, NULL, 1, 0, N'admin@email.com')
");
            Sql(@"
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ea3a00d9-7b96-47b7-a156-1cc38f431e2f', N'CanManageMedia')
");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'88247507-7232-4a57-91a3-3383e93091bc', N'ea3a00d9-7b96-47b7-a156-1cc38f431e2f')
");
        }

        public override void Down()
        {
        }
    }
}
