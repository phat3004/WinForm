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

namespace DOANPQSHOP
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        public bool flag;
        static int ID = 6;
        string Hinh;
        string TenSP;
        private void KhachHang_Load(object sender, EventArgs e)
        {
            KTSLHang();
            UpDaTruHD();
            HienThiHang(dgvSP_KH);
        }
        private bool KTSLHang()
        {
            bool kq = false;
            var xuli = new BAL_Hang();
            if (xuli.CapNhapSLHang() == true)
                return kq = true;
            return false;
        }
        private bool UpDaTruHD()
        {
            bool kq = false;
            var xuli = new BAL_HD();
            if (xuli.CapNhaDaTru() == true)
                return kq = true;
            return false;
        }
        private void HienThiHang(DataGridView dvg)
        {
            BAL_Hang xuli = new BAL_Hang();
            dvg.DataSource = xuli.LayTen_KH();
        }
        private int cothang = -1;
        private void dgvSP_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            var xuli = new BAL_Hang();
            try
            {
                cothang = e.RowIndex;
                DataGridViewRow row = dgvSP_KH.Rows[cothang];
                string ten = row.Cells[0].Value.ToString();
                dt = xuli.LayDSSLHangQuaTen(ten);
                int SL = int.Parse(dt.Rows[0]["SoLuong"].ToString());
                if(SL == 0)
                {
                    lb1.Text = "Mặt Hàng Đã Hết";
                    lb1.ForeColor = Color.Red;
                    dt = xuli.LayHinh_KH(ten);
                    pt1.Image = Image.FromFile(dt.Rows[0]["Hinh"].ToString());
                }
                else
                {
                    lb1.Text = "Giá " + row.Cells[1].Value.ToString() + "$";
                    lb1.ForeColor = Color.Black;
                    dt = xuli.LayHinh_KH(ten);
                    pt1.Image = Image.FromFile(dt.Rows[0]["Hinh"].ToString());
                }    
            }
            catch (Exception err)
            {

            }
        }
        private void TimTenHang(DataGridView dvg)
        {
            BAL_Hang xuli = new BAL_Hang();
            dvg.DataSource = xuli.TimHang_KH(tbTen.Text);
        }
        private void btTim_Click(object sender, EventArgs e)
        {
            TimTenHang(dgvSP_KH);
        }

        private void KhachHang_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                HienThiHang(dgvSP_KH);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult Thoat = MessageBox.Show("Mày chắc chưa con trai!", "Câu hỏi cho 1 thằng đàn ông", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Thoat == DialogResult.Yes)
                this.Close();   
        }

        private void btRe_Click(object sender, EventArgs e)
        {
            HienThiHang(dgvSP_KH);
        }

        //void HienThiHinh()
        //{

        //    BAL_Hang xuli = new BAL_Hang();
        //    DataTable dt = new DataTable();
        //    //dt = xuli.LayTenNV(General.TK);
        //    //lbTenNV.Text = dt.Rows[0]["HoTen"].ToString();
        //    for (int i = 1; i <= ID; i++)
        //    {
        //        switch (i)
        //        {
        //            case 1:
        //                {
        //                    dt = xuli.LayHinh(i.ToString());
        //                    pt1.Image = Image.FromFile(dt.Rows[0]["Hinh"].ToString());
        //                } break;
        //            case 2:
        //                {
        //                    dt = xuli.LayHinh(i.ToString());
        //                    pt2.Image = Image.FromFile(dt.Rows[0]["Hinh"].ToString());
        //                }
        //                break;
        //            case 3:
        //                {
        //                    dt = xuli.LayHinh(i.ToString());
        //                    pt3.Image = Image.FromFile(dt.Rows[0]["Hinh"].ToString());
        //                }
        //                break;
        //            case 4:
        //                {
        //                    dt = xuli.LayHinh(i.ToString());
        //                    pt4.Image = Image.FromFile(dt.Rows[0]["Hinh"].ToString());
        //                }
        //                break;
        //            case 5:
        //                {
        //                    dt = xuli.LayHinh(i.ToString());
        //                    pt5.Image = Image.FromFile(dt.Rows[0]["Hinh"].ToString());
        //                }
        //                break;
        //            case 6:
        //                {
        //                    dt = xuli.LayHinh(i.ToString());
        //                    pt6.Image = Image.FromFile(dt.Rows[0]["Hinh"].ToString());
        //                }
        //                break;
        //        }

        //    }
        //    }
        //    //void HienThiTen()
        //    //{
        //    //    BAL_Hang xuli = new BAL_Hang();
        //    //    DataTable dt = new DataTable();
        //    //    //dt = xuli.LayTenNV(General.TK);
        //    //    //lbTenNV.Text = dt.Rows[0]["HoTen"].ToString();
        //    //    for (int i = 1; i <= ID; i++)
        //    //    {
        //    //        switch (i)
        //    //        {
        //    //            case 1:
        //    //                {
        //    //                    dt = xuli.LayTen(i);
        //    //                    lb1.Text = dt.Rows[0]["TenHang"].ToString();
        //    //                }
        //    //                break;
        //    //            case 2:
        //    //                {
        //    //                    dt = xuli.LayTen(i);
        //    //                    lb2.Text = dt.Rows[0]["TenHang"].ToString();
        //    //                }
        //    //                break;
        //    //            case 3:
        //    //                {
        //    //                    dt = xuli.LayTen(i);
        //    //                    lb3.Text = dt.Rows[0]["TenHang"].ToString();
        //    //                }
        //    //                break;
        //    //            case 4:
        //    //                {
        //    //                    dt = xuli.LayTen(i);
        //    //                    lb4.Text = dt.Rows[0]["TenHang"].ToString();
        //    //                }
        //    //                break;
        //    //            case 5:
        //    //                {
        //    //                    dt = xuli.LayTen(i);
        //    //                    lb5.Text = dt.Rows[0]["TenHang"].ToString();
        //    //                }
        //    //                break;
        //    //            case 6:
        //    //                {
        //    //                    dt = xuli.LayTen(i);
        //    //                    lb6.Text = dt.Rows[0]["TenHang"].ToString();
        //    //                }
        //    //                break;
        //    //        }

        //        }
        //    }

        //}

    }
}
