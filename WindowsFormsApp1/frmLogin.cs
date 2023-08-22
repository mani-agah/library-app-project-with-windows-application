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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
        Users user = new Users();
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Users> Users = user.getAllUser();
            Users u=  Users.Where(x=>x.Name==txtBoxUser.Text && x.Password==txtBoxPass.Text).FirstOrDefault();
            if (u != null) {
                frmPanel panel = new frmPanel();
                panel.ShowDialog();
            }
            else
            {
                MessageBox.Show("error");
            }
;
        }
    }
}
