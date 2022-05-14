using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_ad0027
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "1234")
            {
                frmWelcome frm = new frmWelcome(txtUsername.Text);
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Wrong Password!!");
                
        }

        
    }
}
