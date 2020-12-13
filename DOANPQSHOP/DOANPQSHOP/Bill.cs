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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }
        public bool flag;
        Login_NV nv = new Login_NV();
        BAL_NHANVIEN xuli = new BAL_NHANVIEN();
        public static string Ten;
        public static float SoDong = 0;
        double KQ;
        int SL;
        int SL_Dem;
        int Chay = 0;
        private void HienThiTenHang(ComboBox cbTenHang)
        {
            var xuli = new BAL_Hang();
            cbTenHang.DisplayMember = "TenHang";
            cbTenHang.DataSource = xuli.LayDSTenHang();
        }
        private void cbTenHang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HienThiLoaiHang(cbTenHang.Text);
            HienThiGia(cbTenHang.Text);
            HienThiSL(cbTenHang.Text);
        }
        private void HienThiLoaiHang(string TenHang)
        {
            var xulihang = new BAL_Hang();
            DataTable dt = new DataTable();
            dt = xulihang.LayDSLoaiHangQuaTen(TenHang);
            tbLoaiHang.Text = dt.Rows[0]["Loai"].ToString();
        }
        private void HienThiGia(string TenHang)
        {
            var xulihang = new BAL_Hang();
            DataTable dt = new DataTable();
            dt = xulihang.LayDSGiaHangQuaTen(TenHang);
            tbGia.Text = dt.Rows[0]["Gia"].ToString();
        }
        private void HienThiSL(string TenHang)
        {
            var xulihang = new BAL_Hang();
            DataTable dt = new DataTable();
            dt = xulihang.LayDSSLHangQuaTen(TenHang);
            if (Chay == 0)
            {
                tbSoLuong.Text = dt.Rows[0]["SoLuong"].ToString();
                SL = int.Parse(tbSoLuong.Text);
                SL_Dem = SL;
            }
            else
                tbSoLuong.Text = SL_Dem.ToString();
        }
        private void Bill_Load_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = xuli.LayTenNV(General.TK);
                lbTenNV.Text = dt.Rows[0]["HoTen"].ToString();
                tbMaHD.Enabled = false;
                tbLoaiHang.Enabled = false;
                tbTong.Enabled = false;
                tbGia.Enabled = false;
                HienThiTenHang(cbTenHang);
                BAL_HD capnhap = new BAL_HD();
                if (FrmBAOCAO.Dem != 0)
                {
                    capnhap.CapNhatTrung();
                }
            }
            catch
            {
                MessageBox.Show("Sai tên Server!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HienThiHD(DataGridView dvg)
        {
            BAL_HD xuli = new BAL_HD();
            dvg.DataSource = xuli.LayDSHD(lbTenNV.Text);
        }
        private int cot = -1;
        private void dgvHoaDon_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cot = e.RowIndex;
                DataGridViewRow row = dgvHoaDon.Rows[cot];
                tbMaHD.Text = row.Cells[0].Value.ToString();
                tbLoaiHang.Text = row.Cells[1].Value.ToString();
                cbTenHang.Text = row.Cells[2].Value.ToString();
                tbSoLuong.Text = row.Cells[3].Value.ToString();
                tbTong.Text = row.Cells[6].Value.ToString();
                lbTenNV.Text = row.Cells[7].Value.ToString();
            }
            catch (Exception err)
            {

            }
        }
        private void gọiQuảnLíToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("SĐT quản lí: 0987654321", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        int Dem = 0;
        private void khôngTìmĐượcSPToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Dem == 0)
            {
                MessageBox.Show("Gọi Quản Lí Nhé!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Dem == 1)
            {
                MessageBox.Show("Vẫn Cứ Gọi Quản Lí THôi :)) !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Dem == 2)
            {
                MessageBox.Show("Cứ Y Như Hồi Nãy GOIQUANLI !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dem = 0;
            }
            else
                Dem++;
        }
        private void khôngThựcHiệnĐượcChứcNăngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Dem == 0)
            {
                MessageBox.Show("Gọi Quản Lí Nhé!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Dem == 1)
            {
                MessageBox.Show("Vẫn Cứ Gọi Quản Lí THôi :)) !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Dem == 2)
            {
                MessageBox.Show("Cứ Y Như Hồi Nãy GOIQUANLI !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dem = 0;
            }
            else
                Dem++;
        }

        private void khácToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Dem == 0)
            {
                MessageBox.Show("Gọi Quản Lí Nhé!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Dem == 1)
            {
                MessageBox.Show("Vẫn Cứ Gọi Quản Lí THôi :)) !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Dem == 2)
            {
                MessageBox.Show("Cứ Y Như Hồi Nãy GOIQUANLI !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dem = 0;
            }
            else
                Dem++;
        }
        private void xemMãKhuyếnMãiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Xem Mã Khuyến Mãi Cũng Cần Gọi Quản Lí Nhé!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void gặpLỗiKhiSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Dem == 0)
            {
                MessageBox.Show("Gọi Quản Lí Nhé!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Dem == 1)
            {
                MessageBox.Show("Vẫn Cứ Gọi Quản Lí THôi :)) !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Dem == 2)
            {
                MessageBox.Show("Cứ Y Như Hồi Nãy GOIQUANLI !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dem = 0;
            }
            else
                Dem++;
        }

        double Tong = 0;
        private void tbSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbSoLuong.Text != "")
                {
                    KQ = double.Parse(tbGia.Text) * double.Parse(tbSoLuong.Text);
                    double tong;
                    Tong = 0;
                    tong = KQ;
                    Tong += tong;
                    tbTong.Text = Tong.ToString();
                }
                else
                {
                    tbTong.Text = "0";
                }
            }
            catch
            {

            }
        }

        private void btThemHD_Click(object sender, EventArgs e)
        {
            var Xuly = new BAL_HD();
            var hd = new BEL_HD();
            dgvHoaDon.DataSource = null;
            hd.LoaiHang = tbLoaiHang.Text.ToString();
            hd.TenHang = cbTenHang.Text.ToString();
            hd.SL = int.Parse(tbSoLuong.Text);
            hd.GiamGia = 0;  
            hd.Tong = float.Parse(tbTong.Text);
            hd.TenNV = lbTenNV.Text;
            hd.TThai = 1;
            hd.Tru = 'N';
            hd.Trung = 0;
            HienThiGia(cbTenHang.Text);
            SL = SL - int.Parse(tbSoLuong.Text);
            if (SL < 0)
            {
                MessageBox.Show("Số lượng hàng không đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiSL(cbTenHang.Text);
                SL = int.Parse(tbSoLuong.Text);
            }
            else
            {
                if (Xuly.ThemHD(hd) == true)
                {
                    MessageBox.Show("Thêm dữ liệu thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbSoLuong.Text = (SL_Dem - int.Parse(tbSoLuong.Text)).ToString();
                    dgvHoaDon.DataSource = Xuly.LayDSHD(lbTenNV.Text);
                    HienThiHD(dgvHoaDon);
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại vui lòng xem lại thông tin nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvHoaDon.DataSource = Xuly.LayDSHD(lbTenNV.Text);
                    tbLoaiHang.Focus();
                }
            }
            
        }
        
        private void btInHD_Click(object sender, EventArgs e)
        {
            Ten = lbTenNV.Text;
            TinhTien tt = new TinhTien();
            int sc = dgvHoaDon.Rows.Count;
            for (int i = 0; i < sc - 1; i++)
            {
                SoDong++;
            }
            if(SoDong == 0)
            {
                MessageBox.Show("Chưa Thêm Hóa Đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tinhtong();
                this.Visible = false;
                tt.ShowDialog();
                HienThiHD(dgvHoaDon);
                Chay++;
            }    
        }
        public static double TongTien = 0;
        public double tinhtong()
        {
            int sc = dgvHoaDon.Rows.Count;
            string LoaiHang = null;
            for (int i = 0; i < sc - 1; i++)
            {
                TongTien += double.Parse(dgvHoaDon.Rows[i].Cells["Tổng"].Value.ToString());
            }
            return TongTien;
        }
        private void btSuaHD_Click(object sender, EventArgs e)
        {
            try
            {
                var Xuly = new BAL_HD();
                var hd = new BEL_HD();
                hd.MaHD = int.Parse(tbMaHD.Text);
                hd.LoaiHang = tbLoaiHang.Text;
                hd.TenHang = cbTenHang.Text;
                hd.SL = int.Parse(tbSoLuong.Text);
                hd.Tong = float.Parse(tbTong.Text);
                hd.Tru = 'N';
                if (Xuly.CapNhaphd(hd) == true)
                {
                    MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvHoaDon.DataSource = Xuly.LayDSHD(lbTenNV.Text);
                    HienThiHD(dgvHoaDon);
                    tbMaHD.Text = null;
                    tbTong.Text = null;
                }
                else
                {
                    MessageBox.Show("Update thất bại vui lòng xem lại thông tin nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvHoaDon.DataSource = Xuly.LayDSHD(lbTenNV.Text);
                    tbMaHD.Focus();
                }
            }
            catch
            {

            }
            
        }

        private void btXoaHD_Click_1(object sender, EventArgs e)
        {
            var xuli = new BAL_HD();
            if (xuli.XoaSachHD(tbMaHD.Text) == true)
            {
                MessageBox.Show("Đã Xoá HD", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiHD(dgvHoaDon);
            }
            else
            {
                MessageBox.Show("Chọn hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Thoat = MessageBox.Show("Bạn muốn đăng xuất !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Thoat == DialogResult.Yes)
            {
                this.Visible = false;
                nv.ShowDialog();
                bool flag = nv.flag;
                nv.Close();
            }
        }

        private void đổimậtkhẩuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DoiMK xuli = new DoiMK();
            Ten = lbTenNV.Text;
            xuli.ShowDialog();
        }

        private void đăngKíVIPChoKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VIP_KH kh = new VIP_KH();
            kh.ShowDialog();
            bool flag = kh.flag;
            kh.Close();
        }

        private void Bill_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                HienThiHD(dgvHoaDon);
                HienThiTenHang(cbTenHang);
            }
        }

        
        

       

       

        

       

       

     

       

        
    }
}
