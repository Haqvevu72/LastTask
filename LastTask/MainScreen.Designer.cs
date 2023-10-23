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
            search_bar = new TextBox();
            search_btn = new Button();
            clear_btn = new Button();
            remove_btn = new Button();
            edit_btn = new Button();
            add_btn = new Button();
            product_list = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)product_list).BeginInit();
            SuspendLayout();
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
            search_btn.Click += search_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.DarkSlateBlue;
            clear_btn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            clear_btn.ForeColor = Color.White;
            clear_btn.Location = new Point(12, 431);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(432, 28);
            clear_btn.TabIndex = 3;
            clear_btn.Text = "Clear List";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // remove_btn
            // 
            remove_btn.BackColor = Color.DarkSlateBlue;
            remove_btn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            remove_btn.ForeColor = Color.White;
            remove_btn.Location = new Point(12, 397);
            remove_btn.Name = "remove_btn";
            remove_btn.Size = new Size(432, 28);
            remove_btn.TabIndex = 4;
            remove_btn.Text = "Remove Product";
            remove_btn.UseVisualStyleBackColor = false;
            remove_btn.Click += remove_btn_Click;
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
            edit_btn.Click += edit_btn_Click;
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
            add_btn.Click += add_btn_Click;
            // 
            // product_list
            // 
            product_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            product_list.Location = new Point(14, 61);
            product_list.Name = "product_list";
            product_list.RowTemplate.Height = 25;
            product_list.Size = new Size(430, 263);
            product_list.TabIndex = 7;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(459, 471);
            Controls.Add(product_list);
            Controls.Add(add_btn);
            Controls.Add(edit_btn);
            Controls.Add(remove_btn);
            Controls.Add(clear_btn);
            Controls.Add(search_btn);
            Controls.Add(search_bar);
            Name = "MainScreen";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)product_list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox search_bar;
        private Button search_btn;
        private Button clear_btn;
        private Button remove_btn;
        private Button edit_btn;
        private Button add_btn;
        private DataGridView product_list;
    }
}