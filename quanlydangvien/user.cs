using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlydangvien
{
    class vanphongchibo
    {
        private string taikhoan;
        private string matkhau;
        private string hoten;
        private int capdo;


        public string Taikhoan
        {
            get
            {
                return taikhoan;
            }
            set
            {
                taikhoan = value;
            }
        }
        public string Matkhau
        {
            get
            {
                return matkhau;
            }
            set
            {
                matkhau = value;
            }
        }
        public string Hoten
        {
            get
            {
                return hoten;
            }
            set
            {
                hoten = value;
            }
        }
        public int Capdo
        {
            get
            {
                return capdo;
            }
            set
            {
                capdo = value;
            }
        }
        public vanphongchibo(string tk, string mk, string ht, int cd)
        {
            taikhoan = tk;
            matkhau = mk;
            hoten = ht;
            capdo = cd;
        }
        public void DoiMatKhau()
        {

        }
        public void Thoat()
        {

        }
    }

     class vanphongdanguy : vanphongchibo
    {
        public vanphongdanguy(string taikhoan,string matkhau,string hoten,int capdo) :base(taikhoan,matkhau,hoten,capdo) { 
        
        }
        public void QuanLyCB() { 
        
        }
        public void SaoLuuDL()
        {

        }
        public void KhoiPhucDL()
        {

        }

    }

}
