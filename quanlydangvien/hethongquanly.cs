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
        database db = new database();
        DataSet ds = new DataSet();
        string form;
        vanphongchibo user;
        int start;
        int totalrecord;
        int pages;
        public formhethongquanly(vanphongchibo vpcb)
        {
            InitializeComponent();


            toolStripquanlyhoso.Visible = false;
            comboBoxloc.Visible = false;
            textBoxtimkiem.Visible = false;
            buttontimkiem.Visible = false;
            buttonendpre.Visible = false;
            buttonpre.Visible = false;
            buttonnext.Visible = false;
            buttonendnext.Visible = false;
            labeltongtrang.Visible = false;
            textBoxsotrang.Visible = false;
            tabControl1.Visible = false;
            dataGridViewdanhsach.Visible = false;
            user = vpcb;
            start = 0;
            if (form == "chibo") {
                tabPagedsdvchinhthuc.Text = "Danh Sách Chi Bộ";
            }

            //commbobox loc

            comboBoxloc.Items.AddRange(db.dschibocbb().ToArray());  
            comboBoxloc.DisplayMember = "tencb";
            



            textBoxsotrang.Text = (start / 10 + 1).ToString();
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
            Formdoimatkhau dmk = new Formdoimatkhau(user);
            dmk.ShowDialog();
        }

        private void thêmĐảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themdangvien formthemdangvien = new themdangvien("THÊM ĐẢNG VIÊN", null);
            formthemdangvien.ShowDialog();
        }

        private void danhSáchĐảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabPagedsdvchinhthuc);
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Add(tabPage3);

            Anlogo();
            hiendanhsach();
            //
            form = "dangvien";
            tabPagedsdvchinhthuc.Text = "Danh Sách Đảng Viên";
            tabPage2.Text = "Danh Sách Đảng Viên Chính Thức";
            tabPage3.Text = "Danh Sách Đảng Viên Dự Bị";
            loaddsdangvien("","");
            totalrecord = ds.Tables[0].Rows.Count;
            pages = totalrecord / 10;
            labeltongtrang.Text = "Của " + (pages + 1).ToString();
            
        }
        private void loaddsdangvien(string ten, string macb)
        {

            ds = db.pagingdangvien(start, ten, macb);
            dataGridViewdanhsach.DataSource = ds.Tables[0];
            //dataGridViewdanhsach.DataMember = "bang_dangvien";
        }
        private void toolStripButtonsua_Click(object sender, EventArgs e)
        {

            if (dataGridViewdanhsach.SelectedRows.Count > 0)
            {
                if (form == "dangvien")
                {
                    themdangvien tdv = new themdangvien("SỬA ĐẢNG VIÊN", dataGridViewdanhsach.SelectedRows[0]);
                    tdv.ShowDialog();
                }
                else if (form == "chibo")
                {
                    Formthemchibo tcb = new Formthemchibo("SỬA CHI BỘ", dataGridViewdanhsach.SelectedRows[0]);
                    tcb.ShowDialog();
                }

            }
        }

        private void toolStripButtonxoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewdanhsach.SelectedRows.Count > 0)
            {

                if (MessageBox.Show(null, "Bạn có muốn xóa không!", "Cảnh Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (form == "dangvien")
                    {
                        db.xoadangvien(dataGridViewdanhsach.SelectedRows[0]);
                        loaddsdangvien("","");
                    }
                    else if (form == "chibo")
                    {
                        db.xoachibo(dataGridViewdanhsach.SelectedRows[0]);
                        loaddschibo();
                    }



                }
            }
        }

        private void comboBoxloc_SelectedIndexChanged(object sender, EventArgs e)
        {
            chibo cbselect = new chibo(((chibo)comboBoxloc.SelectedItem).MaCB, ((chibo)comboBoxloc.SelectedItem).TenCB);
            loaddsdangvien("", cbselect.MaCB);
        }

        private void formhethongquanly_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewdanhsach.SelectedRows.Count > 0)
            {
                toolStripButtonsua.Enabled = true;
                toolStripButtonxoa.Enabled = true;
            }
            else
            {
                toolStripButtonsua.Enabled = false;
                toolStripButtonxoa.Enabled = false;
            }

        }

        private void quảnLýChiBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anlogo();
            hiendanhsach();
            start = 0;
            menuStrip1.Select();
            form = "chibo";
            tabPagedsdvchinhthuc.Text = "Danh Sách Chi Bộ";
            
            ds = db.pagingchibo(start,"","");
            dataGridViewdanhsach.DataSource = ds.Tables[0];

            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            
        }
        private void Anlogo()
        {
            pictureBoxlogo.Visible = false;
            labeltb1.Visible = false;
            labeltb2.Visible = false;
            labeltb3.Visible = false;

        }
        private void hiendanhsach()
        {
            toolStripquanlyhoso.Visible = true;
            toolStripButtonsua.Enabled = false;
            toolStripButtonxoa.Enabled = false;
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
        }

        private void toolStripButtonthem_Click(object sender, EventArgs e)
        {
            if (form == "dangvien")
            {
                themdangvien tdv = new themdangvien("THÊM ĐẢNG VIÊN", null);
                tdv.ShowDialog();
            }
            else if (form == "chibo")
            {
                Formthemchibo tcb = new Formthemchibo("THÊM CHI BỘ", null);
                tcb.ShowDialog();
            }
        }
       
        private void loaddschibo() {
            ds = db.laydanhsachchibo();
            dataGridViewdanhsach.DataSource = ds.Tables[0];
        }

        private void toolStripButtonlammoi_Click(object sender, EventArgs e)
        {
            if (form == "dangvien") {

                loaddsdangvien("", "");
            }
            else if (form == "chibo") {
                loaddschibo();
            }
        }

        private void toolStripButtontimkiem_Click(object sender, EventArgs e)
        {

        }

        private void buttontimkiem_Click(object sender, EventArgs e)
        {
            ds = db.timkiemtendv(textBoxtimkiem.Text);
            dataGridViewdanhsach.DataSource = ds.Tables[0];
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBoxtimkiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxtimkiem_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxtimkiem.SelectAll();
        }

        private void textBoxtimkiem_MouseUp(object sender, MouseEventArgs e)
        {
            if (textBoxtimkiem.Text == "") textBoxtimkiem.Text = "Nhập Tên Đảng Viên";
        }

        private void buttonpre_Click(object sender, EventArgs e)
        {
             start = start - 10;
            if (start <= 0)
            {
                start = 0;
            }
            loaddsdangvien("","");
            textBoxsotrang.Text =  (start / 10 + 1).ToString();
        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            start = start + 10;
            if (start > totalrecord)
            {
                start = totalrecord -totalrecord%10;
            }
            loaddsdangvien("","");
            textBoxsotrang.Text = (start / 10 + 1).ToString();
        }

        private void textBoxsotrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxsotrang.Text != null) {
                if (e.KeyChar == (char)Keys.Enter) {
                    start = (Int32.Parse(textBoxsotrang.Text)-1)*10;
                    loaddsdangvien("","");
                    
                }
            }
        }

        private void xuấtDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Frm_danhsachdangvien()).ShowDialog();
        }

        private void formhethongquanly_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonketxuat_Click(object sender, EventArgs e)
        {
            (new Frm_danhsachdangvien()).ShowDialog();
        }

        private void toolStripButtontat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
