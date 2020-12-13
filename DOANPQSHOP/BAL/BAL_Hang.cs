using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using BEL;

namespace BAL
{
    public class BAL_Hang
    {
        public DataTable LayDSHang()
        {
            DAL_Hang objdal = new DAL_Hang();
            return objdal.DocSQLHANG("tbHang");
        }
        public DataTable LayDSMaHang()
        {
            DAL_Hang objdal = new DAL_Hang();
            return objdal.DocSQLMaHang();
        }
        public DataTable LayHinh(string ma)
        {
            DAL_Hang objdal = new DAL_Hang();
            return objdal.LayHinh(ma);
        }
        public DataTable LayHinh_KH(string Ten)
        {
            DAL_Hang objdal = new DAL_Hang();
            return objdal.LayHinh_KH(Ten);
        }
        public DataTable TimHang_KH(string tenhang)
        {
            DAL_Hang objdal = new DAL_Hang();
            return objdal.TimHang_KH(tenhang);
        }
        public DataTable LayTen_KH()
        {
            DAL_Hang objdal = new DAL_Hang();
            return objdal.DocSQLTenHang_KH();
        }
        public DataTable LayDSMaHangQuaTen(string tenhang)
        {
            DAL_Hang objdal = new DAL_Hang();
            return objdal.DocSQLMaHangQuaTen(tenhang);
        }
        public DataTable LayDSLoaiHangQuaTen(string tenhang)
        {
            DAL_Hang objdal = new DAL_Hang();
            return objdal.DocSQLLoaiHangQuaTen(tenhang);
        }
        public DataTable LayDSGiaHangQuaTen(string tenhang)
        {
            DAL_Hang objdal = new DAL_Hang();
            return objdal.DocSQLGiaHangQuaTen(tenhang);
        }
        public DataTable LayDSSLHangQuaTen(string tenhang)
        {
            DAL_Hang objdal = new DAL_Hang();
            return objdal.DocSQLSLHangQuaTen(tenhang);
        }
        public DataTable LayDSTenHang()
        {
            DAL_Hang objdal = new DAL_Hang();
            return objdal.DocSQLTenHang();
        }
        public DataTable TimTheoMaHang(string mahang)
        {
            DAL_Hang objdal = new DAL_Hang();
            return objdal.TimMaHang(mahang);
        }
        public DataTable TimTheoTenHang(string tenhang)
        {
            DAL_Hang objdal = new DAL_Hang();
            return objdal.TimTenHang(tenhang);
        }
        public bool XoaHang(string mahang)
        {
            DAL_Hang objdal = new DAL_Hang();
            return objdal.Xoa(mahang);
        }
        public DataTable LayDSHANGXOA()
        {
            try
            {
                DAL_Hang objdal = new DAL_Hang();
                return objdal.DocSQLXOAHANG("tbHang");
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool Phuchoi()
        {
            try
            {
                DAL_Hang objdal = new DAL_Hang();
                return objdal.phuchoi();
            }
            catch
            {
                throw;
            }
        }
        /*       public bool CapNhapSoLuongHang()
               {
                   try
                   {
                       DAL_Hang objdal = new DAL_Hang();
                       return objdal.CapNhapSoLuongHang();
                   }
                   catch
                   {
                       throw;
                   }
               }*/
        public bool Phuchoitheoma(string ma)
        {
            try
            {
                DAL_Hang objdal = new DAL_Hang();
                return objdal.phuchoitheoma(ma);
            }
            catch
            {
                throw;
            }
        }
        public bool CapNhapSLHang()
        {
            try
            {
                DAL_Hang objdal = new DAL_Hang();
                return objdal.capnhapsl();
            }
            catch
            {
                throw;
            }
        }
        public bool Themhang(BEL_Hang hang)
        {
            var xuly = new DAL_Hang();
            return xuly.Themhang(hang);
        }
        public bool CapNhaphang(BEL_Hang hang, string mahang)
        {
            var xuly = new DAL_Hang();
            return xuly.CapNhaphang(hang, mahang);
        }
        public bool Kiemtratrungmahang(string mahang)
        {
            var xuly = new DAL_Hang();
            return xuly.Kiemtratrungmahang(mahang);
        }

    }
}
