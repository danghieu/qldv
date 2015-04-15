namespace quanlydangvien
{
    partial class Formcapnhatdiadanh
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
            this.labelcapnhatdd = new System.Windows.Forms.Label();
            this.labelmatinh = new System.Windows.Forms.Label();
            this.labeltentinh = new System.Windows.Forms.Label();
            this.textBoxmatinh = new System.Windows.Forms.TextBox();
            this.textBoxtentinh = new System.Windows.Forms.TextBox();
            this.buttoncapnhat = new System.Windows.Forms.Button();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tentinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelcapnhatdd
            // 
            this.labelcapnhatdd.AutoSize = true;
            this.labelcapnhatdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcapnhatdd.ForeColor = System.Drawing.Color.Red;
            this.labelcapnhatdd.Location = new System.Drawing.Point(86, 19);
            this.labelcapnhatdd.Name = "labelcapnhatdd";
            this.labelcapnhatdd.Size = new System.Drawing.Size(266, 33);
            this.labelcapnhatdd.TabIndex = 0;
            this.labelcapnhatdd.Text = "Cập Nhật Địa Danh";
            // 
            // labelmatinh
            // 
            this.labelmatinh.AutoSize = true;
            this.labelmatinh.Location = new System.Drawing.Point(62, 106);
            this.labelmatinh.Name = "labelmatinh";
            this.labelmatinh.Size = new System.Drawing.Size(42, 13);
            this.labelmatinh.TabIndex = 0;
            this.labelmatinh.Text = "Mã tỉnh";
            // 
            // labeltentinh
            // 
            this.labeltentinh.AutoSize = true;
            this.labeltentinh.Location = new System.Drawing.Point(62, 187);
            this.labeltentinh.Name = "labeltentinh";
            this.labeltentinh.Size = new System.Drawing.Size(50, 13);
            this.labeltentinh.TabIndex = 0;
            this.labeltentinh.Text = "Tên Tỉnh";
            // 
            // textBoxmatinh
            // 
            this.textBoxmatinh.Location = new System.Drawing.Point(161, 99);
            this.textBoxmatinh.Name = "textBoxmatinh";
            this.textBoxmatinh.Size = new System.Drawing.Size(191, 20);
            this.textBoxmatinh.TabIndex = 1;
            // 
            // textBoxtentinh
            // 
            this.textBoxtentinh.Location = new System.Drawing.Point(161, 180);
            this.textBoxtentinh.Name = "textBoxtentinh";
            this.textBoxtentinh.Size = new System.Drawing.Size(191, 20);
            this.textBoxtentinh.TabIndex = 1;
            // 
            // buttoncapnhat
            // 
            this.buttoncapnhat.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttoncapnhat.Location = new System.Drawing.Point(100, 278);
            this.buttoncapnhat.Name = "buttoncapnhat";
            this.buttoncapnhat.Size = new System.Drawing.Size(75, 23);
            this.buttoncapnhat.TabIndex = 2;
            this.buttoncapnhat.Text = "Cập nhật";
            this.buttoncapnhat.UseVisualStyleBackColor = false;
            // 
            // buttonthoat
            // 
            this.buttonthoat.BackColor = System.Drawing.Color.Lime;
            this.buttonthoat.Location = new System.Drawing.Point(211, 278);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(75, 23);
            this.buttonthoat.TabIndex = 2;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = false;
            // 
            // buttonxoa
            // 
            this.buttonxoa.BackColor = System.Drawing.Color.Lime;
            this.buttonxoa.ForeColor = System.Drawing.Color.Red;
            this.buttonxoa.Location = new System.Drawing.Point(325, 278);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(75, 23);
            this.buttonxoa.TabIndex = 2;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matinh,
            this.Tentinh});
            this.dataGridView1.Location = new System.Drawing.Point(482, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // matinh
            // 
            this.matinh.HeaderText = "Ma Tỉnh";
            this.matinh.Name = "matinh";
            // 
            // Tentinh
            // 
            this.Tentinh.HeaderText = "Tên Tỉnh";
            this.Tentinh.Name = "Tentinh";
            // 
            // Formcapnhatdiadanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 335);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttoncapnhat);
            this.Controls.Add(this.textBoxtentinh);
            this.Controls.Add(this.textBoxmatinh);
            this.Controls.Add(this.labeltentinh);
            this.Controls.Add(this.labelmatinh);
            this.Controls.Add(this.labelcapnhatdd);
            this.Name = "Formcapnhatdiadanh";
            this.Text = "Formcapnhatdiadanh";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcapnhatdd;
        private System.Windows.Forms.Label labelmatinh;
        private System.Windows.Forms.Label labeltentinh;
        private System.Windows.Forms.TextBox textBoxmatinh;
        private System.Windows.Forms.TextBox textBoxtentinh;
        private System.Windows.Forms.Button buttoncapnhat;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tentinh;
    }
}