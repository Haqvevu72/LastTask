namespace LastTask
{
    partial class MainScreen
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
            product_list = new ListBox();
            search_bar = new TextBox();
            search_btn = new Button();
            button2 = new Button();
            button3 = new Button();
            edit_btn = new Button();
            add_btn = new Button();
            SuspendLayout();
            // 
            // product_list
            // 
            product_list.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            product_list.FormattingEnabled = true;
            product_list.ItemHeight = 21;
            product_list.Location = new Point(12, 53);
            product_list.Name = "product_list";
            product_list.Size = new Size(432, 256);
            product_list.TabIndex = 0;
            // 
            // search_bar
            // 
            search_bar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            search_bar.Location = new Point(12, 12);
            search_bar.Name = "search_bar";
            search_bar.Size = new Size(345, 29);
            search_bar.TabIndex = 1;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.DarkSlateBlue;
            search_btn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            search_btn.ForeColor = Color.White;
            search_btn.Location = new Point(372, 11);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(75, 36);
            search_btn.TabIndex = 2;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateBlue;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 431);
            button2.Name = "button2";
            button2.Size = new Size(432, 28);
            button2.TabIndex = 3;
            button2.Text = "Clear List";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateBlue;
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 397);
            button3.Name = "button3";
            button3.Size = new Size(432, 28);
            button3.TabIndex = 4;
            button3.Text = "Remove Product";
            button3.UseVisualStyleBackColor = false;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = Color.DarkSlateBlue;
            edit_btn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            edit_btn.ForeColor = Color.White;
            edit_btn.Location = new Point(12, 364);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(432, 28);
            edit_btn.TabIndex = 5;
            edit_btn.Text = "Edit Product";
            edit_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.DarkSlateBlue;
            add_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(12, 330);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(432, 28);
            add_btn.TabIndex = 6;
            add_btn.Text = "Add Product";
            add_btn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(459, 471);
            Controls.Add(add_btn);
            Controls.Add(edit_btn);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(search_btn);
            Controls.Add(search_bar);
            Controls.Add(product_list);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox product_list;
        private TextBox search_bar;
        private Button search_btn;
        private Button button2;
        private Button button3;
        private Button edit_btn;
        private Button add_btn;
    }
}