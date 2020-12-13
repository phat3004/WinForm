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
using BEL;
using DAL;
using System.Windows.Forms.DataVisualization.Charting;

namespace DOANPQSHOP
{
    public partial class Admin : Form
    {
        public bool flag;
        int Xem = 0;
        public Admin()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------
        // Hàm chung
        //private void TSMIUnDo_Click(object sender, EventArgs e)
        //{
        //        HienThiNV(dgvNV);
        //        label14.ForeColor = Color.Black;
        //        label15.ForeColor = Color.Black;
        //        tbTimTenNV.Enabled = true;
        //        cbTimMaNV.Enabled = true;
        //        radMaNV.Checked = false;
        //        radTenNV.Checked = false;

        //        HienThiHang(dgvHang);
        //        label16.ForeColor = Color.Black;
        //        label17.ForeColor = Color.Black;
        //        tbTimTenHang.Enabled = true;
        //        cbMaHang.Enabled = true;
        //        radTimTenHang.Checked = false;
        //        radTimMaHang.Checked = false;

        //        HienThiTKNV(dgvTKNV);
        //        HienThiMaNV(cbMaNV_Nhap_TK);
        //        HienThiMaNV(cbMaNV_Tim_TK);
        //        HienThiMaHang(cbMaHang);
        //} 
        private void Admin_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                F5();

            }   
        }
        private void F5()
        {
            HienThiNV(dgvNV);
            label14.ForeColor = Color.Black;
            label15.ForeColor = Color.Black;
            tbMaNV.Enabled = true;
            tbTimTenNV.Enabled = true;
            cbTimMaNV.Enabled = true;
            radMaNV.Checked = false;
            radTenNV.Checked = false;

            HienThiHang(dgvHang);
            label16.ForeColor = Color.Black;
            label17.ForeColor = Color.Black;
            tbMaHang.Enabled = true;
            tbTimTenHang.Enabled = true;
            cbMaHang.Enabled = true;
            radTimTenHang.Checked = false;
            radTimMaHang.Checked = false;

            HienThiTKNV(dgvTKNV);
            cbMaNV_Nhap_TK.Enabled = true;
            HienThiMaNV(cbMaNV_Nhap_TK);
            HienThiMaNV(cbMaNV_Tim_TK);
            HienThiMaHang(cbMaHang);

            BAL_HD xuli = new BAL_HD();
            dgvHD.DataSource = xuli.LayDSSaiHD_HD();
            HienThiMaHD(cbMaHD_HD);
            HienThiKhachHang(dgvKH);
            //try
            //{
            //    int sc = dgvKH.Rows.Count;
            //    int DongDau;
            //    int DongSau;
            //    for (int i = 0; i < sc - 1; i++)
            //    {
            //        DongDau = int.Parse(dgvKH.Rows[i].Cells["MaKH"].Value.ToString());
            //        for (int j = i + 1; j < sc - 1; j++)
            //        {
            //            DongSau = int.Parse(dgvKH.Rows[j].Cells["MaKH"].Value.ToString());
            //            if (DongSau == DongDau)
            //            {
            //                dgvKH.Rows.RemoveAt(DongSau);
            //                sc = dgvKH.Rows.Count;//gan lai sc sau khi da tru
            //                j--;//tru no de cong len lay lai vi tri cu
            //                i--;
            //            }
            //        }

            //    }
            //}
            //catch
            //{

            //}
            radMaKH_KH.Checked = false;
            radSDT_KH.Checked = false;
            radSoLanMua_KH.Checked = false;
            cbMa_KH.Enabled = true;
            tbSDT_KH.Enabled = true;
            tbSoLanMua.Enabled = true;

            tbMaNV.Text = null;
            tbHoTen.Text = null;
            tbCMND.Text = null;
            tbDChi.Text = null;
            tbSDT.Text = null;
            tbMaHang.Text = null;
            tbTenHang.Text = null;
            tbSL.Text = null;
            tbLoai.Text = null;
            tbNCC.Text = null;
            tbMo.Text = null;
            tbTKNV.Text = null;
            tbMKNV.Text = null;
            radMaHD_HD.Checked = false;
            radMaHD_HD.ForeColor = Color.Black;
            radTenNV_HD.Checked = false;
            radTenNV_HD.ForeColor = Color.Black;
            radMaHD_HD.Enabled = true;
            radTenNV_HD.Enabled = true;
            cbMaHD_HD.Enabled = true;
            btTim_HD.Enabled = true;
            tbTenNV_HD.Enabled = true;
            btPhucHoi_HD.Enabled = true;
            btTim_HD.Enabled = true;
            btPhucHoi_HD.Enabled = true;
            tbTenNV_HD.Text = null;
            tbTongGiam_HD.Text = null;
            tbTongThu_HD.Text = null;
            tbSL_HD.Text = null;
        }
        private bool ThongBao()
        {
            bool KQ = false;
            int sc = dgvHang.Rows.Count;
            float sosanh = 0;
            for (int i = 0; i < sc - 1; i++)
                if (sosanh == float.Parse(dgvHang.Rows[i].Cells[2].Value.ToString()))
                {
                    KQ = true;
                }
            return KQ;
        }
        int ThucThi = 0;
        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var style = new DataGridViewCellStyle();
            style.BackColor = Color.Red;
            var style1 = new DataGridViewCellStyle();
            style1.BackColor = Color.White;
            if (tabControl1.SelectedIndex == 1 && ThongBao() == true)
            {
                MessageBox.Show("Một số mặt hàng đã hết vui lòng cập nhập thêm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                float sosanh = 0;
                int sc = dgvHang.Rows.Count;
                for (int i = 0; i < sc - 1; i++)
                {
                    if (sosanh == float.Parse(dgvHang.Rows[i].Cells[2].Value.ToString()))
                    {
                        dgvHang.Rows[i].DefaultCellStyle = style;
                        //dgvHang.RowsDefaultCellStyle.BackColor = Color.White;
                        //dgvHang.AlternatingRowsDefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                        dgvHang.Rows[i].DefaultCellStyle = style1;
                }
            }
            if (tabControl1.SelectedIndex == 4 && Xem == 1)
            {
                BieuDo();
            }
            if (tabControl1.SelectedIndex == 4 && Xem == 0)
            {
                MessageBox.Show("Chọn Hóa Đơn Cần Xem Trước Khi Thống Kê", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void TSMIDANGXUAT_Click_1(object sender, EventArgs e)
        {

            var DangXuat = new Login_Admin();
            this.Visible = false;
            DangXuat.ShowDialog();
            DangXuat.Close();
        }     
        //-------------------------------------------------------------------------------------------------------------------------------------------------
        //form_load
        private void Admin_Load(object sender, EventArgs e)
        {
            /*var hd = new BAL_HD();
            var hang = new BAL_Hang();
            if(hd.LayHD()== true)
            {
                hang.CapNhapSoLuongHang();
                hd.CapNhapTThai();
                HienThiHang(dgvHang);
            }
            else*/
            try
            {
                HienThiHang(dgvHang);
                HienThiNV(dgvNV);
                HienThiTKNV(dgvTKNV);
                HienThiMaNV(cbTimMaNV);
                HienThiMaNV(cbMaNV_Nhap_TK);
                HienThiMaNV(cbMaNV_Tim_TK);
                HienThiMaHang(cbMaHang);
                //HienThiHoaDon(dgvHD);
                HienThiMaHD(cbMaHD_HD);
                tbTongGiam_HD.Enabled = false;
                tbTongThu_HD.Enabled = false;
                tbSL_HD.Enabled = false;
                //BieuDo();
                tbMKNV.Enabled = false;
                tbMKDaMaHoa.Enabled = false;
                //KhachHang
                    HienThiMaKH(cbMa_KH);
                    HienThiKhachHang(dgvKH);
                    //try
                    //{
                    //    int sc = dgvKH.Rows.Count;
                    //    int DongDau;
                    //    int DongSau;
                    //    for (int i = 0; i < sc - 1; i++)
                    //    {
                    //        DongDau = int.Parse(dgvKH.Rows[i].Cells["MaKH"].Value.ToString());
                    //        for (int j = i + 1; j < sc - 1; j++)
                    //        {
                    //            DongSau = int.Parse(dgvKH.Rows[j].Cells["MaKH"].Value.ToString());
                    //            if (DongSau == DongDau)
                    //            {
                    //                dgvKH.Rows.RemoveAt(DongSau);
                    //                sc = dgvKH.Rows.Count;//gan lai sc sau khi da tru
                    //                j--;//tru no de cong len lay lai vi tri cu
                    //                i--;
                    //            }
                    //        }

                    //    }  
                    //}
                    //catch
                    //{

                    //}
                //Icon Tagpage
                var ico = new ImageList();
                ico.ColorDepth = ColorDepth.Depth32Bit;
                ico.ImageSize = new Size(40, 40);
                ico.Images.Add("key1", Image.FromFile(@"D:\workspace\DOANPQSHOP\Img\TabPageImage\NV.png"));
                ico.Images.Add("key2", Image.FromFile(@"D:\workspace\DOANPQSHOP\Img\TabPageImage\SP.png"));
                ico.Images.Add("key3", Image.FromFile(@"D:\workspace\DOANPQSHOP\Img\TabPageImage\TK.png"));
                ico.Images.Add("key4", Image.FromFile(@"D:\workspace\DOANPQSHOP\Img\TabPageImage\bill.png"));
                ico.Images.Add("key5", Image.FromFile(@"D:\workspace\DOANPQSHOP\Img\TabPageImage\BieuDo.png"));
                ico.Images.Add("key6", Image.FromFile(@"D:\workspace\DOANPQSHOP\Img\TabPageImage\VIP.jpg"));
                tabControl1.ImageList = ico;
                tabPage1.ImageIndex = 0;
                tabPage2.ImageIndex = 1;
                tabPage3.ImageIndex = 2;
                tabPage4.ImageIndex = 3;
                tabPage5.ImageIndex = 4;
                tabPage6.ImageIndex = 5;
                //////////

            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng tên CSDL ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Visible = false;
                Helpcs help = new Helpcs();
                help.ShowDialog();
                help.Close();
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------
        //Bảng nhân viên
        private void HienThiNV(DataGridView dvg)
        {
            BAL_NHANVIEN xuli = new BAL_NHANVIEN();
            dvg.DataSource = xuli.LayDSNV();
        }
        private void HienThiMaNV(ComboBox cbMa)
        {
            var xuli = new BAL_NHANVIEN();
            cbMa.DisplayMember = "MaNV";
            cbMa.DataSource = xuli.LayDSMaNV();
        }
        private int cot = -1;
        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cot = e.RowIndex;
                DataGridViewRow row = dgvNV.Rows[cot];
                tbMaNV.Text = row.Cells[0].Value.ToString();
                tbHoTen.Text = row.Cells[1].Value.ToString();
                tbCMND.Text = row.Cells[2].Value.ToString();
                tbDChi.Text = row.Cells[3].Value.ToString();
                tbSDT.Text = row.Cells[4].Value.ToString();
                if (String.IsNullOrEmpty(tbMaNV.Text))
                    tbMaNV.Enabled = true;
                else
                    tbMaNV.Enabled = false;
            }
            catch (Exception err)
            {

            }
        }
        private void HienThiXOA(DataGridView dvg)
        {
            BAL_NHANVIEN xuli = new BAL_NHANVIEN();
            dvg.DataSource = xuli.LayDSNVXOA();
        }
        private bool XoaNV(string ma)
        {
            ma = tbMaNV.Text;
            bool kq = false;
            BAL_NHANVIEN xuli = new BAL_NHANVIEN();
            if (xuli.XoaNV(ma) == true)
                return kq = true;
            return false;
        }
        private bool phuchoinv()
        {
            bool kq = false;
            var xuli = new BAL_NHANVIEN();
            if (xuli.Phuchoi() == true)
                return kq = true;
            return false;

        }
        private bool phuchoinvtheoma(string ma)
        {
            bool kq = false;
            var xuli = new BAL_NHANVIEN();
            if (xuli.Phuchoitheoma(ma) == true)
                return kq = true;
            return false;
        }

        private void radMaNV_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radMaNV.Checked == true)
            {
                tbTimTenNV.Enabled = false;
                cbTimMaNV.Enabled = true;
                label14.ForeColor = Color.Red;
                label15.ForeColor = Color.Black;
            }
        }

        private void radTenNV_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radTenNV.Checked == true)
            {
                cbTimMaNV.Enabled = false;
                tbTimTenNV.Enabled = true;
                label15.ForeColor = Color.Red;
                label14.ForeColor = Color.Black;
            }
        }
        private void TimMaNV(DataGridView dvg)
        {
            BAL_NHANVIEN xuli = new BAL_NHANVIEN();
            dvg.DataSource = xuli.TimTheoMa(cbTimMaNV.Text);
        }
        private void TimTenNV(DataGridView dvg)
        {
            BAL_NHANVIEN xuli = new BAL_NHANVIEN();
            dvg.DataSource = xuli.TimTheoTen(tbTimTenNV.Text);
        }
        private void btThemNV_Click(object sender, EventArgs e)
        {
            var Xuly = new BAL_NHANVIEN();
            var nv = new BEL_NHANVIEN();
            dgvNV.DataSource = null;
            nv.MaNV = tbMaNV.Text.ToString();
            nv.TenNV = tbHoTen.Text.ToString();
            nv.CMND_NV = tbCMND.Text.ToString();
            nv.DiaChi_NV = tbDChi.Text.ToString();
            nv.SDT_NV = tbSDT.Text.ToString();
            nv.TTinh = "1";
            if (String.IsNullOrEmpty(tbMaNV.Text))
            {
                MessageBox.Show("Not ADD Because Not ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HienThiNV(dgvNV);
                tbMaNV.Focus();
            }
            else
            {
                if (Xuly.Kiemtratrungmanv(nv.MaNV) == true)
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (Xuly.Themnv(nv) == true)
                {
                    MessageBox.Show("Thêm dữ liệu thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNV.DataSource = Xuly.LayDSNV();
                    HienThiNV(dgvNV);
                    tbMaNV.Text = "";
                    tbHoTen.Text = "";
                    tbDChi.Text = "";
                    tbSDT.Text = "";
                    tbCMND.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại vui lòng xem lại thông tin nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNV.DataSource = Xuly.LayDSNV(); ;
                    tbMaNV.Focus();
                }
            }
        }
        private void btXoaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaNV.Text))
                MessageBox.Show("Chọn nhân viên đi nào!", "Có OK chưa anh/chị?");
            else
            {
                if (XoaNV(tbMaNV.Text) == true)
                {
                    foreach (DataGridViewRow item in this.dgvNV.SelectedRows)
                    {
                        dgvNV.Rows.RemoveAt(item.Index);
                    }
                }
                MessageBox.Show("Xóa gòi!", "Có OK chưa anh/chị?");
                HienThiXOA(dgvNV);
                tbMaNV.Text = null;
                tbHoTen.Text = null;
                tbCMND.Text = null;
                tbDChi.Text = null;
                tbSDT.Text = null;
            }
        }
        private void btSuaNV_Click(object sender, EventArgs e)
        {
            var Xuly = new BAL_NHANVIEN();
            var nv = new BEL_NHANVIEN();
            nv.MaNV = tbMaNV.Text.ToString();
            nv.TenNV = tbHoTen.Text.ToString();
            nv.CMND_NV = tbCMND.Text.ToString();
            nv.DiaChi_NV = tbDChi.Text.ToString();
            nv.SDT_NV = tbSDT.Text.ToString();
            nv.TTinh = "1";
            if (Xuly.CapNhapnv(nv, tbMaNV.Text) == true)
            {
                MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNV.DataSource = Xuly.LayDSNV();
                HienThiNV(dgvNV);
                tbMaNV.Text = "";
                tbHoTen.Text = "";
                tbDChi.Text = "";
            }
            else
            {
                MessageBox.Show("Update thất bại vui lòng xem lại thông tin nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNV.DataSource = Xuly.LayDSNV(); ;
                tbMaNV.Focus();

            }
        }
        private void btTimNV_Click(object sender, EventArgs e)
        {
            var xuli = new BAL_NHANVIEN();
            if (radMaNV.Checked == false && radTenNV.Checked == false)
            {
                MessageBox.Show("Chọn chế độ tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radMaNV.Checked == true)
            {
                tbTimTenNV.Text = null;
                TimMaNV(dgvNV);
                cbTimMaNV.Text = null;
            }
            if (radTenNV.Checked == true)
            {
                cbTimMaNV.Text = null;
                TimTenNV(dgvNV);
                tbTimTenNV.Text = null;
            }
        }
        private void btRe_Click(object sender, EventArgs e)
        {
            string ma = tbMaReNV.Text.ToString();
            if (phuchoinvtheoma(ma) == true)
            {
                HienThiNV(dgvNV);
                tbMaReNV.Text = null;
                MessageBox.Show("Phục hồi thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Nhập lại mã đi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------
        //BẢNG MẶT HÀNG
        private void HienThiHang(DataGridView dvg)
        {
            KTSLHang();
            UpDaTruHD();
            BAL_Hang xuli = new BAL_Hang();
            dvg.DataSource = xuli.LayDSHang();

        }
        private void HienThiMaHang(ComboBox cbMaHang)
        {
            var xuli = new BAL_Hang();
            cbMaHang.DisplayMember = "MaHang";
            cbMaHang.DataSource = xuli.LayDSMaHang();
        }
        private int cothang = -1;
        private void dgvHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            var xuli = new BAL_Hang();

            try
            {
                cothang = e.RowIndex;
                DataGridViewRow row = dgvHang.Rows[cothang];
                tbMaHang.Text = row.Cells[0].Value.ToString();
                tbTenHang.Text = row.Cells[1].Value.ToString();
                tbSL.Text = row.Cells[2].Value.ToString();
                tbLoai.Text = row.Cells[3].Value.ToString();
                tbNCC.Text = row.Cells[5].Value.ToString();
                tbGia.Text = row.Cells[4].Value.ToString();
                dt = xuli.LayHinh(tbMaHang.Text);
                string hinh = dt.Rows[0]["Hinh"].ToString();
                pictureBox1.Image = Image.FromFile(hinh);
                tbMaHang.Enabled = false;
            }
            catch (Exception err)
            {
                tbMaHang.Enabled = true;
            }
        }
        private bool XoaHang(string ma)
        {
            ma = tbMaHang.Text;
            bool kq = false;
            BAL_Hang xuli = new BAL_Hang();
            if (xuli.XoaHang(ma) == true)
                return kq = true;
            return false;
        }
        private bool phuchoihangtheoma(string ma)
        {
            bool kq = false;
            var xuli = new BAL_Hang();
            if (xuli.Phuchoitheoma(ma) == true)
                return kq = true;
            return false;

        }
        private void HienThiXOAHANG(DataGridView dvg)
        {
            BAL_Hang xuli = new BAL_Hang();
            dvg.DataSource = xuli.LayDSHANGXOA();
        }
        private bool phuchoihang()
        {
            bool kq = false;
            BAL_Hang xuli = new BAL_Hang();
            if (xuli.Phuchoi() == true)
                return kq = true;
            return false;
        }
        private void radTimMaHang_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radTimMaHang.Checked == true)
            {
                tbTimTenHang.Enabled = false;
                radTimTenHang.Checked = false;
                label16.ForeColor = Color.Red;
                label17.ForeColor = Color.Black;
                cbMaHang.Enabled = true;
            }
        }

        private void radTimTenHang_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radTimTenHang.Checked == true)
            {
                cbMaHang.Enabled = false;
                radTimMaHang.Checked = false;
                label17.ForeColor = Color.Red;
                label16.ForeColor = Color.Black;
                tbTimTenHang.Enabled = true;
            }
        }
        private void TimMaHang(DataGridView dvg)
        {
            BAL_Hang xuli = new BAL_Hang();
            dvg.DataSource = xuli.TimTheoMaHang(cbMaHang.Text);
        }
        private void TimTenHang(DataGridView dvg)
        {
            BAL_Hang xuli = new BAL_Hang();
            dvg.DataSource = xuli.TimTheoTenHang(tbTimTenHang.Text);
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
        private void btThemHang_Click(object sender, EventArgs e)
        {
            HienThiNV(dgvNV);
            var Xuly = new BAL_Hang();
            var hang = new BEL_Hang();
            var style = new DataGridViewCellStyle();
            style.BackColor = Color.Red;
            var style1 = new DataGridViewCellStyle();
            style1.BackColor = Color.White;
            dgvNV.DataSource = null;
            hang.MaHang = tbMaHang.Text.ToString();
            hang.TenHang = tbTenHang.Text.ToString();
            hang.SoLuong = tbSL.Text.ToString();
            hang.Loai = tbLoai.Text.ToString();
            hang.NCC = tbNCC.Text.ToString();
            hang.TThai = "1";
            hang.Hinh = tbMo.Text.ToString();
            hang.Gia = tbGia.Text.ToString();
            if (String.IsNullOrEmpty(tbMaHang.Text))
            {
                MessageBox.Show("Not ADD Because Not ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HienThiHang(dgvHang);
                HienThiNV(dgvNV);
                tbMaHang.Focus();
            }
            else
            {
                if (Xuly.Kiemtratrungmahang(hang.MaHang) == true)
                {
                    MessageBox.Show("Mã hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (Xuly.Themhang(hang) == true)
                {
                    MessageBox.Show("Thêm dữ liệu thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvHang.DataSource = Xuly.LayDSHang();
                    HienThiHang(dgvHang);
                    
                    float sosanh = 0;
                    int sc = dgvHang.Rows.Count;
                    for (int i = 0; i < sc - 1; i++)
                    {
                        if (sosanh == float.Parse(dgvHang.Rows[i].Cells[2].Value.ToString()))
                        {
                            dgvHang.Rows[i].DefaultCellStyle = style;
                            //dgvHang.RowsDefaultCellStyle.BackColor = Color.White;
                            //dgvHang.AlternatingRowsDefaultCellStyle.BackColor = Color.Red;
                        }
                        else
                            dgvHang.Rows[i].DefaultCellStyle = style1;
                    }

                    tbMaHang.Text = "";
                    tbTenHang.Text = "";
                    tbSL.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại vui lòng xem lại thông tin nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvHang.DataSource = Xuly.LayDSHang(); ;
                    tbMaHang.Focus();
                }
            }
        }

        private void btXoaHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaHang.Text))
                MessageBox.Show("Chọn mặt hàng đi nào !", "Có OK chưa anh/chị?");
            else
            {
                if (XoaHang(tbMaHang.Text) == true)
                {
                    foreach (DataGridViewRow item in this.dgvNV.SelectedRows)
                    {
                        dgvHang.Rows.RemoveAt(item.Index);
                    }
                }
                MessageBox.Show("Xóa gòi!", "Có OK chưa anh/chị?");
                HienThiXOAHANG(dgvHang);
                tbMaHang.Text = null;
                tbTenHang.Text = null;
                tbSL.Text = null;
                tbLoai.Text = null;
                tbNCC.Text = null;
                tbMo.Text = null;
            }
        }

        private void btSuaHang_Click(object sender, EventArgs e)
        {
            var style = new DataGridViewCellStyle();
            style.BackColor = Color.Red;
            var style1 = new DataGridViewCellStyle();
            style1.BackColor = Color.White;
            var Xuly = new BAL_Hang();
            var Hang = new BEL_Hang();
            DataTable dt = new DataTable();
            dt = Xuly.LayHinh(tbMaHang.Text);
            string hinh = dt.Rows[0]["Hinh"].ToString();
            dgvHang.DataSource = null;
            Hang.MaHang = tbMaHang.Text.ToString();
            Hang.TenHang = tbTenHang.Text.ToString();
            Hang.SoLuong = tbSL.Text.ToString();
            Hang.Loai = tbLoai.Text.ToString();
            Hang.NCC = tbNCC.Text.ToString();
            Hang.TThai = "1";
            if (string.IsNullOrEmpty(tbMo.Text))
            {
                Hang.Hinh = hinh;
            }
            else
            {
                Hang.Hinh = tbMo.Text.ToString();
            }
            if (Xuly.CapNhaphang(Hang, tbMaHang.Text) == true)
            {
                MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNV.DataSource = Xuly.LayDSHang();
                HienThiHang(dgvHang);
                float sosanh = 0;
                int sc = dgvHang.Rows.Count;
                for (int i = 0; i < sc - 1; i++)
                {
                    if (sosanh == float.Parse(dgvHang.Rows[i].Cells[2].Value.ToString()))
                    {
                        dgvHang.Rows[i].DefaultCellStyle = style;
                        //dgvHang.RowsDefaultCellStyle.BackColor = Color.White;
                        //dgvHang.AlternatingRowsDefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                        dgvHang.Rows[i].DefaultCellStyle = style1;
                }

                tbMaHang.Text = "";
                tbTenHang.Text = "";
                tbSL.Text = "";
                tbLoai.Text = "";
                tbNCC.Text = "";
                tbMo.Text = "";
            }
            else
            {
                MessageBox.Show("Update thất bại vui lòng xem lại thông tin nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvHang.DataSource = Xuly.LayDSHang();
                tbMaHang.Focus();
            }
        }

        private void btSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogOpen = new OpenFileDialog();
            dialogOpen.Filter = "";
            dialogOpen.Title = "Application open";
            string filename = null;
            if (dialogOpen.ShowDialog() == DialogResult.OK)
            {
                filename = dialogOpen.FileName;
                tbMo.Text = filename;
                pictureBox1.Image = Image.FromFile(tbMo.Text);
            }
        }

        private void btTimHang_Click(object sender, EventArgs e)
        {
            var xuli = new BAL_Hang();
            if (radTimMaHang.Checked == false && radTimTenHang.Checked == false)
            {
                MessageBox.Show("Chọn chế độ tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radTimMaHang.Checked == true)
            {
                tbTimTenHang.Text = null;
                TimMaHang(dgvHang);
                cbMaHang.Text = null;
            }
            if (radTimTenHang.Checked == true)
            {
                cbMaHang.Text = null;
                TimTenHang(dgvHang);
                tbTimTenHang.Text = null;
            }
        }

        private void btReH_Click(object sender, EventArgs e)
        {
            string ma = tbReHang.Text.ToString();
            if (phuchoihangtheoma(ma) == true)
            {
                HienThiHang(dgvHang);
                tbReHang.Text = null;
                MessageBox.Show("Phục hồi thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Nhập lại mã đi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------
        //Bảng Tài Khoản Nhân Viên
        private int cotTK = -1;
        private void HienThiTKNV(DataGridView dvg)
        {
            BAL_NHANVIEN xuli = new BAL_NHANVIEN();
            dvg.DataSource = xuli.LayDSTKNV();
        }
        private void dgvTKNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cotTK = e.RowIndex;
                DataGridViewRow row = dgvTKNV.Rows[cotTK];
                cbMaNV_Nhap_TK.Text = row.Cells[0].Value.ToString();
                tbTKNV.Text = row.Cells[1].Value.ToString();
                tbMKNV.Text = row.Cells[2].Value.ToString();
                btMa.Enabled = true;
                tbMKDaMaHoa.Text = null;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        int Dem = 0;

        private void HienThiXoaTK(DataGridView dvg)
        {
            BAL_NHANVIEN xuli = new BAL_NHANVIEN();
            dvg.DataSource = xuli.LayDSTKNVXOA();
        }
        private bool XoaTKNV(string ma)
        {
            bool kq = false;
            BAL_NHANVIEN xuli = new BAL_NHANVIEN();
            if (xuli.XoaTKNV(ma) == true)
                return kq = true;
            return false;
        }
       
        private void TimMaTKNV(DataGridView dvg)
        {
            BAL_NHANVIEN xuli = new BAL_NHANVIEN();
            dvg.DataSource = xuli.TimTheoMaTK(cbMaNV_Tim_TK.Text);
        }

        private bool phuchoitknvtheoma(string ma)
        {
            bool kq = false;
            var xuli = new BAL_NHANVIEN();
            if (xuli.Phuchoitktheoma(ma) == true)
                return kq = true;
            return false;
        }

        private void btThemTKNV_Click(object sender, EventArgs e)
        {
            HienThiNV(dgvNV);
            if (Dem == 0)
            {
                MessageBox.Show("Vui lòng làm đúng thao tác, mã hoá mật khẩu thành công rồi thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMKMaHoa.Focus();
            }
            else
            {
                var Xuly = new BAL_NHANVIEN();
                var nv = new BEL_NHANVIEN();
                dgvNV.DataSource = null;
                nv.MaNV = cbMaNV_Nhap_TK.Text.ToString();
                nv.TK = tbTKNV.Text.ToString();
                nv.MK = tbMKNV.Text.ToString();
                nv.TTinh = "1";

                if (Xuly.KiemtratrungmanvTKNV(cbMaNV_Nhap_TK.Text) == true)
                {
                    MessageBox.Show("Mã số nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbMaNV_Nhap_TK.Focus();
                }
                if (Xuly.Themtknv(nv) == true)
                {
                    MessageBox.Show("Thêm dữ liệu thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTKNV.DataSource = Xuly.LayDSTKNV();
                    HienThiTKNV(dgvTKNV);
                    tbMaNV.Text = null;
                    tbTKNV.Text = null;
                    tbMKNV.Text = null;
                    tbMKMaHoa.Text = null;
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại vui lòng xem lại thông tin nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNV.DataSource = Xuly.LayDSNV(); ;
                    tbMaNV.Focus();

                }
                Dem = 0;
            }
        }

        private void btXoaTKNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbMaNV_Nhap_TK.Text))
                    MessageBox.Show("Chọn nhân viên đi nào!", "Có OK chưa anh/chị?");
                else
                {
                    if (XoaTKNV(cbMaNV_Nhap_TK.Text) == true)
                    {
                        foreach (DataGridViewRow item in this.dgvTKNV.SelectedRows)
                        {
                            dgvTKNV.Rows.RemoveAt(item.Index);
                        }
                    }
                    MessageBox.Show("Xóa gòi!", "Có OK chưa anh/chị?");
                    HienThiXoaTK(dgvTKNV);
                    tbTKNV.Text = null;
                    tbMKNV.Text = null;
                }
            }
            catch
            {
                MessageBox.Show("Vui Lòng Chọn Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSuaTKNV_Click(object sender, EventArgs e)
        {
            if (Dem == 0)
            {
                MessageBox.Show("Vui lòng làm đúng thao tác, mã hoá mật khẩu thành công rồi cập nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMKMaHoa.Focus();
            }
            else
            {
                var Xuly = new BAL_NHANVIEN();
                var nv = new BEL_NHANVIEN();
                nv.MaNV = cbMaNV_Nhap_TK.Text.ToString();
                nv.TK = tbTKNV.Text.ToString();
                nv.MK = tbMKNV.Text.ToString();
                nv.TTinh = "1";
                if (Xuly.CapNhapTKnv(nv, cbMaNV_Nhap_TK.Text) == true)
                {
                    MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTKNV.DataSource = Xuly.LayDSTKNV();
                    HienThiTKNV(dgvTKNV);
                    cbMaNV_Nhap_TK.Text = null;
                    tbMKMaHoa.Text = null;
                    tbTKNV.Text = null;
                    tbMKNV.Text = null;
                }
                else
                {
                    MessageBox.Show("Update thất bại vui lòng xem lại thông tin nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTKNV.DataSource = Xuly.LayDSTKNV();
                    cbMaNV_Nhap_TK.Focus();

                }
                Dem = 0;
            }
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            tbMKNV.Text = Encrytion.Mahoa(tbMKMaHoa.Text);
            Dem++;
        }

        private void btMa_Click(object sender, EventArgs e)
        {
            var KTMAHOA = new MaHoa();
            KTMAHOA.ShowDialog();
            flag = KTMAHOA.flag;
            if (flag == true)
            {
                tbMKDaMaHoa.Text = Encrytion.GiaiMa(tbMKNV.Text);
                btMa.Enabled = false;
            }
            else
                MessageBox.Show("Không phải Admin mà cứ thích xem mật khẩu thế nhò! ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btReTKNV_Click(object sender, EventArgs e)
        {
            string ma = tbMaNVPhucHoi_TK.Text.ToString();
            if (phuchoitknvtheoma(ma) == true)
            {
                HienThiTKNV(dgvTKNV);
                tbMaNVPhucHoi_TK.Text = null;
                MessageBox.Show("Phục hồi thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Nhập lại mã đi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btTimTKNV_Click(object sender, EventArgs e)
        {
            TimMaTKNV(dgvTKNV);
        }



        //-------------------------------------------------------------------------------------------------------------------------------------------------
        //Bảng Hoá Đơn
        private int CotHD = -1;
        private void HienThiHoaDon(DataGridView dvg)
        {
            BAL_HD xuli = new BAL_HD();
            dvg.DataSource = xuli.LayDSHD_HD();
        }
        private void HienThiMaHD(ComboBox cbMaHD)
        {
            var xuli = new BAL_HD();
            cbMaHD_HD.DisplayMember = "MaHoaDon";
            cbMaHD.DataSource = xuli.LayDSMaHD();
        }
        private void dgvHD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CotHD = e.RowIndex;
                DataGridViewRow row = dgvHD.Rows[CotHD];
                cbMaHD_HD.Text = row.Cells[0].Value.ToString();
                tbTenNV_HD.Text = row.Cells[7].Value.ToString();
                if (string.IsNullOrEmpty(tbTenNV_HD.Text))
                {
                    cbMaHD_HD.Text = null;
                    radMaHD_HD.Enabled = true;
                    radTenNV_HD.Enabled = true;
                    cbMaHD_HD.Enabled = true;
                    btTim_HD.Enabled = true;
                    tbTenNV_HD.Enabled = true;
                    btPhucHoi_HD.Enabled = true;
                    btXoa_HD.Enabled = false;
                }
                else
                {
                    radMaHD_HD.Enabled = false;
                    radTenNV_HD.Enabled = false;
                    cbMaHD_HD.Enabled = false;
                    btTim_HD.Enabled = false;
                    tbTenNV_HD.Enabled = false;
                    btPhucHoi_HD.Enabled = false;
                    btXoa_HD.Enabled = true;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool XoaHD(string ma)
        {
            ma = cbMaHD_HD.Text;
            bool kq = false;
            BAL_HD xuli = new BAL_HD();
            if (xuli.XoaHD(ma) == true)
                return kq = true;
            return false;
        }
       
        private void HienThiXOAHD(DataGridView dvg)
        {
            BAL_HD xuli = new BAL_HD();
            dvg.DataSource = xuli.LayDSHDXoa();
        }
        private void radMaHD_HD_CheckedChanged(object sender, EventArgs e)
        {
            if (radMaHD_HD.Checked == true)
            {
                radMaHD_HD.ForeColor = Color.Red;
                tbTenNV_HD.Enabled = false;
                radTenNV_HD.ForeColor = Color.Black;
                cbMaHD_HD.Enabled = true;
            }
        }
        private void radTenNV_HD_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenNV_HD.Checked == true)
            {
                radTenNV_HD.ForeColor = Color.Red;
                cbMaHD_HD.Enabled = false;
                radMaHD_HD.ForeColor = Color.Black;
                tbTenNV_HD.Enabled = true;
            }
        }
        private void TimMaHD(DataGridView dvg)
        {
            BAL_HD xuli = new BAL_HD();
            dvg.DataSource = xuli.TimTheoMaHD(cbMaHD_HD.Text);
        }
        private void TimTenNV_HD(DataGridView dvg)
        {
            BAL_HD xuli = new BAL_HD();
            dvg.DataSource = xuli.TimTheoTenNV(tbTenNV_HD.Text);
        }
       
        private bool phuchoihoadontheoma(string ma)
        {
            bool kq = false;
            var xuli = new BAL_HD();
            if (xuli.Phuchoitheoma(ma) == true)
                return kq = true;
            return false;
        }
        private bool phuchoihoadontheoten(string ten)
        {
            bool kq = false;
            var xuli = new BAL_HD();
            if (xuli.Phuchoitheoten(ten) == true)
                return kq = true;
            return false;

        }
      
        public void tinhtongsp()
        {
            int sc = dgvHD.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvHD.Rows[i].Cells["Tong_HD"].Value.ToString());
            tbTongThu_HD.Text = thanhtien.ToString();
            lbTongThu.Text = thanhtien.ToString() + "$";
        }
        public void tinhtonggiamsp()
        {
            int sc = dgvHD.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvHD.Rows[i].Cells["Giam_HD"].Value.ToString());
            tbTongGiam_HD.Text = thanhtien.ToString();
        }
        public void tinhtongslsp()
        {
            int sc = dgvHD.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvHD.Rows[i].Cells["SoLuong_HD"].Value.ToString());
            tbSL_HD.Text = thanhtien.ToString();
            lbTongSLBan.Text = thanhtien.ToString() + " SP";
        }

        private void tbTinh_HD_Click_1(object sender, EventArgs e)
        {
            tinhtongsp();
            tinhtonggiamsp();
            tinhtongslsp();
        }

        private void btTim_HD_Click_1(object sender, EventArgs e)
        {
            var xuli = new BAL_HD();
            if (radMaHD_HD.Checked == false && radTenNV_HD.Checked == false)
            {
                MessageBox.Show("Chọn chế độ tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radMaHD_HD.Checked == true)
            {
                tbTenNV_HD.Text = null;
                TimMaHD(dgvHD);
            }
            if (radTenNV_HD.Checked == true)
            {
                cbMaHD_HD.Text = null;
                TimTenNV_HD(dgvHD);
                tbTenNV_HD.Text = null;
            }
        }

        private void btXoa_HD_Click(object sender, EventArgs e)
        {
            DialogResult Xoa = MessageBox.Show("Bạn Chắc chắn muốn xoá hoá đơn?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            try
            {
                if (Xoa == DialogResult.Yes)
                {
                    if (XoaHD(cbMaHD_HD.Text) == true)
                    {
                        foreach (DataGridViewRow item in this.dgvHD.SelectedRows)
                        {
                            dgvHD.Rows.RemoveAt(item.Index);
                        }
                        MessageBox.Show("Xóa gòi!", "Có OK chưa anh/chị?");
                    }
                    
                    HienThiXOAHD(dgvHD);
                }
                else
                {
                    HienThiHoaDon(dgvHD);
                    cbMaHD_HD.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Chọn hóa đơn", "Error", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btPhucHoi_HD_Click_1(object sender, EventArgs e)
        {
            if (radMaHD_HD.Checked == false && radTenNV_HD.Checked == false)
            {
                MessageBox.Show("Chọn kiểu phục hồi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (radMaHD_HD.Checked == true)
                {
                    string ma = cbMaHD_HD.Text;
                    if (phuchoihoadontheoma(ma) == true)
                    {
                        HienThiHoaDon(dgvHD);
                        MessageBox.Show("Phục hồi thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Nhập lại mã đi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string ten = tbTenNV_HD.Text;

                    DialogResult Re = MessageBox.Show("Bạn muốn phục hồi tất cả hoá đơn của nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Re == DialogResult.Yes)
                    {
                        if (phuchoihoadontheoten(ten) == true)
                        {
                            HienThiHoaDon(dgvHD);
                            MessageBox.Show("Phục hồi thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Nhập lại mã đi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        btPhucHoi_HD.Focus();
                }

            }
        }

        private void btXem_HD_Click(object sender, EventArgs e)
        {
            var xuli = new BAL_HD();
            if (cbXemAll_HD.Checked == true)
            {
                HienThiHoaDon(dgvHD);
                Xem = 1;
            }
            else
            {
                if (dtp1.Value.Day > dtp2.Value.Day || dtp1.Value.Month > dtp2.Value.Month || dtp1.Value.Year > dtp2.Value.Year)
                    MessageBox.Show("Tháng trước phải lớn hơn tháng sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    dgvHD.DataSource = xuli.LayDSHD_TheoNgay(dtp1.Value.Day, dtp2.Value.Day, dtp1.Value.Month, dtp2.Value.Month);
                    Xem = 1;
                }
            }

        }

        private void cbXemAll_HD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbXemAll_HD.Checked == true)
            {
                dtp1.Enabled = false;
                dtp2.Enabled = false;
            }
            else
            {
                dtp1.Enabled = true;
                dtp2.Enabled = true;
            }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------
        //Bảng Thống Kê
        public int tinhtongAO()
        {
            int sc = dgvHD.Rows.Count;
            int tong = 0;
            string LoaiHang = null;
            for (int i = 0; i < sc - 1; i++)
            {
                LoaiHang = dgvHD.Rows[i].Cells["LoaiHang_HD"].Value.ToString();
                if (LoaiHang.Trim().Equals("AO"))
                    tong += int.Parse(dgvHD.Rows[i].Cells["SoLuong_HD"].Value.ToString());
            }
            return tong;
        }
        public int tinhtongAK()
        {
            int sc = dgvHD.Rows.Count;
            int tong = 0;
            string LoaiHang = null;
            for (int i = 0; i < sc - 1; i++)
            {
                LoaiHang = dgvHD.Rows[i].Cells["LoaiHang_HD"].Value.ToString();
                if (LoaiHang.Trim().Equals("AK"))
                    tong += int.Parse(dgvHD.Rows[i].Cells["SoLuong_HD"].Value.ToString());
            }
            return tong;
        }
        public int tinhtongQN()
        {
            int sc = dgvHD.Rows.Count;
            int tong = 0;
            string LoaiHang = null;
            for (int i = 0; i < sc - 1; i++)
            {
                LoaiHang = dgvHD.Rows[i].Cells["LoaiHang_HD"].Value.ToString();
                if (LoaiHang.Trim().Equals("QN"))
                    tong += int.Parse(dgvHD.Rows[i].Cells["SoLuong_HD"].Value.ToString());
            }
            return tong;
        }
        public int tinhtongGA()
        {
            int sc = dgvHD.Rows.Count;
            int tong = 0;
            string LoaiHang = null;
            for (int i = 0; i < sc - 1; i++)
            {
                LoaiHang = dgvHD.Rows[i].Cells["LoaiHang_HD"].Value.ToString();
                if (LoaiHang.Trim().Equals("GA"))
                    tong += int.Parse(dgvHD.Rows[i].Cells["SoLuong_HD"].Value.ToString());
            }
            return tong;
        }
        public int tinhtongPK()
        {
            int sc = dgvHD.Rows.Count;
            int tong = 0;
            string LoaiHang = null;
            for (int i = 0; i < sc - 1; i++)
            {
                LoaiHang = dgvHD.Rows[i].Cells["LoaiHang_HD"].Value.ToString();
                if (LoaiHang.Trim().Equals("PK"))
                    tong += int.Parse(dgvHD.Rows[i].Cells["SoLuong_HD"].Value.ToString());
            }
            return tong;
        }
        public double tinhtongtienAO()
        {
            int sc = dgvHD.Rows.Count;
            double tong = 0;
            string LoaiHang = null;
            for (int i = 0; i < sc - 1; i++)
            {
                LoaiHang = dgvHD.Rows[i].Cells["LoaiHang_HD"].Value.ToString();
                if (LoaiHang.Trim().Equals("AO"))
                    tong += double.Parse(dgvHD.Rows[i].Cells["Tong_HD"].Value.ToString());
            }
            return tong;
        }
        public double tinhtongtienAK()
        {
            int sc = dgvHD.Rows.Count;
            double tong = 0;
            string LoaiHang = null;
            for (int i = 0; i < sc - 1; i++)
            {
                LoaiHang = dgvHD.Rows[i].Cells["LoaiHang_HD"].Value.ToString();
                if (LoaiHang.Trim().Equals("AK"))
                    tong += double.Parse(dgvHD.Rows[i].Cells["Tong_HD"].Value.ToString());
            }
            return tong;
        }
        public double tinhtongtienQN()
        {
            int sc = dgvHD.Rows.Count;
            double tong = 0;
            string LoaiHang = null;
            for (int i = 0; i < sc - 1; i++)
            {
                LoaiHang = dgvHD.Rows[i].Cells["LoaiHang_HD"].Value.ToString();
                if (LoaiHang.Trim().Equals("QN"))
                    tong += double.Parse(dgvHD.Rows[i].Cells["Tong_HD"].Value.ToString());
            }
            return tong;
        }
        public double tinhtongtienGA()
        {
            int sc = dgvHD.Rows.Count;
            double tong = 0;
            string LoaiHang = null;
            for (int i = 0; i < sc - 1; i++)
            {
                LoaiHang = dgvHD.Rows[i].Cells["LoaiHang_HD"].Value.ToString();
                if (LoaiHang.Trim().Equals("GA"))
                    tong += double.Parse(dgvHD.Rows[i].Cells["Tong_HD"].Value.ToString());
            }
            return tong;
        }
        public double tinhtongtienPK()
        {
            int sc = dgvHD.Rows.Count;
            double tong = 0;
            string LoaiHang = null;
            for (int i = 0; i < sc - 1; i++)
            {
                LoaiHang = dgvHD.Rows[i].Cells["LoaiHang_HD"].Value.ToString();
                if (LoaiHang.Trim().Equals("PK"))
                    tong += double.Parse(dgvHD.Rows[i].Cells["Tong_HD"].Value.ToString());
            }
            return tong;
        }
        string[] seriarr = { "Áo", "Áo Khoác", "Quần", "Giày", "Phụ Kiện" };
        private void BieuDo()
        {

            int a = tinhtongAO();
            int b = tinhtongAK();
            int c = tinhtongQN();
            int d = tinhtongGA();
            int e = tinhtongPK();
            this.chart1.Series.Clear();
            this.chart2.Series.Clear();
            int[] poit = { a, b, c, d, e };
            this.chart1.Series.Clear();
            for (int j = 0; j < seriarr.Length; j++)
            {
                Series seri = this.chart1.Series.Add(seriarr[j]);
                seri.Points.Add(poit[j]);
            }

            double f = tinhtongtienAO();
            double g = tinhtongtienAK();
            double h = tinhtongtienQN();
            double i = tinhtongtienGA();
            double k = tinhtongtienPK();
            double[] poit1 = { f, g, h, i, k };
            this.chart2.Series.Clear();
            //chart2.Titles.Add("Doanh Thu Hằng Tháng");
            //chart2.Series[0].ChartType = SeriesChartType.Pie;
            for (int j = 0; j < seriarr.Length; j++)
            {
                Series seri = this.chart2.Series.Add(seriarr[j]);
                seri.Points.Add(poit1[j]);
            }
            chart1.Update();
            chart2.Update();

            //chart1.Series["Số Lượng Bán Ra"].Points.AddXY("Áo", tinhtongAO());
            //chart1.Series["Số Lượng Bán Ra"].Points.AddXY("Áo Khoác", tinhtongAK());
            //chart1.Series["Số Lượng Bán Ra"].Points.AddXY("Quần", tinhtongQN());
            //chart1.Series["Số Lượng Bán Ra"].Points.AddXY("Giày", tinhtongGA());
            //chart1.Series["Số Lượng Bán Ra"].Points.AddXY("Phụ Kiện", tinhtongPK());
            //chart1.Update();

            //chart2.Series["Doanh Thu Hằng Tháng"].Points.AddXY("Áo", tinhtongtienAO());
            //chart2.Series["Doanh Thu Hằng Tháng"].Points.AddXY("Áo", tinhtongtienAK());
            //chart2.Series["Doanh Thu Hằng Tháng"].Points.AddXY("Quần", tinhtongtienQN());
            //chart2.Series["Doanh Thu Hằng Tháng"].Points.AddXY("Giày", tinhtongtienGA());
            //chart2.Series["Doanh Thu Hằng Tháng"].Points.AddXY("Phụ Kiện", tinhtongtienPK());
            //chart2.Update();

        }
        /* //private void BieuDo1()
       //{
       //    chart1.Series["Số Lượng Bán Ra"].Points.AddXY("Áo",0);
       //    chart1.Series["Số Lượng Bán Ra"].Points.AddXY("Áo Khoác", 0);
       //    chart1.Series["Số Lượng Bán Ra"].Points.AddXY("Quần",0);
       //    chart1.Series["Số Lượng Bán Ra"].Points.AddXY("Giày",0);
       //    chart1.Series["Số Lượng Bán Ra"].Points.AddXY("Phụ Kiện",0);

       //    chart2.Series["Doanh Thu Hằng Tháng"].Points.AddXY("Áo",0);
       //    chart2.Series["Doanh Thu Hằng Tháng"].Points.AddXY("Áo",0);
       //    chart2.Series["Doanh Thu Hằng Tháng"].Points.AddXY("Quần",0);
       //    chart2.Series["Doanh Thu Hằng Tháng"].Points.AddXY("Giày",0);
       //    chart2.Series["Doanh Thu Hằng Tháng"].Points.AddXY("Phụ Kiện",0);

       //}
       */
        /*
private void button1_Click(object sender, EventArgs e)
{//Biểu đồ hình tròn
string kn = “server = hue02win\HUE02WIN; database = QLHH; uid = sa; pwd = 123”;
string cl = “SELECT * FROM HANGHOA”;
SqlConnection con = new SqlConnection(kn);
SqlCommand cmd = new SqlCommand(cl, con);
SqlDataAdapter ad = new SqlDataAdapter(cmd);
DataSet ds = new DataSet();
ad.Fill(ds);
con.Open();
chart1.DataSource = ds;
chart1.Series[“Salary”].XValueMember = “TENHANG”;
chart1.Series[“Salary”].YValueMembers = “DONGIA”;
chart1.Titles.Add(“Salary Chart”);
//Chuyển kiểu biểu đồ hình tròn
//chart1.Series[0].ChartType = SeriesChartType.Pie;
con.Close();
}
}
*/
        //-------------------------------------------------------------------------------------------------------------------------------------------------
        //Bảng Khách Hàng
        private int CotKH = -1;
        private void HienThiKhachHang(DataGridView dvg)
        {
            BAL_KHACHHANG xuli = new BAL_KHACHHANG();
            dvg.DataSource = xuli.DocSQLHD_KH();
        }
        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CotKH = e.RowIndex;
                DataGridViewRow row = dgvKH.Rows[CotKH];
                cbMa_KH.Text = row.Cells[0].Value.ToString();
                tbSDT_KH.Text = row.Cells[1].Value.ToString();
                tbSoLanMua.Text = row.Cells[2].Value.ToString();
               
            }
            catch 
            {
                
            }
        }

        private void radMaKH_KH_CheckedChanged(object sender, EventArgs e)
        {
            if(radMaKH_KH.Checked == true)
            {
                cbMa_KH.Enabled = true;
                tbSDT_KH.Enabled = false;
                tbSoLanMua.Enabled = false;
            }
            else
            {
                cbMa_KH.Enabled = true;
                tbSDT_KH.Enabled = true;
                tbSoLanMua.Enabled = true;
            }
        }

        private void radSDT_KH_CheckedChanged(object sender, EventArgs e)
        {

            if (radSDT_KH.Checked == true)
            {
                cbMa_KH.Enabled = false;
                tbSDT_KH.Enabled = true;
                tbSDT_KH.Focus();
                tbSoLanMua.Enabled = false;
            }
            else
            {
                cbMa_KH.Enabled = true;
                tbSDT_KH.Enabled = true;
                tbSoLanMua.Enabled = true;
            }
        }

        private void radSoLanMua_KH_CheckedChanged(object sender, EventArgs e)
        {
            if (radSoLanMua_KH.Checked == true)
            {
                cbMa_KH.Enabled = false;
                tbSDT_KH.Enabled = false;
                tbSoLanMua.Enabled = true;
                tbSoLanMua.Focus();
            }
            else
            {
                cbMa_KH.Enabled = true;
                tbSDT_KH.Enabled = true;
                tbSoLanMua.Enabled = true;
            }
        }

        private void HienThiMaKH(ComboBox cbMa_KH)
        {
            var xuli = new BAL_KHACHHANG();
            cbMa_KH.DisplayMember = "MaKH";
            cbMa_KH.DataSource = xuli.LayDSMaKH();
        }

        private void btXem_KH_Click(object sender, EventArgs e)
        {   
            BAL_KHACHHANG xuli = new BAL_KHACHHANG();
            if(radMaKH_KH.Checked == true)
            {
                dgvKH.DataSource = xuli.TimTheoMa(int.Parse(cbMa_KH.Text));
            }
            if(radSDT_KH.Checked == true)
            {
                try
                {
                    dgvKH.DataSource = xuli.TimTheoSDT(tbSDT_KH.Text);
                }
                catch
                {
                    MessageBox.Show("Nhập SDT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (radSoLanMua_KH.Checked == true)
            {
                try
                {
                    dgvKH.DataSource = xuli.TimTheoSoLanMua(tbSoLanMua.Text);
                }
                catch
                {
                    MessageBox.Show("Nhập Số Lần Mua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }




    }
}
