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
    public partial class frmAuthors : Form
    {
        public frmAuthors()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPanel panel = new frmPanel();
            panel.ShowDialog();
        }
        Author ath = new Author();
        private void frmAuthors_Load(object sender, EventArgs e)
        {
            dgvAuthor.DataSource = ath.Authors();
        }
    }
}
