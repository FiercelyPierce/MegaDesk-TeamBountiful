using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_Cirks
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ViewAllCancelButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = (MainMenu)Tag;
            mainMenuForm.Show();
            Close();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            // Read the quotes.json file and display the data in the DataGridView
            string quotesFile = @"quotes.json";
            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    string quotes = reader.ReadToEnd();
                    List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                    // Create a new DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Add columns to the DataTable
                    dataTable.Columns.Add("Customer Name");
                    dataTable.Columns.Add("Quote Date");
                    dataTable.Columns.Add("Desk Width");
                    dataTable.Columns.Add("Desk Depth");
                    dataTable.Columns.Add("Desk Material");
                    dataTable.Columns.Add("Rush Days");
                    dataTable.Columns.Add("Quote Price");

                    // Populate the DataTable with data from the DeskQuote objects
                    foreach (DeskQuote deskQuote in deskQuotes)
                    {
                        DataRow row = dataTable.NewRow();
                        row["Customer Name"] = deskQuote.CustomerName;
                        row["Quote Date"] = deskQuote.QuoteDate;
                        row["Desk Width"] = deskQuote.Desk.Width;
                        row["Desk Depth"] = deskQuote.Desk.Depth;
                        row["Desk Material"] = deskQuote.Desk.SurfaceMaterial;
                        row["Rush Days"] = deskQuote.RushDays;
                        row["Quote Price"] = deskQuote.QuotePrice;
                        dataTable.Rows.Add(row);
                    }

                    // Set the DataTable as the DataSource for the DataGridView
                    viewQuotesDataGrid.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("No quotes found.");
            }
        }
    }
}
