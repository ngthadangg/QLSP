namespace Check_Connect_DB
{
    partial class frmThemMoiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemMoiSanPham));
            this.lblDanhSachSanPham = new System.Windows.Forms.Label();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeaderMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaDichVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbThongTinSanPham = new System.Windows.Forms.GroupBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.btnLuuParameter = new System.Windows.Forms.Button();
            this.btnLuuKhongParameter = new System.Windows.Forms.Button();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.grbThongTinSanPham.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDanhSachSanPham
            // 
            this.lblDanhSachSanPham.AutoSize = true;
            this.lblDanhSachSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachSanPham.Location = new System.Drawing.Point(82, 42);
            this.lblDanhSachSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSachSanPham.Name = "lblDanhSachSanPham";
            this.lblDanhSachSanPham.Size = new System.Drawing.Size(182, 22);
            this.lblDanhSachSanPham.TabIndex = 0;
            this.lblDanhSachSanPham.Text = "Danh sách Sản phẩm";
            // 
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMa,
            this.columnHeaderTen,
            this.columnHeaderDonGia,
            this.columnHeaderMaDichVu});
            this.lvSanPham.FullRowSelect = true;
            this.lvSanPham.GridLines = true;
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.Location = new System.Drawing.Point(26, 89);
            this.lvSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(518, 516);
            this.lvSanPham.TabIndex = 1;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderMa
            // 
            this.columnHeaderMa.Text = "Mã";
            this.columnHeaderMa.Width = 79;
            // 
            // columnHeaderTen
            // 
            this.columnHeaderTen.Text = "Tên";
            this.columnHeaderTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTen.Width = 168;
            // 
            // columnHeaderDonGia
            // 
            this.columnHeaderDonGia.Text = "Đơn Giá";
            this.columnHeaderDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDonGia.Width = 151;
            // 
            // columnHeaderMaDichVu
            // 
            this.columnHeaderMaDichVu.Text = "Mã Dịch Vụ";
            this.columnHeaderMaDichVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderMaDichVu.Width = 115;
            // 
            // grbThongTinSanPham
            // 
            this.grbThongTinSanPham.Controls.Add(this.cboDanhMuc);
            this.grbThongTinSanPham.Controls.Add(this.txtGia);
            this.grbThongTinSanPham.Controls.Add(this.txtTenSanPham);
            this.grbThongTinSanPham.Controls.Add(this.txtMaSanPham);
            this.grbThongTinSanPham.Controls.Add(this.btnLuuParameter);
            this.grbThongTinSanPham.Controls.Add(this.btnLuuKhongParameter);
            this.grbThongTinSanPham.Controls.Add(this.lblDanhMuc);
            this.grbThongTinSanPham.Controls.Add(this.lblTenSanPham);
            this.grbThongTinSanPham.Controls.Add(this.lblGia);
            this.grbThongTinSanPham.Controls.Add(this.lblMaSanPham);
            this.grbThongTinSanPham.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinSanPham.Location = new System.Drawing.Point(629, 42);
            this.grbThongTinSanPham.Name = "grbThongTinSanPham";
            this.grbThongTinSanPham.Size = new System.Drawing.Size(411, 517);
            this.grbThongTinSanPham.TabIndex = 2;
            this.grbThongTinSanPham.TabStop = false;
            this.grbThongTinSanPham.Text = "Thông tin Chi Tiết Sản Phẩm";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(185, 207);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(213, 29);
            this.txtGia.TabIndex = 8;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.Location = new System.Drawing.Point(185, 142);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(213, 29);
            this.txtTenSanPham.TabIndex = 7;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSanPham.Location = new System.Drawing.Point(185, 72);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(213, 29);
            this.txtMaSanPham.TabIndex = 6;
            // 
            // btnLuuParameter
            // 
            this.btnLuuParameter.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnLuuParameter.Location = new System.Drawing.Point(59, 434);
            this.btnLuuParameter.Name = "btnLuuParameter";
            this.btnLuuParameter.Size = new System.Drawing.Size(316, 39);
            this.btnLuuParameter.TabIndex = 5;
            this.btnLuuParameter.Text = "Lưu  dùng Parameter";
            this.btnLuuParameter.UseVisualStyleBackColor = true;
            this.btnLuuParameter.Click += new System.EventHandler(this.btnLuuParameter_Click);
            // 
            // btnLuuKhongParameter
            // 
            this.btnLuuKhongParameter.ForeColor = System.Drawing.Color.Red;
            this.btnLuuKhongParameter.Location = new System.Drawing.Point(59, 363);
            this.btnLuuKhongParameter.Name = "btnLuuKhongParameter";
            this.btnLuuKhongParameter.Size = new System.Drawing.Size(316, 39);
            this.btnLuuKhongParameter.TabIndex = 4;
            this.btnLuuKhongParameter.Text = "Lưu không dùng Parameter";
            this.btnLuuKhongParameter.UseVisualStyleBackColor = true;
            this.btnLuuKhongParameter.Click += new System.EventHandler(this.btnLuuKhongParameter_Click);
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Location = new System.Drawing.Point(6, 273);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(120, 26);
            this.lblDanhMuc.TabIndex = 3;
            this.lblDanhMuc.Text = "Danh Mục";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Location = new System.Drawing.Point(6, 145);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(160, 26);
            this.lblTenSanPham.TabIndex = 2;
            this.lblTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(15, 205);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(49, 26);
            this.lblGia.TabIndex = 1;
            this.lblGia.Text = "Giá";
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Location = new System.Drawing.Point(6, 75);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(156, 26);
            this.lblMaSanPham.TabIndex = 0;
            this.lblMaSanPham.Text = "Mã Sản Phẩm";
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(185, 270);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(213, 34);
            this.cboDanhMuc.TabIndex = 10;
            // 
            // frmThemMoiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 658);
            this.Controls.Add(this.grbThongTinSanPham);
            this.Controls.Add(this.lvSanPham);
            this.Controls.Add(this.lblDanhSachSanPham);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThemMoiSanPham";
            this.Text = "frmThemMoiSanPham";
            this.Load += new System.EventHandler(this.frmThemMoiSanPham_Load);
            this.grbThongTinSanPham.ResumeLayout(false);
            this.grbThongTinSanPham.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSachSanPham;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader columnHeaderMa;
        private System.Windows.Forms.ColumnHeader columnHeaderTen;
        private System.Windows.Forms.ColumnHeader columnHeaderDonGia;
        private System.Windows.Forms.ColumnHeader columnHeaderMaDichVu;
        private System.Windows.Forms.GroupBox grbThongTinSanPham;
        private System.Windows.Forms.Button btnLuuKhongParameter;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Button btnLuuParameter;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.ComboBox cboDanhMuc;
    }
}