using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceForm
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemID { get; set; }
        public string ItemName { get; set; }


        // navigation property of Item_Unit Table
        public virtual ICollection<Item_Unit> Item_Units { get; set; }
        // navigation property of Invoice_Item Table
        public virtual ICollection<Invoice_Item> Invoice_Items { get; set; }
        // navigation property of Store_Item Tabel
        public virtual ICollection<Store_Item> store_Items { get; set; }
    }
}
