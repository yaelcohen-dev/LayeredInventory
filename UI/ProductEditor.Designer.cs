namespace UI
{
    partial class ProductEditor
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
            actionLable = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            OK = new Button();
            categoryInput = new ComboBox();
            priceInput = new NumericUpDown();
            amountInput = new NumericUpDown();
            nameInput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountInput).BeginInit();
            SuspendLayout();
            // 
            // actionLable
            // 
            actionLable.AutoSize = true;
            actionLable.Location = new Point(364, 68);
            actionLable.Name = "actionLable";
            actionLable.Size = new Size(86, 20);
            actionLable.TabIndex = 0;
            actionLable.Text = "actionLable";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 319);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 256);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 193);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 5;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(273, 137);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 6;
            label5.Text = "Name";
            // 
            // OK
            // 
            OK.Location = new Point(383, 368);
            OK.Name = "OK";
            OK.Size = new Size(128, 55);
            OK.TabIndex = 7;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += button1_Click;
            // 
            // categoryInput
            // 
            categoryInput.FormattingEnabled = true;
            categoryInput.Location = new Point(434, 193);
            categoryInput.Name = "categoryInput";
            categoryInput.Size = new Size(151, 28);
            categoryInput.TabIndex = 8;
            // 
            // priceInput
            // 
            priceInput.Location = new Point(435, 249);
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(150, 27);
            priceInput.TabIndex = 13;
            // 
            // amountInput
            // 
            amountInput.Location = new Point(435, 319);
            amountInput.Name = "amountInput";
            amountInput.Size = new Size(150, 27);
            amountInput.TabIndex = 14;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(443, 137);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(125, 27);
            nameInput.TabIndex = 12;
            // 
            // ProductEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(amountInput);
            Controls.Add(priceInput);
            Controls.Add(nameInput);
            Controls.Add(categoryInput);
            Controls.Add(OK);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(actionLable);
            Name = "ProductEditor";
            Text = "ProductEditor";
            ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label actionLable;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button OK;
        private ComboBox categoryInput;
        private NumericUpDown priceInput;
        private NumericUpDown amountInput;
        private TextBox nameInput;
    }
}