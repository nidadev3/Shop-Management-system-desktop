namespace _2nddesktopapp.Product
{
    partial class AdvanceFeaturesProduct_Form
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
            lbladvancepro = new Label();
            probyname = new Button();
            probyprice = new Button();
            probypricerange = new Button();
            probypricediffer = new Button();
            probysubstring = new Button();
            backpro = new Button();
            SuspendLayout();
            // 
            // lbladvancepro
            // 
            lbladvancepro.AutoSize = true;
            lbladvancepro.Font = new Font("Fraunces 9pt", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladvancepro.ForeColor = Color.DarkSlateGray;
            lbladvancepro.Location = new Point(169, 21);
            lbladvancepro.Name = "lbladvancepro";
            lbladvancepro.Size = new Size(443, 47);
            lbladvancepro.TabIndex = 0;
            lbladvancepro.Text = "Advance Product Features";
            // 
            // probyname
            // 
            probyname.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            probyname.ForeColor = Color.Teal;
            probyname.Location = new Point(286, 103);
            probyname.Name = "probyname";
            probyname.Size = new Size(175, 34);
            probyname.TabIndex = 1;
            probyname.Text = "Search By Name";
            probyname.UseVisualStyleBackColor = true;
            probyname.Click += probyname_Click;
            // 
            // probyprice
            // 
            probyprice.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            probyprice.ForeColor = Color.Teal;
            probyprice.Location = new Point(286, 167);
            probyprice.Name = "probyprice";
            probyprice.Size = new Size(175, 34);
            probyprice.TabIndex = 2;
            probyprice.Text = "Srach By Price";
            probyprice.UseVisualStyleBackColor = true;
            probyprice.Click += probyprice_Click;
            // 
            // probypricerange
            // 
            probypricerange.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            probypricerange.ForeColor = Color.Teal;
            probypricerange.Location = new Point(286, 228);
            probypricerange.Name = "probypricerange";
            probypricerange.Size = new Size(241, 34);
            probypricerange.TabIndex = 3;
            probypricerange.Text = "Search By Price Range";
            probypricerange.UseVisualStyleBackColor = true;
            probypricerange.Click += probypricerange_Click;
            // 
            // probypricediffer
            // 
            probypricediffer.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            probypricediffer.ForeColor = Color.Teal;
            probypricediffer.Location = new Point(286, 286);
            probypricediffer.Name = "probypricediffer";
            probypricediffer.Size = new Size(252, 34);
            probypricediffer.TabIndex = 4;
            probypricediffer.Text = "Search By Price Difference";
            probypricediffer.UseVisualStyleBackColor = true;
            probypricediffer.Click += probypricediffer_Click;
            // 
            // probysubstring
            // 
            probysubstring.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            probysubstring.ForeColor = Color.Teal;
            probysubstring.Location = new Point(286, 344);
            probysubstring.Name = "probysubstring";
            probysubstring.Size = new Size(252, 34);
            probysubstring.TabIndex = 5;
            probysubstring.Text = "Search By  Substring";
            probysubstring.UseVisualStyleBackColor = true;
            probysubstring.Click += probysubstring_Click;
            // 
            // backpro
            // 
            backpro.Font = new Font("Fraunces 9pt SemiBold", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            backpro.ForeColor = Color.Teal;
            backpro.Location = new Point(330, 398);
            backpro.Name = "backpro";
            backpro.Size = new Size(91, 30);
            backpro.TabIndex = 6;
            backpro.Text = "Back";
            backpro.UseVisualStyleBackColor = true;
            backpro.Click += backpro_Click;
            // 
            // AdvanceFeaturesProduct_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(backpro);
            Controls.Add(probysubstring);
            Controls.Add(probypricediffer);
            Controls.Add(probypricerange);
            Controls.Add(probyprice);
            Controls.Add(probyname);
            Controls.Add(lbladvancepro);
            Name = "AdvanceFeaturesProduct_Form";
            Text = "AdvanceFeaturesProduct_Form";
            Load += AdvanceFeaturesProduct_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbladvancepro;
        private Button probyname;
        private Button probyprice;
        private Button probypricerange;
        private Button probypricediffer;
        private Button probysubstring;
        private Button backpro;
    }
}