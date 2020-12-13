using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_NHANVIEN : General
    {
        public bool SoSanhTK(string tk, string mk)
        {
            bool kq = false;
            try
            {
                DataTable dt = new DataTable();
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "update tbTKNV set TThai = 1 where TK ='" + tk + "' and MK ='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
                return kq;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable DocSQLNV(string table1)
        {
            DataTable dt = new DataTable();
            GetCon();
            //string sql = "select MaNV,HoTen,CMND,DChi,SDT from " + table1 + " where TThai = 1";
            string sql = "select MaNV N'Mã Nhân Viên',HoTen  N'Họ&Tên',CMND  N'CMND',DChi  N'Địa Chỉ',SDT N'Số Điện Thoại' from " + table1 + " where TThai = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable DocSQLMaNV()
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select MaNV from tbNHANVIEN where TThai = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable TimTheoMa(string manv)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select MaNV N'Mã Nhân Viên',HoTen  N'Họ&Tên',CMND  N'CMND',DChi  N'Địa Chỉ',SDT N'Số Điện Thoại' " +
                "from tbNHANVIEN where MaNV ='" + manv + "' and TThai = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable TimTheoMaTK(string manv)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select MaNV N'Mã Nhân Viên',TK  N'Tài Khoản',MK  N'Mật Khẩu' from tbTKNV where MaNV ='" + manv + "' and TThai = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable TimTheoTen(string tennv)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select MaNV N'Mã Nhân Viên',HoTen  N'Họ&Tên',CMND  N'CMND',DChi  N'Địa Chỉ',SDT N'Số Điện Thoại' " +
                "from tbNHANVIEN where HoTen like N'%" + tennv + "%' and TThai = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable DocSQLTKNV(string table1)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select MaNV N'Mã Nhân Viên',TK N'Tài Khoản', MK N'Mật Khẩu' from " + table1 + " where TThai = 1";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }

        public DataTable DocSQLXOANV(string table1)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select MaNV N'Mã Nhân Viên',HoTen  N'Họ&Tên',CMND  N'CMND',DChi  N'Địa Chỉ',SDT N'Số Điện Thoại' from  " + table1 + " where TThai = 1";
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
        public DataTable DocSQLXOATKNV(string table1)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select MaNV N'Mã Nhân Viên',TK  N'Tài Khoản',MK  N'Mật Khẩu' from  " + table1 + " where TThai = 1";
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
        public bool XoaTK(string manv)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("Update tbTKNV Set TThai = 0 where MaNV = '" + manv + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
                return kq;

            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool Xoa(string manv)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("Update tbNhanVien Set TThai = 0 where MaNV = '" + manv + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
                return kq;

            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool phuchoi()
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("Update tbNhanVien Set TThai = 1", con);
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
                SqlCommand cmd = new SqlCommand("Update tbNhanVien Set TThai = 1 WHERE MaNV ='" + ma + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
                return kq;

            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool phuchoitktheoma(string ma)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                SqlCommand cmd = new SqlCommand("Update tbTKNV Set TThai = 1 WHERE MaNV ='" + ma + "'", con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
                return kq;

            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool CapNhapnv(BEL_NHANVIEN nv, string manv)
        {
            bool ketqua = false;
            try
            {
                GetCon();
                string sql = "Update tbNhanVien set MaNV = '" + nv.MaNV + "'  ,HoTen = N'" + nv.TenNV + "' ,CMND ='"
                    + nv.CMND_NV + "' , DChi = N'" + nv.DiaChi_NV + "' , SDT = '" + nv.SDT_NV + "' ,TThai = '" + nv.TTinh + "' Where Manv = '" + manv + "'";
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
        public bool CapNhapTKnv(BEL_NHANVIEN nv, string manv)
        {
            bool ketqua = false;
            try
            {
                GetCon();
                string sql = "Update tbTKNV set MaNV = '" + nv.MaNV + "'  ,TK = '" + nv.TK + "' ,MK = N'"
                    + nv.MK + "' Where MaNV = '" + manv + "'";
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
        public bool CapNhapMKnv(BEL_NHANVIEN nv)
        {
            bool ketqua = false;
            try
            {
                GetCon();
                string sql = "Update tbTKNV set MK = N'"
                    + nv.MK + "' Where TK = '" + nv.TK + "'";
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
        public bool Themnv(BEL_NHANVIEN nv)
        {
            bool ketqua = false;
            try
            {
                GetCon();
                string sql = "insert into tbNhanVien values('" + nv.MaNV + "',N'" + nv.TenNV + "',N'" + nv.CMND_NV + "',N'"
                    + nv.DiaChi_NV + "','" + nv.SDT_NV + "','" + nv.TTinh + "')";
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
        public bool Themtknv(BEL_NHANVIEN nv)
        {
            bool ketqua = false;
            try
            {
                GetCon();
                string sql = "insert into tbTKNV values('" + nv.MaNV + "',N'" + nv.TK + "',N'" + nv.MK + "','" + nv.TTinh + "')";
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
        public bool Kiemtratrungmanv(string Manv)
        {
            bool ketqua = false;
            GetCon();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbNhanVien where MaNV ='" + Manv + "'", con);
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
        public bool Kiemtratrungmanvtk(string Manv)
        {
            bool ketqua = false;
            GetCon();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbTKNV where MaNV = '" + Manv + "'", con);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                    ketqua = true;
                return ketqua;
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayTenNV(string tknv)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select HoTen from  tbNhanVien, tbTKNV where tbNhanVien.MaNV = tbTKNV.MaNV and TK = '" + tknv + "'";
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
        public DataTable LayTKNV(string ten)
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "select TK from  tbNhanVien, tbTKNV where tbNhanVien.MaNV = tbTKNV.MaNV and HoTen like N'" + ten + "'";
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
    }
}
