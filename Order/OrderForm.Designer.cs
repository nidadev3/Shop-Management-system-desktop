namespace _2nddesktopapp.Order
{
    partial class OrderForm
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
            lblorder = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ProductTable = new DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            productname = new DataGridViewTextBoxColumn();
            Productprice = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            BillId = new DataGridViewTextBoxColumn();
            BillProductName = new DataGridViewTextBoxColumn();
            BillSalePrice = new DataGridViewTextBoxColumn();
            BillItem = new DataGridViewTextBoxColumn();
            BillDiscount = new DataGridViewTextBoxColumn();
            billTotalprice = new DataGridViewTextBoxColumn();
            label9 = new Label();
            additembtn = new Button();
            button1 = new Button();
            label10 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label11 = new Label();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ProductTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lblorder
            // 
            lblorder.AutoSize = true;
            lblorder.BackColor = SystemColors.ActiveCaption;
            lblorder.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblorder.ForeColor = Color.DarkSlateGray;
            lblorder.Location = new Point(460, 9);
            lblorder.Name = "lblorder";
            lblorder.Size = new Size(403, 47);
            lblorder.TabIndex = 0;
            lblorder.Text = "ORDER MANAGEMENT";
            lblorder.Click += lblorder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Fraunces 9pt", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(77, 111);
            label1.Name = "label1";
            label1.Size = new Size(189, 42);
            label1.TabIndex = 1;
            label1.Text = "All Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Fraunces 9pt", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(663, 94);
            label2.Name = "label2";
            label2.Size = new Size(136, 42);
            label2.TabIndex = 2;
            label2.Text = "Add Sale";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(590, 362);
            label3.Name = "label3";
            label3.Size = new Size(16, 25);
            label3.TabIndex = 3;
            label3.Text = "'";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Fraunces 9pt", 8.999999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(441, 224);
            label4.Name = "label4";
            label4.Size = new Size(78, 26);
            label4.TabIndex = 4;
            label4.Text = "Product";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Fraunces 9pt", 8.999999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(726, 198);
            label5.Name = "label5";
            label5.Size = new Size(94, 26);
            label5.TabIndex = 5;
            label5.Text = "Sale Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Fraunces 9pt", 8.999999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(446, 279);
            label6.Name = "label6";
            label6.Size = new Size(50, 26);
            label6.TabIndex = 6;
            label6.Text = "Item";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Fraunces 9pt", 8.999999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(726, 256);
            label7.Name = "label7";
            label7.Size = new Size(86, 26);
            label7.TabIndex = 7;
            label7.Text = "Discount";
            // 
            // ProductTable
            // 
            ProductTable.AllowUserToAddRows = false;
            ProductTable.BackgroundColor = SystemColors.ButtonFace;
            ProductTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductTable.Columns.AddRange(new DataGridViewColumn[] { ProductId, productname, Productprice });
            ProductTable.Location = new Point(2, 156);
            ProductTable.MultiSelect = false;
            ProductTable.Name = "ProductTable";
            ProductTable.RowHeadersVisible = false;
            ProductTable.RowHeadersWidth = 62;
            ProductTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductTable.Size = new Size(387, 567);
            ProductTable.TabIndex = 8;
            ProductTable.Click += button4_Click;
            ProductTable.KeyDown += ProductTable_KeyDown;
            ProductTable.KeyUp += ProductTable_KeyUp;
            // 
            // ProductId
            // 
            ProductId.HeaderText = "Id";
            ProductId.MinimumWidth = 8;
            ProductId.Name = "ProductId";
            ProductId.Width = 150;
            // 
            // productname
            // 
            productname.HeaderText = "Name";
            productname.MinimumWidth = 8;
            productname.Name = "productname";
            productname.Width = 150;
            // 
            // Productprice
            // 
            Productprice.HeaderText = "Price";
            Productprice.MinimumWidth = 8;
            Productprice.Name = "Productprice";
            Productprice.Width = 150;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(525, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 31);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(823, 196);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 31);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(524, 279);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 31);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged_1;
            textBox3.KeyUp += textBox3_KeyUp;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(823, 254);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 31);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Fraunces 9pt", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(419, 338);
            label8.Name = "label8";
            label8.Size = new Size(186, 42);
            label8.TabIndex = 13;
            label8.Text = "Current Bill";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { BillId, BillProductName, BillSalePrice, BillItem, BillDiscount, billTotalprice });
            dataGridView2.Location = new Point(395, 390);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(858, 274);
            dataGridView2.TabIndex = 14;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // BillId
            // 
            BillId.HeaderText = "Product Id";
            BillId.MinimumWidth = 8;
            BillId.Name = "BillId";
            BillId.Width = 150;
            // 
            // BillProductName
            // 
            BillProductName.HeaderText = "Product Name";
            BillProductName.MinimumWidth = 8;
            BillProductName.Name = "BillProductName";
            BillProductName.Width = 150;
            // 
            // BillSalePrice
            // 
            BillSalePrice.HeaderText = "Sale Price";
            BillSalePrice.MinimumWidth = 8;
            BillSalePrice.Name = "BillSalePrice";
            BillSalePrice.Width = 150;
            // 
            // BillItem
            // 
            BillItem.HeaderText = "Items";
            BillItem.MinimumWidth = 8;
            BillItem.Name = "BillItem";
            BillItem.Width = 150;
            // 
            // BillDiscount
            // 
            BillDiscount.HeaderText = "Discount";
            BillDiscount.MinimumWidth = 8;
            BillDiscount.Name = "BillDiscount";
            BillDiscount.Width = 150;
            // 
            // billTotalprice
            // 
            billTotalprice.HeaderText = "Total Price";
            billTotalprice.MinimumWidth = 8;
            billTotalprice.Name = "billTotalprice";
            billTotalprice.Width = 150;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Fraunces 9pt", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(413, 694);
            label9.Name = "label9";
            label9.Size = new Size(115, 42);
            label9.TabIndex = 15;
            label9.Text = "G.Total";
            // 
            // additembtn
            // 
            additembtn.Font = new Font("Fraunces 9pt", 8.999999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            additembtn.ForeColor = Color.Teal;
            additembtn.Location = new Point(893, 338);
            additembtn.Name = "additembtn";
            additembtn.Size = new Size(112, 34);
            additembtn.TabIndex = 16;
            additembtn.Text = "Add Item";
            additembtn.UseVisualStyleBackColor = true;
            additembtn.Click += additembtn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Fraunces 9pt", 8.999999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Teal;
            button1.Location = new Point(893, 703);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 17;
            button1.Text = "Print Bill";
            button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Fraunces 9pt", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(1046, 257);
            label10.Name = "label10";
            label10.Size = new Size(57, 26);
            label10.TabIndex = 18;
            label10.Text = "Total";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(534, 705);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(107, 31);
            textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1119, 257);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(86, 31);
            textBox6.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Fraunces 9pt", 8.999999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(413, 169);
            label11.Name = "label11";
            label11.Size = new Size(99, 26);
            label11.TabIndex = 21;
            label11.Text = "Product Id";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(525, 167);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(186, 31);
            textBox7.TabIndex = 22;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1317, 817);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(additembtn);
            Controls.Add(label9);
            Controls.Add(dataGridView2);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(ProductTable);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblorder);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblorder;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView ProductTable;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label8;
        private DataGridView dataGridView2;
        private Label label9;
        private Button additembtn;
        private Button button1;
        private Label label10;
        private TextBox textBox5;
        private TextBox textBox6;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn productname;
        private DataGridViewTextBoxColumn Productprice;
        private Label label11;
        private TextBox textBox7;
        private DataGridViewTextBoxColumn BillId;
        private DataGridViewTextBoxColumn BillProductName;
        private DataGridViewTextBoxColumn BillSalePrice;
        private DataGridViewTextBoxColumn BillItem;
        private DataGridViewTextBoxColumn BillDiscount;
        private DataGridViewTextBoxColumn billTotalprice;
    }
}