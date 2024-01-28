namespace MegaDesk_Cirks
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.AddQuoteButton = new System.Windows.Forms.Button();
            this.SearchQuoteButton = new System.Windows.Forms.Button();
            this.ViewAllQuotesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddQuoteButton
            // 
            this.AddQuoteButton.Location = new System.Drawing.Point(175, 66);
            this.AddQuoteButton.Name = "AddQuoteButton";
            this.AddQuoteButton.Size = new System.Drawing.Size(135, 49);
            this.AddQuoteButton.TabIndex = 0;
            this.AddQuoteButton.Text = "Add Quote";
            this.AddQuoteButton.UseVisualStyleBackColor = true;
            this.AddQuoteButton.Click += new System.EventHandler(this.AddQuoteButton_Click);
            // 
            // SearchQuoteButton
            // 
            this.SearchQuoteButton.Location = new System.Drawing.Point(175, 121);
            this.SearchQuoteButton.Name = "SearchQuoteButton";
            this.SearchQuoteButton.Size = new System.Drawing.Size(135, 49);
            this.SearchQuoteButton.TabIndex = 1;
            this.SearchQuoteButton.Text = "Search Quote";
            this.SearchQuoteButton.UseVisualStyleBackColor = true;
            this.SearchQuoteButton.Click += new System.EventHandler(this.SearchQuoteButton_Click);
            // 
            // ViewAllQuotesButton
            // 
            this.ViewAllQuotesButton.Location = new System.Drawing.Point(175, 176);
            this.ViewAllQuotesButton.Name = "ViewAllQuotesButton";
            this.ViewAllQuotesButton.Size = new System.Drawing.Size(135, 49);
            this.ViewAllQuotesButton.TabIndex = 3;
            this.ViewAllQuotesButton.Text = "View All Quotes";
            this.ViewAllQuotesButton.UseVisualStyleBackColor = true;
            this.ViewAllQuotesButton.Click += new System.EventHandler(this.ViewAllQuotesButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.ViewAllQuotesButton);
            this.Controls.Add(this.SearchQuoteButton);
            this.Controls.Add(this.AddQuoteButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Mega Desk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuoteButton;
        private System.Windows.Forms.Button SearchQuoteButton;
        private System.Windows.Forms.Button ViewAllQuotesButton;
    }
}

