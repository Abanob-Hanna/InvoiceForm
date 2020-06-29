using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceForm
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceID { get; set; }
        [ForeignKey("Store")]
        public int StoreID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Invoice_Date { get; set; }
        public System.Nullable<double> InvoiceTotal { get; set; }
        public System.Nullable<double> Taxes { get; set; }
        public System.Nullable<double> InvoiceNet { get; set; }

        public virtual ICollection<Invoice_Item> Invoice_Items { get; set; }
        public virtual Store Store { get; set; }
    }
}
