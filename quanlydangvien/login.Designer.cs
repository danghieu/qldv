namespace quanlydangvien
{
    partial class Formquanlydangvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formquanlydangvien));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxtaikhoan = new System.Windows.Forms.TextBox();
            this.textBoxmatkhau = new System.Windows.Forms.TextBox();
            this.buttondangnhap = new System.Windows.Forms.Button();
            this.linkLabelquenmatkhau = new System.Windows.Forms.LinkLabel();
            this.labelthongbao = new System.Windows.Forms.Label();
            this.labelthongbaotaikhoan = new System.Windows.Forms.Label();
            this.labelthongbaomatkhau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(397, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐẢNG CỘNG SẢN VIỆT NAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(426, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "ĐẠI HỌC BÁCH KHOA ĐÀ NẴNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(208, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(438, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập Tài khoản và mật khẩu để truy cập vào hệ thống quản lý Đảng viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tài Khoản";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mật Khẩu";
            // 
            // textBoxtaikhoan
            // 
            this.textBoxtaikhoan.Location = new System.Drawing.Point(358, 240);
            this.textBoxtaikhoan.Name = "textBoxtaikhoan";
            this.textBoxtaikhoan.Size = new System.Drawing.Size(141, 20);
            this.textBoxtaikhoan.TabIndex = 7;
            this.textBoxtaikhoan.Text = "admin";
            // 
            // textBoxmatkhau
            // 
            this.textBoxmatkhau.Location = new System.Drawing.Point(358, 281);
            this.textBoxmatkhau.Name = "textBoxmatkhau";
            this.textBoxmatkhau.PasswordChar = '*';
            this.textBoxmatkhau.Size = new System.Drawing.Size(141, 20);
            this.textBoxmatkhau.TabIndex = 8;
            this.textBoxmatkhau.Text = "admin";
            // 
            // buttondangnhap
            // 
            this.buttondangnhap.BackColor = System.Drawing.Color.Green;
            this.buttondangnhap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttondangnhap.Location = new System.Drawing.Point(416, 317);
            this.buttondangnhap.Name = "buttondangnhap";
            this.buttondangnhap.Size = new System.Drawing.Size(83, 32);
            this.buttondangnhap.TabIndex = 9;
            this.buttondangnhap.Text = "Đăng Nhập";
            this.buttondangnhap.UseVisualStyleBackColor = false;
            this.buttondangnhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabelquenmatkhau
            // 
            this.linkLabelquenmatkhau.AutoSize = true;
            this.linkLabelquenmatkhau.Location = new System.Drawing.Point(355, 370);
            this.linkLabelquenmatkhau.Name = "linkLabelquenmatkhau";
            this.linkLabelquenmatkhau.Size = new System.Drawing.Size(86, 13);
            this.linkLabelquenmatkhau.TabIndex = 10;
            this.linkLabelquenmatkhau.TabStop = true;
            this.linkLabelquenmatkhau.Text = "Quên mật khẩu?";
            this.linkLabelquenmatkhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelquenmatkhau_LinkClicked);
            // 
            // labelthongbao
            // 
            this.labelthongbao.AutoSize = true;
            this.labelthongbao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelthongbao.ForeColor = System.Drawing.Color.Red;
            this.labelthongbao.Location = new System.Drawing.Point(285, 204);
            this.labelthongbao.Name = "labelthongbao";
            this.labelthongbao.Size = new System.Drawing.Size(343, 19);
            this.labelthongbao.TabIndex = 11;
            this.labelthongbao.Text = "Tài khoản hoặc Mật khẩu chưa đúng. Vui lòng nhập lại!";
            // 
            // labelthongbaotaikhoan
            // 
            this.labelthongbaotaikhoan.AutoSize = true;
            this.labelthongbaotaikhoan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelthongbaotaikhoan.ForeColor = System.Drawing.Color.Red;
            this.labelthongbaotaikhoan.Location = new System.Drawing.Point(526, 240);
            this.labelthongbaotaikhoan.Name = "labelthongbaotaikhoan";
            this.labelthongbaotaikhoan.Size = new System.Drawing.Size(106, 15);
            this.labelthongbaotaikhoan.TabIndex = 12;
            this.labelthongbaotaikhoan.Text = "Hãy nhập Tài khoản";
            // 
            // labelthongbaomatkhau
            // 
            this.labelthongbaomatkhau.AutoSize = true;
            this.labelthongbaomatkhau.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelthongbaomatkhau.ForeColor = System.Drawing.Color.Red;
            this.labelthongbaomatkhau.Location = new System.Drawing.Point(529, 288);
            this.labelthongbaomatkhau.Name = "labelthongbaomatkhau";
            this.labelthongbaomatkhau.Size = new System.Drawing.Size(105, 15);
            this.labelthongbaomatkhau.TabIndex = 13;
            this.labelthongbaomatkhau.Text = "Hãy nhập Mật khẩu";
            // 
            // Formquanlydangvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 422);
            this.Controls.Add(this.labelthongbaomatkhau);
            this.Controls.Add(this.labelthongbaotaikhoan);
            this.Controls.Add(this.labelthongbao);
            this.Controls.Add(this.linkLabelquenmatkhau);
            this.Controls.Add(this.buttondangnhap);
            this.Controls.Add(this.textBoxmatkhau);
            this.Controls.Add(this.textBoxtaikhoan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Formquanlydangvien";
            this.Text = "Quản Lý Đảng Viên";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxtaikhoan;
        private System.Windows.Forms.TextBox textBoxmatkhau;
        private System.Windows.Forms.Button buttondangnhap;
        private System.Windows.Forms.LinkLabel linkLabelquenmatkhau;
        private System.Windows.Forms.Label labelthongbao;
        private System.Windows.Forms.Label labelthongbaotaikhoan;
        private System.Windows.Forms.Label labelthongbaomatkhau;
    }
}

