using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace UserInterface
{
    public partial class FormList : Form
    {   
        ItemRepository itemRepo = new ItemRepository();
        public FormList()
        {
            InitializeComponent();

            gridProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int row = 0;

            foreach (var Item in ItemRepository.inventoryList)
            {
                gridProductList.Rows.Add();
                gridProductList.Rows[row].Cells[0].Value = Item.Category;
                gridProductList.Rows[row].Cells[1].Value = Item.Name;
                gridProductList.Rows[row].Cells[2].Value = Item.SalesPrice;
                gridProductList.Rows[row].Cells[3].Value = Item.MarketPrice;
                gridProductList.Rows[row].Cells[4].Value = Item.Weight;
                gridProductList.Rows[row].Cells[5].Value = Item.Amount;
                row++;
            }
        }

        private void IncButton_Click(object sender, EventArgs e)
        {
            string name = "Nameless";
            int row = 0;

            try
            {
            name = gridProductList.SelectedRows[0].Cells[1].Value.ToString();
                foreach (var Item in ItemRepository.inventoryList)
                {
                    if (Item.name == name)
                    {
                        Item.IncAmount(int.Parse(IncTextBox.Text));
                    }
                    gridProductList.Rows[row].Cells[0].Value = Item.Category;
                    gridProductList.Rows[row].Cells[1].Value = Item.Name;
                    gridProductList.Rows[row].Cells[2].Value = Item.SalesPrice;
                    gridProductList.Rows[row].Cells[3].Value = Item.MarketPrice;
                    gridProductList.Rows[row].Cells[4].Value = Item.Weight;
                    gridProductList.Rows[row].Cells[5].Value = Item.Amount;
                    row++;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
               MessageBox.Show("Vælg venligst et produkt");
            }
        }
        private void DecButton_Click(object sender, EventArgs e)
        {
            string name = "Nameless";
            int row = 0;

            try
            {
                name = gridProductList.SelectedRows[0].Cells[1].Value.ToString();
                foreach (var Item in ItemRepository.inventoryList)
                {
                    if (Item.name == name)
                    {
                        Item.DecAmount(int.Parse(DecTextBox.Text));
                    }
                    gridProductList.Rows[row].Cells[0].Value = Item.Category;
                    gridProductList.Rows[row].Cells[1].Value = Item.Name;
                    gridProductList.Rows[row].Cells[2].Value = Item.SalesPrice;
                    gridProductList.Rows[row].Cells[3].Value = Item.MarketPrice;
                    gridProductList.Rows[row].Cells[4].Value = Item.Weight;
                    gridProductList.Rows[row].Cells[5].Value = Item.Amount;
                    row++;
                }
            }
            catch (Exception dec)
            {
                if (dec.Message == "Can't go below zero")
                {
                    MessageBox.Show("Kan ikke gå under 0");
                }
                else
                    MessageBox.Show("Vælg venligst et produkt");

            }
        } 

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchWord = SearchTextBox.Text;

            try
            {
                foreach (DataGridViewRow row in gridProductList.Rows)
                {

                    row.Selected = false;
                    if
                        (row.Cells[0].Value.ToString().ToLower().Contains(searchWord.ToLower())
                        || row.Cells[1].Value.ToString().ToLower().Contains(searchWord.ToLower())
                        || row.Cells[2].Value.ToString().ToLower().Contains(searchWord.ToLower())
                        || row.Cells[3].Value.ToString().ToLower().Contains(searchWord.ToLower())
                        || row.Cells[5].Value.ToString().ToLower().Contains(searchWord.ToLower()))
                    {
                        row.Selected = true;
                    }
                    if (row.Cells[0].Value.ToString().Equals("Tobak"))
                    {
                        if (row.Cells[4].Value.ToString().ToLower().Contains(searchWord.ToLower()))
                        {
                            row.Selected = true;
                        }
                    }
                }
            }
            catch (Exception)
            { }
        }
    }
}
