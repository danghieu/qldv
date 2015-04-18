namespace quanlydangvien
{
    partial class Formthemchibo
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
            this.labelthemchibo = new System.Windows.Forms.Label();
            this.labelmachibo = new System.Windows.Forms.Label();
            this.labeltenchibo = new System.Windows.Forms.Label();
            this.textBoxmachibo = new System.Windows.Forms.TextBox();
            this.textBoxtenchibo = new System.Windows.Forms.TextBox();
            this.buttoncapnhat = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.dataGridViewds = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewds)).BeginInit();
            this.SuspendLayout();
            // 
            // labelthemchibo
            // 
            this.labelthemchibo.AutoSize = true;
            this.labelthemchibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelthemchibo.ForeColor = System.Drawing.Color.Red;
            this.labelthemchibo.Location = new System.Drawing.Point(109, 26);
            this.labelthemchibo.Name = "labelthemchibo";
            this.labelthemchibo.Size = new System.Drawing.Size(185, 33);
            this.labelthemchibo.TabIndex = 0;
            this.labelthemchibo.Text = "Thêm Chi Bộ";
            // 
            // labelmachibo
            // 
            this.labelmachibo.AutoSize = true;
            this.labelmachibo.Location = new System.Drawing.Point(45, 90);
            this.labelmachibo.Name = "labelmachibo";
            this.labelmachibo.Size = new System.Drawing.Size(55, 13);
            this.labelmachibo.TabIndex = 0;
            this.labelmachibo.Text = "Mã Chi bộ";
            // 
            // labeltenchibo
            // 
            this.labeltenchibo.AutoSize = true;
            this.labeltenchibo.Location = new System.Drawing.Point(45, 139);
            this.labeltenchibo.Name = "labeltenchibo";
            this.labeltenchibo.Size = new System.Drawing.Size(60, 13);
            this.labeltenchibo.TabIndex = 0;
            this.labeltenchibo.Text = "Tên Chi Bộ";
            // 
            // textBoxmachibo
            // 
            this.textBoxmachibo.Location = new System.Drawing.Point(159, 82);
            this.textBoxmachibo.Name = "textBoxmachibo";
            this.textBoxmachibo.Size = new System.Drawing.Size(178, 20);
            this.textBoxmachibo.TabIndex = 1;
            // 
            // textBoxtenchibo
            // 
            this.textBoxtenchibo.Location = new System.Drawing.Point(159, 132);
            this.textBoxtenchibo.Name = "textBoxtenchibo";
            this.textBoxtenchibo.Size = new System.Drawing.Size(178, 20);
            this.textBoxtenchibo.TabIndex = 1;
            // 
            // buttoncapnhat
            // 
            this.buttoncapnhat.BackColor = System.Drawing.Color.Aqua;
            this.buttoncapnhat.Location = new System.Drawing.Point(86, 251);
            this.buttoncapnhat.Name = "buttoncapnhat";
            this.buttoncapnhat.Size = new System.Drawing.Size(64, 23);
            this.buttoncapnhat.TabIndex = 2;
            this.buttoncapnhat.Text = "Cập Nhật";
            this.buttoncapnhat.UseVisualStyleBackColor = false;
            this.buttoncapnhat.Click += new System.EventHandler(this.buttoncapnhat_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.BackColor = System.Drawing.Color.Aqua;
            this.buttonxoa.Location = new System.Drawing.Point(201, 251);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(64, 23);
            this.buttonxoa.TabIndex = 2;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = false;
            // 
            // buttonthoat
            // 
            this.buttonthoat.BackColor = System.Drawing.Color.Aqua;
            this.buttonthoat.Location = new System.Drawing.Point(304, 251);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(64, 23);
            this.buttonthoat.TabIndex = 2;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = false;
            // 
            // dataGridViewds
            // 
            this.dataGridViewds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewds.Location = new System.Drawing.Point(405, 63);
            this.dataGridViewds.Name = "dataGridViewds";
            this.dataGridViewds.Size = new System.Drawing.Size(317, 236);
            this.dataGridViewds.TabIndex = 3;
            // 
            // Formthemchibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 337);
            this.Controls.Add(this.dataGridViewds);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttoncapnhat);
            this.Controls.Add(this.textBoxtenchibo);
            this.Controls.Add(this.textBoxmachibo);
            this.Controls.Add(this.labeltenchibo);
            this.Controls.Add(this.labelmachibo);
            this.Controls.Add(this.labelthemchibo);
            this.Name = "Formthemchibo";
            this.Text = "Formthemchibo";
            this.Load += new System.EventHandler(this.Formthemchibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelthemchibo;
        private System.Windows.Forms.Label labelmachibo;
        private System.Windows.Forms.Label labeltenchibo;
        private System.Windows.Forms.TextBox textBoxmachibo;
        private System.Windows.Forms.TextBox textBoxtenchibo;
        private System.Windows.Forms.Button buttoncapnhat;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.DataGridView dataGridViewds;
    }
}