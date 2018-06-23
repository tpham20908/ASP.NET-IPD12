namespace Phono.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddRecordsToBrand : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[Brands] ([Id], [BrandName], [CountryOfOrigin]) VALUES (1, N'Huawei', N'China')
                INSERT INTO [dbo].[Brands] ([Id], [BrandName], [CountryOfOrigin]) VALUES (2, N'Lenovo', N'China')
                INSERT INTO [dbo].[Brands] ([Id], [BrandName], [CountryOfOrigin]) VALUES (3, N'BlackBerry', N'Canada')
                INSERT INTO [dbo].[Brands] ([Id], [BrandName], [CountryOfOrigin]) VALUES (4, N'Sony', N'Japan')
                INSERT INTO [dbo].[Brands] ([Id], [BrandName], [CountryOfOrigin]) VALUES (5, N'Panasonic', N'Japan')
                INSERT INTO [dbo].[Brands] ([Id], [BrandName], [CountryOfOrigin]) VALUES (6, N'Philips', N'Netherlands')
                INSERT INTO [dbo].[Brands] ([Id], [BrandName], [CountryOfOrigin]) VALUES (7, N'HTC', N'Taiwan')
                INSERT INTO [dbo].[Brands] ([Id], [BrandName], [CountryOfOrigin]) VALUES (8, N'Apple', N'USA')
                INSERT INTO [dbo].[Brands] ([Id], [BrandName], [CountryOfOrigin]) VALUES (9, N'HP', N'USA')
                ");
        }

        public override void Down()
        {
        }
    }
}
