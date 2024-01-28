namespace MegaDesk_Cirks
{
    partial class DisplayQuote
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
            this.DisplayCancelButton = new System.Windows.Forms.Button();
            this.DisplayQuoteBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DisplayCancelButton
            // 
            this.DisplayCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DisplayCancelButton.Location = new System.Drawing.Point(397, 326);
            this.DisplayCancelButton.Name = "DisplayCancelButton";
            this.DisplayCancelButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayCancelButton.TabIndex = 0;
            this.DisplayCancelButton.Text = "Cancel";
            this.DisplayCancelButton.UseVisualStyleBackColor = true;
            this.DisplayCancelButton.Click += new System.EventHandler(this.DisplayCancelButton_Click);
            // 
            // DisplayQuoteBox
            // 
            this.DisplayQuoteBox.Location = new System.Drawing.Point(12, 12);
            this.DisplayQuoteBox.Name = "DisplayQuoteBox";
            this.DisplayQuoteBox.Size = new System.Drawing.Size(460, 308);
            this.DisplayQuoteBox.TabIndex = 1;
            this.DisplayQuoteBox.Text = "";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DisplayCancelButton;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.DisplayQuoteBox);
            this.Controls.Add(this.DisplayCancelButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayQuote";
            this.Text = "Display Quote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DisplayCancelButton;
        private System.Windows.Forms.RichTextBox DisplayQuoteBox;
    }
}