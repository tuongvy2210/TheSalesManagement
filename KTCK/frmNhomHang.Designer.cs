namespace KTCK
{
    partial class frmQuanLyNhomHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhomHang));
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.lblTenNhom = new System.Windows.Forms.Label();
            this.lblMaNhom = new System.Windows.Forms.Label();
            this.grpCongCuHoTro = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNhomHang = new System.Windows.Forms.DataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNhomHang = new System.Windows.Forms.Label();
            this.lblSoNhomHang = new System.Windows.Forms.Label();
            this.grpThongTin.SuspendLayout();
            this.grpCongCuHoTro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHang)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpThongTin.Controls.Add(this.txtTenNhom);
            this.grpThongTin.Controls.Add(this.txtMaNhom);
            this.grpThongTin.Controls.Add(this.lblTenNhom);
            this.grpThongTin.Controls.Add(this.lblMaNhom);
            this.grpThongTin.Location = new System.Drawing.Point(63, 329);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpThongTin.Size = new System.Drawing.Size(691, 118);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông Tin";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(133, 62);
            this.txtTenNhom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(277, 22);
            this.txtTenNhom.TabIndex = 3;
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Location = new System.Drawing.Point(133, 21);
            this.txtMaNhom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(277, 22);
            this.txtMaNhom.TabIndex = 2;
            // 
            // lblTenNhom
            // 
            this.lblTenNhom.AutoSize = true;
            this.lblTenNhom.Location = new System.Drawing.Point(35, 64);
            this.lblTenNhom.Name = "lblTenNhom";
            this.lblTenNhom.Size = new System.Drawing.Size(82, 17);
            this.lblTenNhom.TabIndex = 1;
            this.lblTenNhom.Text = "Tên Nhóm :";
            // 
            // lblMaNhom
            // 
            this.lblMaNhom.AutoSize = true;
            this.lblMaNhom.Location = new System.Drawing.Point(35, 22);
            this.lblMaNhom.Name = "lblMaNhom";
            this.lblMaNhom.Size = new System.Drawing.Size(76, 17);
            this.lblMaNhom.TabIndex = 0;
            this.lblMaNhom.Text = "Mã Nhóm :";
            // 
            // grpCongCuHoTro
            // 
            this.grpCongCuHoTro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpCongCuHoTro.Controls.Add(this.btnXoa);
            this.grpCongCuHoTro.Controls.Add(this.btnKhong);
            this.grpCongCuHoTro.Controls.Add(this.btnGhi);
            this.grpCongCuHoTro.Controls.Add(this.btnSua);
            this.grpCongCuHoTro.Controls.Add(this.btnThem);
            this.grpCongCuHoTro.Location = new System.Drawing.Point(63, 486);
            this.grpCongCuHoTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCongCuHoTro.Name = "grpCongCuHoTro";
            this.grpCongCuHoTro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCongCuHoTro.Size = new System.Drawing.Size(691, 111);
            this.grpCongCuHoTro.TabIndex = 1;
            this.grpCongCuHoTro.TabStop = false;
            this.grpCongCuHoTro.Text = "Công Cụ Hỗ Trợ";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.Image = global::KTCK.Properties.Resources.btXoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(290, 34);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 49);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnKhong.Image = global::KTCK.Properties.Resources.Go_back_icon;
            this.btnKhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhong.Location = new System.Drawing.Point(595, 34);
            this.btnKhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(75, 49);
            this.btnKhong.TabIndex = 3;
            this.btnKhong.Text = "Không";
            this.btnKhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhong.UseVisualStyleBackColor = false;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGhi.Image = global::KTCK.Properties.Resources.btSave1;
            this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhi.Location = new System.Drawing.Point(446, 34);
            this.btnGhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(89, 49);
            this.btnGhi.TabIndex = 2;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGhi.UseVisualStyleBackColor = false;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.Image = global::KTCK.Properties.Resources.hp_customization_control_panel_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(158, 34);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 49);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImageKey = "(none)";
            this.btnThem.Location = new System.Drawing.Point(23, 34);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 49);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNhomHang
            // 
            this.dgvNhomHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhomHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.TenNhom});
            this.dgvNhomHang.Location = new System.Drawing.Point(63, 114);
            this.dgvNhomHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhomHang.Name = "dgvNhomHang";
            this.dgvNhomHang.RowHeadersWidth = 51;
            this.dgvNhomHang.RowTemplate.Height = 24;
            this.dgvNhomHang.Size = new System.Drawing.Size(691, 150);
            this.dgvNhomHang.TabIndex = 2;
            this.dgvNhomHang.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNhomHang_CellMouseClick);
            // 
            // MaNhom
            // 
            this.MaNhom.DataPropertyName = "MaNhom";
            this.MaNhom.HeaderText = "Mã nhóm";
            this.MaNhom.MinimumWidth = 6;
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.ReadOnly = true;
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "Tên nhóm";
            this.TenNhom.MinimumWidth = 6;
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.ReadOnly = true;
            // 
            // lblNhomHang
            // 
            this.lblNhomHang.AutoSize = true;
            this.lblNhomHang.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhomHang.Location = new System.Drawing.Point(283, 31);
            this.lblNhomHang.Name = "lblNhomHang";
            this.lblNhomHang.Size = new System.Drawing.Size(279, 45);
            this.lblNhomHang.TabIndex = 3;
            this.lblNhomHang.Text = "NHÓM HÀNG";
            // 
            // lblSoNhomHang
            // 
            this.lblSoNhomHang.AutoSize = true;
            this.lblSoNhomHang.Location = new System.Drawing.Point(589, 292);
            this.lblSoNhomHang.Name = "lblSoNhomHang";
            this.lblSoNhomHang.Size = new System.Drawing.Size(116, 17);
            this.lblSoNhomHang.TabIndex = 4;
            this.lblSoNhomHang.Text = "Có 4 Nhóm Hàng";
            // 
            // frmQuanLyNhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 644);
            this.Controls.Add(this.lblSoNhomHang);
            this.Controls.Add(this.lblNhomHang);
            this.Controls.Add(this.dgvNhomHang);
            this.Controls.Add(this.grpCongCuHoTro);
            this.Controls.Add(this.grpThongTin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyNhomHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Quản Lý Nhóm Hàng";
            this.Load += new System.EventHandler(this.frmQuanLyNhomHang_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpCongCuHoTro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblTenNhom;
        private System.Windows.Forms.Label lblMaNhom;
        private System.Windows.Forms.GroupBox grpCongCuHoTro;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.DataGridView dgvNhomHang;
        private System.Windows.Forms.Label lblNhomHang;
        private System.Windows.Forms.Label lblSoNhomHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
    }
}