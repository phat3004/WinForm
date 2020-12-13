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
    public partial class Login_Admin : Form
    {
        public Login_Admin()
        {
            InitializeComponent();
        }

        private int n;
        public bool flag;
        public int N;
        public string username = "admin";//Quản lí là chủ cửa hàng nên chỉ có 1 tài khoản
        public string pass = "Admin115161";
        public string CMNDQL = "5161";



        private void btOk_Click_1(object sender, EventArgs e)
        {
            Admin fr3 = new Admin();
            if (username == tbTK.Text && pass == tbMk.Text)
            {
                this.Visible = false;
                fr3.ShowDialog();
                bool flag = fr3.flag;
                fr3.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu !", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lLQuen_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var MK = new QMKQL();
            this.Visible = false;
            MK.ShowDialog();
            bool flag = MK.flag;
            MK.Close();
            if (flag = true)
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

        private void LlbEsc_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult Thoat = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Thoat == DialogResult.Yes)
                this.Close();
        }

    }
}
