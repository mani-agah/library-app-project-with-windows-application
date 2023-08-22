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
    public partial class frmPublisherList : Form
    {
        public frmPublisherList()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPanel panel = new frmPanel();
            panel.ShowDialog();
        }
        Publishers publisher= new Publishers();
        private void frmPublisherList_Load(object sender, EventArgs e)
        {
            dgvPublisher.DataSource = publisher.allPublisher();
        }
    }
}
