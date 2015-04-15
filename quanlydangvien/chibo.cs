using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlydangvien
{
    class chibo
    {
        private string macb;
        private string tencb;
        public string MaCB
        {
            get
            {
                return macb;
            }
            set
            {
                macb = value;
            }
        }
        public string TenCB
        {
            get
            {
                return tencb;
            }
            set
            {
                tencb = value;
            }
        }

        public chibo(string MaCB, string TenCB)
        {
            macb=MaCB;
            tencb = TenCB;
        }
    }
   
}
