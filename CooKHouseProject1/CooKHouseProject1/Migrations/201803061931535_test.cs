namespace CooKHouseProject1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Meals",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Description = c.String(),
                    Price = c.Double(nullable: false),
                    Size = c.Int(nullable: false),
                    Rest_ID = c.Int(nullable: false),
                    Category_Id = c.Int(nullable: false)

                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Restaurants", t => t.Rest_ID)

                .Index(t => t.Rest_ID)
                .Index(t => t.Category_Id);

            
            CreateTable(
                "dbo.Meals_Order",
                c => new
                    {
                        Meals_ID = c.Int(nullable: false),
                        Order_ID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Order_ID1 = c.Int(),
                        Meals_ID1 = c.Int(),
                    })
                .PrimaryKey(t => new { t.Meals_ID, t.Order_ID })
                .ForeignKey("dbo.Meals", t => t.Meals_ID)
                .ForeignKey("dbo.Orders", t => t.Order_ID1)
                .ForeignKey("dbo.Orders", t => t.Order_ID)
                .ForeignKey("dbo.Meals", t => t.Meals_ID1)
                .Index(t => t.Meals_ID)
                .Index(t => t.Order_ID)
                .Index(t => t.Order_ID1)
                .Index(t => t.Meals_ID1);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TotalPrice = c.Double(nullable: false),
                        Rest_ID = c.Int(nullable: false),
                        client_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clients", t => t.client_ID)
                .ForeignKey("dbo.Restaurant_Branch", t => t.Rest_ID)
                .Index(t => t.Rest_ID)
                .Index(t => t.client_ID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.Int(nullable: false),
                        Address_Gov = c.String(),
                        Address_Quarter = c.String(),
                        Address_Street = c.String(),
                    })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Restaurant_Branch",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Rest_ID = c.Int(nullable: false),
                    Quarter_ID = c.Int(nullable: false),
                    Rate = c.Int(nullable: false)
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Quarters", t => t.Quarter_ID)

                .ForeignKey("dbo.Restaurants", t => t.Rest_ID)
                .Index(t => t.Rest_ID)
                .Index(t => t.Quarter_ID);
                
            
            CreateTable(
                "dbo.Quarters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quarter_Name = c.String(),
                        Governorate_ID = c.Int(nullable: false),
                        Governorate_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Governorates", t => t.Governorate_ID1)
                .ForeignKey("dbo.Governorates", t => t.Governorate_ID)
                .Index(t => t.Governorate_ID)
                .Index(t => t.Governorate_ID1);
            
            CreateTable(
                "dbo.Governorates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.Int(nullable: false),
                        LogoImage = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Meals", "Category_ID", "dbo.Categories");
            DropForeignKey("dbo.Meals", "Rest_ID", "dbo.Restaurants");
            DropForeignKey("dbo.Meals_Order", "Meals_ID1", "dbo.Meals");
            DropForeignKey("dbo.Meals_Order", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Rest_ID", "dbo.Restaurant_Branch");
            DropForeignKey("dbo.Restaurant_Branch", "Rest_ID", "dbo.Restaurants");
            DropForeignKey("dbo.Restaurant_Branch", "Restaurant_ID", "dbo.Restaurants");
            DropForeignKey("dbo.Restaurant_Branch", "Quarter_ID", "dbo.Quarters");
            DropForeignKey("dbo.Quarters", "Governorate_ID", "dbo.Governorates");
            DropForeignKey("dbo.Quarters", "Governorate_ID1", "dbo.Governorates");
            DropForeignKey("dbo.Meals_Order", "Order_ID1", "dbo.Orders");
            DropForeignKey("dbo.Orders", "client_ID", "dbo.Clients");
            DropForeignKey("dbo.Meals_Order", "Meals_ID", "dbo.Meals");
            DropForeignKey("dbo.Meals", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Quarters", new[] { "Governorate_ID1" });
            DropIndex("dbo.Quarters", new[] { "Governorate_ID" });
            DropIndex("dbo.Restaurant_Branch", new[] { "Restaurant_ID" });
            DropIndex("dbo.Restaurant_Branch", new[] { "Quarter_ID" });
            DropIndex("dbo.Restaurant_Branch", new[] { "Rest_ID" });
            DropIndex("dbo.Orders", new[] { "client_ID" });
            DropIndex("dbo.Orders", new[] { "Rest_ID" });
            DropIndex("dbo.Meals_Order", new[] { "Meals_ID1" });
            DropIndex("dbo.Meals_Order", new[] { "Order_ID1" });
            DropIndex("dbo.Meals_Order", new[] { "Order_ID" });
            DropIndex("dbo.Meals_Order", new[] { "Meals_ID" });
            DropIndex("dbo.Meals", new[] { "Category_ID" });
            DropIndex("dbo.Meals", new[] { "Category_Id" });
            DropIndex("dbo.Meals", new[] { "Rest_ID" });
            DropTable("dbo.Restaurants");
            DropTable("dbo.Governorates");
            DropTable("dbo.Quarters");
            DropTable("dbo.Restaurant_Branch");
            DropTable("dbo.Clients");
            DropTable("dbo.Orders");
            DropTable("dbo.Meals_Order");
            DropTable("dbo.Meals");
            DropTable("dbo.Categories");
        }
    }
}
