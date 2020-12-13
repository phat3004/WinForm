using BEL;
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
namespace DOANPQSHOP
{
    public partial class VIP_KH : Form
    {
        public VIP_KH()
        {
            InitializeComponent();
        }
        public bool flag;
        string MaKH;
        private void btEn_Click(object sender, EventArgs e)
        {
            BEL_KHACHHANG kh = new BEL_KHACHHANG();
            BAL_KHACHHANG xuli = new BAL_KHACHHANG();
            DataTable dt = new DataTable();
            dt = xuli.SDTTrung(tbSDT.Text);
            kh.SDT = tbSDT.Text;
            try
            {
                MaKH = dt.Rows[0]["MaKH"].ToString();
                if (string.IsNullOrEmpty(MaKH) == false)
                {
                    MessageBox.Show("Số Điện Thoại Đã Đăng Kí", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch
            {
                if (xuli.ThemSDT(kh) == true)
                {
                    MessageBox.Show("Thêm Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
                
            
        }
    }
}
