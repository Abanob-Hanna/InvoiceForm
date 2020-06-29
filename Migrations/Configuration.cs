namespace InvoiceForm.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    internal sealed class Configuration : DbMigrationsConfiguration<InvoiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InvoiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //context.Stores.AddOrUpdate(x => x.StoreID,
            //  new Store() { StoreName = "Store(1)" },
            //  new Store() { StoreName = "Store(2)" },
            //  new Store() { StoreName = "Store(3)" });

            //context.Items.AddOrUpdate(x => x.ItemID,
            //  new Item() { ItemID = 1, ItemName = "HoHos" },
            //  new Item() { ItemID = 2, ItemName = "ARIEL Bag" },
            //  new Item() { ItemID = 3, ItemName = "Water" },
            //  new Item() { ItemID = 4, ItemName = "Rice" }
            //  );

            //context.Units.AddOrUpdate(x => x.UnitID,
            //  new Unit() { UnitName = "Piece" },
            //  new Unit() { UnitName = "Pack" },
            //  new Unit() { UnitName = "Carton" },
            //  new Unit() { UnitName = "1kg" },
            //  new Unit() { UnitName = "2kg" },
            //  new Unit() { UnitName = "10kg" },
            //  new Unit() { UnitName = "0.60L" },
            //  new Unit() { UnitName = "1.5L" },
            //  new Unit() { UnitName = "18.9L" },
            //  new Unit() { UnitName = "1gm" },
            //  new Unit() { UnitName = "1kg" },
            //  new Unit() { UnitName = "10kg" });

            //context.Item_Units.AddOrUpdate(x => new { x.ItemID, x.UnitID },
            //    new Item_Unit() { ItemID = 1, UnitID = 1, UnitPrice = 3 },
            //    new Item_Unit() { ItemID = 1, UnitID = 2, UnitPrice = 36 },
            //    new Item_Unit() { ItemID = 1, UnitID = 3, UnitPrice = 150 },
            //    new Item_Unit() { ItemID = 2, UnitID = 4, UnitPrice = 5 },
            //    new Item_Unit() { ItemID = 2, UnitID = 5, UnitPrice = 10 },
            //    new Item_Unit() { ItemID = 2, UnitID = 6, UnitPrice = 50 },
            //    new Item_Unit() { ItemID = 3, UnitID = 7, UnitPrice = 2.5 },
            //    new Item_Unit() { ItemID = 3, UnitID = 8, UnitPrice = 5 },
            //    new Item_Unit() { ItemID = 3, UnitID = 9, UnitPrice = 74.5 },
            //    new Item_Unit() { ItemID = 4, UnitID = 10, UnitPrice = 1.5 },
            //    new Item_Unit() { ItemID = 4, UnitID = 11, UnitPrice = 10 },
            //    new Item_Unit() { ItemID = 4, UnitID = 12, UnitPrice = 100 }
            //);

            //context.Store_Items.AddOrUpdate(x => new { x.StoreID, x.ItemID, x.UnitID },
            //new Store_Item() { StoreID = 1, ItemID = 1, ItemQuantity = 10, UnitID = 1 },
            //new Store_Item() { StoreID = 1, ItemID = 1, ItemQuantity = 10, UnitID = 2 },
            //new Store_Item() { StoreID = 1, ItemID = 1, ItemQuantity = 10, UnitID = 3 },
            //new Store_Item() { StoreID = 1, ItemID = 2, ItemQuantity = 10, UnitID = 4 },
            //new Store_Item() { StoreID = 1, ItemID = 2, ItemQuantity = 10, UnitID = 5 },
            //new Store_Item() { StoreID = 1, ItemID = 2, ItemQuantity = 10, UnitID = 6 },
            //new Store_Item() { StoreID = 1, ItemID = 3, ItemQuantity = 10, UnitID = 7 },
            //new Store_Item() { StoreID = 1, ItemID = 3, ItemQuantity = 10, UnitID = 8 },
            //new Store_Item() { StoreID = 1, ItemID = 3, ItemQuantity = 10, UnitID = 9 },
            //new Store_Item() { StoreID = 1, ItemID = 4, ItemQuantity = 10, UnitID = 10 },
            //new Store_Item() { StoreID = 1, ItemID = 4, ItemQuantity = 10, UnitID = 11 },
            //new Store_Item() { StoreID = 1, ItemID = 4, ItemQuantity = 10, UnitID = 12 },
            //new Store_Item() { StoreID = 2, ItemID = 1, ItemQuantity = 8, UnitID = 1 },
            //new Store_Item() { StoreID = 2, ItemID = 1, ItemQuantity = 8, UnitID = 2 },
            //new Store_Item() { StoreID = 2, ItemID = 1, ItemQuantity = 8, UnitID = 3 },
            //new Store_Item() { StoreID = 2, ItemID = 2, ItemQuantity = 8, UnitID = 4 },
            //new Store_Item() { StoreID = 2, ItemID = 2, ItemQuantity = 8, UnitID = 5 },
            //new Store_Item() { StoreID = 2, ItemID = 2, ItemQuantity = 8, UnitID = 6 },
            //new Store_Item() { StoreID = 2, ItemID = 3, ItemQuantity = 8, UnitID = 7 },
            //new Store_Item() { StoreID = 2, ItemID = 3, ItemQuantity = 8, UnitID = 8 },
            //new Store_Item() { StoreID = 2, ItemID = 3, ItemQuantity = 8, UnitID = 9 },
            //new Store_Item() { StoreID = 2, ItemID = 4, ItemQuantity = 8, UnitID = 10 },
            //new Store_Item() { StoreID = 2, ItemID = 4, ItemQuantity = 8, UnitID = 11 },
            //new Store_Item() { StoreID = 2, ItemID = 4, ItemQuantity = 8, UnitID = 12 }
            //);

        }
    }
}
