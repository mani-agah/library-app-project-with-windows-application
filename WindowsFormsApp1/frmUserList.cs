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
    public partial class frmUserList : Form
    {
        public frmUserList()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmPanel panel= new frmPanel();
            this.Hide();
            panel.ShowDialog();
        }
        Users user = new Users();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmUserList_Load(object sender, EventArgs e)
        {

            dgvUser.DataSource = user.getAllUser();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Users newUser=new Users();
            newUser.Password = txtPassword.Text;
            newUser.NationalID = numID.Text;
            if (RBtnMale.Checked)
            {
                newUser.Gender = 1;
            }
            else
            {
                newUser.Gender = 2;
            }
            newUser.Family = txtBFamily.Text;
            newUser.Name = txtBName.Text;
            newUser.Age = (int)numBAge.Value;
            List<Users> u = user.getAllUser();
                u.Add(newUser);
            dgvUser.DataSource = u;
                
        }
    }
}
