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
    public partial class BillWater : Form
    {
        public BillWater()
        {
            InitializeComponent();
        }
        public BillWater(string name, string phone, string tep, string cu, string moi, string tong, string tien)
        {
            InitializeComponent();
            txtname.Text = name;
            txtphone.Text = phone;
            txtfile.Text = tep;
            txtlast.Text = cu;
            txtthis.Text = moi;
            txtuser.Text = tong;
            txttotal.Text = tien;
        }
        private void BillWater_Load(object sender, EventArgs e)
        {

        }

        private void btpay_Click(object sender, EventArgs e)
        {

        }
    }
}
