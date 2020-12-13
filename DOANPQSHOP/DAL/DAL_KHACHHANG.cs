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
    public class DAL_KHACHHANG : General
    {
        public bool ThemSDTKHACH(BEL_KHACHHANG kh)
        {
            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "INSERT INTO tbKhachHang(SoLanDaMua,SDT) VALUES(0,'" + kh.SDT +"')";
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
        public DataTable SDTTrung(string sdt)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select MaKH from tbKhachHang where SDT = '" + sdt + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable LaySoLanMua(string sdt)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select SoLanDaMua from tbKhachHang where SDT = '" + sdt + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public bool ThemSoLanMua(string sdt,int SoLanMua)
        {
            bool ketqua = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "update tbKhachHang set SoLanDaMua = " + SoLanMua + " where SDT = '" + sdt + "'";
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
        public DataTable DocSQLMaKH()
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select MaKH from tbKhachHang";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable TimTheoMa(int Ma)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select top 1 B.MaKH,SDT, NgayLap,SoLanDaMua from tbHoaDon A,tbKhachHang B where A.MaKH = B.MaKH and A.MaKH = " + Ma + " order by NgayLap Desc ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable TimTheoSDT(string sdt)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select top 1 B.MaKH,SDT, NgayLap,SoLanDaMua from tbHoaDon A,tbKhachHang B where A.MaKH = B.MaKH and SDT = " + sdt + " order by NgayLap Desc ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable TimTheoSoLanMua(string slm)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select top 1 B.MaKH,SDT, NgayLap,SoLanDaMua from tbHoaDon A,tbKhachHang B where A.MaKH = B.MaKH and SoLanDaMua = " + slm + " order by NgayLap Desc ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable TimTheoNgay(string ngay)
        {
            DataTable dt = new DataTable();
            GetCon();
            string sql = "select top 1 B.MaKH,SDT, NgayLap,SoLanDaMua from tbHoaDon A,tbKhachHang B where A.MaKH = B.MaKH and NgayLap = '" + ngay + "' order by NgayLap Desc ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
        public DataTable DocSQLHD_KH()
        {
            DataTable dt = new DataTable();
            GetCon();
            //string sql = "select MaNV,HoTen,CMND,DChi,SDT from " + table1 + " where TThai = 1";
            string sql = "select MaKH,SDT,SoLanDaMua from tbKhachHang order by MaKH ASC";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }
    }
}
