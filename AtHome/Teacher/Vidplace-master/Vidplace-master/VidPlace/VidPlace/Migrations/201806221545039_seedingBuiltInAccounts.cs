namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingBuiltInAccounts : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd98e0a79-f5c0-4795-ac6c-363d37b62eff', N'admin@vidplace.com', 0, N'AN4Nwc5Ev7EZQsQPeqEc7qx9gZQgVYGiAR4T26grIaAasHGavsT+8oFZonI0JSx8Kg==', N'85b31097-277e-48a0-b94d-16b4df504186', NULL, 0, 0, NULL, 1, 0, N'admin@vidplace.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ee963df4-2188-47c5-b751-133676da933a', N'guest@vidplace.com', 0, N'AEiN+4QCceasLfkrl7UozH3tFserWSSrbLEwlQY/sWmyX7AO7fOBIVfC509xx8PHOA==', N'06e36a40-f5cc-4c7f-9846-9a33c14c3f9b', NULL, 0, 0, NULL, 1, 0, N'guest@vidplace.com')");
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0331aee8-7009-459c-a5a0-3456d5b0bd20', N'CanManageMedia')");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd98e0a79-f5c0-4795-ac6c-363d37b62eff', N'0331aee8-7009-459c-a5a0-3456d5b0bd20')");

        }
        
        public override void Down()
        {
        }
    }
}
