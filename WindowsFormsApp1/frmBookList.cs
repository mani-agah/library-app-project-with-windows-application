using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmBookList : Form
    {
        public frmBookList()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPanel panel = new frmPanel();
            panel.ShowDialog();
        }

           Books allBook = new Books();
        private void frmBookList_Load(object sender, EventArgs e)
        {
            dgvBook.DataSource = allBook.book();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Books newBook = new Books();
            newBook.Price = Convert.ToInt32(txtPrice.Text);
        }
    }
}
