namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRecordsToPhoneTypes : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[PhoneTypes] ([Id], [Type], [OS]) VALUES (1, N'Smart', N'Android')
                INSERT INTO [dbo].[PhoneTypes] ([Id], [Type], [OS]) VALUES (2, N'Smart', N'iOS')
                INSERT INTO [dbo].[PhoneTypes] ([Id], [Type], [OS]) VALUES (3, N'Bar', N'N/A')
                INSERT INTO [dbo].[PhoneTypes] ([Id], [Type], [OS]) VALUES (4, N'Flip', N'N/A')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
