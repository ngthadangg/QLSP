namespace Check_Connect_DB
{
    partial class frmCapNhatSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatSanPham));
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.lblDanhSachSanPham = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.btnCapNhatSanPham = new System.Windows.Forms.Button();
            this.btnCapNhat_Parameter = new System.Windows.Forms.Button();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeaderMaSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMuc.Location = new System.Drawing.Point(23, 16);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(96, 22);
            this.lblDanhMuc.TabIndex = 0;
            this.lblDanhMuc.Text = "Danh Mục";
            // 
            // lblDanhSachSanPham
            // 
            this.lblDanhSachSanPham.AutoSize = true;
            this.lblDanhSachSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachSanPham.Location = new System.Drawing.Point(23, 77);
            this.lblDanhSachSanPham.Name = "lblDanhSachSanPham";
            this.lblDanhSachSanPham.Size = new System.Drawing.Size(187, 22);
            this.lblDanhSachSanPham.TabIndex = 1;
            this.lblDanhSachSanPham.Text = "Danh Sách Sản Phẩm";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(23, 296);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(43, 22);
            this.lblMa.TabIndex = 2;
            this.lblMa.Text = "Mã:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(23, 352);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(47, 22);
            this.lblTen.TabIndex = 3;
            this.lblTen.Text = "Tên:";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(23, 394);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(45, 22);
            this.lblGia.TabIndex = 4;
            this.lblGia.Text = "Giá:";
            // 
            // btnCapNhatSanPham
            // 
            this.btnCapNhatSanPham.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatSanPham.Location = new System.Drawing.Point(67, 463);
            this.btnCapNhatSanPham.Name = "btnCapNhatSanPham";
            this.btnCapNhatSanPham.Size = new System.Drawing.Size(208, 62);
            this.btnCapNhatSanPham.TabIndex = 5;
            this.btnCapNhatSanPham.Text = "Cập Nhật Sản Phẩm";
            this.btnCapNhatSanPham.UseVisualStyleBackColor = true;
            this.btnCapNhatSanPham.Click += new System.EventHandler(this.btnCapNhatSanPham_Click);
            // 
            // btnCapNhat_Parameter
            // 
            this.btnCapNhat_Parameter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat_Parameter.Location = new System.Drawing.Point(331, 463);
            this.btnCapNhat_Parameter.Name = "btnCapNhat_Parameter";
            this.btnCapNhat_Parameter.Size = new System.Drawing.Size(208, 62);
            this.btnCapNhat_Parameter.TabIndex = 6;
            this.btnCapNhat_Parameter.Text = "Cập Nhật Sản Phẩm dùng Paramether";
            this.btnCapNhat_Parameter.UseVisualStyleBackColor = true;
            this.btnCapNhat_Parameter.Click += new System.EventHandler(this.btnCapNhat_Parameter_Click);
            // 
            // lvSanPham
            // 
            this.lvSanPham.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMaSanPham,
            this.columnHeaderTenSanPham,
            this.columnHeaderGia});
            this.lvSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSanPham.FullRowSelect = true;
            this.lvSanPham.GridLines = true;
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.Location = new System.Drawing.Point(216, 77);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(440, 199);
            this.lvSanPham.TabIndex = 8;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            this.lvSanPham.SelectedIndexChanged += new System.EventHandler(this.lvSanPham_SelectedIndexChanged);
            // 
            // columnHeaderMaSanPham
            // 
            this.columnHeaderMaSanPham.Text = "Mã Sản Phẩm";
            this.columnHeaderMaSanPham.Width = 130;
            // 
            // columnHeaderTenSanPham
            // 
            this.columnHeaderTenSanPham.Text = "Tên Sản Phẩm";
            this.columnHeaderTenSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTenSanPham.Width = 179;
            // 
            // columnHeaderGia
            // 
            this.columnHeaderGia.Text = "Giá";
            this.columnHeaderGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderGia.Width = 124;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSanPham.Location = new System.Drawing.Point(242, 293);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(297, 29);
            this.txtMaSanPham.TabIndex = 9;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.Location = new System.Drawing.Point(242, 349);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(297, 29);
            this.txtTenSanPham.TabIndex = 10;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(242, 404);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(297, 29);
            this.txtGia.TabIndex = 11;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(242, 14);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(296, 30);
            this.cboDanhMuc.TabIndex = 12;
            this.cboDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cboDanhMuc_SelectedIndexChanged);
            // 
            // frmCapNhatSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 550);
            this.Controls.Add(this.cboDanhMuc);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.lvSanPham);
            this.Controls.Add(this.btnCapNhat_Parameter);
            this.Controls.Add(this.btnCapNhatSanPham);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblDanhSachSanPham);
            this.Controls.Add(this.lblDanhMuc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCapNhatSanPham";
            this.Text = "frmCapNhatSanPham";
            this.Load += new System.EventHandler(this.frmCapNhatSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.Label lblDanhSachSanPham;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Button btnCapNhatSanPham;
        private System.Windows.Forms.Button btnCapNhat_Parameter;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader columnHeaderMaSanPham;
        private System.Windows.Forms.ColumnHeader columnHeaderTenSanPham;
        private System.Windows.Forms.ColumnHeader columnHeaderGia;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ComboBox cboDanhMuc;
    }
}