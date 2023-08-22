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
    public partial class frmPanel : Form
    {
        public frmPanel()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmLogin loginFrm = new frmLogin();
            this.Hide();
            loginFrm.ShowDialog();
        }

        private void frmPanel_Load(object sender, EventArgs e)
        {




        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserList userlist = new frmUserList();
            userlist.ShowDialog();
        }

        private void btnBooksList_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookList bookList = new frmBookList();
            bookList.ShowDialog();
        }

        private void btnPublishersList_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPublisherList Publisher = new frmPublisherList();
            Publisher.ShowDialog();
        }

        private void btnCustomersList_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerList customerList = new frmCustomerList();
            customerList.ShowDialog();
        }

        private void btnAuthorsList_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAuthors author = new frmAuthors();
            author.ShowDialog();
        }
    }
}
