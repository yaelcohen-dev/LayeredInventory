namespace UI
{
    partial class Cashier
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            totalPrice = new Label();
            addProductBtn = new Button();
            addProductInput = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            amountInput = new NumericUpDown();
            doOrderBtn = new Button();
            productBindingSource = new BindingSource(components);
            productsGrid = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productInOrderBindingSource = new BindingSource(components);
            productInOrderBindingSource1 = new BindingSource(components);
            productsInOrderGrid = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            originPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            finalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label6 = new Label();
            saleBindingSource = new BindingSource(components);
            saleInProductBindingSource = new BindingSource(components);
            sales = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salePriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isForClubDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            beginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)addProductInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productInOrderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productInOrderBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsInOrderGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleInProductBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sales).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(411, 471);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Total price";
            label1.Click += label1_Click;
            // 
            // totalPrice
            // 
            totalPrice.AutoSize = true;
            totalPrice.Location = new Point(439, 503);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(17, 20);
            totalPrice.TabIndex = 3;
            totalPrice.Text = "0";
            // 
            // addProductBtn
            // 
            addProductBtn.Location = new Point(88, 489);
            addProductBtn.Margin = new Padding(3, 4, 3, 4);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(169, 47);
            addProductBtn.TabIndex = 4;
            addProductBtn.Text = "Add product";
            addProductBtn.UseVisualStyleBackColor = true;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // addProductInput
            // 
            addProductInput.Location = new Point(202, 117);
            addProductInput.Margin = new Padding(3, 4, 3, 4);
            addProductInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            addProductInput.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            addProductInput.Name = "addProductInput";
            addProductInput.Size = new Size(137, 27);
            addProductInput.TabIndex = 5;
            addProductInput.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            addProductInput.ValueChanged += addProductInput_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(373, 24);
            label2.Name = "label2";
            label2.Size = new Size(195, 38);
            label2.TabIndex = 7;
            label2.Text = "Place an order";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 393);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 8;
            label3.Text = "choose amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 79);
            label4.Name = "label4";
            label4.Size = new Size(291, 20);
            label4.TabIndex = 9;
            label4.Text = "Insert product code or choose from the list";
            // 
            // amountInput
            // 
            amountInput.Location = new Point(88, 431);
            amountInput.Name = "amountInput";
            amountInput.Size = new Size(150, 27);
            amountInput.TabIndex = 10;
            amountInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // doOrderBtn
            // 
            doOrderBtn.Location = new Point(691, 485);
            doOrderBtn.Name = "doOrderBtn";
            doOrderBtn.Size = new Size(127, 37);
            doOrderBtn.TabIndex = 11;
            doOrderBtn.Text = "Do order";
            doOrderBtn.UseVisualStyleBackColor = true;
            doOrderBtn.Click += doOrderBtn_Click;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(BO.Product);
            // 
            // productsGrid
            // 
            productsGrid.AutoGenerateColumns = false;
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn });
            productsGrid.DataSource = productBindingSource;
            productsGrid.Location = new Point(41, 171);
            productsGrid.Name = "productsGrid";
            productsGrid.RowHeadersWidth = 51;
            productsGrid.RowTemplate.Height = 29;
            productsGrid.Size = new Size(299, 188);
            productsGrid.TabIndex = 0;
            productsGrid.CellContentClick += productsGrid_CellContentClick;
            productsGrid.SelectionChanged += productsGrid_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // productInOrderBindingSource
            // 
            productInOrderBindingSource.DataSource = typeof(BO.ProductInOrder);
            // 
            // productInOrderBindingSource1
            // 
            productInOrderBindingSource1.DataSource = typeof(BO.ProductInOrder);
            // 
            // productsInOrderGrid
            // 
            productsInOrderGrid.AutoGenerateColumns = false;
            productsInOrderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsInOrderGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, productNameDataGridViewTextBoxColumn, originPriceDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, finalPriceDataGridViewTextBoxColumn });
            productsInOrderGrid.DataSource = productInOrderBindingSource;
            productsInOrderGrid.Location = new Point(366, 136);
            productsInOrderGrid.Name = "productsInOrderGrid";
            productsInOrderGrid.RowHeadersWidth = 51;
            productsInOrderGrid.RowTemplate.Height = 29;
            productsInOrderGrid.Size = new Size(224, 285);
            productsInOrderGrid.TabIndex = 14;
            productsInOrderGrid.SelectionChanged += productsInOrderGrid_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // originPriceDataGridViewTextBoxColumn
            // 
            originPriceDataGridViewTextBoxColumn.DataPropertyName = "OriginPrice";
            originPriceDataGridViewTextBoxColumn.HeaderText = "OriginPrice";
            originPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            originPriceDataGridViewTextBoxColumn.Name = "originPriceDataGridViewTextBoxColumn";
            originPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Count";
            countDataGridViewTextBoxColumn.MinimumWidth = 6;
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.Width = 125;
            // 
            // finalPriceDataGridViewTextBoxColumn
            // 
            finalPriceDataGridViewTextBoxColumn.DataPropertyName = "FinalPrice";
            finalPriceDataGridViewTextBoxColumn.HeaderText = "FinalPrice";
            finalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            finalPriceDataGridViewTextBoxColumn.Name = "finalPriceDataGridViewTextBoxColumn";
            finalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 112);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 15;
            label5.Text = "Products in order";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(706, 112);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 16;
            label6.Text = "sales in order";
            // 
            // saleBindingSource
            // 
            saleBindingSource.DataSource = typeof(BO.Sale);
            // 
            // saleInProductBindingSource
            // 
            saleInProductBindingSource.DataSource = typeof(BO.SaleInProduct);
            // 
            // sales
            // 
            sales.AutoGenerateColumns = false;
            sales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sales.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, productIdDataGridViewTextBoxColumn, minAmountDataGridViewTextBoxColumn, salePriceDataGridViewTextBoxColumn, isForClubDataGridViewCheckBoxColumn, beginDataGridViewTextBoxColumn, endDataGridViewTextBoxColumn });
            sales.DataSource = saleBindingSource;
            sales.Location = new Point(604, 135);
            sales.Name = "sales";
            sales.RowHeadersWidth = 51;
            sales.RowTemplate.Height = 29;
            sales.Size = new Size(300, 286);
            sales.TabIndex = 17;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            idDataGridViewTextBoxColumn2.Width = 125;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // minAmountDataGridViewTextBoxColumn
            // 
            minAmountDataGridViewTextBoxColumn.DataPropertyName = "MinAmount";
            minAmountDataGridViewTextBoxColumn.HeaderText = "MinAmount";
            minAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            minAmountDataGridViewTextBoxColumn.Name = "minAmountDataGridViewTextBoxColumn";
            minAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            salePriceDataGridViewTextBoxColumn.HeaderText = "SalePrice";
            salePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            salePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // isForClubDataGridViewCheckBoxColumn
            // 
            isForClubDataGridViewCheckBoxColumn.DataPropertyName = "IsForClub";
            isForClubDataGridViewCheckBoxColumn.HeaderText = "IsForClub";
            isForClubDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isForClubDataGridViewCheckBoxColumn.Name = "isForClubDataGridViewCheckBoxColumn";
            isForClubDataGridViewCheckBoxColumn.Width = 125;
            // 
            // beginDataGridViewTextBoxColumn
            // 
            beginDataGridViewTextBoxColumn.DataPropertyName = "Begin";
            beginDataGridViewTextBoxColumn.HeaderText = "Begin";
            beginDataGridViewTextBoxColumn.MinimumWidth = 6;
            beginDataGridViewTextBoxColumn.Name = "beginDataGridViewTextBoxColumn";
            beginDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDataGridViewTextBoxColumn
            // 
            endDataGridViewTextBoxColumn.DataPropertyName = "End";
            endDataGridViewTextBoxColumn.HeaderText = "End";
            endDataGridViewTextBoxColumn.MinimumWidth = 6;
            endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            endDataGridViewTextBoxColumn.Width = 125;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(sales);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(productsInOrderGrid);
            Controls.Add(productsGrid);
            Controls.Add(doOrderBtn);
            Controls.Add(amountInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(addProductInput);
            Controls.Add(addProductBtn);
            Controls.Add(totalPrice);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cashier";
            ((System.ComponentModel.ISupportInitialize)addProductInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)productInOrderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productInOrderBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsInOrderGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleInProductBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label totalPrice;
        private Button addProductBtn;
        private NumericUpDown addProductInput;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown amountInput;
        private Button doOrderBtn;
        private BindingSource productBindingSource;
        private DataGridView productsGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private BindingSource productInOrderBindingSource;
        private BindingSource productInOrderBindingSource1;
        private DataGridView productsInOrderGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn originPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finalPriceDataGridViewTextBoxColumn;
        private Label label5;
        private Label label6;
        private BindingSource saleBindingSource;
        private BindingSource saleInProductBindingSource;
        private DataGridView sales;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isForClubDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn beginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
    }
}