﻿namespace MegaDesk_Cirks
{
    partial class ViewAllQuotes
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
            this.ViewAllCancelButton = new System.Windows.Forms.Button();
            this.viewQuotesDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewQuotesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewAllCancelButton
            // 
            this.ViewAllCancelButton.Location = new System.Drawing.Point(397, 326);
            this.ViewAllCancelButton.Name = "ViewAllCancelButton";
            this.ViewAllCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ViewAllCancelButton.TabIndex = 0;
            this.ViewAllCancelButton.Text = "Cancel";
            this.ViewAllCancelButton.UseVisualStyleBackColor = true;
            this.ViewAllCancelButton.Click += new System.EventHandler(this.ViewAllCancelButton_Click);
            // 
            // viewQuotesDataGrid
            // 
            this.viewQuotesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewQuotesDataGrid.Location = new System.Drawing.Point(81, 63);
            this.viewQuotesDataGrid.Name = "viewQuotesDataGrid";
            this.viewQuotesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewQuotesDataGrid.Size = new System.Drawing.Size(334, 210);
            this.viewQuotesDataGrid.TabIndex = 1;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.viewQuotesDataGrid);
            this.Controls.Add(this.ViewAllCancelButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewQuotesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewAllCancelButton;
        private System.Windows.Forms.DataGridView viewQuotesDataGrid;
    }
}