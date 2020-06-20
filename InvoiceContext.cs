
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceForm
{
    public class InvoiceContext : DbContext
    {
        public InvoiceContext()
            : base("InvoiceContext")
        {
            //Database.SetInitializer<InvoiceContext>(new InvoiceDbInitializer());
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Item_Unit> Item_Units { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Invoice_Item> Invoice_Items { get; set; }
        public DbSet<Store_Item> Store_Items { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
