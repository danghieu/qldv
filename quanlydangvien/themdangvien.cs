using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace quanlydangvien
{
    public partial class themdangvien : Form
    {
        String image = Directory.GetCurrentDirectory() + @"/upload/noavatar.gif";
        
                //var data = (Byte[])(row.Cells["afbeelding"].Value);
               // var stream = new MemoryStream(data);
               // pictureBox1.Image= Image.FromStream(stream);
                
        public themdangvien(bool edit,DataGridViewRow dvr)
        {
            InitializeComponent();
            if (edit == true) {
                Text = "Sửa Đảng Viên";
                var data = (Byte[])(dvr.Cells["anhdaidien"].Value);
                var stream = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(stream);
                
                textBoxsothedv.Text = dvr.Cells["MaDV"].Value.ToString();
                textBoxten.Text= dvr.Cells["hoten"].Value.ToString();
                comboBoxtrangthai.Text =dvr.Cells["tinhtrangDV"].Value.ToString();
                textBoxsolylich.Text=dvr.Cells["solylich"].Value.ToString();
                textBoxcmnd.Text=dvr.Cells["CMND"].Value.ToString(); 
                dateTimePickerngaysinh.Value=(DateTime) dvr.Cells["ngaysinh"].Value;
                comboBoxdantoc.Text=dvr.Cells["MaDT"].Value.ToString();
                comboBoxtongiao.Text=dvr.Cells["MaTG"].Value.ToString(); 
                comboBoxtrinhdophothong.Text=dvr.Cells["maTDVH"].Value.ToString();
                comboBoxchucdanh.Text=dvr.Cells["chucdanh"].Value.ToString();
                comboBoxgioitinh.Text=dvr.Cells["gioitinh"].Value.ToString();
                textBoxbidanh.Text=dvr.Cells["bidanh"].Value.ToString();
                textBoxnghenghiep.Text=dvr.Cells["nghenghiep"].Value.ToString();
                textBoxnoisinh.Text=dvr.Cells["noisinh"].Value.ToString(); 
                textBoxquequan.Text=dvr.Cells["quequan"].Value.ToString(); 
                textBoxhiennay.Text=dvr.Cells["choohiennay"].Value.ToString(); 
                textBoxnoivaodubi.Text=dvr.Cells["noivaodubi"].Value.ToString(); 
                dateTimePickerngayvaodubi.Value=(DateTime) dvr.Cells["ngayvaodubi"].Value;
                textBoxnoivaochinhthuc.Text=dvr.Cells["MaDV"].Value.ToString();
                dateTimePickerngayvaochinhthuc.Value=(DateTime) dvr.Cells["ngayvaochinhthuc"].Value;
                comboBoxngoaingu.Text=dvr.Cells["ngoaingu"].Value.ToString(); 
                comboBoxchibo.Text=dvr.Cells["MaCB"].Value.ToString();
                richTextBoxthongtinthem.Text = dvr.Cells["thongtinthem"].Value.ToString();
            }
            
        }

         

        private void labelngoaingu_Click(object sender, EventArgs e)
        {

        }

        private void buttonbrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = open.Filter = "Image file|" + "*.png; *.jpg; *.jpeg; *.jfif; *.bmp;*.tif; *.tiff; *.gif";
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromStream(open.OpenFile());
                
                image = open.FileName;
            }
           
        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            dangvien dv = new dangvien(
                image, 
                textBoxsothedv.Text, 
                textBoxten.Text, 
                comboBoxtrangthai.Text,
                textBoxsolylich.Text,
                int.Parse(textBoxcmnd.Text), 
                dateTimePickerngaysinh.Value,
                comboBoxdantoc.Text, 
                comboBoxtongiao.Text, 
                comboBoxtrinhdophothong.Text, 
                comboBoxchucdanh.Text,
                comboBoxgioitinh.Text,
                textBoxbidanh.Text, 
                textBoxnghenghiep.Text, 
                textBoxnoisinh.Text, 
                textBoxquequan.Text, 
                textBoxhiennay.Text, 
                textBoxnoivaodubi.Text, 
                dateTimePickerngayvaodubi.Value, 
                textBoxnoivaochinhthuc.Text,
                dateTimePickerngayvaochinhthuc.Value, 
                comboBoxngoaingu.Text, 
                comboBoxchibo.Text, 
                richTextBoxthongtinthem.Text);
            //Them Dang Vien
                dv.themdangvien();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void labelcacbidanh_Click(object sender, EventArgs e)
        {

        }

        private void buttontrove_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                tabControl1.SelectedTab = tabPage1;
            }
            else { this.Close(); }


            
        }

        private void textBoxcmnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void themdangvien_Load(object sender, EventArgs e)
        {

        }

        private void buttontieptheo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
    }
}
