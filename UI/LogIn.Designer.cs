namespace UI
{
    partial class LogIn
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
            label1 = new Label();
            okBtn = new Button();
            customerIdInput = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)customerIdInput).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 89);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 1;
            label1.Text = "Insert your customer id";
            // 
            // okBtn
            // 
            okBtn.Location = new Point(348, 169);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(107, 39);
            okBtn.TabIndex = 2;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // customerIdInput
            // 
            customerIdInput.Location = new Point(335, 118);
            customerIdInput.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            customerIdInput.Name = "customerIdInput";
            customerIdInput.Size = new Size(120, 23);
            customerIdInput.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(335, 368);
            button1.Name = "button1";
            button1.Size = new Size(135, 39);
            button1.TabIndex = 4;
            button1.Text = "login without a club";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(customerIdInput);
            Controls.Add(okBtn);
            Controls.Add(label1);
            Name = "LogIn";
            Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)customerIdInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button okBtn;
        private NumericUpDown customerIdInput;
        private Button button1;
    }
}