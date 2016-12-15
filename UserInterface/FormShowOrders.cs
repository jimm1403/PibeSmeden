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
    public partial class FormShowOrders : Form
    {
        OrderRepository orderRepo = new OrderRepository();
        public FormShowOrders()
        {
            InitializeComponent();

            
            gridOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int row = 0;

            foreach (var order in OrderRepository.orderList)
            {
                gridOrderList.Rows.Add();
                gridOrderList.Rows[row].Cells[0].Value = order.GetId();
                gridOrderList.Rows[row].Cells[1].Value = order.OrderDate;
                gridOrderList.Rows[row].Cells[2].Value = order.isOrderDone();
                row++;
            }
            showOrderContent();
            
        }
        public void showOrderContent()
        {
            int row = 0;
            string idToFind = "";
            idToFind = gridOrderList.SelectedRows[0].Cells[0].Value.ToString();
            
            Order orderToFind;
            foreach (var order in OrderRepository.orderList)
            {
                if (order.GetId() == int.Parse(idToFind))
                {
                orderToFind = orderRepo.FindOrderById(int.Parse(idToFind));
                orderLineListBox.DataSource = orderToFind.orderLineList.ToString();
                }
            }
        }
    }
}
