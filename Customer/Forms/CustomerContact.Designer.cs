namespace _2nddesktopapp.Customer.Forms
{
    partial class CustomerContact
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
            searchcustomebycontack = new Button();
            backcustomercontact = new Button();
            label1 = new Label();
            customercontactlbl = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchcustomebycontack
            // 
            searchcustomebycontack.Location = new Point(589, 115);
            searchcustomebycontack.Name = "searchcustomebycontack";
            searchcustomebycontack.Size = new Size(112, 34);
            searchcustomebycontack.TabIndex = 0;
            searchcustomebycontack.Text = "Search";
            searchcustomebycontack.UseVisualStyleBackColor = true;
            searchcustomebycontack.Click += searchcustomebycontack_Click;
            // 
            // backcustomercontact
            // 
            backcustomercontact.Location = new Point(569, 394);
            backcustomercontact.Name = "backcustomercontact";
            backcustomercontact.Size = new Size(112, 34);
            backcustomercontact.TabIndex = 1;
            backcustomercontact.Text = "Back";
            backcustomercontact.UseVisualStyleBackColor = true;
            backcustomercontact.Click += backcustomercontact_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(166, 24);
            label1.Name = "label1";
            label1.Size = new Size(480, 47);
            label1.TabIndex = 2;
            label1.Text = "Search Customer By Contact";
            // 
            // customercontactlbl
            // 
            customercontactlbl.AutoSize = true;
            customercontactlbl.Location = new Point(57, 112);
            customercontactlbl.Name = "customercontactlbl";
            customercontactlbl.Size = new Size(216, 25);
            customercontactlbl.TabIndex = 3;
            customercontactlbl.Text = "Enter Customer's Contact:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(180, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(466, 192);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CustomerContact
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(customercontactlbl);
            Controls.Add(label1);
            Controls.Add(backcustomercontact);
            Controls.Add(searchcustomebycontack);
            Name = "CustomerContact";
            Text = "CustomerContact";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchcustomebycontack;
        private Button backcustomercontact;
        private Label label1;
        private Label customercontactlbl;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}