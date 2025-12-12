namespace _2nddesktopapp.Product.Forms
{
    partial class SearchProductbypricerange
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
            backpricerange = new Button();
            searchbypricerange = new Button();
            lblsearchbypricerange = new Label();
            enterminpricerange = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            entermaxprice = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backpricerange
            // 
            backpricerange.Location = new Point(603, 404);
            backpricerange.Name = "backpricerange";
            backpricerange.Size = new Size(112, 34);
            backpricerange.TabIndex = 0;
            backpricerange.Text = "Back";
            backpricerange.UseVisualStyleBackColor = true;
            backpricerange.Click += backpricerange_Click;
            // 
            // searchbypricerange
            // 
            searchbypricerange.Location = new Point(603, 103);
            searchbypricerange.Name = "searchbypricerange";
            searchbypricerange.Size = new Size(112, 34);
            searchbypricerange.TabIndex = 1;
            searchbypricerange.Text = "Search";
            searchbypricerange.UseVisualStyleBackColor = true;
            searchbypricerange.Click += searchbypricerange_Click;
            // 
            // lblsearchbypricerange
            // 
            lblsearchbypricerange.AutoSize = true;
            lblsearchbypricerange.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsearchbypricerange.ForeColor = Color.DarkSlateGray;
            lblsearchbypricerange.Location = new Point(138, 22);
            lblsearchbypricerange.Name = "lblsearchbypricerange";
            lblsearchbypricerange.Size = new Size(520, 47);
            lblsearchbypricerange.TabIndex = 2;
            lblsearchbypricerange.Text = "Search Product By Price Range";
            // 
            // enterminpricerange
            // 
            enterminpricerange.AutoSize = true;
            enterminpricerange.Location = new Point(49, 103);
            enterminpricerange.Name = "enterminpricerange";
            enterminpricerange.Size = new Size(130, 25);
            enterminpricerange.TabIndex = 3;
            enterminpricerange.Text = "Enter Min price";
            enterminpricerange.Click += enterpricerange_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 31);
            textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(129, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(529, 165);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // entermaxprice
            // 
            entermaxprice.AutoSize = true;
            entermaxprice.Location = new Point(49, 151);
            entermaxprice.Name = "entermaxprice";
            entermaxprice.Size = new Size(132, 25);
            entermaxprice.TabIndex = 6;
            entermaxprice.Text = "Enter Max Price";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(215, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 31);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // SearchProductbypricerange
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(entermaxprice);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(enterminpricerange);
            Controls.Add(lblsearchbypricerange);
            Controls.Add(searchbypricerange);
            Controls.Add(backpricerange);
            Name = "SearchProductbypricerange";
            Text = "SearchProductbypricerange";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backpricerange;
        private Button searchbypricerange;
        private Label lblsearchbypricerange;
        private Label enterminpricerange;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label entermaxprice;
        private TextBox textBox2;
    }
}