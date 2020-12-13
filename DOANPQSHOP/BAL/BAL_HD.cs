using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data;

namespace BAL
{
    public class BAL_HD
    {
        public bool ThemHD(BEL_HD hd)
        {
            var xuly = new DAL_HD();
            return xuly.ThemHD(hd);
        }

        public bool CapNhatTrung()
        {
            var xuly = new DAL_HD();
            return xuly.CapNhaphdTrung();
        }
        public bool CapNhaDaTru()
        {
            var xuly = new DAL_HD();
            return xuly.CapNhapDaTru();
        }
        /*       public bool CapNhapTThai()
               {
                   var xuly = new DAL_HD();
                   return xuly.CapNhapTThaiHD();
               }
               public bool LayHD()
               {
                   var xuly = new DAL_HD();
                   return xuly.LayHD();
               }*/

        public DataTable LayDSHD(string ten)
        {
            DAL_HD objdal = new DAL_HD();
            return objdal.DocSQLHD("tbHoaDon", ten);
        }
        public DataTable LayDSHD_HD()
        {
            DAL_HD objdal = new DAL_HD();
            return objdal.DocSQLHD_HD("tbHoaDon");
        }
        public DataTable LayDSMaHD()
        {
            DAL_HD objdal = new DAL_HD();
            return objdal.DocSQLMaHD();
        }
        public DataTable TimTheoMaHD(string mahd)
        {
            DAL_HD objdal = new DAL_HD();
            return objdal.TimMaHD(mahd);
        }
        public DataTable TimTheoTenNV(string tennv)
        {
            DAL_HD objdal = new DAL_HD();
            return objdal.TimTenNV(tennv);
        }
        public bool XoaHD(string mahd)
        {
            DAL_HD objdal = new DAL_HD();
            return objdal.Xoa(mahd);
        }
        public DataTable LayDSHDXoa()
        {
            try
            {
                DAL_HD objdal = new DAL_HD();
                return objdal.DocSQLXOAHD("tbHoaDon");
            }
            catch (Exception err)
            {
                throw;
            }
        }
        //public DataTable LayTongTienBan()
        //{
        //    try
        //    {
        //        DAL_HD objdal = new DAL_HD();
        //        return objdal.LayTongTienBan("tbHoaDon");
        //    }
        //    catch (Exception err)
        //    {
        //        throw;
        //    }
        //}
        public bool Phuchoitheoma(string ma)
        {
            try
            {
                DAL_HD objdal = new DAL_HD();
                return objdal.phuchoitheoma(ma);
            }
            catch
            {
                throw;
            }
        }
        public bool Phuchoitheoten(string ten)
        {
            try
            {
                DAL_HD objdal = new DAL_HD();
                return objdal.phuchoitheoten(ten);
            }
            catch
            {
                throw;
            }
        }
        public bool CapNhaphd(BEL_HD hd)
        {
            var xuly = new DAL_HD();
            return xuly.CapNhaphd(hd);
        }
        public bool XoaSachHD(string ma)
        {
            var xuly = new DAL_HD();
            return xuly.XoaHD(ma);
        }
        public DataTable LayDSHD_TheoNgay(int ngay1, int ngay2, int thang1, int thang2)
        {
            DAL_HD objdal = new DAL_HD();
            return objdal.DocSQLHD_TheoNgay(ngay1, ngay2, thang1, thang2);
        }
        public DataTable LayDSSaiHD_HD()
        {
            DAL_HD objdal = new DAL_HD();
            return objdal.DocSQLSaiHD_HD("tbHoaDon");
        }
        public bool CapNhapKM_MaKH(double giam, int ma)
        {
            var xuly = new DAL_HD();
            return xuly.CapNhapKM_MAKH(giam,ma);
        }
        
    }
}
