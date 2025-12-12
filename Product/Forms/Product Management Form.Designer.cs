namespace _2nddesktopapp.Product
{
    partial class Product_Management_Form
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
            label1 = new Label();
            lblProductName = new Label();
            lblProductPrice = new Label();
            lblSalePro = new Label();
            lblDisPro = new Label();
            ProId = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            addPro = new Button();
            updatepro = new Button();
            deletePro = new Button();
            ViewPro = new Button();
            backpro = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(449, 47);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT MANAGEMENT";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(12, 76);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(133, 26);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product Name";
            lblProductName.Click += lblProductName_Click;
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProductPrice.Location = new Point(12, 135);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(140, 26);
            lblProductPrice.TabIndex = 3;
            lblProductPrice.Text = "Purchase Price";
            lblProductPrice.Click += lblProductPrice_Click;
            // 
            // lblSalePro
            // 
            lblSalePro.AutoSize = true;
            lblSalePro.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSalePro.Location = new Point(12, 187);
            lblSalePro.Name = "lblSalePro";
            lblSalePro.Size = new Size(97, 26);
            lblSalePro.TabIndex = 4;
            lblSalePro.Text = "Sale Price";
            lblSalePro.Click += lblSalePro_Click;
            // 
            // lblDisPro
            // 
            lblDisPro.AutoSize = true;
            lblDisPro.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDisPro.Location = new Point(12, 238);
            lblDisPro.Name = "lblDisPro";
            lblDisPro.Size = new Size(88, 26);
            lblDisPro.TabIndex = 5;
            lblDisPro.Text = "Discount";
            lblDisPro.Click += lblDisPro_Click;
            // 
            // ProId
            // 
            ProId.AutoSize = true;
            ProId.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ProId.Location = new Point(12, 319);
            ProId.Name = "ProId";
            ProId.Size = new Size(222, 26);
            ProId.TabIndex = 6;
            ProId.Text = "ID(For Delete or Update)";
            ProId.Click += ProId_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 31);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(201, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(329, 31);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(201, 187);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(329, 31);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(240, 319);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(130, 31);
            textBox5.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(201, 238);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(329, 31);
            textBox7.TabIndex = 13;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // addPro
            // 
            addPro.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addPro.ForeColor = Color.Teal;
            addPro.Location = new Point(49, 407);
            addPro.Name = "addPro";
            addPro.Size = new Size(112, 34);
            addPro.TabIndex = 14;
            addPro.Text = "Add";
            addPro.UseVisualStyleBackColor = true;
            addPro.Click += addPro_Click;
            // 
            // updatepro
            // 
            updatepro.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            updatepro.ForeColor = Color.Teal;
            updatepro.Location = new Point(192, 407);
            updatepro.Name = "updatepro";
            updatepro.Size = new Size(112, 34);
            updatepro.TabIndex = 15;
            updatepro.Text = "Update";
            updatepro.UseVisualStyleBackColor = true;
            updatepro.Click += updatepro_Click;
            // 
            // deletePro
            // 
            deletePro.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            deletePro.ForeColor = Color.Teal;
            deletePro.Location = new Point(343, 407);
            deletePro.Name = "deletePro";
            deletePro.Size = new Size(112, 34);
            deletePro.TabIndex = 16;
            deletePro.Text = "Delete";
            deletePro.UseVisualStyleBackColor = true;
            deletePro.Click += deletePro_Click;
            // 
            // ViewPro
            // 
            ViewPro.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ViewPro.ForeColor = Color.Teal;
            ViewPro.Location = new Point(490, 407);
            ViewPro.Name = "ViewPro";
            ViewPro.Size = new Size(112, 34);
            ViewPro.TabIndex = 17;
            ViewPro.Text = "View All";
            ViewPro.UseVisualStyleBackColor = true;
            ViewPro.Click += ViewPro_Click;
            // 
            // backpro
            // 
            backpro.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            backpro.ForeColor = Color.Teal;
            backpro.Location = new Point(634, 407);
            backpro.Name = "backpro";
            backpro.Size = new Size(112, 34);
            backpro.TabIndex = 18;
            backpro.Text = "Back";
            backpro.UseVisualStyleBackColor = true;
            backpro.Click += backpro_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(551, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(221, 242);
            dataGridView1.TabIndex = 19;
            // 
            // Product_Management_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 491);
            Controls.Add(dataGridView1);
            Controls.Add(backpro);
            Controls.Add(ViewPro);
            Controls.Add(deletePro);
            Controls.Add(updatepro);
            Controls.Add(addPro);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(ProId);
            Controls.Add(lblDisPro);
            Controls.Add(lblSalePro);
            Controls.Add(lblProductPrice);
            Controls.Add(lblProductName);
            Controls.Add(label1);
            Name = "Product_Management_Form";
            Text = "Product_Management_Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblProductName;
        private Label lblProductPrice;
        private Label lblSalePro;
        private Label lblDisPro;
        private Label ProId;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox7;
        private Button addPro;
        private Button updatepro;
        private Button deletePro;
        private Button ViewPro;
        private Button backpro;
        private DataGridView dataGridView1;
    }
}