using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmoDic
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtServer.Text == "")
            {
                lbInfo.Text = "Không được để trống ServerName";
                txtServer.Focus();
                return;
            }
            if (txtID.Text == "")
            {
                lbInfo.Text = "Không được để trống ID";
                txtID.Focus();
                return;
            }
            Program.Connect(txtServer.Text.Trim(), txtDB.Text.Trim(), txtID.Text.Trim(), txtPass.Text.Trim());
            if (Program.CheckConnectString())
                this.Close();
            else
                return;
            
        }
    }
}
