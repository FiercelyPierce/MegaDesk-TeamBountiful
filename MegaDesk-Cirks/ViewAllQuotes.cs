using System;
using System.Collections.Generic;
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
            string jsonContent = File.ReadAllText("C:\\Users\\Aidan\\source\\repos\\MegaDesk-TeamBountiful\\MegaDesk-Cirks\\AllQuotes.json");
            var allQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonContent);
            viewQuotesDataGrid.DataSource = allQuotes;
        }

      
    }
}
