namespace _2nddesktopapp.Customer.Forms
{
    partial class CustomerName
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
            backcustomername = new Button();
            searchnamecustomer = new Button();
            customernamelbl = new Label();
            enternamecus = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backcustomername
            // 
            backcustomername.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            backcustomername.ForeColor = Color.Teal;
            backcustomername.Location = new Point(568, 392);
            backcustomername.Name = "backcustomername";
            backcustomername.Size = new Size(112, 34);
            backcustomername.TabIndex = 0;
            backcustomername.Text = "Back";
            backcustomername.UseVisualStyleBackColor = true;
            backcustomername.Click += backcustomername_Click;
            // 
            // searchnamecustomer
            // 
            searchnamecustomer.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            searchnamecustomer.ForeColor = Color.Teal;
            searchnamecustomer.Location = new Point(581, 126);
            searchnamecustomer.Name = "searchnamecustomer";
            searchnamecustomer.Size = new Size(99, 39);
            searchnamecustomer.TabIndex = 1;
            searchnamecustomer.Text = "Search";
            searchnamecustomer.UseVisualStyleBackColor = true;
            searchnamecustomer.Click += searchnamecustomer_Click;
            // 
            // customernamelbl
            // 
            customernamelbl.AutoSize = true;
            customernamelbl.BackColor = SystemColors.ActiveCaption;
            customernamelbl.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customernamelbl.ForeColor = Color.DarkSlateGray;
            customernamelbl.Location = new Point(238, 30);
            customernamelbl.Name = "customernamelbl";
            customernamelbl.Size = new Size(330, 47);
            customernamelbl.TabIndex = 2;
            customernamelbl.Text = "Customer By Name";
            // 
            // enternamecus
            // 
            enternamecus.AutoSize = true;
            enternamecus.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            enternamecus.Location = new Point(139, 132);
            enternamecus.Name = "enternamecus";
            enternamecus.Size = new Size(118, 26);
            enternamecus.TabIndex = 3;
            enternamecus.Text = "Enter Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(263, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(189, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(491, 172);
            dataGridView1.TabIndex = 5;
            // 
            // CustomerName
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(enternamecus);
            Controls.Add(customernamelbl);
            Controls.Add(searchnamecustomer);
            Controls.Add(backcustomername);
            Name = "CustomerName";
            Text = "CustomerAge";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backcustomername;
        private Button searchnamecustomer;
        private Label customernamelbl;
        private Label enternamecus;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}