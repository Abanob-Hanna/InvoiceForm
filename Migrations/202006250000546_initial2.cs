namespace InvoiceForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Store_Item");
            AddPrimaryKey("dbo.Store_Item", new[] { "StoreID", "ItemID", "UnitID" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Store_Item");
            AddPrimaryKey("dbo.Store_Item", new[] { "StoreID", "ItemID" });
        }
    }
}
