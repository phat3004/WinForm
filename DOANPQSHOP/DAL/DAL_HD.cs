using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_HD : General
    {
        public bool ThemHD(BEL_HD hd)
        {
            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "INSERT INTO tbHoaDon(LoaiHang,TenHang,SoLuong,Giam,Tong,TenNV,TThai,DaTru,Trung,NgayLap) VALUES('" + hd.LoaiHang +
                "',N'" + hd.TenHang + "','" + hd.SL + "','" + hd.GiamGia + "','" + hd.Tong + "',N'" + hd.TenNV + "','" + hd.TThai + "','" + hd.Tru + "','" + hd.Trung + "', GETDATE())";
                SqlCommand commmand = new SqlCommand(sql, con);
                if (commmand.ExecuteNonQuery() > 0)
                    ketqua = true;
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }
            return ketqua;
        }
        public DataTable DocSQLHD(string table1, string ten)
        {
            DataTable dt = new DataTable();
            GetCon();
            //string sql = "select MaNV,HoTen,CMND,DChi,SDT from " + table1 + " where TThai = 1";
            string sql = "select MaHoaDon N'Mã Hoá Đơn',LoaiHang  N'Loại',TenHang  N'Tên Hàng',SoLuong 'SL',MaKH 'MaKH',Giam 'Giảm',Tong 'Tổng',TenNV 'Tên NV' from " + table1 + " where DaTru = 'N' and TenNV like N'%" + ten + "%' and Trung = 0";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable DocSQLHD_HD(string table1)
        {
            DataTable dt = new DataTable();
            GetCon();
            //string sql = "select MaNV,HoTen,CMND,DChi,SDT from " + table1 + " where TThai = 1";
            string sql = "select MaHoaDon,LoaiHang,TenHang,SoLuong,MaKM,Giam,Tong,NgayLap,TenNV from " + table1 + " where TThai = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable DocSQLMaHD()
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select MaHoaDon from tbHoaDon where TThai = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable TimMaHD(string mahd)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select MaHoaDon,LoaiHang,TenHang,SoLuong,MaKM,Giam,Tong,TenNV from tbHoaDon where TThai = 1 and MaHoaDon ='" + mahd + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }

        public DataTable TimTenNV(string tennv)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select MaHoaDon,LoaiHang,TenHang,SoLuong,MaKM,Giam,Tong,TenNV from tbHoaDon where TThai = 1 and TenNV like N'%" + tennv + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public bool Xoa(string mahd)
        {
            bool kq = false;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("Update tbHoaDon Set TThai = 0 where MaHoaDon = '" + mahd + "'", con);
            if (cmd.ExecuteNonQuery() > 0)
                kq = true;
            return kq;
        }
        public DataTable DocSQLXOAHD(string table1)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select MaHoaDon,LoaiHang,TenHang,SoLuong,MaKM,Giam,Tong,TenNV from " + table1 + " where TThai = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        //public int LayTongTienBan(string table1)
        //{
        //    DataTable dt = new DataTable();
        //    if (ConnectionState.Closed == con.State)
        //        con.Open();
        //    string sql = "select Sum(Tong) from " + table1;
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    try
        //    {
        //        SqlDataReader rd = cmd.ExecuteReader();
        //        dt.Load(rd);
        //        return dt;
        //    }
        //    catch (Exception err)
        //    {
        //        throw;
        //    }
        //}
        public bool phuchoitheoma(string ma)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("Update tbHoaDon Set TThai = 1 WHERE MaHoaDon ='" + ma + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
                return kq;

            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool phuchoitheoten(string ten)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("Update tbHoaDon Set TThai = 1 WHERE TenNV like'%" + ten + "%'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
                return kq;

            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool CapNhapDaTru()
        {
            bool ketqua = false;
            try
            {
                GetCon();
                string sql = "update tbHoaDon set DaTru = 'Y' where DaTru = 'N' ";
                SqlCommand commmand = new SqlCommand(sql, con);
                if (commmand.ExecuteNonQuery() > 0)
                    ketqua = true;
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }
            return ketqua;
        }
        public bool CapNhaphd(BEL_HD hd)
        {
            bool ketqua = false;
            try
            {
                GetCon();
                string sql = "Update tbHoaDon set LoaiHang = '" + hd.LoaiHang + "'  ,TenHang = N'" + hd.TenHang + "' ,SoLuong ='"
                    + hd.SL + "' , Tong = '" + hd.Tong + "' ,Datru = '" + hd.Tru + "'" +
                    "Where MaHoaDon = '" + hd.MaHD + "'";
                SqlCommand commmand = new SqlCommand(sql, con);
                if (commmand.ExecuteNonQuery() > 0)
                    ketqua = true;
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }
            return ketqua;
        }
        public bool CapNhaphdTrung()
        {
            bool ketqua = false;
            try
            {
                GetCon();
                string sql = "Update tbHoaDon set Trung = 1 Where Trung = 0 ";
                SqlCommand commmand = new SqlCommand(sql, con);
                if (commmand.ExecuteNonQuery() > 0)
                    ketqua = true;
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }
            return ketqua;
        }
        public bool XoaHD(string ma)
        {
            bool ketqua = false;
            try
            {
                GetCon();
                string sql = "delete from tbHoaDon where MaHoaDon = " + ma;
                SqlCommand commmand = new SqlCommand(sql, con);
                if (commmand.ExecuteNonQuery() > 0)
                    ketqua = true;
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }
            return ketqua;
        }
        public DataTable DocSQLHD_TheoNgay(int Ngay1, int Ngay2, int Thang1, int Thang2)
        {
            DataTable dt = new DataTable();
            GetCon();
            //string sql = "select MaNV,HoTen,CMND,DChi,SDT from " + table1 + " where TThai = 1";
            string sql = "select MaHoaDon,LoaiHang,TenHang,SoLuong,Giam,Tong,NgayLap,TenNV,MaKH from tbHoaDon where ((DAY(NgayLap) = " + Ngay1 + " or Day(NgayLap) > " + Ngay1 + ") and (MONTH(NgayLap) = " + Thang1 + " or MONTH(NgayLap) > " + Thang1 + ")) and ((DAY(NgayLap) = " + Ngay2 + " or Day(NgayLap) < " + Ngay2 + ") and (MONTH(NgayLap) = " + Thang2 + " or MONTH(NgayLap) < " + Thang2 + "))";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable DocSQLSaiHD_HD(string table1)
        {
            DataTable dt = new DataTable();
            GetCon();
            //string sql = "select MaNV,HoTen,CMND,DChi,SDT from " + table1 + " where TThai = 1";
            string sql = "select MaHoaDon,LoaiHang,TenHang,SoLuong,Giam,Tong,TenNV,MaKH from " + table1 + " where TThai = 3";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public bool CapNhapKM_MAKH(double giam, int MaKH)
        {
            bool ketqua = false;
            try
            {
                GetCon();
                string sql = "Update tbHoaDon set Giam =" + giam + ", MaKH = " + MaKH + " Where Trung = 0";
                SqlCommand commmand = new SqlCommand(sql, con);
                if (commmand.ExecuteNonQuery() > 0)
                    ketqua = true;
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }
            return ketqua;
        }
        
        
    }
}
