namespace UI
{
    partial class Sale
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
            SaleTable = new TabControl();
            tabPage1 = new TabPage();
            updateBtn = new Button();
            addBtn = new Button();
            deleteBtn = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            SaleTable.SuspendLayout();
            SuspendLayout();
            // 
            // SaleTable
            // 
            SaleTable.AccessibleRole = AccessibleRole.None;
            SaleTable.Appearance = TabAppearance.Buttons;
            SaleTable.Controls.Add(tabPage1);
            SaleTable.HotTrack = true;
            SaleTable.Location = new Point(261, 98);
            SaleTable.Name = "SaleTable";
            SaleTable.SelectedIndex = 0;
            SaleTable.Size = new Size(493, 304);
            SaleTable.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(485, 268);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "All sales";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(49, 233);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(161, 70);
            updateBtn.TabIndex = 8;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(49, 132);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(161, 70);
            addBtn.TabIndex = 7;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(49, 330);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(161, 70);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(569, 87);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(180, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "for club members only";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(390, 40);
            label1.Name = "label1";
            label1.Size = new Size(66, 31);
            label1.TabIndex = 10;
            label1.Text = "Sales";
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(deleteBtn);
            Controls.Add(SaleTable);
            Name = "Sale";
            Text = "Sale";
            SaleTable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl SaleTable;
        private TabPage tabPage1;
        private Button updateBtn;
        private Button addBtn;
        private Button deleteBtn;
        private CheckBox checkBox1;
        private Label label1;
    }
}