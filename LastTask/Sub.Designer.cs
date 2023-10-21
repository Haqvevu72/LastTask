namespace LastTask
{
    partial class Sub
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
            product_namelbl = new Label();
            product_name = new TextBox();
            product_cost = new TextBox();
            label1 = new Label();
            origin_country = new TextBox();
            label = new Label();
            OK_btn = new Button();
            cancel_btn = new Button();
            SuspendLayout();
            // 
            // product_namelbl
            // 
            product_namelbl.AutoSize = true;
            product_namelbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            product_namelbl.ForeColor = Color.White;
            product_namelbl.Location = new Point(28, 18);
            product_namelbl.Name = "product_namelbl";
            product_namelbl.Size = new Size(112, 20);
            product_namelbl.TabIndex = 0;
            product_namelbl.Text = "Product Name:";
            // 
            // product_name
            // 
            product_name.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            product_name.Location = new Point(31, 46);
            product_name.Name = "product_name";
            product_name.Size = new Size(364, 27);
            product_name.TabIndex = 1;
            // 
            // product_cost
            // 
            product_cost.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            product_cost.Location = new Point(31, 185);
            product_cost.Name = "product_cost";
            product_cost.Size = new Size(364, 27);
            product_cost.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 153);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 2;
            label1.Text = "Product Cost:";
            // 
            // origin_country
            // 
            origin_country.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            origin_country.Location = new Point(31, 111);
            origin_country.Name = "origin_country";
            origin_country.Size = new Size(364, 27);
            origin_country.TabIndex = 5;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = Color.White;
            label.Location = new Point(28, 83);
            label.Name = "label";
            label.Size = new Size(116, 20);
            label.TabIndex = 4;
            label.Text = "Origin Country:";
            // 
            // OK_btn
            // 
            OK_btn.BackColor = Color.CornflowerBlue;
            OK_btn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            OK_btn.ForeColor = Color.White;
            OK_btn.Location = new Point(31, 257);
            OK_btn.Name = "OK_btn";
            OK_btn.Size = new Size(87, 29);
            OK_btn.TabIndex = 6;
            OK_btn.Text = "OK";
            OK_btn.UseVisualStyleBackColor = false;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.CornflowerBlue;
            cancel_btn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cancel_btn.ForeColor = Color.White;
            cancel_btn.Location = new Point(308, 257);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(87, 29);
            cancel_btn.TabIndex = 7;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(423, 319);
            Controls.Add(cancel_btn);
            Controls.Add(OK_btn);
            Controls.Add(origin_country);
            Controls.Add(label);
            Controls.Add(product_cost);
            Controls.Add(label1);
            Controls.Add(product_name);
            Controls.Add(product_namelbl);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label product_namelbl;
        private TextBox product_name;
        private TextBox product_cost;
        private Label label1;
        private TextBox origin_country;
        private Label label;
        private Button OK_btn;
        private Button cancel_btn;
    }
}