using System;
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
            cmd.CommandText = "Select taikhoan,matkhau,hoten,capdo from users where taikhoan=@taikhoan and matkhau=@matkhau";
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
                if (cd == 1)
                {
                    curuser = new vanphongchibo(tk, mk, ht, cd);

                }
                else
                {
                    curuser = new vanphongdanguy(tk, mk, ht, cd);
                }
                // connect.Close();
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
        public bool kttontaidangvien(dangvien dv){
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
        public void themchibo(chibo cb){
            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO chibo(MaCB,TenCB)" +
                                            "VALUES(@MaCB,@TenCB) ";
            cmd.Parameters.AddWithValue("@TenCB", cb.TenCB);
            cmd.Parameters.AddWithValue("@MaCB", cb.MaCB);
            
            
            cmd.Connection = connect;
            cmd.ExecuteReader();
        }
        public void suachibo(chibo cb)
        {

            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "UPDATE  dangvien SET MaCB=@MaCB,TenCB=@TenCB";
            cmd.Parameters.AddWithValue("@TenCB", cb.TenCB);
            cmd.Parameters.AddWithValue("@MaCB", cb.MaCB);
            
            
            cmd.Connection = connect;
            cmd.ExecuteNonQuery();
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
    }

}
