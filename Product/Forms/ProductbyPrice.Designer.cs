namespace _2nddesktopapp.Product.Forms
{
    partial class ProductbyPrice
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
            searchbyproductprice = new Button();
            Backproductprice = new Button();
            searchproductbyprice = new Label();
            enterproductprice = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchbyproductprice
            // 
            searchbyproductprice.Location = new Point(606, 100);
            searchbyproductprice.Name = "searchbyproductprice";
            searchbyproductprice.Size = new Size(112, 34);
            searchbyproductprice.TabIndex = 0;
            searchbyproductprice.Text = "Search";
            searchbyproductprice.UseVisualStyleBackColor = true;
            searchbyproductprice.Click += searchbyproductprice_Click;
            // 
            // Backproductprice
            // 
            Backproductprice.Location = new Point(606, 370);
            Backproductprice.Name = "Backproductprice";
            Backproductprice.Size = new Size(112, 34);
            Backproductprice.TabIndex = 1;
            Backproductprice.Text = "Back";
            Backproductprice.UseVisualStyleBackColor = true;
            Backproductprice.Click += Backproductprice_Click;
            // 
            // searchproductbyprice
            // 
            searchproductbyprice.AutoSize = true;
            searchproductbyprice.BackColor = SystemColors.ActiveCaption;
            searchproductbyprice.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchproductbyprice.ForeColor = Color.DarkSlateGray;
            searchproductbyprice.Location = new Point(160, 18);
            searchproductbyprice.Name = "searchproductbyprice";
            searchproductbyprice.Size = new Size(411, 47);
            searchproductbyprice.TabIndex = 2;
            searchproductbyprice.Text = "Search By Product Price";
            // 
            // enterproductprice
            // 
            enterproductprice.AutoSize = true;
            enterproductprice.Location = new Point(25, 105);
            enterproductprice.Name = "enterproductprice";
            enterproductprice.Size = new Size(191, 25);
            enterproductprice.TabIndex = 3;
            enterproductprice.Text = "Enter the Product Price";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 31);
            textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(135, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(557, 178);
            dataGridView1.TabIndex = 5;
            // 
            // ProductbyPrice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(enterproductprice);
            Controls.Add(searchproductbyprice);
            Controls.Add(Backproductprice);
            Controls.Add(searchbyproductprice);
            Name = "ProductbyPrice";
            Text = "ProductbyPrice";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchbyproductprice;
        private Button Backproductprice;
        private Label searchproductbyprice;
        private Label enterproductprice;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}