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
    public partial class Formthemchibo : Form
    {
        DataSet ds = new DataSet();
        database db = new database();
        DataGridViewRow drv= new DataGridViewRow();
        public Formthemchibo(string text)
        {
            InitializeComponent();
            ds = db.laydanhsachchibo();
            dataGridViewds.DataSource = ds.Tables[0];
            dataGridViewds.Columns[0].HeaderText = "Mã Chi Bộ";
            dataGridViewds.Columns[1].HeaderText = "Tên Chi Bộ";
            Text = text;
            labeltb.Visible = false;

            buttonxoa.Enabled = false;
            if (text=="SỬA CHI BỘ") {
                labelthemchibo.Text = text;
                buttoncapnhat.Text = "Cập nhật";
            }

        }

        private void Formthemchibo_Load(object sender, EventArgs e)
        {

        }

        private void buttoncapnhat_Click(object sender, EventArgs e)
        {
            chibo cb = new chibo(textBoxmachibo.Text, textBoxtenchibo.Text);
            if (Text == "SỬA CHI BỘ")
            {
                if (cb.suachibo())
                {
                    loaddschibo();
                    labeltb.Visible = true;
                    labeltb.Text = "Cập nhật Thành Công";
                    labeltb.ForeColor = Color.Green;
                }


                else {
                    labeltb.Visible = true;
                    labeltb.Text = "Lỗi Hệ Thống!";
                    labeltb.ForeColor = Color.Red;
                } 
            }
            else {
                if (cb.themchibo())
                {
                    labeltb.Visible = true;
                    labeltb.Text = "Thêm Thành Công";
                    labeltb.ForeColor = Color.Green;
                    if (MessageBox.Show(null, "Bạn muốn tiếp tục thêm Đảng viên không?", "Nhắc nhở", MessageBoxButtons.YesNoCancel) == DialogResult.No)
                    {
                        Close();
                    }
                }
                else {

                    MessageBox.Show(null, "Chi Bộ đã tồn tại", "Cảnh báo", MessageBoxButtons.OK);
                }
                
            }
        }
        private void loaddschibo()
        {
            ds = db.laydanhsachchibo();
            dataGridViewds.DataSource = ds.Tables[0];
        }

        private void dataGridViewds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewds.SelectedRows.Count > 0)
            {
                buttonxoa.Enabled = true;
                if (Text == "SỬA CHI BỘ")
                {
                    drv = dataGridViewds.SelectedRows[0];
                    textBoxmachibo.Text = drv.Cells[0].Value.ToString();
                    textBoxtenchibo.Text = drv.Cells[1].Value.ToString();
                }
                
            }
            else {
                buttonxoa.Enabled = false;
            }
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewds.SelectedRows.Count > 0)
            {

                if (MessageBox.Show(null, "Bạn có muốn xóa không!", "Cảnh Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                        db.xoachibo(dataGridViewds.SelectedRows[0]);
                        loaddschibo();
                    
                }
            }
        }
    }
}
