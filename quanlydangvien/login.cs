using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace quanlydangvien
{
    public partial class Formquanlydangvien : Form
    {
        database db = new database();
        public Formquanlydangvien()
        {
            InitializeComponent();
            labelthongbao.Visible = false;
            labelthongbaotaikhoan.Visible = false;
            labelthongbaomatkhau.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vanphongchibo curuser = db.checklogin(textBoxtaikhoan.Text, textBoxmatkhau.Text);
            if (textBoxtaikhoan.Text == "")
            {
                labelthongbaotaikhoan.Visible = true;
            }
            else if (textBoxmatkhau.Text == "")
            {
                labelthongbaomatkhau.Visible = true;
            }
            else if (curuser != null)
            {

                this.Hide();
                formhethongquanly htql = new formhethongquanly();
                htql.Show();
            }
            else labelthongbao.Visible = true;

            
        }

        private void linkLabelquenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ văn phòng Đảng ủy để lấy lại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
