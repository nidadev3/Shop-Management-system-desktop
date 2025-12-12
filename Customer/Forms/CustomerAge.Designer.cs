namespace _2nddesktopapp.Customer.Forms
{
    partial class CustomerAge
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
            backcustomerage = new Button();
            searchcustomeragebtn = new Button();
            lblcustomerage = new Label();
            entercustomerage = new Label();
            txtboxage = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backcustomerage
            // 
            backcustomerage.Location = new Point(568, 375);
            backcustomerage.Name = "backcustomerage";
            backcustomerage.Size = new Size(112, 34);
            backcustomerage.TabIndex = 0;
            backcustomerage.Text = "Back";
            backcustomerage.UseVisualStyleBackColor = true;
            backcustomerage.Click += button1_Click;
            // 
            // searchcustomeragebtn
            // 
            searchcustomeragebtn.Location = new Point(568, 131);
            searchcustomeragebtn.Name = "searchcustomeragebtn";
            searchcustomeragebtn.Size = new Size(112, 34);
            searchcustomeragebtn.TabIndex = 1;
            searchcustomeragebtn.Text = "Search";
            searchcustomeragebtn.UseVisualStyleBackColor = true;
            searchcustomeragebtn.Click += button2_Click;
            // 
            // lblcustomerage
            // 
            lblcustomerage.AutoSize = true;
            lblcustomerage.BackColor = SystemColors.ActiveCaption;
            lblcustomerage.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcustomerage.ForeColor = Color.DarkSlateGray;
            lblcustomerage.Location = new Point(192, 38);
            lblcustomerage.Name = "lblcustomerage";
            lblcustomerage.Size = new Size(421, 47);
            lblcustomerage.TabIndex = 2;
            lblcustomerage.Text = "Search By Customer Age ";
            // 
            // entercustomerage
            // 
            entercustomerage.AutoSize = true;
            entercustomerage.Location = new Point(129, 131);
            entercustomerage.Name = "entercustomerage";
            entercustomerage.Size = new Size(193, 25);
            entercustomerage.TabIndex = 3;
            entercustomerage.Text = "Enter Age of Customer";
            // 
            // txtboxage
            // 
            txtboxage.Location = new Point(328, 131);
            txtboxage.Name = "txtboxage";
            txtboxage.Size = new Size(202, 31);
            txtboxage.TabIndex = 4;
            txtboxage.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(194, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(436, 151);
            dataGridView1.TabIndex = 5;
            // 
            // CustomerAge
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(txtboxage);
            Controls.Add(entercustomerage);
            Controls.Add(lblcustomerage);
            Controls.Add(searchcustomeragebtn);
            Controls.Add(backcustomerage);
            Name = "CustomerAge";
            Text = "CustomerAge";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backcustomerage;
        private Button searchcustomeragebtn;
        private Label lblcustomerage;
        private Label entercustomerage;
        private TextBox txtboxage;
        private DataGridView dataGridView1;
    }
}