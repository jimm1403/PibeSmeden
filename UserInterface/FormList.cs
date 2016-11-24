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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> stringList = itemRepo.ConvertItemListToStringList();
            InventoryListBox.DataSource = stringList;
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
        }
        
    }
}
