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
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client cal = new ServiceReference1.Service1Client();

        public Form1()
        {
            InitializeComponent();
        }

        private void Btplus_Click_1(object sender, EventArgs e)
        {
            Txtz.Text = Convert.ToString(cal.WebAdd(int.Parse(Txtx.Text),
            int.Parse(Txty.Text)));
        }

        private void Btsous_Click_1(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client cal = new ServiceReference1.Service1Client();
            /* */
            int Total = cal.WebSoustraction(Convert.ToInt32(Txtx.Text),Convert.ToInt32(Txty.Text));
            MessageBox.Show(Total.ToString());
        }

        private void Btdiv_Click_1(object sender, EventArgs e)
        {
            Txtz.Text = Convert.ToString(cal.WebMultiply(int.Parse(Txtx.Text),
            int.Parse(Txty.Text)));
        }

        private void Btmult_Click(object sender, EventArgs e)
        {
            Txtz.Text = Convert.ToString(cal.WebDivision(int.Parse(Txtx.Text),
            int.Parse(Txty.Text)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bplus_Click(object sender, EventArgs e)
        {
            rs.Text = Convert.ToString(cal.WebAdd(int.Parse(tx.Text),
            int.Parse(ty.Text)));
        }

        private void bsous_Click(object sender, EventArgs e)
        {
            rs.Text = Convert.ToString(cal.WebSoustraction(int.Parse(tx.Text),
            int.Parse(ty.Text)));
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            rs.Text = Convert.ToString(cal.WebMultiply(int.Parse(tx.Text),
            int.Parse(ty.Text)));
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            rs.Text = Convert.ToString(cal.WebDivision(int.Parse(tx.Text),
            int.Parse(ty.Text)));
        }
    }
}
