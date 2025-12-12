namespace _2nddesktopapp.Customer.Forms
{
    partial class CustomerSubstring
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
            searchbyfirstcharacter = new Button();
            backcustomerfirstchar = new Button();
            lblcustomerbyfirstcharacter = new Label();
            enterfirstcharacter = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchbyfirstcharacter
            // 
            searchbyfirstcharacter.Location = new Point(604, 101);
            searchbyfirstcharacter.Name = "searchbyfirstcharacter";
            searchbyfirstcharacter.Size = new Size(112, 34);
            searchbyfirstcharacter.TabIndex = 0;
            searchbyfirstcharacter.Text = "Search";
            searchbyfirstcharacter.UseVisualStyleBackColor = true;
            searchbyfirstcharacter.Click += searchbyfirstcharacter_Click;
            // 
            // backcustomerfirstchar
            // 
            backcustomerfirstchar.Location = new Point(604, 385);
            backcustomerfirstchar.Name = "backcustomerfirstchar";
            backcustomerfirstchar.Size = new Size(112, 34);
            backcustomerfirstchar.TabIndex = 1;
            backcustomerfirstchar.Text = "Back";
            backcustomerfirstchar.UseVisualStyleBackColor = true;
            backcustomerfirstchar.Click += backcustomerfirstchar_Click;
            // 
            // lblcustomerbyfirstcharacter
            // 
            lblcustomerbyfirstcharacter.AutoSize = true;
            lblcustomerbyfirstcharacter.BackColor = SystemColors.ActiveCaption;
            lblcustomerbyfirstcharacter.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcustomerbyfirstcharacter.ForeColor = Color.DarkSlateGray;
            lblcustomerbyfirstcharacter.Location = new Point(89, 9);
            lblcustomerbyfirstcharacter.Name = "lblcustomerbyfirstcharacter";
            lblcustomerbyfirstcharacter.Size = new Size(599, 47);
            lblcustomerbyfirstcharacter.TabIndex = 2;
            lblcustomerbyfirstcharacter.Text = "Search By Customer First Character";
            // 
            // enterfirstcharacter
            // 
            enterfirstcharacter.AutoSize = true;
            enterfirstcharacter.Location = new Point(12, 101);
            enterfirstcharacter.Name = "enterfirstcharacter";
            enterfirstcharacter.Size = new Size(312, 25);
            enterfirstcharacter.TabIndex = 3;
            enterfirstcharacter.Text = "Enter Customer's Name first Character";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(340, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 31);
            textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(100, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(562, 190);
            dataGridView1.TabIndex = 5;
            // 
            // CustomerSubstring
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(enterfirstcharacter);
            Controls.Add(lblcustomerbyfirstcharacter);
            Controls.Add(backcustomerfirstchar);
            Controls.Add(searchbyfirstcharacter);
            Name = "CustomerSubstring";
            Text = "CustomerSubstring";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchbyfirstcharacter;
        private Button backcustomerfirstchar;
        private Label lblcustomerbyfirstcharacter;
        private Label enterfirstcharacter;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}