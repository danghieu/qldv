using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlydangvien
{
    class dangvien
    {
        private string anhdaidien;
        private string sothe;
        private string hoten;
        private string trangthai;
        private string solylich;
        private int cmnd;
        private DateTime ngaysinh;
        private string madt;
        private string matg;
        private string matdhv;
        private string chucdanh;
        private string gioitinh;
        private string bidanh;
        private string nghenghiep;
        private string noisinh;
        private string quequan;
        private string choohiennay;
        private string noivaodubi;
        private DateTime ngayvaodubi;
        private string noivaochinhthuc;
        private DateTime ngaychinhthuc;
        private string ngoaingu;
        private string macb;
        private string thongtinthem;

        public string Thongtinthem
        {
            get { return thongtinthem; }
            set { thongtinthem = value; }
        }

        public string Sothe
        {
            get { return sothe; }
            set { sothe = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }

        public string Solylich
        {
            get { return solylich; }
            set { solylich = value; }
        }

        public int Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        public string Madt
        {
            get { return madt; }
            set { madt = value; }
        }

        public string Matg
        {
            get { return matg; }
            set { matg = value; }
        }

        public string Matdhv
        {
            get { return matdhv; }
            set { matdhv = value; }
        }

        public string Chucdanh
        {
            get { return chucdanh; }
            set { chucdanh = value; }
        }

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        public string Bidanh
        {
            get { return bidanh; }
            set { bidanh = value; }
        }

        public string Nghenghiep
        {
            get { return nghenghiep; }
            set { nghenghiep = value; }
        }

        public string Noisinh
        {
            get { return noisinh; }
            set { noisinh = value; }
        }

        public string Quequan
        {
            get { return quequan; }
            set { quequan = value; }
        }

        public string Choohiennay
        {
            get { return choohiennay; }
            set { choohiennay = value; }
        }

        public string Noivaodubi
        {
            get { return noivaodubi; }
            set { noivaodubi = value; }
        }

        public DateTime Ngayvaodubi
        {
            get { return ngayvaodubi; }
            set { ngayvaodubi = value; }
        }

        public string Noivaochinhthuc
        {
            get { return noivaochinhthuc; }
            set { noivaochinhthuc = value; }
        }

        public DateTime Ngaychinhthuc
        {
            get { return ngaychinhthuc; }
            set { ngaychinhthuc = value; }
        }

        public string Ngoainhu
        {
            get { return ngoaingu; }
            set { ngoaingu = value; }
        }

        public string Macb
        {
            get { return macb; }
            set { macb = value; }
        }

        

        public dangvien(string add,string st, string ht, string tt, string soll, int cm,DateTime ns,string dt, string tg,
                        string tdhv, string cd,string gt, string bd, string nn, string nois, string qq, string chohn, string noivdb,
                        DateTime ngayvdb, string noivct, DateTime ngayvct,string ngng,string cb,string ttt) {
                anhdaidien = add;
                sothe=st;
                hoten=ht;
                trangthai=tt;
                solylich=soll;
                cmnd=cm;
                ngaysinh=ns;
                madt=dt;
                matg=tg;
                matdhv=tdhv;
                chucdanh=cd;
                gioitinh=gt;
                bidanh=bd;
                nghenghiep=nn;
                noisinh=nois;
                quequan=qq;
                choohiennay=chohn;
                noivaodubi=noivdb;
                ngayvaodubi=ngayvdb;
                noivaochinhthuc=noivct;
                ngaychinhthuc=ngayvct;
                ngoaingu=ngng;
                macb=cb;
                thongtinthem=ttt;               
        
        }

        public void themdangvien() {
            database db = new database();
            db.themdangvien(anhdaidien, sothe, hoten, ngaysinh, gioitinh, cmnd, ngaychinhthuc, noivaochinhthuc, ngayvaodubi, noivaodubi, quequan, noisinh, matg, madt, matdhv, solylich, bidanh, nghenghiep, Macb, chucdanh,choohiennay, thongtinthem, trangthai);
        }

    }
}
