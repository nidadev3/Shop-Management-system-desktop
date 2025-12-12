namespace _2nddesktopapp.Product.Forms
{
    partial class Productbyname
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
            searchproductname = new Button();
            Backproductname = new Button();
            searchproductbynamebtn = new Label();
            enterproductname = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchproductname
            // 
            searchproductname.Location = new Point(579, 100);
            searchproductname.Name = "searchproductname";
            searchproductname.Size = new Size(112, 34);
            searchproductname.TabIndex = 0;
            searchproductname.Text = "Search";
            searchproductname.UseVisualStyleBackColor = true;
            searchproductname.Click += button1_Click;
            // 
            // Backproductname
            // 
            Backproductname.Location = new Point(579, 382);
            Backproductname.Name = "Backproductname";
            Backproductname.Size = new Size(112, 34);
            Backproductname.TabIndex = 1;
            Backproductname.Text = "Back";
            Backproductname.UseVisualStyleBackColor = true;
            Backproductname.Click += Backproductname_Click;
            // 
            // searchproductbynamebtn
            // 
            searchproductbynamebtn.AutoSize = true;
            searchproductbynamebtn.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchproductbynamebtn.ForeColor = Color.DarkSlateGray;
            searchproductbynamebtn.Location = new Point(180, 22);
            searchproductbynamebtn.Name = "searchproductbynamebtn";
            searchproductbynamebtn.Size = new Size(420, 47);
            searchproductbynamebtn.TabIndex = 2;
            searchproductbynamebtn.Text = "Search Product By Name";
            searchproductbynamebtn.Click += label1_Click;
            // 
            // enterproductname
            // 
            enterproductname.AutoSize = true;
            enterproductname.Location = new Point(43, 104);
            enterproductname.Name = "enterproductname";
            enterproductname.Size = new Size(168, 25);
            enterproductname.TabIndex = 3;
            enterproductname.Text = "Enter Product name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 31);
            textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(105, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(577, 183);
            dataGridView1.TabIndex = 5;
            // 
            // Productbyname
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(enterproductname);
            Controls.Add(searchproductbynamebtn);
            Controls.Add(Backproductname);
            Controls.Add(searchproductname);
            Name = "Productbyname";
            Text = "Productbyname";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchproductname;
        private Button Backproductname;
        private Label searchproductbynamebtn;
        private Label enterproductname;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}