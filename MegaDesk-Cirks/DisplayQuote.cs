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

        private void FinishQuoteButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Tag = this;
            mainMenuForm.Show(this);
            this.Hide();
        }
    }
}
