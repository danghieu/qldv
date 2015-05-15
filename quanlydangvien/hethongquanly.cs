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
        DataSet ds, dstong;
        string form;
        vanphongchibo user;
        DataGridViewRow dvr;
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
            textBoxsotrang.Text = (start / 15 + 1).ToString();
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
            form = "dangvien";
        }

        private void danhSáchĐảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabPagedsdvchinhthuc);
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Add(tabPage3);
            textBoxtimkiem.Text = "Nhập Tên Đảng Viên";
            Anlogo();
            hiendanhsach();
            //
            form = "dangvien";
            tabPagedsdvchinhthuc.Text = "Danh Sách Đảng Viên";
            loaddsdangvien("", "");
            tabPage2.Text = "Danh Sách Đảng Viên Chính Thức";
            loaddsdangvienct("", "","DVCT");
            tabPage3.Text = "Danh Sách Đảng Viên Dự Bị";
            loaddsdangviendb("","","DVDB");
            lammoi();
            
        }
        private void loaddsdangvien(string ten, string macb)
        {

            ds = db.pagingdangvien(start, ten, macb,"");
            designbang();            
            


            //Dien vao cot so thu tu 
            dataGridViewdanhsach.DataSource = ds.Tables[0];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dataGridViewdanhsach.Rows[i].Cells[0].Value = (i + 1 + start );

            }  
            //dataGridViewdanhsach.DataMember = "bang_dangvien";
        }
        private void loaddsdangvienct(string ten, string macb,string trangthai)
        {

            ds = db.pagingdangvien(start, ten, macb, trangthai);
            dataGridViewdvct.Columns.Clear();

            
           


            //Dien vao cot so thu tu 
            dataGridViewdvct.DataSource = ds.Tables[0];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dataGridViewdvct.Rows[i].Cells[0].Value = (i + 1 + start);

            }
            //dataGridViewdanhsach.DataMember = "bang_dangvien";
        }
        private void loaddsdangviendb(string ten, string macb, string trangthai)
        {

            ds = db.pagingdangvien(start, ten, macb, trangthai);
            dataGridViewdvdb.Columns.Clear();

          
            //Dien vao cot so thu tu 
            dataGridViewdvdb.DataSource = ds.Tables[0];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dataGridViewdvdb.Rows[i].Cells[0].Value = (i + 1 + start);

            }
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
                    Formthemchibo tcb = new Formthemchibo("SỬA CHI BỘ");
                    tcb.ShowDialog();
                }
                else if (form == "nguoidung") {
                    dvr = dataGridViewdanhsach.SelectedRows[0];
                    string tk = dvr.Cells[1].Value.ToString();

                    vanphongchibo u = new vanphongchibo(tk);
                    (new Formthemnguoidung("SỬA NGƯỜI DÙNG")).ShowDialog();
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
                        loaddschibo("","");
                    }
                    else if (form == "nguoidung") {
                        dvr = dataGridViewdanhsach.SelectedRows[0];
                        string tk=  dvr.Cells[1].Value.ToString(); 
                        vanphongchibo u = new vanphongchibo(tk);
                        if (u.xoauser())
                        {
                            loaddsnguoidung("");
                        }
                        else {
                            MessageBox.Show(null, "Không thể xóa được người dùng!", "Lỗi Hệ Thống", MessageBoxButtons.OK);
                        }
                    }



                }
            }
        }

        private void comboBoxloc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (form == "dangvien")
            {
                chibo cbselect = new chibo(((chibo)comboBoxloc.SelectedItem).MaCB, ((chibo)comboBoxloc.SelectedItem).TenCB);
                loaddsdangvien("", cbselect.MaCB);
                
            }
            else if (form == "chibo") {
                chibo cbselect = new chibo(((chibo)comboBoxloc.SelectedItem).MaCB, ((chibo)comboBoxloc.SelectedItem).TenCB);
                loaddschibo("", cbselect.MaCB);
                
            }
            loadsotrang();
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
            textBoxtimkiem.Text = "Nhập Tên Chi Bộ";
            loaddschibo("","");

            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);

            loadsotrang();
            
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
                Formthemchibo tcb = new Formthemchibo("THÊM CHI BỘ");
                tcb.ShowDialog();
            }
            else if (form == "nguoidung") {
                Formthemnguoidung tnd = new Formthemnguoidung("Thêm Người Dùng");
                tnd.ShowDialog();
            }
        }
       
        private void loaddschibo(string ten,string macb) {
            ds = db.pagingchibo(start,ten,macb);
            dataGridViewdanhsach.Columns.Clear();

            DataGridViewTextBoxColumn stt = new DataGridViewTextBoxColumn();
            stt.ValueType = typeof(Int32);
            stt.HeaderText = "STT";
            //stt.Frozen = true;
            stt.Width = 100;
            stt.Resizable = DataGridViewTriState.True;
            dataGridViewdanhsach.Columns.Add(stt);


            //Dien vao cot so thu tu 
            dataGridViewdanhsach.DataSource = ds.Tables[0];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                dataGridViewdanhsach.Rows[i].Cells[0].Value = (i + 1 + start * 15);

            }  
            
        }

        private void toolStripButtonlammoi_Click(object sender, EventArgs e)
        {
            lammoi();
        }
        private void lammoi(){
            if (form == "dangvien")
            {
                textBoxsotrang.Text = (start / 15 + 1).ToString();
                loaddsdangvien("", "");
                dstong = db.laydanhsachdangvien();

            }
            else if (form == "chibo")
            {
                loaddschibo("", "");
                dstong = db.laydanhsachchibo();
            }
            else if (form == "nguoidung")
            {
                loaddsnguoidung("");
            }
            totalrecord = dstong.Tables[0].Rows.Count;
            pages = totalrecord / 15;
            labeltongtrang.Text = "Của " + (pages + 1).ToString();
        }
        private void toolStripButtontimkiem_Click(object sender, EventArgs e)
        {

        }

        private void buttontimkiem_Click(object sender, EventArgs e)
        {
            if(form=="dangvien"){
                loaddsdangvien(textBoxtimkiem.Text,"");
                loaddsdangvienct(textBoxtimkiem.Text,"","DVCT");
                loaddsdangviendb(textBoxtimkiem.Text, "", "DVDB");
            }
            else if (form == "chibo") {
                loaddschibo(textBoxtimkiem.Text,"");
                
            }
            else if (form == "nguoidung") {
                loaddsnguoidung(textBoxtimkiem.Text);
                
            }
            loadsotrang();
            
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

             start = start - 15;
            if (start <= 0)
            {
                start = 0;
            }
            if (form == "dangvien") {
                loaddsdangvien("", "");
                
            }else
                if (form == "nguoidung") {
                    loaddsnguoidung("");
                }
            textBoxsotrang.Text = (start / 15 + 1).ToString();
        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            start = start + 15;
            if (start > totalrecord)
            {
                start = totalrecord -totalrecord%15;
            }
            if (form == "dangvien")
            {
                loaddsdangvien("", "");

            }
            else
                if (form == "nguoidung")
                {
                    loaddsnguoidung("");
                }
            textBoxsotrang.Text = (start / 15 + 1).ToString();
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

        private void danhSáchĐảngViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new Frm_danhsachdangvien()).ShowDialog();
        }

        private void buttonendpre_Click(object sender, EventArgs e)
        {
            start = 0;
            textBoxsotrang.Text = (start / 15 + 1).ToString();
            if (form == "dangvien")
            {
                loaddsdangvien("", "");

            }
            else
                if (form == "nguoidung")
                {
                    loaddsnguoidung("");
                }
            
        }

        private void buttonendnext_Click(object sender, EventArgs e)
        {
            start = start = totalrecord - totalrecord % 15;
            textBoxsotrang.Text = (start / 15 + 1).ToString();
            if (form == "dangvien")
            {
                loaddsdangvien("", "");

            }
            else
                if (form == "nguoidung")
                {
                    loaddsnguoidung("");
                }
            
        }

        private void quốcGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void qLNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Anlogo();
            hiendanhsach();
            start = 0;
            menuStrip1.Select();
            form = "nguoidung";
            tabPagedsdvchinhthuc.Text = "Danh Sách Người Dùng";
            loaddsnguoidung("");
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            DataSet dstong = new DataSet();
            dstong = db.laydanhsachdangvien();
            totalrecord = dstong.Tables[0].Rows.Count;
            pages = totalrecord / 15;
            labeltongtrang.Text = "Của " + (pages + 1).ToString();
        }

        private void loaddsnguoidung(string ten) 
        {
            
         
            
            ds = db.pagingnguoidung(start,ten);

            designbang();

            dataGridViewdanhsach.DataSource = ds.Tables[0];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                dataGridViewdanhsach.Rows[i].Cells[0].Value = (i + 1 + start);

            }  
        }

        private void designbang() {

            dataGridViewdanhsach.Columns.Clear();
        
            DataGridViewTextBoxColumn stt = new DataGridViewTextBoxColumn();
            stt.ValueType = typeof(Int32);
            stt.HeaderText = "STT";
            //stt.Frozen = true;
            stt.Width = 100;
            stt.Resizable = DataGridViewTriState.True;
            dataGridViewdanhsach.Columns.Add(stt);
            if(form =="nguoidung"){
                DataGridViewTextBoxColumn colum = new DataGridViewTextBoxColumn();
                colum.DataPropertyName = "taikhoan";
                colum.ValueType = typeof(string);
                colum.HeaderText = "Tài Khoản";
                //colum.Frozen = true;
                colum.Width = 200;
                dataGridViewdanhsach.Columns.Add(colum);

                DataGridViewTextBoxColumn colum2 = new DataGridViewTextBoxColumn();
                colum2.DataPropertyName = "hoten";
                colum2.ValueType = typeof(string);
                colum2.HeaderText = "Họ Và Tên";
                // colum2.Frozen = true;

                colum2.Width = 280;



                dataGridViewdanhsach.Columns.Add(colum2);

                DataGridViewTextBoxColumn colum3 = new DataGridViewTextBoxColumn();
                colum3.DataPropertyName = "thongtin";
                colum3.ValueType = typeof(string);
                colum3.HeaderText = "Thông Tin";
                colum3.Width = 360;
                dataGridViewdanhsach.Columns.Add(colum3);
            }

           
               
                
                //Dien vao cot so thu tu 
                
                
            
        
        }
        private void loadsotrang() {
            
            totalrecord = ds.Tables[0].Rows.Count;
            pages = totalrecord / 15;
            labeltongtrang.Text = "Của " + (pages + 1).ToString();
        }

        private void toolStripquanlyhoso_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
