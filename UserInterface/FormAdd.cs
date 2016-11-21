using ClassLibrary;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FormAdd : Form
    {
        Form1 form1 = new Form1();
        string category;
        string brand;
        string brandType;
        string price;
        string pieces;
        string weight;
        string amount;
        public string newestItem = null;

        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Item myItem = new Item(category, brand, brandType, double.Parse(price), int.Parse(pieces));
            newestItem = "Tilføjede: " + myItem.ToStringItem() + ". Antal: "+amount;
            this.Close();
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            brand = ToEmne.Text;
        }
        private void txtBrandType_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            brandType = ToEmne.Text;
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            price = ToEmne.Text;
        }
        private void txtPieces_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            pieces = ToEmne.Text;
        }
        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            weight = ToEmne.Text;
        }
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            amount = ToEmne.Text;
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = comboCategory.Text;
            if (category == "Røg Tobak")
            {
                txtPieces.Enabled = false;
                txtWeight.Enabled = true;
            }
            else
            {
                txtPieces.Enabled = true;
                txtWeight.Enabled = false;
            }
        }
    }
}
