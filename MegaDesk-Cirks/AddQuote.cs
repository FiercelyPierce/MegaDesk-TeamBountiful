using Newtonsoft.Json;
using System;
using System.IO;
using System.Management.Instrumentation;
using System.Windows.Forms;

namespace MegaDesk_Cirks
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddCancelButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = (MainMenu)Tag;
            mainMenuForm.Show();
            Close();
        }

        private void SaveNewButton_Click(object sender, EventArgs e)
        {
            int rushDays = 0;
            DateTime quoteDate = System.DateTime.Now;

            // Make a switch statement to set the RushDays property
            switch (RushDaysInput.SelectedIndex)
            {
                case 0:
                    rushDays = 3;
                    break;
                case 1:
                    rushDays = 5;
                    break;
                case 2:
                    rushDays = 7;
                    break;
                case 3:
                    rushDays = 14;
                    break;
            }

            // Create new Desk object and set properties
            Desk desk = new Desk
            {
                Width = (int)DeskWidthInput.Value,
                Depth = (int)DeskDepthInput.Value,
                NumDrawers = (int)DrawerNumInput.Value,
                SurfaceMaterial = (DeskMaterial)DeskMaterialInput.SelectedIndex
            };

            // Create new DeskQuote object and set properties
            DeskQuote deskQuote = new DeskQuote
            {
                CustomerName = NameInput.Text,
                QuoteDate = quoteDate,
                Desk = desk,
                RushDays = rushDays,
                QuotePrice = DeskQuote.CalculateQuotePrice(desk, rushDays)
            };

            deskQuote.SaveQuote(deskQuote);
            
            // DateTime quoteDate = DateTime.Now;
            string quoteData =
                $"Name: {deskQuote.CustomerName}\n" +
                $"Width: {desk.Width}\n" +
                $"Depth: {desk.Depth}\n" +
                $"Number of Drawers: {desk.NumDrawers} \n" +
                $"Surface Material: {desk.SurfaceMaterial} \n" +
                $"Rush Days: {rushDays}\n" +
                $"Quote Price: ${deskQuote.QuotePrice}\n" +
                $"Date: {quoteDate}";

            // Show quote values display form and hide add quote form
            DisplayQuote displayQuoteForm = new DisplayQuote(quoteData);
            displayQuoteForm.Tag = this;
            displayQuoteForm.Show(this);
            this.Hide();
        }

        // Validate width input and display error message if invalid
        private void DeskWidthInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DeskWidthInput.Value < 24 || DeskWidthInput.Value > 96)
            {
                e.Cancel = true;
                DeskWidthInput.Focus();
                errorProviderWidth.SetError(DeskWidthInput, "Width must be between 24 and 96 inches.");
            }
        }

        // Clear error message when width input is valid
        private void DeskWidthInput_Validated(object sender, EventArgs e)
        {
            errorProviderWidth.SetError(DeskWidthInput, "");
        }

        // Validate depth input and display error message if invalid
        private void DeskDepthInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DeskDepthInput.Value < 12 || DeskDepthInput.Value > 48)
            {
                e.Cancel = true;
                DeskDepthInput.Focus();
                errorProviderDepth.SetError(DeskDepthInput, "Depth must be between 12 and 48 inches.");
            }
        }

        // Clear error message when depth input is valid
        private void DeskDepthInput_Validated(object sender, EventArgs e)
        {
            errorProviderDepth.SetError(DeskDepthInput, "");
        }

        // Validate drawer number input and display error message if invalid
        private void DrawerNumInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (DrawerNumInput.Value < 0 || DrawerNumInput.Value > 7)
            {
                e.Cancel = true;
                DrawerNumInput.Focus();
                errorProviderNumDrawer.SetError(DrawerNumInput, "Number of drawers must be between 0 and 7.");
            }
        }

        // Clear error message when drawer number input is valid
        private void DrawerNumInput_Validated(object sender, EventArgs e)
        {
            errorProviderNumDrawer.SetError(DrawerNumInput, "");
        }

        private void DeskDepthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow numbers to be entered
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DrawerNumInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow numbers to be entered
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
