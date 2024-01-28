using System;
using System.Windows.Forms;

namespace MegaDesk_Cirks
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string saveData)
        {
            InitializeComponent();
            DisplayQuoteBox.Text = saveData;
        }

        private void DisplayCancelButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = (MainMenu)Tag;
            mainMenuForm.Show();
            Close();
        }
    }
}
