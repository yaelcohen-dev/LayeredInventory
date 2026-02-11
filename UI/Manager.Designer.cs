namespace UI
{
    partial class Manager
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
            selectCategory = new Label();
            Products = new Button();
            Sales = new Button();
            Customers = new Button();
            SuspendLayout();
            // 
            // selectCategory
            // 
            selectCategory.AutoSize = true;
            selectCategory.Location = new Point(408, 221);
            selectCategory.Name = "selectCategory";
            selectCategory.Size = new Size(113, 20);
            selectCategory.TabIndex = 0;
            selectCategory.Text = "Select Category";
            selectCategory.Click += label1_Click;
            // 
            // Products
            // 
            Products.Location = new Point(296, 277);
            Products.Margin = new Padding(3, 4, 3, 4);
            Products.Name = "Products";
            Products.Size = new Size(86, 31);
            Products.TabIndex = 1;
            Products.Text = "Products";
            Products.UseVisualStyleBackColor = true;
            Products.Click += Products_Click;
            // 
            // Sales
            // 
            Sales.Location = new Point(408, 277);
            Sales.Margin = new Padding(3, 4, 3, 4);
            Sales.Name = "Sales";
            Sales.Size = new Size(86, 31);
            Sales.TabIndex = 2;
            Sales.Text = "Sales";
            Sales.UseVisualStyleBackColor = true;
            Sales.Click += button1_Click;
            // 
            // Customers
            // 
            Customers.Location = new Point(544, 277);
            Customers.Margin = new Padding(3, 4, 3, 4);
            Customers.Name = "Customers";
            Customers.Size = new Size(86, 31);
            Customers.TabIndex = 3;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = true;
            Customers.Click += Customers_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Customers);
            Controls.Add(Sales);
            Controls.Add(Products);
            Controls.Add(selectCategory);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Manager";
            Text = "Manager";
            Load += Manager_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectCategory;
        private Button Products;
        private Button Sales;
        private Button Customers;
    }
}