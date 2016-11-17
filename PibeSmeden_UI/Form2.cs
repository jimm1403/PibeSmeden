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
        string weight;
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
        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            weight = ToEmne.Text;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            newest = form1.category + " - " + brand + " - " + brandType + " - " + price + " - " + pieces + weight;
            Item myItem = new Item(form1.category, brand, brandType, double.Parse(price), int.Parse(pieces));
            myItem.Weight = double.Parse(weight);
            myItem.Pieces = int.Parse(pieces);
            this.Close();
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
