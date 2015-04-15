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
    public partial class formhethongquanly : Form
    {
        public formhethongquanly()
        {
            InitializeComponent();
            database db = new database();
            toolStripquanlyhoso.Visible = false;
            comboBoxloc.Visible = false;
            textBoxtimkiem.Visible = false;
            buttontimkiem.Visible = false;
            buttonendpre.Visible  = false;
            buttonpre.Visible = false;
            buttonnext.Visible = false;
            buttonendnext.Visible = false;
            labeltongtrang.Visible = false;
            textBoxsotrang.Visible = false;
            tabControl1.Visible = false;
            dataGridViewdanhsach.Visible = false;
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thêmĐảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool edit = false; //
            themdangvien formthemdangvien = new themdangvien(edit,null);
            formthemdangvien.ShowDialog();
        }

        private void danhSáchĐảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pictureBoxlogo.Visible = false;
            labeltb1.Visible = false;
            labeltb2.Visible = false;
            labeltb3.Visible = false;
            toolStripquanlyhoso.Visible = true;
            comboBoxloc.Visible = true;
            textBoxtimkiem.Visible = true;
            buttontimkiem.Visible = true;
            buttonendpre.Visible = true;
            buttonpre.Visible = true;
            buttonnext.Visible = true;
            buttonendnext.Visible = true;
            labeltongtrang.Visible = true;
            textBoxsotrang.Visible = true;
            tabControl1.Visible = true;
            dataGridViewdanhsach.Visible = true;
            database db = new database();
            DataSet ds= new DataSet();
            ds = db.laydanhsachdangvien();
            dataGridViewdanhsach.DataSource = ds.Tables[0];
            if (dataGridViewdanhsach.SelectedRows.Count > 0)
            {

               
            }

        }

        private void toolStripButtonsua_Click(object sender, EventArgs e)
        {
            if (dataGridViewdanhsach.SelectedRows.Count > 0) {
                
                themdangvien tdv = new themdangvien(true, dataGridViewdanhsach.SelectedRows[0]);
                tdv.ShowDialog();
            }
        }

        private void toolStripButtonxoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewdanhsach.SelectedRows.Count > 0)
            {

                if (MessageBox.Show(null, "Bạn có muốn xóa không!", "Cảnh Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    database db = new database();
                    db.xoadangvien(dataGridViewdanhsach.SelectedRows[0]);
                    DataSet ds = new DataSet();
                    ds = db.laydanhsachdangvien();
                    dataGridViewdanhsach.DataSource = ds.Tables[0];
                    
                }
            }
        }

        private void comboBoxloc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
