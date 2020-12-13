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
    public class BAL_NHANVIEN
    {
        public bool SS(string tk, string mk)
        {
            bool KQ = false;
            DAL_NHANVIEN objdal = new DAL_NHANVIEN();
            if (objdal.SoSanhTK(tk, mk) == true)
                KQ = true;
            return KQ;
        }
        public DataTable LayTenNV(string tknv)
        {
            DAL_NHANVIEN objdal = new DAL_NHANVIEN();
            return objdal.LayTenNV(tknv);
        }
        public DataTable LayTKNV(string ten)
        {
            DAL_NHANVIEN objdal = new DAL_NHANVIEN();
            return objdal.LayTKNV(ten);
        }
        public DataTable LayDSNV()
        {
            DAL_NHANVIEN objdal = new DAL_NHANVIEN();
            return objdal.DocSQLNV("tbNhanVien");
        }
        public DataTable LayDSMaNV()
        {
            DAL_NHANVIEN objdal = new DAL_NHANVIEN();
            return objdal.DocSQLMaNV();
        }
        public DataTable TimTheoMa(string manv)
        {
            DAL_NHANVIEN objdal = new DAL_NHANVIEN();
            return objdal.TimTheoMa(manv);
        }
        public DataTable TimTheoMaTK(string manv)
        {
            DAL_NHANVIEN objdal = new DAL_NHANVIEN();
            return objdal.TimTheoMaTK(manv);
        }
        public DataTable TimTheoTen(string tennv)
        {
            DAL_NHANVIEN objdal = new DAL_NHANVIEN();
            return objdal.TimTheoTen(tennv);
        }
        public DataTable LayDSTKNV()
        {
            DAL_NHANVIEN objdal = new DAL_NHANVIEN();
            return objdal.DocSQLTKNV("tbTKNV");
        }
        public bool XoaNV(string manv)
        {
            try
            {
                DAL_NHANVIEN objdal = new DAL_NHANVIEN();
                return objdal.Xoa(manv);
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public bool XoaTKNV(string manv)
        {
            try
            {
                DAL_NHANVIEN objdal = new DAL_NHANVIEN();
                return objdal.XoaTK(manv);
            }
            catch
            {
                throw;
            }
        }
        public DataTable LayDSNVXOA()
        {
            try
            {
                DAL_NHANVIEN objdal = new DAL_NHANVIEN();
                return objdal.DocSQLXOANV("tbNhanVien");
            }
            catch (Exception err)
            {
                throw;
            }
        }
        public DataTable LayDSTKNVXOA()
        {
            try
            {
                DAL_NHANVIEN objdal = new DAL_NHANVIEN();
                return objdal.DocSQLXOATKNV("tbTKNV");
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
                DAL_NHANVIEN objdal = new DAL_NHANVIEN();
                return objdal.phuchoi();
            }
            catch
            {
                throw;
            }
        }
        public bool Phuchoitheoma(string ma)
        {
            try
            {
                DAL_NHANVIEN objdal = new DAL_NHANVIEN();
                return objdal.phuchoitheoma(ma);
            }
            catch
            {
                throw;
            }
        }
        public bool Phuchoitktheoma(string ma)
        {
            try
            {
                DAL_NHANVIEN objdal = new DAL_NHANVIEN();
                return objdal.phuchoitktheoma(ma);
            }
            catch
            {
                throw;
            }
        }
        public bool Themnv(BEL_NHANVIEN nv)
        {
            var xuly = new DAL_NHANVIEN();
            return xuly.Themnv(nv);
        }
        public bool Themtknv(BEL_NHANVIEN nv)
        {
            var xuly = new DAL_NHANVIEN();
            return xuly.Themtknv(nv);
        }
        public bool CapNhapnv(BEL_NHANVIEN nv, string manv)
        {
            var xuly = new DAL_NHANVIEN();
            return xuly.CapNhapnv(nv, manv);
        }
        public bool CapNhapTKnv(BEL_NHANVIEN nv, string manv)
        {
            var xuly = new DAL_NHANVIEN();
            return xuly.CapNhapTKnv(nv, manv);
        }
        public bool CapNhapMKnv(BEL_NHANVIEN nv)
        {
            var xuly = new DAL_NHANVIEN();
            return xuly.CapNhapMKnv(nv);
        }
        public bool Kiemtratrungmanv(string manv)
        {
            var xuly = new DAL_NHANVIEN();
            return xuly.Kiemtratrungmanv(manv);
        }
        public bool KiemtratrungmanvTKNV(string manv)
        {
            var xuly = new DAL_NHANVIEN();
            return xuly.Kiemtratrungmanvtk(manv);
        }
    }
}
