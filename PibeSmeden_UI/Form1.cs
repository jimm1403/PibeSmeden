﻿using System;
using System.Windows.Forms;

namespace PibeSmeden_UI
{
    public partial class Form1 : Form
    {
        public string itemType;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemType = ChooseProduct.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdd myForm = new FormAdd();
            myForm.ShowDialog();
            txtChosenProduct.Text = myForm.textboxAdd;
        }

        public void txtChosenProduct_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
