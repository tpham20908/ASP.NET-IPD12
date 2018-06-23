namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRecordsToPhones : DbMigration
    {
        public override void Up()
        {
            Sql(@"SET IDENTITY_INSERT [dbo].[Phones] ON
                INSERT INTO [dbo].[Phones] ([Id], [PhoneName], [DateReleased], [ScreenSize], [BrandId], [PhoneTypeId], [ImageUrl]) VALUES (12, N'A 2010', N'2014-10-29 00:00:00', CAST(5.50 AS Decimal(18, 2)), 2, 1, N'https://www3.lenovo.com/medias/lenovo-smartphone-a2010-front-back-list.png?context=bWFzdGVyfHJvb3R8Mzg1NTd8aW1hZ2UvcG5nfGhkYi9oZjgvOTMyNzQ5NTUxMjA5NC5wbmd8NzEyZmNhMDc4ZTMzY2IwZGRiMGIxNGQwODM5NmNiY2Q1Y2VlYzllNTlhOGQ5MjlhMzMwMTJjMWI4YTM0NDY3MQ&w=1920')
                INSERT INTO [dbo].[Phones] ([Id], [PhoneName], [DateReleased], [ScreenSize], [BrandId], [PhoneTypeId], [ImageUrl]) VALUES (13, N'P200', N'2016-06-20 00:00:00', CAST(6.00 AS Decimal(18, 2)), 1, 3, N'https://consumer-img.huawei.com/content/dam/huawei-cbg-site/common/mkt/list-image/phones/p20/P20-listimg-black.png')
                INSERT INTO [dbo].[Phones] ([Id], [PhoneName], [DateReleased], [ScreenSize], [BrandId], [PhoneTypeId], [ImageUrl]) VALUES (14, N'A6600 Plus', N'2015-06-04 00:00:00', CAST(7.50 AS Decimal(18, 2)), 2, 4, N'https://www3.lenovo.com/medias/lenovo-smartphone-a6600-plus-front-back.png?context=bWFzdGVyfGltYWdlc3wxNTkwN3xpbWFnZS9wbmd8aW1hZ2VzL2hmMS9oYWMvOTM2MDYwMDU5NjUxMC5wbmd8MTIzMmY3ZmVkYjY1ZmUzM2U3MDY0MDJhZTFkOTU5MjBmZWIwOTk0MmNmZGU3ODJmMTBkYTFhNWIwODZkYWU1ZA&w=1920')
                INSERT INTO [dbo].[Phones] ([Id], [PhoneName], [DateReleased], [ScreenSize], [BrandId], [PhoneTypeId], [ImageUrl]) VALUES (15, N'iPhone 8', N'2017-10-27 00:00:00', CAST(6.50 AS Decimal(18, 2)), 8, 2, N'https://drop.ndtv.com/TECH/product_database/images/913201715735AM_120_iphone_8.jpeg?downsize=120:90&output-quality=70&output-format=jpg')
                INSERT INTO [dbo].[Phones] ([Id], [PhoneName], [DateReleased], [ScreenSize], [BrandId], [PhoneTypeId], [ImageUrl]) VALUES (16, N'iphone 6', N'2013-11-30 00:00:00', CAST(6.00 AS Decimal(18, 2)), 8, 2, N'https://www3.lenovo.com/medias/lenovo-smartphone-a7700-front-back.png?context=bWFzdGVyfGltYWdlc3wxNzI2NHxpbWFnZS9wbmd8aW1hZ2VzL2gyOC9oZjcvOTM2MDkxNzUyODYwNi5wbmd8MWFkNDBiY2UxOTUzMjYxOTZlN2Y3YTdkZDA3ZWZjMmQ2Zjc5YzlkYWM4YWUyMWViNDE1MDk1MGFiYTg4OTQ2Yw&w=1920')
                SET IDENTITY_INSERT [dbo].[Phones] OFF
                ");
        }
        
        public override void Down()
        {
        }
    }
}
