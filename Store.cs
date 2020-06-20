using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceForm
{
    public class Store
    {
        [Key]
        public int StoreID { get; set; }
        [Required]
        public string StoreName { get; set; }

        public virtual ICollection<Store_Item> Store_Items { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }

    }
}
