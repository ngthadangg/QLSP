namespace Check_Connect_DB
{
    partial class frmXoaSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXoaSanPham));
            this.lsbSanPham = new System.Windows.Forms.ListBox();
            this.lblDanhSachSanPham = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoa_Para = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbSanPham
            // 
            this.lsbSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbSanPham.FormattingEnabled = true;
            this.lsbSanPham.ItemHeight = 32;
            this.lsbSanPham.Location = new System.Drawing.Point(78, 111);
            this.lsbSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsbSanPham.Name = "lsbSanPham";
            this.lsbSanPham.Size = new System.Drawing.Size(649, 324);
            this.lsbSanPham.TabIndex = 0;
            // 
            // lblDanhSachSanPham
            // 
            this.lblDanhSachSanPham.AutoSize = true;
            this.lblDanhSachSanPham.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachSanPham.Location = new System.Drawing.Point(72, 46);
            this.lblDanhSachSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSachSanPham.Name = "lblDanhSachSanPham";
            this.lblDanhSachSanPham.Size = new System.Drawing.Size(313, 36);
            this.lblDanhSachSanPham.TabIndex = 1;
            this.lblDanhSachSanPham.Text = "Danh Sách Sản Phẩm";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(33, 526);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(272, 72);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoa_Para
            // 
            this.btnXoa_Para.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_Para.ForeColor = System.Drawing.Color.Red;
            this.btnXoa_Para.Location = new System.Drawing.Point(387, 526);
            this.btnXoa_Para.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa_Para.Name = "btnXoa_Para";
            this.btnXoa_Para.Size = new System.Drawing.Size(315, 72);
            this.btnXoa_Para.TabIndex = 3;
            this.btnXoa_Para.Text = "Xóa dùng Parameter";
            this.btnXoa_Para.UseVisualStyleBackColor = true;
            this.btnXoa_Para.Click += new System.EventHandler(this.btnXoa_Para_Click);
            // 
            // frmXoaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 692);
            this.Controls.Add(this.btnXoa_Para);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblDanhSachSanPham);
            this.Controls.Add(this.lsbSanPham);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmXoaSanPham";
            this.Text = "frmXoaSanPham";
            this.Load += new System.EventHandler(this.frmXoaSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbSanPham;
        private System.Windows.Forms.Label lblDanhSachSanPham;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoa_Para;
    }
}