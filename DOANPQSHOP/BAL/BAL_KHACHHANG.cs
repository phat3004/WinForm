using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class BAL_KHACHHANG
    {
        public bool ThemSDT(BEL_KHACHHANG kh)
        {
            bool KQ = false;
            DAL_KHACHHANG objdal = new DAL_KHACHHANG();
            if (objdal.ThemSDTKHACH(kh) == true)
                KQ = true;
            return KQ;
        }
        public DataTable LaySoLanMua(string sdt)
        {
            DAL_KHACHHANG objdal = new DAL_KHACHHANG();
            return objdal.LaySoLanMua(sdt);
        }
        public DataTable SDTTrung(string sdt)
        {
            DAL_KHACHHANG objdal = new DAL_KHACHHANG();
            return objdal.SDTTrung(sdt);
        }
        public bool ThemLanMua(string sdt, int SoLanMua)
        {
            bool KQ = false;
            DAL_KHACHHANG objdal = new DAL_KHACHHANG();
            if (objdal.ThemSoLanMua(sdt,SoLanMua) == true)
                KQ = true;
            return KQ;
        }
        public DataTable LayDSMaKH()
        {
            DAL_KHACHHANG objdal = new DAL_KHACHHANG();
            return objdal.DocSQLMaKH();
        }
        public DataTable TimTheoMa(int ma)
        {
            DAL_KHACHHANG objdal = new DAL_KHACHHANG();
            return objdal.TimTheoMa(ma);
        }
        public DataTable TimTheoSDT(string sdt)
        {
            DAL_KHACHHANG objdal = new DAL_KHACHHANG();
            return objdal.TimTheoSDT(sdt);
        }
        public DataTable TimTheoSoLanMua(string slm)
        {
            DAL_KHACHHANG objdal = new DAL_KHACHHANG();
            return objdal.TimTheoSoLanMua(slm);
        }
        public DataTable TimTheoNgay(string ngay)
        {
            DAL_KHACHHANG objdal = new DAL_KHACHHANG();
            return objdal.TimTheoNgay(ngay);
        }
        public DataTable DocSQLHD_KH()
        {
            DAL_KHACHHANG objdal = new DAL_KHACHHANG();
            return objdal.DocSQLHD_KH();
        }
    }
}
