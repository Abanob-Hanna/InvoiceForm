
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceForm
{
    public partial class InvoiceForm : Form
    {
        InvoiceContext db = new InvoiceContext();
        DataTable InvoiceItems = new DataTable();
        bool Flag;
        public InvoiceForm()
        {
            InitializeComponent();
        }



       

        // load data from database to drop down list
        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            SetDefaultValues();  
        }

        private void SetDefaultValues()
        {
            ClearData();
            Flag = false;
            // specify colum for our invoice items Tabel
            InvoiceItems.Columns.Add("Item");
            InvoiceItems.Columns.Add("Unit");
            InvoiceItems.Columns.Add("Price");
            InvoiceItems.Columns.Add("Qty");
            InvoiceItems.Columns.Add("Total");
            InvoiceItems.Columns.Add("Discount");
            InvoiceItems.Columns.Add("Net");


            var stores = db.Stores.Select(s => new { s.StoreID, s.StoreName });
            cb_Stores.DataSource = stores.ToList();
            cb_Stores.DisplayMember = "StoreName";
            cb_Stores.ValueMember = "StoreID";


            txt_Date.Text = DateTime.Today.ToString("dd/MM/yyyy");
            int InvoiceID = GenerateRandomNo();
            txt_InvID.Text = InvoiceID.ToString();

            

        }

        private int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        private void cb_Stores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var items = db.Store_Items.Include(a=>a.Item).Where(a=>a.StoreID == cb_Stores.SelectedIndex + 1).Select(i=> new { i.ItemID, i.Item.ItemName });
            cb_Items.DataSource = items.ToList();
            cb_Items.DisplayMember = "ItemName";
            cb_Items.ValueMember = "ItemID";

        }


        private void cb_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            var units = db.Item_Units.Include(a => a.Unit).Where(a => a.ItemID == cb_Items.SelectedIndex + 1).Select(u=>u.Unit.UnitName);
            cb_Units.DataSource = units.ToList();
            
        }




        private void txt_Price_TextChanged(object sender, EventArgs e)
        {
            string Price = txt_Price.Text;
            if(Price == "")
            {
                txt_Total.Text = "";
                txt_Discount.Text = "";
                txt_Net.Text = "";
                txt_Qty.Text = "";
                return;
            }
        }



        // handel quantity text 
        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            string Qty = txt_Qty.Text;
            if( Qty != "")
            {
                double total = 0;
                total = double.Parse(txt_Price.Text) * int.Parse(txt_Qty.Text);
                txt_Total.Text = total.ToString();

            }
            else
            {
                txt_Total.Text = "";
                txt_Discount.Text = "";
                txt_Net.Text = "";
                return;
            }
            
        }

        private void txt_Discount_TextChanged(object sender, EventArgs e)
        {
            string Discount = txt_Discount.Text;
            string Total = txt_Total.Text;
            if ( Discount != "")
            {
                double net = 0;
                double result = 0;
                result = double.Parse(Total) * double.Parse(Discount)/100;
                net = double.Parse(txt_Total.Text) - result;
                txt_Net.Text = net.ToString();
            }
            else
            {
                txt_Net.Text = "";
                return;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Flag == false)
            {
                Invoice invoice = new Invoice();
                invoice.InvoiceID = int.Parse(txt_InvID.Text);
                invoice.StoreID = cb_Stores.SelectedIndex + 1;
                invoice.Invoice_Date = DateTime.Now;
                db.Invoices.Add(invoice);
                db.SaveChanges();
                Flag = true;
            }

            if (txt_Qty.Text == "" || txt_Discount.Text == "")
            {
                MessageBox.Show("Some thing is Missing either Qty or Discount , Try Again.");
            }
            else
            {

                Invoice_Item obj = new Invoice_Item();
                obj.InvoiceID = int.Parse(txt_InvID.Text);
                obj.ItemID = cb_Items.SelectedIndex + 1;
                obj.ItemName = cb_Items.SelectedItem.ToString();
                obj.ItemQuantity = int.Parse(txt_Qty.Text);
                obj.ItemDiscount = int.Parse(txt_Discount.Text);
                db.Invoice_Items.Add(obj);
                db.SaveChanges();

                double InvTotal = 0;
                if (txt_InvTotal.Text == "")
                {
                    txt_InvTotal.Text = "0";
                }
                InvTotal = double.Parse(txt_InvTotal.Text) + (double.Parse(txt_Net.Text));
                txt_InvTotal.Text = InvTotal.ToString();


                char[] delimiterChars = { ' ', ',', '=','\t','{','}' };

                string text = cb_Items.SelectedItem.ToString();
                string[] parts = text.Split(delimiterChars);

                string Item = parts[10];
                string Unit = cb_Units.SelectedItem.ToString();
                double Price = double.Parse(txt_Price.Text);
                double Qty = int.Parse(txt_Qty.Text);
                double Total = double.Parse(txt_Total.Text);
                double Discount = double.Parse(txt_Discount.Text);
                double Net = double.Parse(txt_Net.Text);

                InvoiceItems.Rows.Add(Item, Unit, Price, Qty, Total, Discount, Net);

                dataGridView1.DataSource = InvoiceItems;

                ClearData();
            }
        }

        // function that clear data of text boxes
        private void ClearData()
        {
            txt_Price.Text = string.Empty;
            txt_Qty.Text = string.Empty;
            txt_Total.Text = string.Empty;
            txt_Discount.Text = string.Empty;
            txt_Net.Text = string.Empty;
            cb_Items.SelectedIndex = -1;
            cb_Units.SelectedIndex = -1;
        }

        private void txt_Taxes_TextChanged(object sender, EventArgs e)
        {
            string Taxes = txt_Taxes.Text;
            string Total = txt_InvTotal.Text;
            if (Taxes != "")
            {
                double net = 0;
                double result = 0;
                result = double.Parse(Total) * double.Parse(Taxes) / 100;
                net = double.Parse(Total) + result;
                txt_InvNet.Text = net.ToString();
            }
            else
            {
                txt_Net.Text = "";
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Net = txt_InvNet.Text;
            if(Net != "")
            {
                int id = int.Parse(txt_InvID.Text);
                Invoice invoice = db.Invoices.SingleOrDefault(a => a.InvoiceID == id);
                invoice.InvoiceTotal = double.Parse(txt_InvTotal.Text);
                invoice.Taxes = double.Parse(txt_Taxes.Text);
                invoice.InvoiceNet = double.Parse(txt_InvNet.Text);
                MessageBox.Show("Invoice Saved Succesfully");
                InvoiceItems = new DataTable();
                dataGridView1.DataSource = null;
                txt_InvTotal.Text = "";
                txt_Taxes.Text = "";
                txt_InvNet.Text = "";
                SetDefaultValues();
            }
            else
            {
                MessageBox.Show("You need to add taxes first");
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_InvID.Text);
            Invoice obj = db.Invoices.SingleOrDefault(a => a.InvoiceID == id);
            db.Invoices.Remove(obj);
            db.SaveChanges();
            MessageBox.Show("Invoice Canceled");
            InvoiceItems = new DataTable();
            dataGridView1.DataSource = null;
            txt_InvTotal.Text = "";
            txt_Taxes.Text = "";
            txt_InvNet.Text = "";
            SetDefaultValues();
        }

        
    }
}
