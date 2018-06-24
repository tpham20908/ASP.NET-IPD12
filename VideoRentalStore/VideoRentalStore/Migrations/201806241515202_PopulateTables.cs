namespace VideoRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTables : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Customers] ON
                INSERT INTO [dbo].[Customers] ([ID], [FirstName], [LastName], [Address], [PhoneNumber]) VALUES (9, N'John', N'Doe', N'1005 1st Ave, Montreal, Quebec', N'555-555-5555')
                INSERT INTO [dbo].[Customers] ([ID], [FirstName], [LastName], [Address], [PhoneNumber]) VALUES (10, N'Justin', N'Trudeau', N'9999 Victoria, BC', N'666-777-8888')
                INSERT INTO [dbo].[Customers] ([ID], [FirstName], [LastName], [Address], [PhoneNumber]) VALUES (11, N'Peter', N'Parker', N'12345 Main Street, WA', N'999-999-9999')
                SET IDENTITY_INSERT [dbo].[Customers] OFF
                ");
            Sql(@"SET IDENTITY_INSERT [dbo].[RentalRecords] ON
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (72, N'2018-06-14 13:20:21', 9)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (73, N'2018-06-16 13:20:21', 9)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (74, N'2018-06-12 13:20:21', 10)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (75, N'2018-06-10 13:20:21', 10)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (76, N'2018-06-16 13:20:21', 10)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (77, N'2018-06-17 13:21:37', 9)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (78, N'2018-06-17 13:22:05', 9)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (79, N'2018-06-17 16:27:15', 9)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (80, N'2018-06-17 16:31:47', 11)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (81, N'2018-06-17 16:32:25', 11)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (82, N'2018-06-17 17:12:20', 10)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (83, N'2018-06-17 17:37:30', 10)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (84, N'2018-06-17 18:01:30', 10)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (85, N'2018-06-17 18:24:57', 11)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (86, N'2018-06-17 20:25:12', 11)
                SET IDENTITY_INSERT [dbo].[RentalRecords] OFF
                ");
            Sql(@"SET IDENTITY_INSERT [dbo].[RentalRecords] ON
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (72, N'2018-06-14 13:20:21', 9)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (73, N'2018-06-16 13:20:21', 9)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (74, N'2018-06-12 13:20:21', 10)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (75, N'2018-06-10 13:20:21', 10)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (76, N'2018-06-16 13:20:21', 10)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (77, N'2018-06-17 13:21:37', 9)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (78, N'2018-06-17 13:22:05', 9)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (79, N'2018-06-17 16:27:15', 9)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (80, N'2018-06-17 16:31:47', 11)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (81, N'2018-06-17 16:32:25', 11)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (82, N'2018-06-17 17:12:20', 10)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (83, N'2018-06-17 17:37:30', 10)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (84, N'2018-06-17 18:01:30', 10)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (85, N'2018-06-17 18:24:57', 11)
                INSERT INTO [dbo].[RentalRecords] ([ID], [RentalDate], [Customer_ID]) VALUES (86, N'2018-06-17 20:25:12', 11)
                SET IDENTITY_INSERT [dbo].[RentalRecords] OFF
                ");
        }
        
        public override void Down()
        {
        }
    }
}
