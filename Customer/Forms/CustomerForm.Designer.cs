namespace _2nddesktopapp.Customer
{
    partial class CustomerForm
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
            lblCS2 = new Label();
            CusName = new Label();
            CusContact = new Label();
            CusAge = new Label();
            CusAddress = new Label();
            IDUD = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnAddCus = new Button();
            btnDelCus = new Button();
            btnUpdCus = new Button();
            btnViewCus = new Button();
            btnbackCus = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCS2
            // 
            lblCS2.AutoSize = true;
            lblCS2.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCS2.ForeColor = Color.DarkSlateGray;
            lblCS2.Location = new Point(178, 18);
            lblCS2.Name = "lblCS2";
            lblCS2.Size = new Size(473, 47);
            lblCS2.TabIndex = 0;
            lblCS2.Text = "CUSTOMER MANAGEMENT";
            // 
            // CusName
            // 
            CusName.AutoSize = true;
            CusName.BackColor = SystemColors.ActiveCaption;
            CusName.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CusName.ForeColor = Color.Black;
            CusName.Location = new Point(21, 109);
            CusName.Name = "CusName";
            CusName.Size = new Size(146, 26);
            CusName.TabIndex = 1;
            CusName.Text = "Customer Name";
            CusName.Click += CusName_Click;
            // 
            // CusContact
            // 
            CusContact.AutoSize = true;
            CusContact.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CusContact.ForeColor = SystemColors.ActiveCaptionText;
            CusContact.Location = new Point(21, 156);
            CusContact.Name = "CusContact";
            CusContact.Size = new Size(164, 26);
            CusContact.TabIndex = 2;
            CusContact.Text = "Customer Contact";
            CusContact.Click += CusContact_Click;
            // 
            // CusAge
            // 
            CusAge.AutoSize = true;
            CusAge.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CusAge.ForeColor = SystemColors.InactiveCaptionText;
            CusAge.Location = new Point(21, 208);
            CusAge.Name = "CusAge";
            CusAge.Size = new Size(129, 26);
            CusAge.TabIndex = 3;
            CusAge.Text = "Customer Age";
            CusAge.Click += label4_Click;
            // 
            // CusAddress
            // 
            CusAddress.AutoSize = true;
            CusAddress.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CusAddress.Location = new Point(21, 257);
            CusAddress.Name = "CusAddress";
            CusAddress.Size = new Size(166, 26);
            CusAddress.TabIndex = 4;
            CusAddress.Text = "Customer Address";
            // 
            // IDUD
            // 
            IDUD.AutoSize = true;
            IDUD.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            IDUD.Location = new Point(12, 315);
            IDUD.Name = "IDUD";
            IDUD.Size = new Size(212, 26);
            IDUD.TabIndex = 5;
            IDUD.Text = "ID(for delete or update)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(204, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(323, 31);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(204, 206);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(323, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(204, 257);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(319, 31);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(230, 315);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(89, 31);
            textBox5.TabIndex = 10;
            // 
            // btnAddCus
            // 
            btnAddCus.Font = new Font("Fraunces 9pt", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddCus.ForeColor = Color.Teal;
            btnAddCus.Location = new Point(38, 428);
            btnAddCus.Name = "btnAddCus";
            btnAddCus.Size = new Size(112, 34);
            btnAddCus.TabIndex = 11;
            btnAddCus.Text = "ADD";
            btnAddCus.UseVisualStyleBackColor = true;
            btnAddCus.Click += btnAddCus_Click;
            // 
            // btnDelCus
            // 
            btnDelCus.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelCus.ForeColor = Color.Teal;
            btnDelCus.Location = new Point(187, 428);
            btnDelCus.Name = "btnDelCus";
            btnDelCus.Size = new Size(112, 34);
            btnDelCus.TabIndex = 12;
            btnDelCus.Text = "Delete";
            btnDelCus.UseVisualStyleBackColor = true;
            btnDelCus.Click += btnDelCus_Click_2;
            // 
            // btnUpdCus
            // 
            btnUpdCus.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdCus.ForeColor = Color.Teal;
            btnUpdCus.Location = new Point(333, 428);
            btnUpdCus.Name = "btnUpdCus";
            btnUpdCus.Size = new Size(112, 34);
            btnUpdCus.TabIndex = 13;
            btnUpdCus.Text = "Update";
            btnUpdCus.UseVisualStyleBackColor = true;
            btnUpdCus.Click += btnUpdCus_Click;
            // 
            // btnViewCus
            // 
            btnViewCus.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnViewCus.ForeColor = Color.Teal;
            btnViewCus.Location = new Point(478, 428);
            btnViewCus.Name = "btnViewCus";
            btnViewCus.Size = new Size(112, 34);
            btnViewCus.TabIndex = 14;
            btnViewCus.Text = "View All";
            btnViewCus.UseVisualStyleBackColor = true;
            btnViewCus.Click += button4_Click;
            // 
            // btnbackCus
            // 
            btnbackCus.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnbackCus.ForeColor = Color.Teal;
            btnbackCus.Location = new Point(621, 428);
            btnbackCus.Name = "btnbackCus";
            btnbackCus.Size = new Size(112, 34);
            btnbackCus.TabIndex = 15;
            btnbackCus.Text = "Back";
            btnbackCus.UseVisualStyleBackColor = true;
            btnbackCus.Click += btnbackCus_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(559, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(229, 239);
            dataGridView1.TabIndex = 16;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 521);
            Controls.Add(dataGridView1);
            Controls.Add(btnbackCus);
            Controls.Add(btnViewCus);
            Controls.Add(btnUpdCus);
            Controls.Add(btnDelCus);
            Controls.Add(btnAddCus);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(IDUD);
            Controls.Add(CusAddress);
            Controls.Add(CusAge);
            Controls.Add(CusContact);
            Controls.Add(CusName);
            Controls.Add(lblCS2);
            Name = "CustomerForm";
            Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCS2;
        private Label CusName;
        private Label CusContact;
        private Label CusAge;
        private Label CusAddress;
        private Label IDUD;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnAddCus;
        private Button btnDelCus;
        private Button btnUpdCus;
        private Button btnViewCus;
        private Button btnbackCus;
        private DataGridView dataGridView1;
    }
}