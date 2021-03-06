﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Windows.Forms;
namespace quanlydangvien
{
    class database
    {
        private string conn;
        private SqlConnection connect;
        SqlCommand cmd;

        public void db_connection()
        {
            try
            {
                conn = "Data Source=DANGHIEU-PC;Initial Catalog=quanlydangvien;Integrated Security=True";
                connect = new SqlConnection(conn);
                connect.Open();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public vanphongchibo checklogin(string taikhoan, string matkhau)
        {
            vanphongchibo curuser = null;
            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "Select taikhoan,matkhau,hoten,capdo,thongtin from users where taikhoan=@taikhoan and matkhau=@matkhau";
            cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            cmd.Connection = connect;
            SqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {


                string tk = login.GetString(0);
                string mk = login.GetString(1);
                string ht = login.GetString(2);
                int cd = login.GetInt32(3);
                string thongtin = login.GetString(4);

                curuser = new vanphongchibo(tk, mk, ht, cd,thongtin);



            }
            return curuser;
        }

        public void themdangvien(dangvien dv)
        {

            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO dangvien(anhdaidien,MaDV,hoten,ngaysinh,gioitinh,CMND,ngayvaochinhthuc,noivaochinhthuc,ngayvaodubi,noivaodubi,quequan,noisinh,MaTG,MaDT,maTDVH,tinhtrangDV,bidanh,nghenghiep,MaCB,chucdanh,choohiennay,thongtinthem)" +
                                            "VALUES(@image,@sothe,@hoten,@ngaysinh,@gioitinh,@cmnd,@ngayvaochinhthuc,@noivaochinhthuc,@ngayvaodubi,@noivaodubi,@quequan,@noisinh,@MaTG,@MaDT,@maTDVH,@tinhtrangDV,@bidanh,@nghenghiep,@MaCB,@chucdanh,@choohiennay,@thongtinthem) ";
            cmd.Parameters.AddWithValue("@image", convertImageToByte(dv.Anhdaidien));
            cmd.Parameters.AddWithValue("@sothe", dv.Sothe);
            cmd.Parameters.AddWithValue("@hoten", dv.Hoten);
            cmd.Parameters.AddWithValue("@ngaysinh", dv.Ngaysinh);
            cmd.Parameters.AddWithValue("@gioitinh", dv.Gioitinh);
            cmd.Parameters.AddWithValue("@cmnd", dv.Cmnd);
            cmd.Parameters.AddWithValue("@ngayvaochinhthuc", dv.Ngaychinhthuc);
            cmd.Parameters.AddWithValue("@noivaochinhthuc", dv.Noivaochinhthuc);
            cmd.Parameters.AddWithValue("@ngayvaodubi", dv.Ngayvaodubi);
            cmd.Parameters.AddWithValue("@noivaodubi", dv.Ngayvaodubi);
            cmd.Parameters.AddWithValue("@quequan", dv.Quequan);
            cmd.Parameters.AddWithValue("@noisinh", dv.Noisinh);
            cmd.Parameters.AddWithValue("@MaTG", dv.Matg);
            cmd.Parameters.AddWithValue("@MaDT", dv.Madt);
            cmd.Parameters.AddWithValue("@maTDVH", dv.Matdhv);
            cmd.Parameters.AddWithValue("@solylich", dv.Solylich);
            cmd.Parameters.AddWithValue("@bidanh", dv.Bidanh);
            cmd.Parameters.AddWithValue("@nghenghiep", dv.Nghenghiep);
            cmd.Parameters.AddWithValue("@MaCB", dv.Macb);
            cmd.Parameters.AddWithValue("@chucdanh", dv.Chucdanh);
            cmd.Parameters.AddWithValue("@thongtinthem", dv.Thongtinthem);
            cmd.Parameters.AddWithValue("@choohiennay", dv.Choohiennay);
            cmd.Parameters.AddWithValue("@tinhtrangDV", dv.Trangthai);
            cmd.Connection = connect;
            cmd.ExecuteReader();
        }
        private byte[] convertImageToByte(string image)
        {
            FileStream fs;
            fs = new FileStream(image, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;

        }
        public DataSet laydanhsachdangvien()
        {
            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM dangvien";
            cmd.Connection = connect;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public void xoadangvien(DataGridViewRow dvr)
        {
            db_connection();
            cmd = new SqlCommand();
            string MaDV = dvr.Cells["MaDV"].Value.ToString();
            cmd.CommandText = "DELETE FROM dangvien WHERE MaDV=@MADV";
            cmd.Parameters.AddWithValue("@MaDV", MaDV);
            cmd.Connection = connect;
            cmd.ExecuteNonQuery();
        }
        public void suadangvien(dangvien dv)
        {

            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "UPDATE  dangvien SET anhdaidien=@image,hoten=@hoten,ngaysinh=@ngaysinh,gioitinh=@gioitinh,CMND=@cmnd,ngayvaochinhthuc=@ngayvaochinhthuc,noivaochinhthuc=@noivaochinhthuc,ngayvaodubi=@ngayvaodubi,noivaodubi=@noivaodubi,quequan=@quequan,noisinh=@noisinh,MaTG=@MaTG,MaDT=@MaDT,maTDVH=@maTDVH,tinhtrangDV=@tinhtrangDV,bidanh=@bidanh,nghenghiep=@nghenghiep,MaCB=@MaCB,chucdanh=@chucdanh,choohiennay=@choohiennay,thongtinthem=@thongtinthem WHERE MaDV=@sothe";
            cmd.Parameters.AddWithValue("@image", convertImageToByte(dv.Anhdaidien));
            cmd.Parameters.AddWithValue("@sothe", dv.Sothe);
            cmd.Parameters.AddWithValue("@hoten", dv.Hoten);
            cmd.Parameters.AddWithValue("@ngaysinh", dv.Ngaysinh);
            cmd.Parameters.AddWithValue("@gioitinh", dv.Gioitinh);
            cmd.Parameters.AddWithValue("@cmnd", dv.Cmnd);
            cmd.Parameters.AddWithValue("@ngayvaochinhthuc", dv.Ngaychinhthuc);
            cmd.Parameters.AddWithValue("@noivaochinhthuc", dv.Noivaochinhthuc);
            cmd.Parameters.AddWithValue("@ngayvaodubi", dv.Ngayvaodubi);
            cmd.Parameters.AddWithValue("@noivaodubi", dv.Ngayvaodubi);
            cmd.Parameters.AddWithValue("@quequan", dv.Quequan);
            cmd.Parameters.AddWithValue("@noisinh", dv.Noisinh);
            cmd.Parameters.AddWithValue("@MaTG", dv.Matg);
            cmd.Parameters.AddWithValue("@MaDT", dv.Madt);
            cmd.Parameters.AddWithValue("@maTDVH", dv.Matdhv);
            cmd.Parameters.AddWithValue("@solylich", dv.Solylich);
            cmd.Parameters.AddWithValue("@bidanh", dv.Bidanh);
            cmd.Parameters.AddWithValue("@nghenghiep", dv.Nghenghiep);
            cmd.Parameters.AddWithValue("@MaCB", dv.Macb);
            cmd.Parameters.AddWithValue("@chucdanh", dv.Chucdanh);
            cmd.Parameters.AddWithValue("@thongtinthem", dv.Thongtinthem);
            cmd.Parameters.AddWithValue("@choohiennay", dv.Choohiennay);
            cmd.Parameters.AddWithValue("@tinhtrangDV", dv.Trangthai);
            cmd.Connection = connect;
            cmd.ExecuteNonQuery();
        }
        public bool kttontaidangvien(dangvien dv)
        {
            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT MaDV FROM dangvien WHERE MaDV=@madv ";
            cmd.Parameters.AddWithValue("@madv", dv.Sothe);
            cmd.Connection = connect;
            SqlDataReader kt = cmd.ExecuteReader();
            if (kt.Read())
            {
                return true;
            }
            else return false;
        }
        public bool kttontaiuser(vanphongchibo u)
        {
            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT taikhoan FROM users WHERE taikhoan=@taikhoan ";
            cmd.Parameters.AddWithValue("@taikhoan", u.Taikhoan);
            cmd.Connection = connect;
            SqlDataReader kt = cmd.ExecuteReader();
            if (kt.Read())
            {
                return true;
            }
            else return false;
        }
        public DataSet laydanhsachchibo()
        {
            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM chibo";
            cmd.Connection = connect;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public void xoachibo(DataGridViewRow dvr)
        {
            db_connection();
            cmd = new SqlCommand();
            string MaCB = dvr.Cells["MaCB"].Value.ToString();
            cmd.CommandText = "DELETE FROM chibo WHERE MaCB=@MaCB";
            cmd.Parameters.AddWithValue("@MaCB", MaCB);
            cmd.Connection = connect;
            cmd.ExecuteNonQuery();
        }
        public void themchibo(chibo cb)
        {
            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO chibo(MaCB,TenCB)" +
                                            "VALUES(@MaCB,@TenCB) ";
            cmd.Parameters.AddWithValue("@TenCB", cb.TenCB);
            cmd.Parameters.AddWithValue("@MaCB", cb.MaCB);


            cmd.Connection = connect;
            cmd.ExecuteReader();
        }
        public bool xoauser(vanphongchibo u)
        {
            db_connection();
            cmd = new SqlCommand();
            
            cmd.CommandText = "DELETE FROM users WHERE taikhoan=@taikhoan";
            cmd.Parameters.AddWithValue("@taikhoan", u.Taikhoan);
            cmd.Connection = connect;
            if (cmd.ExecuteNonQuery() == 1) {
                return true;
            }
            return false;
        }

        public void themuser(vanphongchibo u)
        {
            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO users(taikhoan,matkhau,capdo,hoten,thongtin)" +
                                            "VALUES(@taikhoan,@matkhau,@capdo,@hoten,@thongtin) ";
            cmd.Parameters.AddWithValue("@taikhoan",u.Taikhoan);
            cmd.Parameters.AddWithValue("@matkhau", u.Matkhau);
            cmd.Parameters.AddWithValue("@hoten", u.Hoten);
            cmd.Parameters.AddWithValue("@capdo", u.Capdo);
            cmd.Parameters.AddWithValue("@thongtin", u.Thongtin);
            cmd.Connection = connect;
            cmd.ExecuteReader();
        }
        public bool suauser(vanphongchibo u)
        {

            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "UPDATE users SET hoten=@hoten, thongtin=@thongtin  Where taikhoan=@taikhoan ";
            cmd.Parameters.AddWithValue("@taikhoan", u.Taikhoan);
            cmd.Parameters.AddWithValue("@hoten", u.Hoten);
            cmd.Parameters.AddWithValue("@thongtin", u.Thongtin);

            cmd.Connection = connect;

            if (cmd.ExecuteNonQuery() == 1) return true;
            else return false;
        }
        public bool suachibo(chibo cb)
        {

            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "UPDATE chibo SET TenCB=@TenCB Where MaCB=@MaCB ";
            cmd.Parameters.AddWithValue("@TenCB", cb.TenCB);
            cmd.Parameters.AddWithValue("@MaCB", cb.MaCB);
            cmd.Connection = connect;

            if (cmd.ExecuteNonQuery() == 1) return true;
            else return false;
        }
        public bool kttontaichibo(chibo cb)
        {
            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT MaCB FROM chibo WHERE MaCB=@macb ";
            cmd.Parameters.AddWithValue("@macb", cb.MaCB);
            cmd.Connection = connect;
            SqlDataReader kt = cmd.ExecuteReader();
            if (kt.Read())
            {
                return true;
            }
            else return false;
        }
        public DataSet timkiemtendv(string ten)
        {
            db_connection();
            string hoten = "%" + ten + "%";
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM dangvien WHERE hoten like @hoten ";
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Connection = connect;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public DataSet pagingdangvien(int start, string ten, string macb,string trangthai)
        {
            db_connection();
            cmd = new SqlCommand();
            if (ten != "" && trangthai != "") {
                string hoten = "%" + ten + "%";
                cmd.CommandText = "SELECT * FROM dangvien WHERE tinhtrangDV=@trangthai and hoten like @hoten ";
                cmd.Parameters.AddWithValue("@hoten", hoten);
                cmd.Parameters.AddWithValue("@trangthai", trangthai);
            }
            else if (ten != "")
            {
                string hoten = "%" + ten + "%";
                cmd.CommandText = "SELECT * FROM dangvien WHERE   hoten like @hoten  ";
                cmd.Parameters.AddWithValue("@hoten", hoten);
                
            }
            else if (macb != "")
            {
                cmd.CommandText = "SELECT * FROM dangvien WHERE MaCB=@macb";
                cmd.Parameters.AddWithValue("@macb", macb);
            }
            else if (trangthai !="")
            {
                cmd.CommandText = "SELECT * FROM dangvien WHERE tinhtrangDV=@trangthai";
                cmd.Parameters.AddWithValue("@trangthai", trangthai);
            }
            
            else
            {
                cmd.CommandText = "SELECT * FROM dangvien  ";
            }
            cmd.Connection = connect;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, start, 15, "bang_dangvien");
            return ds;
        }
        public DataSet pagingchibo(int start, string ten, string macb)
        {
            db_connection();
            cmd = new SqlCommand();
            if (ten != "")
            {
                string tencb = "%" + ten + "%";
                cmd.CommandText = "SELECT * FROM chibo WHERE TenCB like @tencb ";
                cmd.Parameters.AddWithValue("@tencb", tencb);
            }
            else if (macb != "")
            {
                cmd.CommandText = "SELECT * FROM chibo WHERE MaCB=@macb";
                cmd.Parameters.AddWithValue("@macb", macb);
            }
            else
            {
                cmd.CommandText = "SELECT t1.TenCB, t3.sodangvien,t1.sodangvienchinhthuc , t2.sodangviendubi, t4.dangviennu FROM ( SELECT chibo.TenCB,COUNT(DISTINCT dangvien.MaDV) AS sodangvienchinhthuc FROM dangvien,chibo WHERE dangvien.MaCB = chibo.MaCB and dangvien.tinhtrangDV='DVCT' GROUP BY chibo.TenCB )as t1 , (SELECT chibo.TenCB,COUNT(DISTINCT dangvien.MaDV) AS sodangviendubi FROM dangvien,chibo WHERE dangvien.MaCB = chibo.MaCB and dangvien.tinhtrangDV='DVDB' GROUP BY chibo.TenCB) as t2,(SELECT chibo.TenCB,COUNT(DISTINCT dangvien.MaDV) AS sodangvien FROM dangvien,chibo WHERE dangvien.MaCB = chibo.MaCB GROUP BY chibo.TenCB )as t3,(SELECT chibo.TenCB,COUNT(DISTINCT dangvien.gioitinh) AS dangviennu FROM dangvien,chibo WHERE dangvien.MaCB = chibo.MaCB and dangvien.gioitinh='Nu' GROUP BY chibo.TenCB)as t4 WHERE t1.TenCB = t2.TenCB and t1.TenCB= t3.TenCB and t1.TenCB= t4.TenCB";
            }
            cmd.Connection = connect;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, start, 15, "bang_chibo");
            return ds;
        }

        public DataSet pagingnguoidung(int start, string hoten)
        {
            db_connection();
            cmd = new SqlCommand();
            if (hoten != "")
            {
                string ht = "%" + hoten + "%";
                cmd.CommandText = "SELECT * FROM users WHERE hoten like @hoten ";
                cmd.Parameters.AddWithValue("@hoten", ht);
            }
            
            else
            {
                cmd.CommandText = "SELECT taikhoan,hoten, thongtin FROM users";
            }
            cmd.Connection = connect;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, start, 15, "bang_nguoidung");
            return ds;
        }

        public bool doimatkhau(vanphongchibo vpcb)
        {
            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "UPDATE users SET matkhau=@matkhau where taikhoan=@taikhoan ";
            cmd.Parameters.AddWithValue("@matkhau", vpcb.Matkhau);
            cmd.Parameters.AddWithValue("@taikhoan", vpcb.Taikhoan);
            cmd.Connection = connect;
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else return false;
        }

        public List<chibo> dschibocbb()
        {
            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM chibo";
            cmd.Connection = connect;
            SqlDataReader reader = cmd.ExecuteReader();
            List<chibo> list = new List<chibo>();
            chibo cb;
            while (reader.Read())
            {
                cb = new chibo(reader.GetString(0), reader.GetString(1));
                list.Add(cb);
            }
            return list;
        }


    }

}
