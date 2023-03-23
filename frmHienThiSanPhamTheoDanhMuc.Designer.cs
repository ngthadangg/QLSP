namespace Check_Connect_DB
{
    partial class frmDanhMuc
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
            this.lsbDanhMuc = new System.Windows.Forms.ListBox();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeaderMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsbDanhMuc
            // 
            this.lsbDanhMuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbDanhMuc.FormattingEnabled = true;
            this.lsbDanhMuc.ItemHeight = 22;
            this.lsbDanhMuc.Location = new System.Drawing.Point(35, 21);
            this.lsbDanhMuc.Name = "lsbDanhMuc";
            this.lsbDanhMuc.Size = new System.Drawing.Size(208, 400);
            this.lsbDanhMuc.TabIndex = 0;
            this.lsbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.lsbDanhMuc_SelectedIndexChanged);
            // 
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMa,
            this.columnHeaderTen,
            this.columnHeaderGia});
            this.lvSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSanPham.FullRowSelect = true;
            this.lvSanPham.GridLines = true;
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.Location = new System.Drawing.Point(279, 24);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(507, 396);
            this.lvSanPham.TabIndex = 1;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            this.lvSanPham.SelectedIndexChanged += new System.EventHandler(this.lvSanPham_SelectedIndexChanged);
            // 
            // columnHeaderMa
            // 
            this.columnHeaderMa.Text = "Mã Sản Phẩm";
            this.columnHeaderMa.Width = 135;
            // 
            // columnHeaderTen
            // 
            this.columnHeaderTen.Text = "Tên Sản Phẩm";
            this.columnHeaderTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTen.Width = 227;
            // 
            // columnHeaderGia
            // 
            this.columnHeaderGia.Text = "Giá";
            this.columnHeaderGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderGia.Width = 146;
            // 
            // frmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvSanPham);
            this.Controls.Add(this.lsbDanhMuc);
            this.Name = "frmDanhMuc";
            this.Text = "Hiển Thị Sản Phẩm Theo Danh Mục";
            this.Load += new System.EventHandler(this.frmDanhMuc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbDanhMuc;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader columnHeaderMa;
        private System.Windows.Forms.ColumnHeader columnHeaderTen;
        private System.Windows.Forms.ColumnHeader columnHeaderGia;
    }
}