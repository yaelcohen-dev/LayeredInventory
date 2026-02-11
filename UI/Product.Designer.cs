namespace UI
{
    partial class Product
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
            ProductTable = new TabControl();
            tabPage1 = new TabPage();
            deleteBtn = new Button();
            addBtn = new Button();
            updateBtn = new Button();
            categoryFilter = new ComboBox();
            filterLable = new Label();
            viewAll = new Button();
            ProductTable.SuspendLayout();
            SuspendLayout();
            // 
            // ProductTable
            // 
            ProductTable.AccessibleRole = AccessibleRole.None;
            ProductTable.Appearance = TabAppearance.Buttons;
            ProductTable.Controls.Add(tabPage1);
            ProductTable.HotTrack = true;
            ProductTable.Location = new Point(261, 105);
            ProductTable.Name = "ProductTable";
            ProductTable.SelectedIndex = 0;
            ProductTable.Size = new Size(493, 304);
            ProductTable.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(485, 268);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "All products";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(51, 335);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(161, 70);
            deleteBtn.TabIndex = 1;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click_1;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(51, 137);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(161, 70);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click_1;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(51, 238);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(161, 70);
            updateBtn.TabIndex = 3;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click_1;
            // 
            // categoryFilter
            // 
            categoryFilter.FormattingEnabled = true;
            categoryFilter.Location = new Point(603, 90);
            categoryFilter.Name = "categoryFilter";
            categoryFilter.Size = new Size(151, 28);
            categoryFilter.TabIndex = 4;
            categoryFilter.SelectedIndexChanged += categoryFilter_SelectedIndexChanged;
            // 
            // filterLable
            // 
            filterLable.AutoSize = true;
            filterLable.Location = new Point(634, 56);
            filterLable.Name = "filterLable";
            filterLable.Size = new Size(120, 20);
            filterLable.TabIndex = 5;
            filterLable.Text = "Filter by caterory";
            // 
            // viewAll
            // 
            viewAll.Location = new Point(449, 90);
            viewAll.Name = "viewAll";
            viewAll.Size = new Size(127, 25);
            viewAll.TabIndex = 11;
            viewAll.Text = "View all";
            viewAll.UseVisualStyleBackColor = true;
            viewAll.Click += viewAll_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewAll);
            Controls.Add(filterLable);
            Controls.Add(categoryFilter);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(deleteBtn);
            Controls.Add(ProductTable);
            Name = "Product";
            Text = "Product";
            ProductTable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl ProductTable;
        private TabPage tabPage1;
        private Button deleteBtn;
        private Button addBtn;
        private Button updateBtn;
        private ComboBox categoryFilter;
        private Label filterLable;
        private Button viewAll;
    }
}