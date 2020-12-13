using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_KHACHHANG
    {
        string _SDT;
        int _SoLanMua;

        public int SoLanMua
        {
            get { return _SoLanMua; }
            set { _SoLanMua = value; }
        }

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
    }
}
