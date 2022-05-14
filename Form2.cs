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
    public partial class frmWelcome : Form
    {
        public string welcomeLabel;
        public frmWelcome(string welcomeLabel)
        {
            InitializeComponent();
            this.welcomeLabel = welcomeLabel;
            lblWelcomeName.Text = welcomeLabel;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            frmMenu myForm = new frmMenu();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            pnlShow.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            frmOrder myForm1 = new frmOrder();
            myForm1.TopLevel = false;
            myForm1.AutoScroll = true;
            pnlShow.Controls.Add(myForm1);
            myForm1.FormBorderStyle = FormBorderStyle.None;
            myForm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            frmCheckOut myForm1 = new frmCheckOut();
            myForm1.TopLevel = false;
            myForm1.AutoScroll = true;
            pnlShow.Controls.Add(myForm1);
            myForm1.FormBorderStyle = FormBorderStyle.None;
            myForm1.Show();
        }
    }
}
