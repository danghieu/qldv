namespace quanlydangvien
{
    partial class Formdoimatkhau
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxmatkhaucu = new System.Windows.Forms.TextBox();
            this.textBoxmatkhaumoi = new System.Windows.Forms.TextBox();
            this.textBoxxacnhanmatkhau = new System.Windows.Forms.TextBox();
            this.buttonxacnhan = new System.Windows.Forms.Button();
            this.buttonhuy = new System.Windows.Forms.Button();
            this.labelmatkhaucu = new System.Windows.Forms.Label();
            this.labelxacnhan = new System.Windows.Forms.Label();
            this.labeltb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(160, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu Cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu Mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập Lại Mật Khẩu";
            // 
            // textBoxmatkhaucu
            // 
            this.textBoxmatkhaucu.Location = new System.Drawing.Point(208, 132);
            this.textBoxmatkhaucu.Name = "textBoxmatkhaucu";
            this.textBoxmatkhaucu.PasswordChar = '*';
            this.textBoxmatkhaucu.Size = new System.Drawing.Size(141, 20);
            this.textBoxmatkhaucu.TabIndex = 4;
            // 
            // textBoxmatkhaumoi
            // 
            this.textBoxmatkhaumoi.Location = new System.Drawing.Point(208, 181);
            this.textBoxmatkhaumoi.Name = "textBoxmatkhaumoi";
            this.textBoxmatkhaumoi.PasswordChar = '*';
            this.textBoxmatkhaumoi.Size = new System.Drawing.Size(141, 20);
            this.textBoxmatkhaumoi.TabIndex = 5;
            // 
            // textBoxxacnhanmatkhau
            // 
            this.textBoxxacnhanmatkhau.Location = new System.Drawing.Point(208, 223);
            this.textBoxxacnhanmatkhau.Name = "textBoxxacnhanmatkhau";
            this.textBoxxacnhanmatkhau.PasswordChar = '*';
            this.textBoxxacnhanmatkhau.Size = new System.Drawing.Size(141, 20);
            this.textBoxxacnhanmatkhau.TabIndex = 6;
            // 
            // buttonxacnhan
            // 
            this.buttonxacnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonxacnhan.Location = new System.Drawing.Point(166, 298);
            this.buttonxacnhan.Name = "buttonxacnhan";
            this.buttonxacnhan.Size = new System.Drawing.Size(94, 35);
            this.buttonxacnhan.TabIndex = 7;
            this.buttonxacnhan.Text = "Xác Nhận";
            this.buttonxacnhan.UseVisualStyleBackColor = false;
            this.buttonxacnhan.Click += new System.EventHandler(this.buttonxacnhan_Click);
            // 
            // buttonhuy
            // 
            this.buttonhuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonhuy.Location = new System.Drawing.Point(327, 298);
            this.buttonhuy.Name = "buttonhuy";
            this.buttonhuy.Size = new System.Drawing.Size(94, 35);
            this.buttonhuy.TabIndex = 7;
            this.buttonhuy.Text = "Hủy";
            this.buttonhuy.UseVisualStyleBackColor = false;
            this.buttonhuy.Click += new System.EventHandler(this.buttonhuy_Click);
            // 
            // labelmatkhaucu
            // 
            this.labelmatkhaucu.AutoSize = true;
            this.labelmatkhaucu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmatkhaucu.ForeColor = System.Drawing.Color.Red;
            this.labelmatkhaucu.Location = new System.Drawing.Point(376, 135);
            this.labelmatkhaucu.Name = "labelmatkhaucu";
            this.labelmatkhaucu.Size = new System.Drawing.Size(89, 15);
            this.labelmatkhaucu.TabIndex = 8;
            this.labelmatkhaucu.Text = "Không Hợp Lệ!";
            // 
            // labelxacnhan
            // 
            this.labelxacnhan.AutoSize = true;
            this.labelxacnhan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelxacnhan.ForeColor = System.Drawing.Color.Red;
            this.labelxacnhan.Location = new System.Drawing.Point(376, 223);
            this.labelxacnhan.Name = "labelxacnhan";
            this.labelxacnhan.Size = new System.Drawing.Size(165, 15);
            this.labelxacnhan.TabIndex = 8;
            this.labelxacnhan.Text = "Không Trùng Mật Khẩu Mới!";
            // 
            // labeltb
            // 
            this.labeltb.AutoSize = true;
            this.labeltb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltb.ForeColor = System.Drawing.Color.Red;
            this.labeltb.Location = new System.Drawing.Point(205, 88);
            this.labeltb.Name = "labeltb";
            this.labeltb.Size = new System.Drawing.Size(133, 15);
            this.labeltb.TabIndex = 9;
            this.labeltb.Text = "Điền đầy đủ thông tin !!";
            // 
            // Formdoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 351);
            this.Controls.Add(this.labeltb);
            this.Controls.Add(this.labelxacnhan);
            this.Controls.Add(this.labelmatkhaucu);
            this.Controls.Add(this.buttonhuy);
            this.Controls.Add(this.buttonxacnhan);
            this.Controls.Add(this.textBoxxacnhanmatkhau);
            this.Controls.Add(this.textBoxmatkhaumoi);
            this.Controls.Add(this.textBoxmatkhaucu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formdoimatkhau";
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.Formdoimatkhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxmatkhaucu;
        private System.Windows.Forms.TextBox textBoxmatkhaumoi;
        private System.Windows.Forms.TextBox textBoxxacnhanmatkhau;
        private System.Windows.Forms.Button buttonxacnhan;
        private System.Windows.Forms.Button buttonhuy;
        private System.Windows.Forms.Label labelmatkhaucu;
        private System.Windows.Forms.Label labelxacnhan;
        private System.Windows.Forms.Label labeltb;
    }
}