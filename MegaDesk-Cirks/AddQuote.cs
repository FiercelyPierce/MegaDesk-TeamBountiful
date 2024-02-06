using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_Cirks
{
    public partial class AddQuote : Form
    {
        private const string QuotesFilePath = "quotes.json";
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
            // Create new Desk object and set properties
            Desk desk = new Desk
            {
                Width = (int)DeskWidthInput.Value,
                Depth = (int)DeskDepthInput.Value,
                NumDrawers = (int)DrawerNumInput.Value,
                SurfaceMaterial = (DeskMaterial)DeskMaterialInput.SelectedIndex
            };

            int rushDays = 0;

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

            // Calculate quote price
            decimal quotePrice = DeskQuote.CalculateQuotePrice(
                desk, rushDays);

            // Create a new instance of DeskQuote and set its properties
            DeskQuote deskQuote = new DeskQuote(
                NameInput.Text,
                System.DateTime.Now, // or you can use a specific date/time as needed
                desk,
                rushDays
            );

            // DateTime quoteDate = DateTime.Now;
            string quoteData =
                $"Name: {NameInput.Text}\n" +
                $"Width: {DeskWidthInput.Text}\n" +
                $"Depth: {DeskDepthInput.Text}\n" +
                $"Number of Drawers: {DrawerNumInput.Text} \n" +
                $"Surface Material: {DeskMaterialInput.Text} \n" +
                $"Rush Days: {RushDaysInput.Text}\n" +
                $"Quote Price: ${quotePrice}\n" +
                $"Date: {System.DateTime.Now.ToString("MM/dd/yyyy")}";

            SaveQuoteToJsonFile(deskQuote);

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

        private void SaveQuoteToJsonFile(DeskQuote deskQuote)
        {
            List<DeskQuote> allQuotes = DeskQuote.GetAllQuotes();
            allQuotes.Add(deskQuote);


            var transformedObject = new
            {
                users = allQuotes.ConvertAll(q => new
                {
                    id = Guid.NewGuid().ToString(), // You may use a meaningful ID
                    name = q.CustomerName,
                    quoteDate = q.QuoteDate,
                    desk = new
                    {
                        width = q.Desk.Width,
                        depth = q.Desk.Depth,
                        numDrawers = q.Desk.NumDrawers,
                        surfaceMaterial = q.Desk.SurfaceMaterial.ToString()
                    },
                    rushDays = q.RushDays,
                    quotePrice = q.QuotePrice
                })
            };

            // Serialize the new object to JSON
            string json = JsonConvert.SerializeObject(transformedObject, Formatting.Indented);


            //string json = JsonConvert.SerializeObject(allQuotes, Formatting.Indented);
            File.WriteAllText(QuotesFilePath, json);
        }
    }
}
