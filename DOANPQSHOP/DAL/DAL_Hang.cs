using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Hang:General
    {
        public DataTable DocSQLHANG(string table1)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select MaHang N'Mã Hàng',TenHang  N'Tên Hàng',SoLuong  N'Số Lượng',Loai  N'Loại Hàng',Gia N'Giá',NhaCungCap N'Nhà Cung Cấp' from " + table1 + " where TThai = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable DocSQLMaHang()
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select MaHang from tbHang";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable LayHinh(string mahang)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select Hinh from tbHang where MaHang = '" + mahang + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable DocSQLMaHangQuaTen(string tenhang)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select MaHang from tbHang where TenHang like N'%" + tenhang + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable DocSQLLoaiHangQuaTen(string tenhang)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select Loai from tbHang where TenHang like N'%" + tenhang + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable DocSQLGiaHangQuaTen(string tenhang)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select Gia from tbHang where TenHang like N'%" + tenhang + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable DocSQLSLHangQuaTen(string tenhang)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select SoLuong from tbHang where TenHang like N'%" + tenhang + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable DocSQLTenHang()
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select TenHang from tbHang";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable TimMaHang(string mahang)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select MaHang N'Mã Hàng',TenHang  N'Tên Hàng',SoLuong  N'Số Lượng',Loai  N'Loại Hàng',NhaCungCap N'Nhà Cung Cấp',Hinh from tbHang where TThai = 1 and MaHang ='" + mahang + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable TimTenHang(string tenhang)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select MaHang N'Mã Hàng',TenHang  N'Tên Hàng',SoLuong  N'Số Lượng',Loai  N'Loại Hàng',NhaCungCap N'Nhà Cung Cấp',Hinh from tbHang where TThai = 1 and TenHang like N'%" + tenhang + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable DocSQLXOAHANG(string table1)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select MaHang N'Mã Hàng',TenHang  N'Tên Hàng',SoLuong  N'Số Lượng',Loai  N'Loại Hàng',NhaCungCap N'Nhà Cung Cấp',Hinh from  " + table1 + " where TThai = 1";
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
        public bool Xoa(string mahang)
        {
            bool kq = false;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("Update tbHang Set TThai = 0 where MaHang = '" + mahang + "'", con);
            if (cmd.ExecuteNonQuery() > 0)
                kq = true;
            return kq;
        }
        public bool phuchoi()
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("Update tbHang Set TThai = 1", con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
                return kq;

            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool phuchoitheoma(string ma)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("Update tbHang Set TThai = 1 WHERE MaHang ='" + ma + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
                return kq;

            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool Themhang(BEL_Hang hang)
        {
            bool ketqua = false;
            try
            {
                GetCon();
                string sql = "INSERT INTO tbHang(MaHang,TenHang,SoLuong,Loai,Gia,NhaCungCap,Hinh,TThai) VALUES('" + hang.MaHang + "',N'" + hang.TenHang + "','" + hang.SoLuong +
                "','" + hang.Loai + "','" + hang.Gia + "',N'" + hang.NCC + "','" + hang.Hinh + "','" + hang.TThai + "')";
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
        public bool Kiemtratrungmahang(string Mahang)
        {
            bool ketqua = false;
            GetCon();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbHang where MaHang ='" + Mahang + "'", con);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                if (cmd.ExecuteNonQuery() > 0)
                    ketqua = true;
                return ketqua;
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool CapNhaphang(BEL_Hang hang, string mahang)
        {
            bool ketqua = false;
            try
            {
                GetCon();
                string sql = "Update tbHang set MaHang ='" + hang.MaHang + "'  ,TenHang = N'" + hang.TenHang +
                "' , SoLuong ='" + hang.SoLuong + "' , Loai ='" + hang.Loai + "', NhaCungCap = '" + hang.NCC + "' ,TThai ='" + hang.TThai + "', Hinh = N'" + hang.Hinh + "' Where MaHang ='" + mahang + "'";
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
        public bool capnhapsl()
        {
            bool ketqua = false;
            try
            {
                GetCon();
                string sql = "UPDATE tbHang SET tbHang.SoLuong = tbHang.SoLuong - tbHoaDon.SoLuong FROM tbHang INNER JOIN tbHoaDon ON(tbHang.TenHang = tbHoaDon.TenHang) where tbHoaDon.DaTru = 'N'";
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
        public DataTable DocSQLTenHang_KH()
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select TenHang,Gia from tbHang where TThai = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable LayHinh_KH(string ten)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select Hinh from tbHang where TenHang like N'%" + ten + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable TimHang_KH(string tenhang)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select TenHang,Gia from tbHang where TThai = 1 and TenHang like N'%" + tenhang + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
    }
}
