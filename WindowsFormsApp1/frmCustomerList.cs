using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPanel panel = new frmPanel();
            panel.ShowDialog();
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            Customers customers= new Customers();
            dgvCustomer.DataSource = customers.customer();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customers newCustomer = new Customers();
            if(RBtnMale.Checked)
            {
                newCustomer.Gender = 1;
            }
            else
            {
                newCustomer.Gender = 2;
            }
            Customers customers = new Customers();
            newCustomer.Family = txtBFamily.Text;
            newCustomer.Name = txtBName.Text;
            newCustomer.Age = Convert.ToInt32(numBAge.Value);
                List<Customers> c = customers.customer();
            c.Add(newCustomer);
            dgvCustomer.DataSource = c;


        }
    }
}
