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
        }

        private void orderReceivedButton_Click(object sender, EventArgs e)
        {
            string id = "";
            int row = 0;

            try
            {
                id = gridOrderList.SelectedRows[0].Cells[0].Value.ToString();
                foreach (var order in OrderRepository.orderList)
                {
                    if (order.GetId() == int.Parse(id))
                    {
                        order.CompletionTracker = true;
                    }
                    
                    gridOrderList.Rows[row].Cells[0].Value = order.GetId();
                    gridOrderList.Rows[row].Cells[1].Value = order.OrderDate;
                    gridOrderList.Rows[row].Cells[2].Value = order.isOrderDone();
                    row++;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Vælg venligst et produkt");
            }
        }
    }
}
