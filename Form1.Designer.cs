namespace _2nddesktopapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPOS = new Label();
            btnCustomerManagement = new Button();
            btnProductManagement = new Button();
            btnOrderManagement = new Button();
            label1 = new Label();
            btnCustomerAF = new Button();
            btnProductAF = new Button();
            SuspendLayout();
            // 
            // lblPOS
            // 
            lblPOS.AutoSize = true;
            lblPOS.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPOS.ForeColor = Color.DarkSlateGray;
            lblPOS.Location = new Point(264, 19);
            lblPOS.Name = "lblPOS";
            lblPOS.Size = new Size(278, 47);
            lblPOS.TabIndex = 0;
            lblPOS.Text = "POINT OF SALE";
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.BackColor = SystemColors.Control;
            btnCustomerManagement.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCustomerManagement.ForeColor = Color.Teal;
            btnCustomerManagement.Location = new Point(264, 94);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(278, 34);
            btnCustomerManagement.TabIndex = 1;
            btnCustomerManagement.Text = "Customer Management";
            btnCustomerManagement.UseVisualStyleBackColor = false;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            // 
            // btnProductManagement
            // 
            btnProductManagement.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProductManagement.ForeColor = Color.Teal;
            btnProductManagement.Location = new Point(264, 148);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(278, 34);
            btnProductManagement.TabIndex = 2;
            btnProductManagement.Text = "Product Management";
            btnProductManagement.UseVisualStyleBackColor = true;
            btnProductManagement.Click += btnProductManagement_Click;
            // 
            // btnOrderManagement
            // 
            btnOrderManagement.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOrderManagement.ForeColor = Color.Teal;
            btnOrderManagement.Location = new Point(264, 204);
            btnOrderManagement.Name = "btnOrderManagement";
            btnOrderManagement.Size = new Size(278, 34);
            btnOrderManagement.TabIndex = 3;
            btnOrderManagement.Text = "Order Management";
            btnOrderManagement.UseVisualStyleBackColor = true;
            btnOrderManagement.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(222, 273);
            label1.Name = "label1";
            label1.Size = new Size(373, 47);
            label1.TabIndex = 4;
            label1.Text = "ADVANCE FEATURES";
            label1.Click += label1_Click;
            // 
            // btnCustomerAF
            // 
            btnCustomerAF.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCustomerAF.ForeColor = Color.Teal;
            btnCustomerAF.Location = new Point(264, 350);
            btnCustomerAF.Name = "btnCustomerAF";
            btnCustomerAF.Size = new Size(278, 34);
            btnCustomerAF.TabIndex = 5;
            btnCustomerAF.Text = "Customer";
            btnCustomerAF.UseVisualStyleBackColor = true;
            btnCustomerAF.Click += btnCustomerAF_Click;
            // 
            // btnProductAF
            // 
            btnProductAF.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProductAF.ForeColor = Color.Teal;
            btnProductAF.Location = new Point(264, 409);
            btnProductAF.Name = "btnProductAF";
            btnProductAF.Size = new Size(278, 34);
            btnProductAF.TabIndex = 6;
            btnProductAF.Text = "Product";
            btnProductAF.UseVisualStyleBackColor = true;
            btnProductAF.Click += btnProductAF_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 494);
            Controls.Add(btnProductAF);
            Controls.Add(btnCustomerAF);
            Controls.Add(label1);
            Controls.Add(btnOrderManagement);
            Controls.Add(btnProductManagement);
            Controls.Add(btnCustomerManagement);
            Controls.Add(lblPOS);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPOS;
        private Button btnCustomerManagement;
        private Button btnProductManagement;
        private Button btnOrderManagement;
        private Label label1;
        private Button btnCustomerAF;
        private Button btnProductAF;
    }
}
