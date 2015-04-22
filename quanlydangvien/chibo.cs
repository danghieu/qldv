using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlydangvien
{
    public class chibo
    {
        private string macb;
        private string tencb;

        database db = new database();
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
        public bool themchibo() 
        {
            if (!ktttchibo())
            {
                db.themchibo(this);
                return true;
            }
            return false;
        }
        public void suachibo()
        {
            db.suachibo(this);
        }
        public bool ktttchibo() {
            return db.kttontaichibo(this);
        }
    }

   
   
}
