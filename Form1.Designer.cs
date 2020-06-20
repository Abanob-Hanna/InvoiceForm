namespace InvoiceForm
{
    partial class InvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Stores = new System.Windows.Forms.ComboBox();
            this.txt_InvID = new System.Windows.Forms.TextBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_InvTotal = new System.Windows.Forms.TextBox();
            this.txt_InvNet = new System.Windows.Forms.TextBox();
            this.txt_Taxes = new System.Windows.Forms.TextBox();
            this.cb_Items = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Units = new System.Windows.Forms.ComboBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.txt_Net = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Store";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Invoice Date";
            // 
            // cb_Stores
            // 
            this.cb_Stores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Stores.FormattingEnabled = true;
            this.cb_Stores.Location = new System.Drawing.Point(164, 63);
            this.cb_Stores.Name = "cb_Stores";
            this.cb_Stores.Size = new System.Drawing.Size(100, 21);
            this.cb_Stores.TabIndex = 3;
            this.cb_Stores.SelectedIndexChanged += new System.EventHandler(this.cb_Stores_SelectedIndexChanged);
            // 
            // txt_InvID
            // 
            this.txt_InvID.Location = new System.Drawing.Point(167, 26);
            this.txt_InvID.Name = "txt_InvID";
            this.txt_InvID.Size = new System.Drawing.Size(100, 20);
            this.txt_InvID.TabIndex = 4;
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(479, 26);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.ReadOnly = true;
            this.txt_Date.Size = new System.Drawing.Size(100, 20);
            this.txt_Date.TabIndex = 5;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(769, 277);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Taxes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Net";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(422, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_InvTotal
            // 
            this.txt_InvTotal.Location = new System.Drawing.Point(640, 323);
            this.txt_InvTotal.Name = "txt_InvTotal";
            this.txt_InvTotal.ReadOnly = true;
            this.txt_InvTotal.Size = new System.Drawing.Size(100, 20);
            this.txt_InvTotal.TabIndex = 14;
            // 
            // txt_InvNet
            // 
            this.txt_InvNet.Location = new System.Drawing.Point(640, 386);
            this.txt_InvNet.Name = "txt_InvNet";
            this.txt_InvNet.ReadOnly = true;
            this.txt_InvNet.Size = new System.Drawing.Size(100, 20);
            this.txt_InvNet.TabIndex = 15;
            // 
            // txt_Taxes
            // 
            this.txt_Taxes.Location = new System.Drawing.Point(640, 356);
            this.txt_Taxes.Name = "txt_Taxes";
            this.txt_Taxes.Size = new System.Drawing.Size(100, 20);
            this.txt_Taxes.TabIndex = 16;
            this.txt_Taxes.TextChanged += new System.EventHandler(this.txt_Taxes_TextChanged);
            // 
            // cb_Items
            // 
            this.cb_Items.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Items.FormattingEnabled = true;
            this.cb_Items.Items.AddRange(new object[] {
            "Select Item  ..."});
            this.cb_Items.Location = new System.Drawing.Point(3, 34);
            this.cb_Items.Name = "cb_Items";
            this.cb_Items.Size = new System.Drawing.Size(116, 21);
            this.cb_Items.TabIndex = 17;
            this.cb_Items.SelectedIndexChanged += new System.EventHandler(this.cb_Items_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.58537F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.41463F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.Controls.Add(this.label13, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_Items, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_Units, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Price, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Qty, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Total, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Discount, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Net, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 116);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 60);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(545, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Net";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(465, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Discount (%)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Total";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Qty";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Price";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Item";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_Units
            // 
            this.cb_Units.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Units.FormattingEnabled = true;
            this.cb_Units.Items.AddRange(new object[] {
            "Select Unit ..."});
            this.cb_Units.Location = new System.Drawing.Point(125, 34);
            this.cb_Units.Name = "cb_Units";
            this.cb_Units.Size = new System.Drawing.Size(88, 21);
            this.cb_Units.TabIndex = 20;
            // 
            // txt_Price
            // 
            this.txt_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Price.Location = new System.Drawing.Point(219, 35);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(60, 20);
            this.txt_Price.TabIndex = 21;
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Price_TextChanged);
            // 
            // txt_Qty
            // 
            this.txt_Qty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Qty.Location = new System.Drawing.Point(285, 35);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(85, 20);
            this.txt_Qty.TabIndex = 27;
            this.txt_Qty.TextChanged += new System.EventHandler(this.txt_Qty_TextChanged);
            // 
            // txt_Total
            // 
            this.txt_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Total.Location = new System.Drawing.Point(376, 35);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(83, 20);
            this.txt_Total.TabIndex = 28;
            // 
            // txt_Discount
            // 
            this.txt_Discount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Discount.Location = new System.Drawing.Point(465, 35);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(74, 20);
            this.txt_Discount.TabIndex = 29;
            this.txt_Discount.TextChanged += new System.EventHandler(this.txt_Discount_TextChanged);
            // 
            // txt_Net
            // 
            this.txt_Net.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Net.Location = new System.Drawing.Point(547, 35);
            this.txt_Net.Name = "txt_Net";
            this.txt_Net.ReadOnly = true;
            this.txt_Net.Size = new System.Drawing.Size(88, 20);
            this.txt_Net.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Unit";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(640, 127);
            this.dataGridView1.TabIndex = 31;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 448);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txt_Taxes);
            this.Controls.Add(this.txt_InvNet);
            this.Controls.Add(this.txt_InvTotal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.txt_InvID);
            this.Controls.Add(this.cb_Stores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InvoiceForm";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Stores;
        private System.Windows.Forms.TextBox txt_InvID;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_InvTotal;
        private System.Windows.Forms.TextBox txt_InvNet;
        private System.Windows.Forms.TextBox txt_Taxes;
        private System.Windows.Forms.ComboBox cb_Items;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Units;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.TextBox txt_Net;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

