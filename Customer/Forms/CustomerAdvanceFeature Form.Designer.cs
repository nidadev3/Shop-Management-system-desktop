namespace _2nddesktopapp.Customer
{
    partial class CustomerAdvanceFeature_Form
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
            cusbyname = new Button();
            cusbychar = new Button();
            cusbyage = new Button();
            cusbyaddress = new Button();
            cusbycontact = new Button();
            advancecusback = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cusbyname
            // 
            cusbyname.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cusbyname.ForeColor = Color.Teal;
            cusbyname.Location = new Point(272, 85);
            cusbyname.Name = "cusbyname";
            cusbyname.Size = new Size(249, 34);
            cusbyname.TabIndex = 0;
            cusbyname.Text = "Search By Name";
            cusbyname.UseVisualStyleBackColor = true;
            cusbyname.Click += button1_Click;
            // 
            // cusbychar
            // 
            cusbychar.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cusbychar.ForeColor = Color.Teal;
            cusbychar.Location = new Point(272, 139);
            cusbychar.Name = "cusbychar";
            cusbychar.Size = new Size(249, 34);
            cusbychar.TabIndex = 1;
            cusbychar.Text = "Search By First Character";
            cusbychar.UseVisualStyleBackColor = true;
            cusbychar.Click += cusbychar_Click;
            // 
            // cusbyage
            // 
            cusbyage.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cusbyage.ForeColor = Color.Teal;
            cusbyage.Location = new Point(272, 190);
            cusbyage.Name = "cusbyage";
            cusbyage.Size = new Size(249, 34);
            cusbyage.TabIndex = 2;
            cusbyage.Text = "Search By Age";
            cusbyage.UseVisualStyleBackColor = true;
            cusbyage.Click += cusbyage_Click;
            // 
            // cusbyaddress
            // 
            cusbyaddress.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cusbyaddress.ForeColor = Color.Teal;
            cusbyaddress.Location = new Point(272, 244);
            cusbyaddress.Name = "cusbyaddress";
            cusbyaddress.Size = new Size(249, 34);
            cusbyaddress.TabIndex = 3;
            cusbyaddress.Text = "Search By Address";
            cusbyaddress.UseVisualStyleBackColor = true;
            cusbyaddress.Click += cusbyaddress_Click;
            // 
            // cusbycontact
            // 
            cusbycontact.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cusbycontact.ForeColor = Color.Teal;
            cusbycontact.Location = new Point(272, 297);
            cusbycontact.Name = "cusbycontact";
            cusbycontact.Size = new Size(249, 34);
            cusbycontact.TabIndex = 4;
            cusbycontact.Text = "Search By Contact";
            cusbycontact.UseVisualStyleBackColor = true;
            cusbycontact.Click += cusbycontact_Click;
            // 
            // advancecusback
            // 
            advancecusback.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            advancecusback.ForeColor = Color.Teal;
            advancecusback.Location = new Point(338, 357);
            advancecusback.Name = "advancecusback";
            advancecusback.Size = new Size(112, 34);
            advancecusback.TabIndex = 5;
            advancecusback.Text = "Back";
            advancecusback.UseVisualStyleBackColor = true;
            advancecusback.Click += advancecusback_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(166, 9);
            label1.Name = "label1";
            label1.Size = new Size(471, 47);
            label1.TabIndex = 6;
            label1.Text = "Advance Customer Features";
            // 
            // CustomerAdvanceFeature_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(advancecusback);
            Controls.Add(cusbycontact);
            Controls.Add(cusbyaddress);
            Controls.Add(cusbyage);
            Controls.Add(cusbychar);
            Controls.Add(cusbyname);
            Name = "CustomerAdvanceFeature_Form";
            Text = "CustomerAdvanceFeature_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cusbyname;
        private Button cusbychar;
        private Button cusbyage;
        private Button cusbyaddress;
        private Button cusbycontact;
        private Button advancecusback;
        private Label label1;
    }
}