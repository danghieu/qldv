using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlydangvien
{
    public class vanphongchibo
    {
        private string taikhoan;
        private string matkhau;
        private string hoten;
        private int capdo;
        private string thongtin;

        database db = new database();
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
        public string Thongtin
        {
            get
            {
                return thongtin;
            }
            set
            {
                thongtin = value;
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
        public vanphongchibo(string tk, string mk, string ht, int cd, string tt)
        {
            taikhoan = tk;
            matkhau = mk;
            hoten = ht;
            capdo = cd;
            thongtin = tt;
        }
        public vanphongchibo(string tk)
        {
            taikhoan = tk;
            
        }
        public bool DoiMatKhau()
        {
            return db.doimatkhau(this);
            
        }
        public bool ktttuser() {

            return db.kttontaiuser(this);
        }
        public bool themuser()
        {
            if (!ktttuser())
            {
                db.themuser(this);
                return true;
            }
            return false;


        }
        public bool suauser() {
            if (db.suauser(this)) {
                return true;
            }
            return false;
        }
        public bool xoauser()
        {
            if (db.xoauser(this))
            {
                return true;
            }
            return false;
        }
        public void Thoat()
        {

        }
    }

     public class vanphongdanguy : vanphongchibo
    {
        public vanphongdanguy(string taikhoan,string matkhau,string hoten,int capdo,string thongtin) :base(taikhoan,matkhau,hoten,capdo,thongtin) { 
        
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
