namespace UI
{
    partial class Customer
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
            customerTable = new TabControl();
            tabPage1 = new TabPage();
            idFilter = new ComboBox();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            filterLable = new Label();
            viewAll = new Button();
            customerTable.SuspendLayout();
            SuspendLayout();
            // 
            // customerTable
            // 
            customerTable.AccessibleRole = AccessibleRole.None;
            customerTable.Appearance = TabAppearance.Buttons;
            customerTable.Controls.Add(tabPage1);
            customerTable.HotTrack = true;
            customerTable.Location = new Point(354, 219);
            customerTable.Name = "customerTable";
            customerTable.SelectedIndex = 0;
            customerTable.Size = new Size(493, 304);
            customerTable.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(485, 268);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "All customers";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // idFilter
            // 
            idFilter.FormattingEnabled = true;
            idFilter.Location = new Point(696, 160);
            idFilter.Name = "idFilter";
            idFilter.Size = new Size(151, 28);
            idFilter.TabIndex = 5;
            idFilter.SelectedIndexChanged += idFilter_SelectedIndexChanged;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(71, 449);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(161, 70);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(71, 347);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(161, 70);
            updateBtn.TabIndex = 7;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(71, 251);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(161, 70);
            addBtn.TabIndex = 8;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // filterLable
            // 
            filterLable.AutoSize = true;
            filterLable.Location = new Point(727, 106);
            filterLable.Name = "filterLable";
            filterLable.Size = new Size(79, 20);
            filterLable.TabIndex = 9;
            filterLable.Text = "Filter by id";
            // 
            // viewAll
            // 
            viewAll.Location = new Point(537, 160);
            viewAll.Name = "viewAll";
            viewAll.Size = new Size(127, 25);
            viewAll.TabIndex = 10;
            viewAll.Text = "View all";
            viewAll.UseVisualStyleBackColor = true;
            viewAll.Click += viewAll_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(viewAll);
            Controls.Add(filterLable);
            Controls.Add(addBtn);
            Controls.Add(updateBtn);
            Controls.Add(deleteBtn);
            Controls.Add(idFilter);
            Controls.Add(customerTable);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Customer";
            Text = "Customer";
            customerTable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl customerTable;
        private TabPage tabPage1;
        private ComboBox idFilter;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
        private Label filterLable;
        private Button viewAll;
    }
}