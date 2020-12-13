using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_NHANVIEN
    {
        string _MaNV;
        string _TenNV;
        string _DiaChi_NV;
        string _CMND_NV;
        string _SDT_NV;
        string _TTinh;
        string _TK;
        string _MK;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        public string TenNV
        {
            get { return _TenNV; }
            set { _TenNV = value; }
        }

        public string DiaChi_NV
        {
            get { return _DiaChi_NV; }
            set { _DiaChi_NV = value; }
        }
        public string CMND_NV
        {
            get { return _CMND_NV; }
            set { _CMND_NV = value; }
        }
        public string SDT_NV
        {
            get { return _SDT_NV; }
            set { _SDT_NV = value; }
        }
        public string TK
        {
            get { return _TK; }
            set { _TK = value; }
        }
        public string MK
        {
            get { return _MK; }
            set { _MK = value; }
        }
        public string TTinh
        {
            get { return _TTinh; }
            set { _TTinh = value; }
        }
    }
}
