namespace Pizza_Menu
{
    partial class Receipt
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
            this.receiptListBox = new System.Windows.Forms.ListBox();
            this.payButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // receiptListBox
            // 
            this.receiptListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptListBox.FormattingEnabled = true;
            this.receiptListBox.ItemHeight = 22;
            this.receiptListBox.Location = new System.Drawing.Point(13, 13);
            this.receiptListBox.Margin = new System.Windows.Forms.Padding(4);
            this.receiptListBox.Name = "receiptListBox";
            this.receiptListBox.Size = new System.Drawing.Size(466, 444);
            this.receiptListBox.TabIndex = 0;
            // 
            // payButton
            // 
            this.payButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.Location = new System.Drawing.Point(278, 494);
            this.payButton.Margin = new System.Windows.Forms.Padding(4);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(100, 44);
            this.payButton.TabIndex = 1;
            this.payButton.Text = "Pay Bill";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(80, 494);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 44);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 572);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.receiptListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox receiptListBox;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button backButton;
    }
}