namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initializing_Database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 150),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ShortDescription = c.String(nullable: false, maxLength: 250),
                        ProductDetail = c.String(nullable: false, maxLength: 500),
                        ProductImageName = c.String(nullable: false),
                        AboutProducer = c.String(maxLength: 500),
                        DateCreated = c.DateTime(nullable: false),
                        ShowInSlider = c.Boolean(nullable: false),
                        InStock = c.Boolean(nullable: false),
                        ProductTags = c.String(),
                        Count = c.Int(nullable: false),
                        Visit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.ProductCategories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryID", "dbo.ProductCategories");
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropTable("dbo.Products");
            DropTable("dbo.ProductCategories");
        }
    }
}
