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
        public Formthemchibo(string text, DataGridViewRow dvr)
        {
            InitializeComponent();
            ds = db.laydanhsachchibo();
            dataGridViewds.DataSource = ds.Tables[0];
            dataGridViewds.Columns[0].HeaderText = "Mã Chi Bộ";
            dataGridViewds.Columns[1].HeaderText = "Tên Chi Bộ";
            Text = text;
            if (text=="SỬA CHI BỘ") {
                labelthemchibo.Text = text;
                textBoxmachibo.Text = dvr.Cells["MaCB"].Value.ToString();
                textBoxtenchibo.Text = dvr.Cells["TenCB"].Value.ToString();
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
                
                cb.suachibo();
            }
            else {
                if (cb.themchibo())
                {
                    this.Close();
                }
                else {
                    MessageBox.Show(null, "Chi Bộ đã tồn tại", "Cảnh báo", MessageBoxButtons.OK);
                }
                
            }
        }
    }
}
