namespace Pizza_Menu
{
    partial class Payment
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
            this.visaRadioButton = new System.Windows.Forms.RadioButton();
            this.mastercardRadioButton = new System.Windows.Forms.RadioButton();
            this.amexRadioButton = new System.Windows.Forms.RadioButton();
            this.debitRadioButton = new System.Windows.Forms.RadioButton();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.expireLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.payButton = new System.Windows.Forms.Button();
            this.amountTotalLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.AutoSize = true;
            this.visaRadioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visaRadioButton.Location = new System.Drawing.Point(40, 55);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(61, 22);
            this.visaRadioButton.TabIndex = 0;
            this.visaRadioButton.TabStop = true;
            this.visaRadioButton.Text = "Visa";
            this.visaRadioButton.UseVisualStyleBackColor = true;
            // 
            // mastercardRadioButton
            // 
            this.mastercardRadioButton.AutoSize = true;
            this.mastercardRadioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mastercardRadioButton.Location = new System.Drawing.Point(122, 55);
            this.mastercardRadioButton.Name = "mastercardRadioButton";
            this.mastercardRadioButton.Size = new System.Drawing.Size(118, 22);
            this.mastercardRadioButton.TabIndex = 1;
            this.mastercardRadioButton.TabStop = true;
            this.mastercardRadioButton.Text = "MasterCard";
            this.mastercardRadioButton.UseVisualStyleBackColor = true;
            // 
            // amexRadioButton
            // 
            this.amexRadioButton.AutoSize = true;
            this.amexRadioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amexRadioButton.Location = new System.Drawing.Point(122, 92);
            this.amexRadioButton.Name = "amexRadioButton";
            this.amexRadioButton.Size = new System.Drawing.Size(170, 22);
            this.amexRadioButton.TabIndex = 2;
            this.amexRadioButton.TabStop = true;
            this.amexRadioButton.Text = "American Express";
            this.amexRadioButton.UseVisualStyleBackColor = true;
            // 
            // debitRadioButton
            // 
            this.debitRadioButton.AutoSize = true;
            this.debitRadioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitRadioButton.Location = new System.Drawing.Point(40, 92);
            this.debitRadioButton.Name = "debitRadioButton";
            this.debitRadioButton.Size = new System.Drawing.Size(70, 22);
            this.debitRadioButton.TabIndex = 3;
            this.debitRadioButton.TabStop = true;
            this.debitRadioButton.Text = "Debit";
            this.debitRadioButton.UseVisualStyleBackColor = true;
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashRadioButton.Location = new System.Drawing.Point(277, 55);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(66, 22);
            this.cashRadioButton.TabIndex = 4;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(63, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(248, 31);
            this.instructionLabel.TabIndex = 5;
            this.instructionLabel.Text = "Select Payment Type:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(36, 152);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(103, 19);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name on Card:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(36, 186);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(97, 19);
            this.numberLabel.TabIndex = 7;
            this.numberLabel.Text = "Card Number:";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.Location = new System.Drawing.Point(36, 256);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(99, 19);
            this.codeLabel.TabIndex = 8;
            this.codeLabel.Text = "Security Code:";
            // 
            // expireLabel
            // 
            this.expireLabel.AutoSize = true;
            this.expireLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expireLabel.Location = new System.Drawing.Point(36, 222);
            this.expireLabel.Name = "expireLabel";
            this.expireLabel.Size = new System.Drawing.Size(84, 19);
            this.expireLabel.TabIndex = 9;
            this.expireLabel.Text = "Expiry Date:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(36, 291);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(60, 19);
            this.amountLabel.TabIndex = 10;
            this.amountLabel.Text = "Amount:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(197, 153);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 11;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(197, 187);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 12;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(197, 223);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 13;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(197, 257);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 14;
            // 
            // payButton
            // 
            this.payButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.Location = new System.Drawing.Point(197, 330);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(75, 26);
            this.payButton.TabIndex = 16;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // amountTotalLabel
            // 
            this.amountTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountTotalLabel.Location = new System.Drawing.Point(197, 291);
            this.amountTotalLabel.Name = "amountTotalLabel";
            this.amountTotalLabel.Size = new System.Drawing.Size(100, 22);
            this.amountTotalLabel.TabIndex = 17;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(296, 330);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 26);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 368);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.amountTotalLabel);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.expireLabel);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.debitRadioButton);
            this.Controls.Add(this.amexRadioButton);
            this.Controls.Add(this.mastercardRadioButton);
            this.Controls.Add(this.visaRadioButton);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton visaRadioButton;
        private System.Windows.Forms.RadioButton mastercardRadioButton;
        private System.Windows.Forms.RadioButton amexRadioButton;
        private System.Windows.Forms.RadioButton debitRadioButton;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label expireLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label amountTotalLabel;
        private System.Windows.Forms.Button exitButton;
    }
}