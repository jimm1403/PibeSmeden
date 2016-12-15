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
    public partial class FormNewOrder : Form
    {
        ItemRepository itemRepo = new ItemRepository();
        OrderRepository orderRepo = new OrderRepository();
        public FormNewOrder()
        {
            InitializeComponent();
            productSelectionComboBox.Enabled = false;
            orderLineQuantityTxtBox.Enabled = false;
            addToOrderBtn.Enabled = false;
            productSelectionComboBox.DataSource = itemRepo.ConvertItemListToStringList();
        }

        private void addToOrderBtn_Click(object sender, EventArgs e)
        {
            string itemToFind = productSelectionComboBox.SelectedItem.ToString();
            Item newItem = itemRepo.FindItem(itemToFind);

            int quantity = int.Parse(orderLineQuantityTxtBox.Text);
            OrderLine newOrderLine = new OrderLine(quantity, newItem);
            Order orderToAddTo = orderRepo.FindNewestOrder();
            orderToAddTo.addItemsToOrderLine(newOrderLine);
            orderLineQuantityTxtBox.Clear();
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order(orderDateTxtBox.Text);
            orderRepo.AddAOrderToList(newOrder);
            orderDateTxtBox.Clear();
            orderDateTxtBox.Enabled = false;
            newOrderButton.Enabled = false;
            productSelectionComboBox.Enabled = true;
            orderLineQuantityTxtBox.Enabled = true;
            addToOrderBtn.Enabled = true;
        }
    }
}
