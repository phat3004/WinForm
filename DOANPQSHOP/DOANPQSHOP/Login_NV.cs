using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DAL;
using BEL;

namespace DOANPQSHOP
{
    public partial class Login_NV : Form
    {
        public bool flag;
        public int N;
        private string taikhoan;

        public string Taikhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }
        public Login_NV()
        {
            InitializeComponent();
        }
        private bool SS(string tk, string mk)
        {

            tk = tbTK.Text;
            mk = tbMk.Text;
            bool kq = false;
            BAL_NHANVIEN xuli = new BAL_NHANVIEN();
            if (xuli.SS(tk, mk) == true)
                return kq = true;
            return kq;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Bill fr5 = new Bill();
            BAL_NHANVIEN xuli = new BAL_NHANVIEN();
            tbMk.Text = Encrytion.Mahoa(tbMk.Text);
            if (SS(tbTK.Text, tbMk.Text) == true)
            {
                this.Visible = false;
                bool flag = fr5.flag;
                General.TK = tbTK.Text;
                fr5.ShowDialog();
                fr5.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu !", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LlbEsc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Gọi quản lí 0933721811/0948535453!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
