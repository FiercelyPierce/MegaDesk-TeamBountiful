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
            this.DisplayQuoteBox = new System.Windows.Forms.RichTextBox();
            this.FinishQuoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayQuoteBox
            // 
            this.DisplayQuoteBox.Location = new System.Drawing.Point(12, 12);
            this.DisplayQuoteBox.Name = "DisplayQuoteBox";
            this.DisplayQuoteBox.Size = new System.Drawing.Size(460, 308);
            this.DisplayQuoteBox.TabIndex = 1;
            this.DisplayQuoteBox.Text = "";
            // 
            // FinishQuoteButton
            // 
            this.FinishQuoteButton.Location = new System.Drawing.Point(397, 326);
            this.FinishQuoteButton.Name = "FinishQuoteButton";
            this.FinishQuoteButton.Size = new System.Drawing.Size(75, 23);
            this.FinishQuoteButton.TabIndex = 2;
            this.FinishQuoteButton.Text = "Finish";
            this.FinishQuoteButton.UseVisualStyleBackColor = true;
            this.FinishQuoteButton.Click += new System.EventHandler(this.FinishQuoteButton_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.FinishQuoteButton);
            this.Controls.Add(this.DisplayQuoteBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayQuote";
            this.Text = "Display Quote";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox DisplayQuoteBox;
        private System.Windows.Forms.Button FinishQuoteButton;
    }
}