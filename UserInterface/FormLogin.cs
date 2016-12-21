using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FormLogin : Form
    {
        string brugernavn;
        string adgangskode;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (brugernavn == "Rasmus" && adgangskode == "Myrfjeld")
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Ugyldig login");
                return;
            }
        }

        private void userNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            TextBox newtext = (TextBox)sender;
            brugernavn = newtext.Text;
        }

        private void passWordTxtBox_TextChanged(object sender, EventArgs e)
        {
            TextBox newtext = (TextBox)sender;
            adgangskode = newtext.Text;
        }
    }
}
