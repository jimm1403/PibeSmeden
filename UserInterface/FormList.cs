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
        string searchWord;
        ItemRepository itemRepo = new ItemRepository();
        public FormList()
        {
            InitializeComponent();
            gridProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int row = 0;
            string amount = "0";

            foreach (var Item in ItemRepository.inventoryList)
            {
                amount = Item.amount.ToString();
                gridProductList.Rows.Add();
                gridProductList.Rows[row].Cells[0].Value = Item.category;
                gridProductList.Rows[row].Cells[1].Value = Item.name;
                gridProductList.Rows[row].Cells[2].Value = Item.salesPriceS;
                gridProductList.Rows[row].Cells[3].Value = Item.marketPriceS;
                gridProductList.Rows[row].Cells[4].Value = Item.weightS;
                gridProductList.Rows[row].Cells[5].Value = amount;
                row++;
            }
        }

        private void IncButton_Click(object sender, EventArgs e)
        {
            List<Item> itemList = itemRepo.GetList();
            int incAmount = int.Parse(IncTextBox.Text);
            int selectedItem = InventoryListBox.SelectedIndex;
            if (selectedItem <= itemList.Count)
            {
                itemList[selectedItem].IncAmount(incAmount);
            }
            IncTextBox.Clear();
            List<string> stringList = itemRepo.ConvertItemListToStringList();
            InventoryListBox.DataSource = stringList;
        }
        private void DecButton_Click(object sender, EventArgs e)
        {
            List<Item> itemList = itemRepo.GetList();
            int decAmount = int.Parse(DecTextBox.Text);
            int selectedItem = InventoryListBox.SelectedIndex;
            if (selectedItem <= itemList.Count)
            {
                itemList[selectedItem].DecAmount(decAmount);
            }
            DecTextBox.Clear();
            List<string> stringList = itemRepo.ConvertItemListToStringList();
            InventoryListBox.DataSource = stringList;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchWord = SearchTextBox.Text;

            try
            {
                foreach (DataGridViewRow row in gridProductList.Rows)
                {
                    row.Selected = false;
                    if
                        (row.Cells[0].Value.Equals(searchWord)
                        || row.Cells[1].Value.Equals(searchWord)
                        || row.Cells[2].Value.Equals(searchWord)
                        || row.Cells[3].Value.Equals(searchWord)
                        || row.Cells[4].Value.Equals(searchWord)
                        || row.Cells[5].Value.Equals(searchWord))   
                    {
                        row.Selected = true;
                    }
                }
            }
            catch (Exception)
            { }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<Item> gridProductList = itemRepo.Search(searchWord);
            List<string> searchList = new List<string>();
            foreach (Item item in gridProductList)
            {
                searchList.Add(item.ToStringItem());
            }

            InventoryListBox.DataSource = searchList;
        }
    }
}
