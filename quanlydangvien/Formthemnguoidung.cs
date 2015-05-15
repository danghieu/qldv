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
    public partial class Formthemnguoidung : Form
    {
        public Formthemnguoidung(string text)
        {
            InitializeComponent();
            labeltb.Visible = false;
            Text = text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxhoten.Text == "" || textBoxmatkhau.Text == "" || textBoxtaikhoan.Text == "" || comboBox1.Text == "" || richTextBoxthongtin.Text == "")
            {
                labeltb.Visible = true;
            }
            else {
                vanphongchibo user = new vanphongchibo(textBoxtaikhoan.Text, textBoxmatkhau.Text, textBoxhoten.Text, Int32.Parse(comboBox1.Text), richTextBoxthongtin.Text);
                if (!user.themuser()) {
                    MessageBox.Show(null, "Người dùng đã tồn tại!", "Thông Báo", MessageBoxButtons.OK);

                }else
                MessageBox.Show(null, "Thêm người dùng thành công", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void Formthemnguoidung_Load(object sender, EventArgs e)
        {

        }
    }
}
