using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceForm
{
    public class Unit
    {
        [Key]
        public int UnitID { get; set; }
        public string UnitName { get; set; }

        public virtual  ICollection <Item_Unit> Item_Units { get; set; }
    }
}
