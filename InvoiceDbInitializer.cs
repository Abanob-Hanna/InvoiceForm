using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceForm
{
    public class InvoiceDbInitializer : DropCreateDatabaseAlways<InvoiceContext>
    {
        protected override void Seed(InvoiceContext context)
        {

            IList<Item> items = new List<Item>();

            items.Add(new Item() { ItemID = 1 , ItemName= "HOHOs" }) ;
            items.Add(new Item() { ItemID = 1 , ItemName= "ARIEL Bag" }) ;
            items.Add(new Item() { ItemID = 1 , ItemName= "Water" }) ;
            items.Add(new Item() { ItemID = 1 , ItemName= "Rice" }) ;
            

            context.Items.AddRange(items);
            //var items = new List<Item>
            //    {
            //       new Item{ ItemID=1, ItemName="HOHOs"},
            //       new Item{ ItemID=2, ItemName="ARIEL Bag"},
            //       new Item{ ItemID=3, ItemName="Water"},
            //       new Item{ ItemID=5, ItemName="Rice"}

            //    };

            //items.ForEach(i => context.Items.Add(i));
            //context.SaveChanges();
            //var stores = new List<Store>
            //    {
            //       new Store{StoreName="San Mark (1)"},
            //       new Store{StoreName="San Mark (2)"},
            //       new Store{StoreName="San Mark (3)"},
            //       new Store{StoreName="San Mark (4)"},

            //    };
            //stores.ForEach(s => context.Stores.Add(s));
            //context.SaveChanges();
            //var units = new List<Unit>
            //    {
            //        new Unit{UnitID=1, UnitName="Piece" },
            //        new Unit{UnitID=2, UnitName="Pack" },
            //        new Unit{UnitID=3, UnitName="Carton" },


            //        new Unit{UnitID=4, UnitName="1Kg" },
            //        new Unit{UnitID=5, UnitName="2kg" },
            //        new Unit{UnitID=6, UnitName="10kg" },

            //        new Unit{UnitID=7, UnitName="0.60L" },
            //        new Unit{UnitID=8, UnitName="1.5L" },
            //        new Unit{UnitID=9, UnitName="6L" },
            //        new Unit{UnitID=10, UnitName="18.9L" },

            //        new Unit{UnitID=11, UnitName="1gm" },
            //        new Unit{UnitID=12, UnitName="1kg" },
            //        new Unit{UnitID=13, UnitName="10kg" },
            //        new Unit{UnitID=14, UnitName="40kg" },


            //    };
            //units.ForEach(u => context.Units.Add(u));
            //context.SaveChanges();
            //var Item_Units = new List<Item_Unit>
            //    {
            //        new Item_Unit{ItemID=1, UnitID=1 ,UnitPrice=3   },
            //        new Item_Unit{ItemID=1, UnitID=2 ,UnitPrice=12   },
            //        new Item_Unit{ItemID=1, UnitID=3 ,UnitPrice= 150   },

            //        new Item_Unit{ItemID=2, UnitID=4 ,UnitPrice= 30   },
            //        new Item_Unit{ItemID=2, UnitID=5 ,UnitPrice= 50   },
            //        new Item_Unit{ItemID=2, UnitID=6 ,UnitPrice= 90   },

            //        new Item_Unit{ItemID=3, UnitID=7 ,UnitPrice= 3   },
            //        new Item_Unit{ItemID=3, UnitID=8 ,UnitPrice= 5   },
            //        new Item_Unit{ItemID=3, UnitID=9 ,UnitPrice= 18   },
            //        new Item_Unit{ItemID=3, UnitID=9 ,UnitPrice= 57.5   },

            //        new Item_Unit{ItemID=4, UnitID=7 ,UnitPrice= 1.25   },
            //        new Item_Unit{ItemID=4, UnitID=8 ,UnitPrice= 10   },
            //        new Item_Unit{ItemID=4, UnitID=9 ,UnitPrice= 100   },
            //        new Item_Unit{ItemID=4, UnitID=9 ,UnitPrice= 400   },


            //};
            //Item_Units.ForEach(iu => context.Item_Units.Add(iu));
            //context.SaveChanges();

            base.Seed(context);
        }
    }
}
