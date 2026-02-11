namespace UI
{
    partial class CustomerEditor
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
            OK = new Button();
            actionLable = new Label();
            label1 = new Label();
            addressLable = new Label();
            nameLable = new Label();
            idLable = new Label();
            nameInput = new TextBox();
            addressInput = new TextBox();
            phoneInput = new TextBox();
            idInput = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)idInput).BeginInit();
            SuspendLayout();
            // 
            // OK
            // 
            OK.Location = new Point(329, 358);
            OK.Name = "OK";
            OK.Size = new Size(128, 55);
            OK.TabIndex = 14;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // actionLable
            // 
            actionLable.AutoSize = true;
            actionLable.Location = new Point(351, 75);
            actionLable.Name = "actionLable";
            actionLable.Size = new Size(86, 20);
            actionLable.TabIndex = 15;
            actionLable.Text = "actionLable";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 298);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 16;
            label1.Text = "Phone";
            // 
            // addressLable
            // 
            addressLable.AutoSize = true;
            addressLable.Location = new Point(244, 239);
            addressLable.Name = "addressLable";
            addressLable.Size = new Size(62, 20);
            addressLable.TabIndex = 17;
            addressLable.Text = "Address";
            // 
            // nameLable
            // 
            nameLable.AutoSize = true;
            nameLable.Location = new Point(244, 188);
            nameLable.Name = "nameLable";
            nameLable.Size = new Size(49, 20);
            nameLable.TabIndex = 18;
            nameLable.Text = "Name";
            // 
            // idLable
            // 
            idLable.AutoSize = true;
            idLable.Location = new Point(244, 133);
            idLable.Name = "idLable";
            idLable.Size = new Size(24, 20);
            idLable.TabIndex = 19;
            idLable.Text = "ID";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(453, 185);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(125, 27);
            nameInput.TabIndex = 20;
            // 
            // addressInput
            // 
            addressInput.Location = new Point(453, 236);
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(125, 27);
            addressInput.TabIndex = 21;
            // 
            // phoneInput
            // 
            phoneInput.Location = new Point(453, 295);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(125, 27);
            phoneInput.TabIndex = 22;
            // 
            // idInput
            // 
            idInput.Location = new Point(428, 133);
            idInput.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            idInput.Name = "idInput";
            idInput.Size = new Size(150, 27);
            idInput.TabIndex = 23;
            // 
            // CustomerEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(idInput);
            Controls.Add(phoneInput);
            Controls.Add(addressInput);
            Controls.Add(nameInput);
            Controls.Add(idLable);
            Controls.Add(nameLable);
            Controls.Add(addressLable);
            Controls.Add(label1);
            Controls.Add(actionLable);
            Controls.Add(OK);
            Name = "CustomerEditor";
            Text = "CustomerEditor";
            ((System.ComponentModel.ISupportInitialize)idInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button OK;
        private Label actionLable;
        private Label label1;
        private Label addressLable;
        private Label nameLable;
        private Label idLable;
        private TextBox nameInput;
        private TextBox addressInput;
        private TextBox phoneInput;
        private NumericUpDown idInput;
    }
}