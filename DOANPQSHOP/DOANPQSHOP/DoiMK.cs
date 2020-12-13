using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;

namespace DOANPQSHOP
{
    public partial class DoiMK : Form
    {
        public DoiMK()
        {
            InitializeComponent();
        }

        public bool flag;
        private void DoiMK_Load(object sender, EventArgs e)
        {
            label1.Text = Bill.Ten;
            DataTable dt = new DataTable();
            var xuli = new BAL_NHANVIEN();
            dt = xuli.LayTKNV(label1.Text);
            tbTK.Text = dt.Rows[0]["TK"].ToString();
            tbTK.Enabled = false;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            BEL_NHANVIEN nv = new BEL_NHANVIEN();
            BAL_NHANVIEN NV = new BAL_NHANVIEN();
            string MaHoaMK;
            nv.TK = tbTK.Text;
            MaHoaMK = Encrytion.Mahoa(tbMKCu.Text);
            if (NV.SS(tbTK.Text, MaHoaMK) == true)
            {
                if (string.IsNullOrEmpty(tbMKMoi.Text))
                {
                    MessageBox.Show("Nhập mật khẩu mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbMKMoi.Focus();
                }
                else
                {
                    if (tbMKMoi.Text == tbXNMK.Text)
                    {
                        nv.MK = Encrytion.Mahoa(tbXNMK.Text);
                        if (NV.CapNhapMKnv(nv) == true)
                        {
                            MessageBox.Show("Đã đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Đã đổi mật khẩu thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu Xác Nhận không trùng khớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbXNMK.Focus();
                    }
                }

            }
            else
            {
                MessageBox.Show("Mật khẩu sai!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMKCu.Focus();
            }
        }

        int Click = 0;
        private void btShow_Click(object sender, EventArgs e)
        {
            if (Click == 0)
            {
                tbMKMoi.UseSystemPasswordChar = false;
                tbXNMK.UseSystemPasswordChar = false;
                Click++;
            }
            else
            {
                tbMKMoi.UseSystemPasswordChar = true;
                tbXNMK.UseSystemPasswordChar = true;
                Click = 0;
            }    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
      
    }
}
