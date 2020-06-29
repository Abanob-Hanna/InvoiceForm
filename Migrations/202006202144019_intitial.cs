namespace InvoiceForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoice_Item",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false),
                        ItemID = c.Int(nullable: false),
                        ItemName = c.String(),
                        ItemQuantity = c.Int(nullable: false),
                        ItemDiscount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.InvoiceID, t.ItemID })
                .ForeignKey("dbo.Invoice", t => t.InvoiceID, cascadeDelete: true)
                .ForeignKey("dbo.Item", t => t.ItemID, cascadeDelete: true)
                .Index(t => t.InvoiceID)
                .Index(t => t.ItemID);
            
            CreateTable(
                "dbo.Invoice",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false),
                        StoreID = c.Int(nullable: false),
                        Invoice_Date = c.DateTime(nullable: false),
                        InvoiceTotal = c.Double(),
                        Taxes = c.Double(),
                        InvoiceNet = c.Double(),
                    })
                .PrimaryKey(t => t.InvoiceID)
                .ForeignKey("dbo.Store", t => t.StoreID, cascadeDelete: true)
                .Index(t => t.StoreID);
            
            CreateTable(
                "dbo.Store",
                c => new
                    {
                        StoreID = c.Int(nullable: false, identity: true),
                        StoreName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StoreID);
            
            CreateTable(
                "dbo.Store_Item",
                c => new
                    {
                        StoreID = c.Int(nullable: false),
                        ItemID = c.Int(nullable: false),
                        ItemQuantity = c.Int(nullable: false),
                        UnitID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StoreID, t.ItemID ,t.UnitID})
                .ForeignKey("dbo.Item", t => t.ItemID, cascadeDelete: true)
                .ForeignKey("dbo.Store", t => t.StoreID, cascadeDelete: true)
                .Index(t => t.StoreID)
                .Index(t => t.ItemID)
                .Index(t=>t.UnitID);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        ItemID = c.Int(nullable: false),
                        ItemName = c.String(),
                    })
                .PrimaryKey(t => t.ItemID);
            
            CreateTable(
                "dbo.Item_Unit",
                c => new
                    {
                        ItemID = c.Int(nullable: false),
                        UnitID = c.Int(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.ItemID, t.UnitID })
                .ForeignKey("dbo.Item", t => t.ItemID, cascadeDelete: true)
                .ForeignKey("dbo.Unit", t => t.UnitID, cascadeDelete: true)
                .Index(t => t.ItemID)
                .Index(t => t.UnitID);
            
            CreateTable(
                "dbo.Unit",
                c => new
                    {
                        UnitID = c.Int(nullable: false, identity: true),
                        UnitName = c.String(),
                    })
                .PrimaryKey(t => t.UnitID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoice_Item", "ItemID", "dbo.Item");
            DropForeignKey("dbo.Invoice_Item", "InvoiceID", "dbo.Invoice");
            DropForeignKey("dbo.Invoice", "StoreID", "dbo.Store");
            DropForeignKey("dbo.Store_Item", "StoreID", "dbo.Store");
            DropForeignKey("dbo.Store_Item", "ItemID", "dbo.Item");
            DropForeignKey("dbo.Item_Unit", "UnitID", "dbo.Unit");
            DropForeignKey("dbo.Item_Unit", "ItemID", "dbo.Item");
            DropIndex("dbo.Item_Unit", new[] { "UnitID" });
            DropIndex("dbo.Item_Unit", new[] { "ItemID" });
            DropIndex("dbo.Store_Item", new[] { "ItemID" });
            DropIndex("dbo.Store_Item", new[] { "StoreID" });
            DropIndex("dbo.Invoice", new[] { "StoreID" });
            DropIndex("dbo.Invoice_Item", new[] { "ItemID" });
            DropIndex("dbo.Invoice_Item", new[] { "InvoiceID" });
            DropTable("dbo.Unit");
            DropTable("dbo.Item_Unit");
            DropTable("dbo.Item");
            DropTable("dbo.Store_Item");
            DropTable("dbo.Store");
            DropTable("dbo.Invoice");
            DropTable("dbo.Invoice_Item");
        }
    }
}
