using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
