using ClassLibrary;
using System;
using System.Windows.Forms;

namespace PibeSmeden_UI
{
    public partial class FormAdd : Form
    {
        Form1 form1 = new Form1();
        string brand;
        string brandType;
        string price;
        string pieces;
        string newest;

        public FormAdd()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            TextBox ToEmne = (TextBox)sender;
            brand = ToEmne.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            brandType = ToEmne.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            price = ToEmne.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            pieces = ToEmne.Text;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            newest = form1.itemType + " - " + brand + " - " + brandType + " - " + price + " - " + pieces;
            Item myItem = new Item(form1.itemType, brand, brandType, double.Parse(price), int.Parse(pieces));
            this.Close();
        }
    }
}
