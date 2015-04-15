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

        public void db_connection(){
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
                else {
                    curuser = new vanphongdanguy(tk, mk, ht, cd);
                }
               // connect.Close();
            }
            return curuser;
        }

        public void themdangvien(string image,string sothe, string hoten, DateTime ngaysinh, string gioitinh, int cmnd, 
            DateTime ngayvaochinhthuc, string noivaochinhthuc, DateTime ngayvaodubi, string noivaodubi, string quequan, 
            string noisinh, string MaTG, string MaDT, string maTDVH, string solylich,string bidanh, string nghenghiep,
            string MaCB, string chucdanh, string choohiennay, string thongtinthem, string tinhtrangDV)
        {
            
            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO dangvien(anhdaidien,MaDV,hoten,ngaysinh,gioitinh,CMND,ngayvaochinhthuc,noivaochinhthuc,ngayvaodubi,noivaodubi,quequan,noisinh,MaTG,MaDT,maTDVH,tinhtrangDV,bidanh,nghenghiep,MaCB,chucdanh,choohiennay,thongtinthem)" +
                                            "VALUES(@image,@sothe,@hoten,@ngaysinh,@gioitinh,@cmnd,@ngayvaochinhthuc,@noivaochinhthuc,@ngayvaodubi,@noivaodubi,@quequan,@noisinh,@MaTG,@MaDT,@maTDVH,@tinhtrangDV,@bidanh,@nghenghiep,@MaCB,@chucdanh,@choohiennay,@thongtinthem) ";
            cmd.Parameters.AddWithValue("@image", convertImageToByte(image));
            cmd.Parameters.AddWithValue("@sothe", sothe );
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Parameters.AddWithValue("@ngaysinh",ngaysinh );
            cmd.Parameters.AddWithValue("@gioitinh",gioitinh );
            cmd.Parameters.AddWithValue("@cmnd", cmnd);
            cmd.Parameters.AddWithValue("@ngayvaochinhthuc",ngayvaochinhthuc );
            cmd.Parameters.AddWithValue("@noivaochinhthuc",noivaochinhthuc );
            cmd.Parameters.AddWithValue("@ngayvaodubi", ngayvaodubi);
            cmd.Parameters.AddWithValue("@noivaodubi",noivaodubi );
            cmd.Parameters.AddWithValue("@quequan",quequan );
            cmd.Parameters.AddWithValue("@noisinh",noisinh );
            cmd.Parameters.AddWithValue("@MaTG", MaTG);
            cmd.Parameters.AddWithValue("@MaDT",MaDT );
            cmd.Parameters.AddWithValue("@maTDVH",maTDVH );
            cmd.Parameters.AddWithValue("@solylich",solylich );
            cmd.Parameters.AddWithValue("@bidanh",bidanh );
            cmd.Parameters.AddWithValue("@nghenghiep",nghenghiep );
            cmd.Parameters.AddWithValue("@MaCB",MaCB );
            cmd.Parameters.AddWithValue("@chucdanh",chucdanh );
            cmd.Parameters.AddWithValue("@thongtinthem",thongtinthem );
            cmd.Parameters.AddWithValue("@choohiennay", choohiennay);
            cmd.Parameters.AddWithValue("@tinhtrangDV", tinhtrangDV);
            cmd.Connection = connect;
            cmd.ExecuteReader();
        }
        private byte[] convertImageToByte(string image){
            FileStream fs;
            fs = new FileStream(image, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;

        }
        public DataSet laydanhsachdangvien() { 
            db_connection();
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM dangvien";
            cmd.Connection = connect;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public void xoadangvien(DataGridViewRow dvr) {
            db_connection();
            cmd = new SqlCommand();
            string MaDV = dvr.Cells["MaDV"].Value.ToString();
            cmd.CommandText = "DELETE FROM dangvien WHERE MADV=@MADV";
            cmd.Parameters.AddWithValue("@MaDV", MaDV);
            cmd.Connection = connect;
            cmd.ExecuteNonQuery();
        }
    }

}
