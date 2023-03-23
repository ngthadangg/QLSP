namespace Check_Connect_DB
{
    partial class CheckConnectDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckConnectDatabase));
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.btnHuyKetNoi = new System.Windows.Forms.Button();
            this.btnDemSoSanPham = new System.Windows.Forms.Button();
            this.lblNhapMaSanPham = new System.Windows.Forms.Label();
            this.lblcChiTietSanPham = new System.Windows.Forms.Label();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblMaDanhMuc = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.btnXemChiTietSanPham = new System.Windows.Forms.Button();
            this.btnHienThiChiTietSanPham = new System.Windows.Forms.Button();
            this.txtMaMuonTim = new System.Windows.Forms.TextBox();
            this.lblSoSanPham = new System.Windows.Forms.Label();
            this.txtSoSanPham = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1MaSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaDanhMuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnHIenThiSanPhamTheoDanhMuc = new System.Windows.Forms.Button();
            this.btnThemMoiSanPham = new System.Windows.Forms.Button();
            this.btnCapNhatSanPham = new System.Windows.Forms.Button();
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetNoi.Image = global::Check_Connect_DB.Properties.Resources._318013199_523523229492806_7403776998824563216_n;
            this.btnKetNoi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKetNoi.Location = new System.Drawing.Point(767, 54);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(124, 41);
            this.btnKetNoi.TabIndex = 0;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // btnHuyKetNoi
            // 
            this.btnHuyKetNoi.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyKetNoi.Location = new System.Drawing.Point(930, 52);
            this.btnHuyKetNoi.Name = "btnHuyKetNoi";
            this.btnHuyKetNoi.Size = new System.Drawing.Size(166, 43);
            this.btnHuyKetNoi.TabIndex = 1;
            this.btnHuyKetNoi.Text = "Hủy kết nối";
            this.btnHuyKetNoi.UseVisualStyleBackColor = true;
            this.btnHuyKetNoi.Click += new System.EventHandler(this.btnHuyKetNoi_Click);
            // 
            // btnDemSoSanPham
            // 
            this.btnDemSoSanPham.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemSoSanPham.Location = new System.Drawing.Point(63, 33);
            this.btnDemSoSanPham.Name = "btnDemSoSanPham";
            this.btnDemSoSanPham.Size = new System.Drawing.Size(248, 51);
            this.btnDemSoSanPham.TabIndex = 2;
            this.btnDemSoSanPham.Text = "Đếm số lượng sản phẩm";
            this.btnDemSoSanPham.UseVisualStyleBackColor = true;
            this.btnDemSoSanPham.Click += new System.EventHandler(this.btnDemSoSanPham_Click);
            // 
            // lblNhapMaSanPham
            // 
            this.lblNhapMaSanPham.AutoSize = true;
            this.lblNhapMaSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapMaSanPham.Location = new System.Drawing.Point(30, 126);
            this.lblNhapMaSanPham.Name = "lblNhapMaSanPham";
            this.lblNhapMaSanPham.Size = new System.Drawing.Size(172, 22);
            this.lblNhapMaSanPham.TabIndex = 3;
            this.lblNhapMaSanPham.Text = "Nhập mã Sản Phẩm";
            // 
            // lblcChiTietSanPham
            // 
            this.lblcChiTietSanPham.AutoSize = true;
            this.lblcChiTietSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcChiTietSanPham.Location = new System.Drawing.Point(30, 217);
            this.lblcChiTietSanPham.Name = "lblcChiTietSanPham";
            this.lblcChiTietSanPham.Size = new System.Drawing.Size(158, 22);
            this.lblcChiTietSanPham.TabIndex = 4;
            this.lblcChiTietSanPham.Text = "Chi tiết Sản Phẩm";
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSanPham.Location = new System.Drawing.Point(30, 268);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(126, 22);
            this.lblMaSanPham.TabIndex = 5;
            this.lblMaSanPham.Text = "Mã Sản Phẩm";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSanPham.Location = new System.Drawing.Point(30, 336);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(130, 22);
            this.lblTenSanPham.TabIndex = 6;
            this.lblTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(30, 392);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(40, 22);
            this.lblGia.TabIndex = 7;
            this.lblGia.Text = "Giá";
            // 
            // lblMaDanhMuc
            // 
            this.lblMaDanhMuc.AutoSize = true;
            this.lblMaDanhMuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDanhMuc.Location = new System.Drawing.Point(30, 451);
            this.lblMaDanhMuc.Name = "lblMaDanhMuc";
            this.lblMaDanhMuc.Size = new System.Drawing.Size(129, 22);
            this.lblMaDanhMuc.TabIndex = 8;
            this.lblMaDanhMuc.Text = "Mã Danh Mục";
            this.lblMaDanhMuc.Click += new System.EventHandler(this.lblMaDanhMuc_Click);
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSanPham.Location = new System.Drawing.Point(214, 268);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.ReadOnly = true;
            this.txtMaSanPham.Size = new System.Drawing.Size(197, 29);
            this.txtMaSanPham.TabIndex = 10;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.Location = new System.Drawing.Point(214, 339);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.ReadOnly = true;
            this.txtTenSanPham.Size = new System.Drawing.Size(197, 29);
            this.txtTenSanPham.TabIndex = 11;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(214, 395);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(197, 29);
            this.txtGia.TabIndex = 12;
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDanhMuc.Location = new System.Drawing.Point(214, 454);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.ReadOnly = true;
            this.txtMaDanhMuc.Size = new System.Drawing.Size(197, 29);
            this.txtMaDanhMuc.TabIndex = 13;
            // 
            // btnXemChiTietSanPham
            // 
            this.btnXemChiTietSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTietSanPham.Location = new System.Drawing.Point(366, 120);
            this.btnXemChiTietSanPham.Name = "btnXemChiTietSanPham";
            this.btnXemChiTietSanPham.Size = new System.Drawing.Size(214, 29);
            this.btnXemChiTietSanPham.TabIndex = 14;
            this.btnXemChiTietSanPham.Text = "Xem Chi tiết Sản Phẩm";
            this.btnXemChiTietSanPham.UseVisualStyleBackColor = true;
            this.btnXemChiTietSanPham.Click += new System.EventHandler(this.btnXemChiTietSanPham_Click);
            // 
            // btnHienThiChiTietSanPham
            // 
            this.btnHienThiChiTietSanPham.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiChiTietSanPham.Location = new System.Drawing.Point(670, 126);
            this.btnHienThiChiTietSanPham.Name = "btnHienThiChiTietSanPham";
            this.btnHienThiChiTietSanPham.Size = new System.Drawing.Size(473, 36);
            this.btnHienThiChiTietSanPham.TabIndex = 15;
            this.btnHienThiChiTietSanPham.Text = "Hiển thị chi tiết Sản phẩm";
            this.btnHienThiChiTietSanPham.UseVisualStyleBackColor = true;
            this.btnHienThiChiTietSanPham.Click += new System.EventHandler(this.btnHienThiChiTietSanPham_Click);
            // 
            // txtMaMuonTim
            // 
            this.txtMaMuonTim.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMuonTim.Location = new System.Drawing.Point(214, 126);
            this.txtMaMuonTim.Name = "txtMaMuonTim";
            this.txtMaMuonTim.Size = new System.Drawing.Size(124, 29);
            this.txtMaMuonTim.TabIndex = 9;
            // 
            // lblSoSanPham
            // 
            this.lblSoSanPham.AutoSize = true;
            this.lblSoSanPham.Location = new System.Drawing.Point(380, 43);
            this.lblSoSanPham.Name = "lblSoSanPham";
            this.lblSoSanPham.Size = new System.Drawing.Size(0, 13);
            this.lblSoSanPham.TabIndex = 16;
            // 
            // txtSoSanPham
            // 
            this.txtSoSanPham.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoSanPham.Location = new System.Drawing.Point(361, 52);
            this.txtSoSanPham.Name = "txtSoSanPham";
            this.txtSoSanPham.ReadOnly = true;
            this.txtSoSanPham.Size = new System.Drawing.Size(190, 32);
            this.txtSoSanPham.TabIndex = 17;
            // 
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1MaSanPham,
            this.columnHeaderTenSanPham,
            this.columnHeaderGia,
            this.columnHeaderMaDanhMuc});
            this.lvSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSanPham.FullRowSelect = true;
            this.lvSanPham.GridLines = true;
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.Location = new System.Drawing.Point(607, 172);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(595, 477);
            this.lvSanPham.TabIndex = 20;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1MaSanPham
            // 
            this.columnHeader1MaSanPham.Text = "Mã Sản Phẩm";
            this.columnHeader1MaSanPham.Width = 133;
            // 
            // columnHeaderTenSanPham
            // 
            this.columnHeaderTenSanPham.Text = "Tên Sản Phẩm";
            this.columnHeaderTenSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTenSanPham.Width = 198;
            // 
            // columnHeaderGia
            // 
            this.columnHeaderGia.Text = "Giá";
            this.columnHeaderGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderGia.Width = 117;
            // 
            // columnHeaderMaDanhMuc
            // 
            this.columnHeaderMaDanhMuc.Text = "Mã Danh Mục";
            this.columnHeaderMaDanhMuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderMaDanhMuc.Width = 138;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnHIenThiSanPhamTheoDanhMuc
            // 
            this.btnHIenThiSanPhamTheoDanhMuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHIenThiSanPhamTheoDanhMuc.Location = new System.Drawing.Point(366, 172);
            this.btnHIenThiSanPhamTheoDanhMuc.Name = "btnHIenThiSanPhamTheoDanhMuc";
            this.btnHIenThiSanPhamTheoDanhMuc.Size = new System.Drawing.Size(214, 67);
            this.btnHIenThiSanPhamTheoDanhMuc.TabIndex = 22;
            this.btnHIenThiSanPhamTheoDanhMuc.Text = "Hiển Thị Sản Phẩm Theo Danh Mục";
            this.btnHIenThiSanPhamTheoDanhMuc.UseVisualStyleBackColor = true;
            this.btnHIenThiSanPhamTheoDanhMuc.Click += new System.EventHandler(this.btnHIenThiSanPhamTheoDanhMuc_Click);
            // 
            // btnThemMoiSanPham
            // 
            this.btnThemMoiSanPham.BackColor = System.Drawing.Color.White;
            this.btnThemMoiSanPham.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoiSanPham.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThemMoiSanPham.Location = new System.Drawing.Point(34, 527);
            this.btnThemMoiSanPham.Name = "btnThemMoiSanPham";
            this.btnThemMoiSanPham.Size = new System.Drawing.Size(126, 60);
            this.btnThemMoiSanPham.TabIndex = 23;
            this.btnThemMoiSanPham.Text = "Thêm Mới Sản Phẩm";
            this.btnThemMoiSanPham.UseVisualStyleBackColor = false;
            this.btnThemMoiSanPham.Click += new System.EventHandler(this.btnThemMoiSanPham_Click);
            // 
            // btnCapNhatSanPham
            // 
            this.btnCapNhatSanPham.BackColor = System.Drawing.Color.White;
            this.btnCapNhatSanPham.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatSanPham.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCapNhatSanPham.Location = new System.Drawing.Point(212, 527);
            this.btnCapNhatSanPham.Name = "btnCapNhatSanPham";
            this.btnCapNhatSanPham.Size = new System.Drawing.Size(126, 60);
            this.btnCapNhatSanPham.TabIndex = 24;
            this.btnCapNhatSanPham.Text = "Cập Nhật Sản Phẩm";
            this.btnCapNhatSanPham.UseVisualStyleBackColor = false;
            this.btnCapNhatSanPham.Click += new System.EventHandler(this.btnCapNhatSanPham_Click);
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.BackColor = System.Drawing.Color.White;
            this.btnXoaSanPham.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSanPham.ForeColor = System.Drawing.Color.Red;
            this.btnXoaSanPham.Location = new System.Drawing.Point(383, 527);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(126, 60);
            this.btnXoaSanPham.TabIndex = 25;
            this.btnXoaSanPham.Text = "Xóa Sản Phẩm";
            this.btnXoaSanPham.UseVisualStyleBackColor = false;
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
            // 
            // CheckConnectDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1232, 690);
            this.Controls.Add(this.btnXoaSanPham);
            this.Controls.Add(this.btnCapNhatSanPham);
            this.Controls.Add(this.btnThemMoiSanPham);
            this.Controls.Add(this.btnHIenThiSanPhamTheoDanhMuc);
            this.Controls.Add(this.lvSanPham);
            this.Controls.Add(this.txtSoSanPham);
            this.Controls.Add(this.lblSoSanPham);
            this.Controls.Add(this.btnHienThiChiTietSanPham);
            this.Controls.Add(this.btnXemChiTietSanPham);
            this.Controls.Add(this.txtMaDanhMuc);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.txtMaMuonTim);
            this.Controls.Add(this.lblMaDanhMuc);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTenSanPham);
            this.Controls.Add(this.lblMaSanPham);
            this.Controls.Add(this.lblcChiTietSanPham);
            this.Controls.Add(this.lblNhapMaSanPham);
            this.Controls.Add(this.btnDemSoSanPham);
            this.Controls.Add(this.btnHuyKetNoi);
            this.Controls.Add(this.btnKetNoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckConnectDatabase";
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.CheckConnectDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.Button btnHuyKetNoi;
        private System.Windows.Forms.Button btnDemSoSanPham;
        private System.Windows.Forms.Label lblNhapMaSanPham;
        private System.Windows.Forms.Label lblcChiTietSanPham;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblMaDanhMuc;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
        private System.Windows.Forms.Button btnXemChiTietSanPham;
        private System.Windows.Forms.Button btnHienThiChiTietSanPham;
        private System.Windows.Forms.TextBox txtMaMuonTim;
        private System.Windows.Forms.Label lblSoSanPham;
        private System.Windows.Forms.TextBox txtSoSanPham;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1MaSanPham;
        private System.Windows.Forms.ColumnHeader columnHeaderTenSanPham;
        private System.Windows.Forms.ColumnHeader columnHeaderGia;
        private System.Windows.Forms.ColumnHeader columnHeaderMaDanhMuc;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnHIenThiSanPhamTheoDanhMuc;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.Button btnCapNhatSanPham;
        private System.Windows.Forms.Button btnThemMoiSanPham;
    }
}

