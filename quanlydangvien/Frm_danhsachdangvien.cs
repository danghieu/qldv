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
    public partial class Frm_danhsachdangvien : Form
    {
        public Frm_danhsachdangvien()
        {
            InitializeComponent();
        }

        private void Frm_danhsachdangvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.dangvien' table. You can move, or remove it, as needed.
            this.dangvienTableAdapter.Fill(this.ds.dangvien);

            this.reportViewer1.RefreshReport();
        }
    }
}
