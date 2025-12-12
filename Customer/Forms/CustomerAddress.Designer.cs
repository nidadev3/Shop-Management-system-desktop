namespace _2nddesktopapp.Customer.Forms
{
    partial class CustomerAddress
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
            searchcustomrtaddress = new Button();
            backcustomeraddress = new Button();
            customerbyaddresslbl = new Label();
            entercustomeraddress = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchcustomrtaddress
            // 
            searchcustomrtaddress.Location = new Point(634, 110);
            searchcustomrtaddress.Name = "searchcustomrtaddress";
            searchcustomrtaddress.Size = new Size(112, 34);
            searchcustomrtaddress.TabIndex = 0;
            searchcustomrtaddress.Text = "Search";
            searchcustomrtaddress.UseVisualStyleBackColor = true;
            searchcustomrtaddress.Click += searchcustomrtaddress_Click;
            // 
            // backcustomeraddress
            // 
            backcustomeraddress.Location = new Point(634, 383);
            backcustomeraddress.Name = "backcustomeraddress";
            backcustomeraddress.Size = new Size(112, 34);
            backcustomeraddress.TabIndex = 1;
            backcustomeraddress.Text = "back";
            backcustomeraddress.UseVisualStyleBackColor = true;
            backcustomeraddress.Click += backcustomeraddress_Click;
            // 
            // customerbyaddresslbl
            // 
            customerbyaddresslbl.AutoSize = true;
            customerbyaddresslbl.BackColor = SystemColors.ActiveCaption;
            customerbyaddresslbl.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerbyaddresslbl.ForeColor = Color.DarkSlateGray;
            customerbyaddresslbl.Location = new Point(166, 9);
            customerbyaddresslbl.Name = "customerbyaddresslbl";
            customerbyaddresslbl.Size = new Size(486, 47);
            customerbyaddresslbl.TabIndex = 2;
            customerbyaddresslbl.Text = "Search Customer By Address";
            // 
            // entercustomeraddress
            // 
            entercustomeraddress.AutoSize = true;
            entercustomeraddress.Location = new Point(32, 110);
            entercustomeraddress.Name = "entercustomeraddress";
            entercustomeraddress.Size = new Size(216, 25);
            entercustomeraddress.TabIndex = 3;
            entercustomeraddress.Text = "Enter Customer's Address";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(268, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(203, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(449, 201);
            dataGridView1.TabIndex = 5;
            // 
            // CustomerAddress
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(entercustomeraddress);
            Controls.Add(customerbyaddresslbl);
            Controls.Add(backcustomeraddress);
            Controls.Add(searchcustomrtaddress);
            Name = "CustomerAddress";
            Text = "CustomerAddress";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchcustomrtaddress;
        private Button backcustomeraddress;
        private Label customerbyaddresslbl;
        private Label entercustomeraddress;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}