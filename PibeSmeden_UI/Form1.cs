using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;

namespace PibeSmeden_UI
{
    public partial class Form1 : Form
    {
        string itemType;
        string brand;
        string brandType;
        string price;
        string pieces;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemType = ChooseProduct.Text;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            pieces = ToEmne.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item myItem = new Item(itemType, brand, brandType, double.Parse(price), int.Parse(pieces));

            
        }
    }
}
