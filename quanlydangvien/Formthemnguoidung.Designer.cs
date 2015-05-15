namespace quanlydangvien
{
    partial class Formthemnguoidung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labeltaikhoan = new System.Windows.Forms.Label();
            this.labelmatkhau = new System.Windows.Forms.Label();
            this.labelhoten = new System.Windows.Forms.Label();
            this.labelcapdo = new System.Windows.Forms.Label();
            this.labelthongtin = new System.Windows.Forms.Label();
            this.textBoxtaikhoan = new System.Windows.Forms.TextBox();
            this.textBoxmatkhau = new System.Windows.Forms.TextBox();
            this.textBoxhoten = new System.Windows.Forms.TextBox();
            this.richTextBoxthongtin = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labeltb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(205, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Người Dùng";
            // 
            // labeltaikhoan
            // 
            this.labeltaikhoan.AutoSize = true;
            this.labeltaikhoan.Location = new System.Drawing.Point(75, 82);
            this.labeltaikhoan.Name = "labeltaikhoan";
            this.labeltaikhoan.Size = new System.Drawing.Size(56, 13);
            this.labeltaikhoan.TabIndex = 1;
            this.labeltaikhoan.Text = "Tài Khoản";
            // 
            // labelmatkhau
            // 
            this.labelmatkhau.AutoSize = true;
            this.labelmatkhau.Location = new System.Drawing.Point(75, 121);
            this.labelmatkhau.Name = "labelmatkhau";
            this.labelmatkhau.Size = new System.Drawing.Size(53, 13);
            this.labelmatkhau.TabIndex = 2;
            this.labelmatkhau.Text = "Mật Khẩu";
            // 
            // labelhoten
            // 
            this.labelhoten.AutoSize = true;
            this.labelhoten.Location = new System.Drawing.Point(75, 159);
            this.labelhoten.Name = "labelhoten";
            this.labelhoten.Size = new System.Drawing.Size(43, 13);
            this.labelhoten.TabIndex = 3;
            this.labelhoten.Text = "Họ Tên";
            // 
            // labelcapdo
            // 
            this.labelcapdo.AutoSize = true;
            this.labelcapdo.Location = new System.Drawing.Point(75, 203);
            this.labelcapdo.Name = "labelcapdo";
            this.labelcapdo.Size = new System.Drawing.Size(43, 13);
            this.labelcapdo.TabIndex = 4;
            this.labelcapdo.Text = "Cấp Độ";
            // 
            // labelthongtin
            // 
            this.labelthongtin.AutoSize = true;
            this.labelthongtin.Location = new System.Drawing.Point(75, 235);
            this.labelthongtin.Name = "labelthongtin";
            this.labelthongtin.Size = new System.Drawing.Size(52, 13);
            this.labelthongtin.TabIndex = 5;
            this.labelthongtin.Text = "Thông tin";
            this.labelthongtin.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxtaikhoan
            // 
            this.textBoxtaikhoan.Location = new System.Drawing.Point(160, 82);
            this.textBoxtaikhoan.Name = "textBoxtaikhoan";
            this.textBoxtaikhoan.Size = new System.Drawing.Size(171, 20);
            this.textBoxtaikhoan.TabIndex = 6;
            this.textBoxtaikhoan.Text = "cntt";
            // 
            // textBoxmatkhau
            // 
            this.textBoxmatkhau.Location = new System.Drawing.Point(160, 121);
            this.textBoxmatkhau.Name = "textBoxmatkhau";
            this.textBoxmatkhau.PasswordChar = '*';
            this.textBoxmatkhau.Size = new System.Drawing.Size(171, 20);
            this.textBoxmatkhau.TabIndex = 7;
            this.textBoxmatkhau.Text = "123456";
            // 
            // textBoxhoten
            // 
            this.textBoxhoten.Location = new System.Drawing.Point(160, 159);
            this.textBoxhoten.Name = "textBoxhoten";
            this.textBoxhoten.Size = new System.Drawing.Size(171, 20);
            this.textBoxhoten.TabIndex = 8;
            this.textBoxhoten.Text = "Tran Van B";
            // 
            // richTextBoxthongtin
            // 
            this.richTextBoxthongtin.Location = new System.Drawing.Point(160, 244);
            this.richTextBoxthongtin.Name = "richTextBoxthongtin";
            this.richTextBoxthongtin.Size = new System.Drawing.Size(243, 96);
            this.richTextBoxthongtin.TabIndex = 10;
            this.richTextBoxthongtin.Text = "Van Phong Chi Bo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(209, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(327, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(160, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(62, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // labeltb
            // 
            this.labeltb.AutoSize = true;
            this.labeltb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltb.ForeColor = System.Drawing.Color.Red;
            this.labeltb.Location = new System.Drawing.Point(166, 53);
            this.labeltb.Name = "labeltb";
            this.labeltb.Size = new System.Drawing.Size(155, 15);
            this.labeltb.TabIndex = 13;
            this.labeltb.Text = "Điền Đầy Đủ Thông Tin";
            // 
            // Formthemnguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 428);
            this.Controls.Add(this.labeltb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxthongtin);
            this.Controls.Add(this.textBoxhoten);
            this.Controls.Add(this.textBoxmatkhau);
            this.Controls.Add(this.textBoxtaikhoan);
            this.Controls.Add(this.labelthongtin);
            this.Controls.Add(this.labelcapdo);
            this.Controls.Add(this.labelhoten);
            this.Controls.Add(this.labelmatkhau);
            this.Controls.Add(this.labeltaikhoan);
            this.Controls.Add(this.label1);
            this.Name = "Formthemnguoidung";
            this.Text = "Formthemnguoidung";
            this.Load += new System.EventHandler(this.Formthemnguoidung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltaikhoan;
        private System.Windows.Forms.Label labelmatkhau;
        private System.Windows.Forms.Label labelhoten;
        private System.Windows.Forms.Label labelcapdo;
        private System.Windows.Forms.Label labelthongtin;
        private System.Windows.Forms.TextBox textBoxtaikhoan;
        private System.Windows.Forms.TextBox textBoxmatkhau;
        private System.Windows.Forms.TextBox textBoxhoten;
        private System.Windows.Forms.RichTextBox richTextBoxthongtin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labeltb;
    }
}