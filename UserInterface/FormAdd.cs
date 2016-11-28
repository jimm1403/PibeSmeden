using ClassLibrary;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FormAdd : Form
    {
        ItemRepository itemRepo = new ItemRepository();
        Form1 form1 = new Form1();
        string category;
        string name;
        string salesPrice;
        string marketPrice;
        string weight;
        string amount;
        public string newestItem = null;

        public FormAdd()
        {
            InitializeComponent();
        }
        
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (category == "Cigaretter" || category == "Rullepapir" || category == "Filtre" || category == "Cigar" || category == "Tobak Pastiller")
            {
                Item myItem = new Item(category, name, double.Parse(salesPrice), double.Parse(marketPrice), int.Parse(amount));
                itemRepo.AddToInventoryList(myItem);
                newestItem = "Tilføjede: " + myItem.ToStringItem() + ". Antal: " + amount;
            }
            else
            {
                Item myItem = new Item(category, name, double.Parse(salesPrice), double.Parse(marketPrice), int.Parse(amount), double.Parse(weight));
                itemRepo.AddToInventoryList(myItem);
                newestItem = "Tilføjede: " + myItem.ToStringItem() + ". Antal: " + amount;
            }
            this.Close();
        }
        
        private void txtBrand_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            name = ToEmne.Text;
        }
        
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            salesPrice = ToEmne.Text;
        }
        private void txtMarketPrice_TextChanged(object sender, EventArgs e)
        {
            TextBox ToEmne = (TextBox)sender;
            marketPrice = ToEmne.Text;
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
                txtWeight.Enabled = true;
            }
            else
            {
                txtWeight.Enabled = false;
            }
        }

       
    }
}
