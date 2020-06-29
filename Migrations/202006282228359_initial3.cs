namespace InvoiceForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Item_Unit", "ItemID", "dbo.Item");
            DropForeignKey("dbo.Store_Item", "ItemID", "dbo.Item");
            DropForeignKey("dbo.Invoice_Item", "ItemID", "dbo.Item");
            DropPrimaryKey("dbo.Item");
            AlterColumn("dbo.Item", "ItemID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Item", "ItemID");
            AddForeignKey("dbo.Item_Unit", "ItemID", "dbo.Item", "ItemID", cascadeDelete: true);
            AddForeignKey("dbo.Store_Item", "ItemID", "dbo.Item", "ItemID", cascadeDelete: true);
            AddForeignKey("dbo.Invoice_Item", "ItemID", "dbo.Item", "ItemID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoice_Item", "ItemID", "dbo.Item");
            DropForeignKey("dbo.Store_Item", "ItemID", "dbo.Item");
            DropForeignKey("dbo.Item_Unit", "ItemID", "dbo.Item");
            DropPrimaryKey("dbo.Item");
            AlterColumn("dbo.Item", "ItemID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Item", "ItemID");
            AddForeignKey("dbo.Invoice_Item", "ItemID", "dbo.Item", "ItemID", cascadeDelete: true);
            AddForeignKey("dbo.Store_Item", "ItemID", "dbo.Item", "ItemID", cascadeDelete: true);
            AddForeignKey("dbo.Item_Unit", "ItemID", "dbo.Item", "ItemID", cascadeDelete: true);
        }
    }
}
