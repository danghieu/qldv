using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydangvien
{
    public partial class Formdoimatkhau : Form
    {
        vanphongchibo user;
        public Formdoimatkhau(vanphongchibo vpcb)
        {
            InitializeComponent();
            user = vpcb;
            anthongbao();
        }

        private void buttonxacnhan_Click(object sender, EventArgs e)
        {
            if (textBoxmatkhaucu.Text == "" )
            {
                anthongbao();
                labelmatkhaucu.Visible = true;
                
            }
            if(textBoxmatkhaumoi.Text == ""){
                anthongbao();
                labelmkmoi.Visible = true;
            }
            if(textBoxxacnhanmatkhau.Text == ""){
                anthongbao();
                labelxacnhan.Visible = true;
            }

             if (user.Matkhau != textBoxmatkhaucu.Text)
            {
                anthongbao();
                labelmatkhaucu.Visible = true;
            }
            else if (textBoxmatkhaumoi.Text != textBoxxacnhanmatkhau.Text)
            {
                anthongbao();
                labelxacnhan.Visible = true;
            }
            else
            {
                anthongbao();

                user.Matkhau = textBoxmatkhaumoi.Text;
                if (user.DoiMatKhau())
                {
                    labeltb.Text = "Thay đổi mật khẩu thành công!";
                    labeltb.ForeColor = Color.Green;
                    labeltb.Visible = true;

                }
                else {

                    labeltb.Text = "Lỗi hệ thống!";
                    labeltb.ForeColor = Color.Red;
                    labeltb.Visible = true;
                }

                
            }

        }
        private void Formdoimatkhau_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void anthongbao() {
            labelmatkhaucu.Visible = false;
            labelxacnhan.Visible = false;
            labeltb.Visible = false;
            labeltb.Text = "Điền đầy đủ thông tin!";
            labeltb.ForeColor = Color.Red;
            labelmkmoi.Visible = false;
        
        }

        private void buttonhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
