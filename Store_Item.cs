using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceForm
{
   public  class Store_Item
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Store")]
        public int StoreID { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Item")]
        public int ItemID { get; set; }

        public int ItemQuantity { get; set; }

        [Key]
        [Column(Order = 3)]
        public int UnitID { get; set; }

        public virtual Item Item { get; set; }
        public virtual Store Store { get; set; }
    }
}
