using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceForm
{
    public class Item_Unit
    {

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Item")]
        public int ItemID { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Unit")]
        public int UnitID { get; set; }

        [Required]
        public double UnitPrice { get; set; }
        public virtual Item Item { get; set; }
        public virtual Unit Unit { get; set; }

    }
}
