namespace DBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemId);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        PurchaseId = c.Int(nullable: false, identity: true),
                        PurchaseDate = c.DateTime(nullable: false),
                        Price = c.Double(nullable: false),
                        Item_ItemId = c.Int(),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.PurchaseId)
                .ForeignKey("dbo.Items", t => t.Item_ItemId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.Item_ItemId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Balance = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Purchases", "Item_ItemId", "dbo.Items");
            DropIndex("dbo.Purchases", new[] { "User_UserId" });
            DropIndex("dbo.Purchases", new[] { "Item_ItemId" });
            DropTable("dbo.Users");
            DropTable("dbo.Purchases");
            DropTable("dbo.Items");
        }
    }
}
