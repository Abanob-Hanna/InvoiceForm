using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceForm
{
    public class Invoice_Item
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Invoice")]
        public int InvoiceID { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Item")]
        public int ItemID { get; set; }

        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public double ItemDiscount { get; set; }

        public Item Item { get; set; }
        public Invoice Invoice { get; set; }
    }
}
