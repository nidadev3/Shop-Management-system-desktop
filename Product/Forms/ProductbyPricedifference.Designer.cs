namespace _2nddesktopapp.Product.Forms
{
    partial class ProductbyPricedifference
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
            searchproductbypricedifference = new Button();
            backpricedifference = new Button();
            searchbypricedifferencelbl = new Label();
            enterpricedifference = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            pricemax = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchproductbypricedifference
            // 
            searchproductbypricedifference.Location = new Point(622, 102);
            searchproductbypricedifference.Name = "searchproductbypricedifference";
            searchproductbypricedifference.Size = new Size(112, 34);
            searchproductbypricedifference.TabIndex = 0;
            searchproductbypricedifference.Text = "Search";
            searchproductbypricedifference.UseVisualStyleBackColor = true;
            searchproductbypricedifference.Click += searchproductbypricedifference_Click;
            // 
            // backpricedifference
            // 
            backpricedifference.Location = new Point(622, 391);
            backpricedifference.Name = "backpricedifference";
            backpricedifference.Size = new Size(112, 34);
            backpricedifference.TabIndex = 1;
            backpricedifference.Text = "Back";
            backpricedifference.UseVisualStyleBackColor = true;
            backpricedifference.Click += backpricedifference_Click;
            // 
            // searchbypricedifferencelbl
            // 
            searchbypricedifferencelbl.AutoSize = true;
            searchbypricedifferencelbl.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchbypricedifferencelbl.ForeColor = Color.DarkSlateGray;
            searchbypricedifferencelbl.Location = new Point(107, 30);
            searchbypricedifferencelbl.Name = "searchbypricedifferencelbl";
            searchbypricedifferencelbl.Size = new Size(590, 47);
            searchbypricedifferencelbl.TabIndex = 2;
            searchbypricedifferencelbl.Text = "Search Product By Price Difference";
            // 
            // enterpricedifference
            // 
            enterpricedifference.AutoSize = true;
            enterpricedifference.Location = new Point(27, 102);
            enterpricedifference.Name = "enterpricedifference";
            enterpricedifference.Size = new Size(176, 25);
            enterpricedifference.TabIndex = 3;
            enterpricedifference.Text = "Enter minimum price";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 31);
            textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(96, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(573, 172);
            dataGridView1.TabIndex = 5;
            // 
            // pricemax
            // 
            pricemax.AutoSize = true;
            pricemax.Location = new Point(39, 157);
            pricemax.Name = "pricemax";
            pricemax.Size = new Size(133, 25);
            pricemax.TabIndex = 6;
            pricemax.Text = "Enter Max price";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(230, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(327, 31);
            textBox2.TabIndex = 7;
            // 
            // ProductbyPricedifference
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(pricemax);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(enterpricedifference);
            Controls.Add(searchbypricedifferencelbl);
            Controls.Add(backpricedifference);
            Controls.Add(searchproductbypricedifference);
            Name = "ProductbyPricedifference";
            Text = "ProductbyPricedifference";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchproductbypricedifference;
        private Button backpricedifference;
        private Label searchbypricedifferencelbl;
        private Label enterpricedifference;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label pricemax;
        private TextBox textBox2;
    }
}