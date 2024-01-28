using System;
using System.Windows.Forms;

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
    }
}
