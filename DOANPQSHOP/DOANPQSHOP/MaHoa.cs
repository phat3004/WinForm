using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANPQSHOP
{
    public partial class MaHoa : Form
    {
        public MaHoa()
        {
            InitializeComponent();
        }
        private string CMNDQL = "5161";
        public bool flag = false;

        private void btOK_Click_1(object sender, EventArgs e)
        {
            var pass = new Login_Admin();
            if (tbPass.Text == pass.pass)
            {
                flag = true;
            }
            this.Close();
        }

        private void lLHelp_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var MK = new QMKQL();
            MK.ShowDialog();
            bool flag = MK.flag;
            MK.Close();
            if (flag == true)
            {
                string cm = MK.N.ToString();
                if (CMNDQL == cm)
                {
                    MessageBox.Show("TK :  admin,MK :  Admin115161", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Quên thì thôi chứ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
