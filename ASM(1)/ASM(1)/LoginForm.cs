using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_1_
{
    public partial class LoginForm : Form
    {
        //private AccountValidator addtk = new AccountValidator();



        public LoginForm()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            
            if(txtpass.Text == txtcf.Text)
            {
                Form1 from1 = new Form1();
                from1.Show();
                this.Hide();
            }
        }

        private void btcreate_Click(object sender, EventArgs e)
        {
            
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
