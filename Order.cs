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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add(btnBeef.Text+" "+ lblBeef.Text);
            
        }

        private void btnClassic_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add(btnClassic.Text+" " + lblClassic.Text);
        }

        private void btnCheese_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add(btnCheese.Text + " " + lblCheese.Text);
        }

        private void btnAmircan_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add(btnAmircan.Text + " " + lblAmircan.Text);
        }

        private void btnPipsi_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add(btnPipsi.Text + " " + lblPipsi.Text);
        }

        private void btn7UP_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add(btn7UP.Text + " " + lbl7UP.Text);

        }

        private void btnMiranda_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add(btnMiranda.Text + " " + lblMiranda.Text);
        }

        private void btnResat_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();
        }

        
    }
}
