using System;
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
            // Create new DeskQuote object
            //DeskQuote deskQuote = new DeskQuote
            //{ 
            //    CustomerName = NameInput.Text,
            //    Desk = new Desk(
            //        width: (int)DeskWidthInput.Value, 
            //        depth: (int)DeskDepthInput.Value, 
            //        numDrawers: (int)DrawerNumInput.Value, 
            //        surfaceMaterial: (DeskMaterial)DeskMaterialInput.SelectedValue),
            //    RushDays = (int)RushDaysInput.SelectedIndex
            //};

            string quoteData =
                $"Name: {NameInput.Text}\n" +
                $"Width: {DeskWidthInput.Text}\n" +
                $"Depth: {DeskDepthInput.Text}\n" +
                $"Number of Drawers: {DrawerNumInput.Text} \n" +
                $"Surface Material: {DeskMaterialInput.Text} \n" +
                $"Rush Days: {RushDaysInput.Text}";

            // Show quote values display form and hide add quote form
            DisplayQuote displayQuoteForm = new DisplayQuote(quoteData);
            displayQuoteForm.Tag = this;
            displayQuoteForm.Show(this);
            Hide();
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
