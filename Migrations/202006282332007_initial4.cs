namespace InvoiceForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Invoice_Item", "InvoiceID", "dbo.Invoice");
            DropPrimaryKey("dbo.Invoice");
            AlterColumn("dbo.Invoice", "InvoiceID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Invoice", "InvoiceID");
            AddForeignKey("dbo.Invoice_Item", "InvoiceID", "dbo.Invoice", "InvoiceID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoice_Item", "InvoiceID", "dbo.Invoice");
            DropPrimaryKey("dbo.Invoice");
            AlterColumn("dbo.Invoice", "InvoiceID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Invoice", "InvoiceID");
            AddForeignKey("dbo.Invoice_Item", "InvoiceID", "dbo.Invoice", "InvoiceID", cascadeDelete: true);
        }
    }
}
