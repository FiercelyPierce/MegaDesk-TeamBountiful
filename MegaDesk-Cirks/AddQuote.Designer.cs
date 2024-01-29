namespace MegaDesk_Cirks
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.AddCancelButton = new System.Windows.Forms.Button();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.Label();
            this.DeskWidthLabel = new System.Windows.Forms.Label();
            this.DeskWidthInput = new System.Windows.Forms.NumericUpDown();
            this.DeskDepthInput = new System.Windows.Forms.NumericUpDown();
            this.DeskDepthLabel = new System.Windows.Forms.Label();
            this.DrawerNumInput = new System.Windows.Forms.NumericUpDown();
            this.DrawerNumLabel = new System.Windows.Forms.Label();
            this.DeskMaterialLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.DeskMaterialInput = new System.Windows.Forms.ComboBox();
            this.SaveNewButton = new System.Windows.Forms.Button();
            this.RushDaysInput = new System.Windows.Forms.ComboBox();
            this.errorProviderWidth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDepth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNumDrawer = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DeskWidthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDepthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerNumInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumDrawer)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCancelButton
            // 
            this.AddCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddCancelButton.Location = new System.Drawing.Point(397, 326);
            this.AddCancelButton.Name = "AddCancelButton";
            this.AddCancelButton.Size = new System.Drawing.Size(75, 23);
            this.AddCancelButton.TabIndex = 1;
            this.AddCancelButton.Text = "Cancel";
            this.AddCancelButton.UseVisualStyleBackColor = true;
            this.AddCancelButton.Click += new System.EventHandler(this.AddCancelButton_Click);
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(219, 25);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 20);
            this.NameInput.TabIndex = 2;
            this.NameInput.Text = "John Doe";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(118, 25);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(80, 20);
            this.CustomerNameLabel.TabIndex = 3;
            this.CustomerNameLabel.Text = "Full Name";
            // 
            // DateTime
            // 
            this.DateTime.AutoSize = true;
            this.DateTime.Location = new System.Drawing.Point(13, 335);
            this.DateTime.MinimumSize = new System.Drawing.Size(100, 0);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(100, 13);
            this.DateTime.TabIndex = 4;
            // 
            // DeskWidthLabel
            // 
            this.DeskWidthLabel.AutoSize = true;
            this.DeskWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthLabel.Location = new System.Drawing.Point(134, 66);
            this.DeskWidthLabel.Name = "DeskWidthLabel";
            this.DeskWidthLabel.Size = new System.Drawing.Size(44, 17);
            this.DeskWidthLabel.TabIndex = 5;
            this.DeskWidthLabel.Text = "Width";
            // 
            // DeskWidthInput
            // 
            this.DeskWidthInput.Location = new System.Drawing.Point(250, 63);
            this.DeskWidthInput.Name = "DeskWidthInput";
            this.DeskWidthInput.Size = new System.Drawing.Size(68, 20);
            this.DeskWidthInput.TabIndex = 6;
            this.DeskWidthInput.Validating += new System.ComponentModel.CancelEventHandler(this.DeskWidthInput_Validating);
            this.DeskWidthInput.Validated += new System.EventHandler(this.DeskWidthInput_Validated);
            // 
            // DeskDepthInput
            // 
            this.DeskDepthInput.Location = new System.Drawing.Point(250, 89);
            this.DeskDepthInput.Name = "DeskDepthInput";
            this.DeskDepthInput.Size = new System.Drawing.Size(68, 20);
            this.DeskDepthInput.TabIndex = 8;
            this.DeskDepthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeskDepthInput_KeyPress);
            this.DeskDepthInput.Validating += new System.ComponentModel.CancelEventHandler(this.DeskDepthInput_Validating);
            this.DeskDepthInput.Validated += new System.EventHandler(this.DeskDepthInput_Validated);
            // 
            // DeskDepthLabel
            // 
            this.DeskDepthLabel.AutoSize = true;
            this.DeskDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthLabel.Location = new System.Drawing.Point(134, 92);
            this.DeskDepthLabel.Name = "DeskDepthLabel";
            this.DeskDepthLabel.Size = new System.Drawing.Size(46, 17);
            this.DeskDepthLabel.TabIndex = 7;
            this.DeskDepthLabel.Text = "Depth";
            // 
            // DrawerNumInput
            // 
            this.DrawerNumInput.Location = new System.Drawing.Point(250, 115);
            this.DrawerNumInput.Name = "DrawerNumInput";
            this.DrawerNumInput.Size = new System.Drawing.Size(68, 20);
            this.DrawerNumInput.TabIndex = 10;
            this.DrawerNumInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DrawerNumInput_KeyPress);
            this.DrawerNumInput.Validating += new System.ComponentModel.CancelEventHandler(this.DrawerNumInput_Validating);
            this.DrawerNumInput.Validated += new System.EventHandler(this.DrawerNumInput_Validated);
            // 
            // DrawerNumLabel
            // 
            this.DrawerNumLabel.AutoSize = true;
            this.DrawerNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawerNumLabel.Location = new System.Drawing.Point(93, 118);
            this.DrawerNumLabel.Name = "DrawerNumLabel";
            this.DrawerNumLabel.Size = new System.Drawing.Size(130, 17);
            this.DrawerNumLabel.TabIndex = 9;
            this.DrawerNumLabel.Text = "Number of Drawers";
            // 
            // DeskMaterialLabel
            // 
            this.DeskMaterialLabel.AutoSize = true;
            this.DeskMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskMaterialLabel.Location = new System.Drawing.Point(102, 144);
            this.DeskMaterialLabel.Name = "DeskMaterialLabel";
            this.DeskMaterialLabel.Size = new System.Drawing.Size(111, 17);
            this.DeskMaterialLabel.TabIndex = 11;
            this.DeskMaterialLabel.Text = "Surface Material";
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.AutoSize = true;
            this.RushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderLabel.Location = new System.Drawing.Point(119, 170);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Size = new System.Drawing.Size(82, 17);
            this.RushOrderLabel.TabIndex = 13;
            this.RushOrderLabel.Text = "Rush Order";
            // 
            // DeskMaterialInput
            // 
            this.DeskMaterialInput.FormattingEnabled = true;
            this.DeskMaterialInput.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.DeskMaterialInput.Location = new System.Drawing.Point(250, 144);
            this.DeskMaterialInput.Name = "DeskMaterialInput";
            this.DeskMaterialInput.Size = new System.Drawing.Size(121, 21);
            this.DeskMaterialInput.TabIndex = 15;
            // 
            // SaveNewButton
            // 
            this.SaveNewButton.Location = new System.Drawing.Point(316, 325);
            this.SaveNewButton.Name = "SaveNewButton";
            this.SaveNewButton.Size = new System.Drawing.Size(75, 23);
            this.SaveNewButton.TabIndex = 16;
            this.SaveNewButton.Text = "Save Quote";
            this.SaveNewButton.UseVisualStyleBackColor = true;
            this.SaveNewButton.Click += new System.EventHandler(this.SaveNewButton_Click);
            // 
            // RushDaysInput
            // 
            this.RushDaysInput.FormattingEnabled = true;
            this.RushDaysInput.Items.AddRange(new object[] {
            "3 days",
            "5 days",
            "7 days",
            "14 days"});
            this.RushDaysInput.Location = new System.Drawing.Point(250, 171);
            this.RushDaysInput.Name = "RushDaysInput";
            this.RushDaysInput.Size = new System.Drawing.Size(121, 21);
            this.RushDaysInput.TabIndex = 17;
            // 
            // errorProviderWidth
            // 
            this.errorProviderWidth.ContainerControl = this.DeskWidthInput;
            // 
            // errorProviderDepth
            // 
            this.errorProviderDepth.ContainerControl = this.DeskDepthInput;
            // 
            // errorProviderNumDrawer
            // 
            this.errorProviderNumDrawer.ContainerControl = this.DrawerNumInput;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.RushDaysInput);
            this.Controls.Add(this.SaveNewButton);
            this.Controls.Add(this.DeskMaterialInput);
            this.Controls.Add(this.RushOrderLabel);
            this.Controls.Add(this.DeskMaterialLabel);
            this.Controls.Add(this.DrawerNumInput);
            this.Controls.Add(this.DrawerNumLabel);
            this.Controls.Add(this.DeskDepthInput);
            this.Controls.Add(this.DeskDepthLabel);
            this.Controls.Add(this.DeskWidthInput);
            this.Controls.Add(this.DeskWidthLabel);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.AddCancelButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.DeskWidthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDepthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerNumInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumDrawer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCancelButton;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label DateTime;
        private System.Windows.Forms.Label DeskWidthLabel;
        private System.Windows.Forms.NumericUpDown DeskWidthInput;
        private System.Windows.Forms.NumericUpDown DeskDepthInput;
        private System.Windows.Forms.Label DeskDepthLabel;
        private System.Windows.Forms.NumericUpDown DrawerNumInput;
        private System.Windows.Forms.Label DrawerNumLabel;
        private System.Windows.Forms.Label DeskMaterialLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label RushOrderLabel;
        private System.Windows.Forms.ComboBox DeskMaterialInput;
        private System.Windows.Forms.Button SaveNewButton;
        private System.Windows.Forms.ComboBox RushDaysInput;
        private System.Windows.Forms.ErrorProvider errorProviderWidth;
        private System.Windows.Forms.ErrorProvider errorProviderDepth;
        private System.Windows.Forms.ErrorProvider errorProviderNumDrawer;
    }
}