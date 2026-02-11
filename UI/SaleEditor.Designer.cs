namespace UI
{
    partial class SaleEditor
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
            salePriceInput = new NumericUpDown();
            OK = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            actionLable = new Label();
            productIdInput = new NumericUpDown();
            minAmountInput = new NumericUpDown();
            isForClub = new CheckBox();
            begin = new DateTimePicker();
            end = new DateTimePicker();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)salePriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productIdInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minAmountInput).BeginInit();
            SuspendLayout();
            // 
            // salePriceInput
            // 
            salePriceInput.Location = new Point(411, 185);
            salePriceInput.Name = "salePriceInput";
            salePriceInput.Size = new Size(150, 27);
            salePriceInput.TabIndex = 23;
            // 
            // OK
            // 
            OK.Location = new Point(330, 362);
            OK.Name = "OK";
            OK.Size = new Size(128, 55);
            OK.TabIndex = 20;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 102);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 19;
            label5.Text = "Product ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 143);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 18;
            label4.Text = "minimum amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 188);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 17;
            label3.Text = "Sale price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 266);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 16;
            label2.Text = "starts on";
            // 
            // actionLable
            // 
            actionLable.AutoSize = true;
            actionLable.Location = new Point(340, 48);
            actionLable.Name = "actionLable";
            actionLable.Size = new Size(86, 20);
            actionLable.TabIndex = 15;
            actionLable.Text = "actionLable";
            // 
            // productIdInput
            // 
            productIdInput.Location = new Point(410, 101);
            productIdInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            productIdInput.Name = "productIdInput";
            productIdInput.Size = new Size(150, 27);
            productIdInput.TabIndex = 25;
            // 
            // minAmountInput
            // 
            minAmountInput.Location = new Point(408, 141);
            minAmountInput.Name = "minAmountInput";
            minAmountInput.Size = new Size(150, 27);
            minAmountInput.TabIndex = 26;
            // 
            // isForClub
            // 
            isForClub.AutoSize = true;
            isForClub.Location = new Point(252, 226);
            isForClub.Name = "isForClub";
            isForClub.Size = new Size(174, 24);
            isForClub.TabIndex = 29;
            isForClub.Text = "for club member only";
            isForClub.UseVisualStyleBackColor = true;
            // 
            // begin
            // 
            begin.Location = new Point(340, 266);
            begin.Name = "begin";
            begin.Size = new Size(250, 27);
            begin.TabIndex = 30;
            // 
            // end
            // 
            end.Location = new Point(340, 301);
            end.Name = "end";
            end.Size = new Size(250, 27);
            end.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(246, 301);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 31;
            label6.Text = "Ends on";
            // 
            // SaleEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(end);
            Controls.Add(label6);
            Controls.Add(begin);
            Controls.Add(isForClub);
            Controls.Add(minAmountInput);
            Controls.Add(productIdInput);
            Controls.Add(salePriceInput);
            Controls.Add(OK);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(actionLable);
            Name = "SaleEditor";
            Text = "SaleEditor";
            ((System.ComponentModel.ISupportInitialize)salePriceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)productIdInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)minAmountInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown salePriceInput;
        private Button OK;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label actionLable;
        private NumericUpDown productIdInput;
        private NumericUpDown minAmountInput;
        private CheckBox isForClub;
        private DateTimePicker begin;
        private DateTimePicker end;
        private Label label6;
    }
}