namespace _2nddesktopapp.Product.Forms
{
    partial class ProductbySubstring
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
            backproductsubstring = new Button();
            searchproductsubstring = new Button();
            searchproductbysubstringlbl = new Label();
            enterproductsubstring = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backproductsubstring
            // 
            backproductsubstring.Location = new Point(630, 367);
            backproductsubstring.Name = "backproductsubstring";
            backproductsubstring.Size = new Size(112, 34);
            backproductsubstring.TabIndex = 0;
            backproductsubstring.Text = "Back";
            backproductsubstring.UseVisualStyleBackColor = true;
            backproductsubstring.Click += backproductsubstring_Click;
            // 
            // searchproductsubstring
            // 
            searchproductsubstring.Location = new Point(630, 105);
            searchproductsubstring.Name = "searchproductsubstring";
            searchproductsubstring.Size = new Size(112, 34);
            searchproductsubstring.TabIndex = 1;
            searchproductsubstring.Text = "Search";
            searchproductsubstring.UseVisualStyleBackColor = true;
            searchproductsubstring.Click += searchproductsubstring_Click;
            // 
            // searchproductbysubstringlbl
            // 
            searchproductbysubstringlbl.AutoSize = true;
            searchproductbysubstringlbl.BackColor = SystemColors.ActiveCaption;
            searchproductbysubstringlbl.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchproductbysubstringlbl.ForeColor = Color.DarkSlateGray;
            searchproductbysubstringlbl.Location = new Point(155, 20);
            searchproductbysubstringlbl.Name = "searchproductbysubstringlbl";
            searchproductbysubstringlbl.Size = new Size(483, 47);
            searchproductbysubstringlbl.TabIndex = 2;
            searchproductbysubstringlbl.Text = "Search Product By Substring";
            // 
            // enterproductsubstring
            // 
            enterproductsubstring.AutoSize = true;
            enterproductsubstring.Location = new Point(44, 111);
            enterproductsubstring.Name = "enterproductsubstring";
            enterproductsubstring.Size = new Size(133, 25);
            enterproductsubstring.TabIndex = 3;
            enterproductsubstring.Text = "Enter Substring";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(374, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(100, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(602, 190);
            dataGridView1.TabIndex = 5;
            // 
            // ProductbySubstring
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(enterproductsubstring);
            Controls.Add(searchproductbysubstringlbl);
            Controls.Add(searchproductsubstring);
            Controls.Add(backproductsubstring);
            Name = "ProductbySubstring";
            Text = "ProductbySubstring";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backproductsubstring;
        private Button searchproductsubstring;
        private Label searchproductbysubstringlbl;
        private Label enterproductsubstring;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}