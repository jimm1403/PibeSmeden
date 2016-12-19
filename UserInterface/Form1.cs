using System;
using System.Windows.Forms;
using ClassLibrary;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            ItemRepository itemRepo = new ItemRepository();
            
            Item newItem1 = new Item("Cigaretter", "Prince Light", 44, 40, 40);
            Item newItem2 = new Item("Cigaretter", "Camel Blue", 39, 35, 20);
            itemRepo.AddToInventoryList(newItem1);
            itemRepo.AddToInventoryList(newItem2);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
            lblLastAction.Text = formAdd.newestItem;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FormList formList = new FormList();
            formList.ShowDialog();
            lblLastAction.Text = "";
        }

        private void btnRecieve_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void newOrderBtn_Click(object sender, EventArgs e)
        {
            FormNewOrder orderForm = new FormNewOrder();
            orderForm.Show();
            
        }

        private void showOrdersBtn_Click(object sender, EventArgs e)
        {
            FormShowOrders showOrderForm = new FormShowOrders();
            showOrderForm.Show();
        }
    }
}
