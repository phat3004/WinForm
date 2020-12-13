using BAL;
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
    public partial class TinhTien : Form
    {
        public TinhTien()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BAL_KHACHHANG xuli = new BAL_KHACHHANG();
            BAL_HD capnhap = new BAL_HD();
            FrmBAOCAO fr = new FrmBAOCAO();
            try
            {
                dt = xuli.LaySoLanMua(tbSDT.Text);
                int SoLanMua = int.Parse(dt.Rows[0]["SoLanDaMua"].ToString());
                dt = xuli.SDTTrung(tbSDT.Text);
                int makh = int.Parse(dt.Rows[0]["MaKH"].ToString());
                fr._NhanVien = Bill.Ten;
                    if (Bill.TongTien > double.Parse(textBox1.Text))
                    {
                        MessageBox.Show("không đủ tiền", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        
                        if (SoLanMua == 0)
                        {
                            fr._KM = 0;
                            xuli.ThemLanMua(tbSDT.Text, 1);
                            capnhap.CapNhapKM_MaKH(0, makh);
                        }
                        else
                        {
                            if (SoLanMua > 0 && SoLanMua < 10)
                            {
                                fr._KM = double.Parse(label3.Text) * 0.05;
                                double chia = (double.Parse(label3.Text) * 0.05) / Bill.SoDong;
                                capnhap.CapNhapKM_MaKH(chia, makh);
                                xuli.ThemLanMua(tbSDT.Text, SoLanMua + 1);

                            }
                            if (SoLanMua > 10 && SoLanMua < 30)
                            {
                                fr._KM = double.Parse(label3.Text) * 0.1;
                                double chia = (double.Parse(label3.Text) * 0.1) / Bill.SoDong;
                                capnhap.CapNhapKM_MaKH(chia, makh);
                                xuli.ThemLanMua(tbSDT.Text, SoLanMua + 1);
                            }
                            if (SoLanMua > 30)
                            {
                                fr._KM = double.Parse(label3.Text) * 0.2;
                                double chia = (double.Parse(label3.Text) * 0.2) / Bill.SoDong;
                                capnhap.CapNhapKM_MaKH(chia, makh);
                                xuli.ThemLanMua(tbSDT.Text, SoLanMua + 1);
                            }
                        }
                        fr._TienKhachDua = double.Parse(textBox1.Text);
                        this.Visible = false;
                        fr.ShowDialog();
                    }  
            }
           catch
            {
                MessageBox.Show("Vui lòng đăng kí SĐT", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void TinhTien_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            label3.Text = Bill.TongTien.ToString();
        }
           

    }
}
