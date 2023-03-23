using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Check_Connect_DB
{
    public partial class frmThemMoiSanPham : Form
    {
        public frmThemMoiSanPham()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = @"Data Source=DESKTOP-7DPCA8J;Initial Catalog=dbSanPham;Integrated Security=True";

        private void frmThemMoiSanPham_Load(object sender, EventArgs e)
        {
            HienThiToanBoSanPham();
            Load_DanhMuc();
        }
        private void HienThiToanBoSanPham()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }


            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM SanPham";

            SqlDataReader reader = cmd.ExecuteReader();
            lvSanPham.Items.Clear();

            while(reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetInt32(0) + " ");
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetInt32(2) + " ");
                lvi.SubItems.Add(reader.GetInt32(3) + " ");

                lvSanPham.Items.Add(lvi);
            }
            reader.Close();
        }
        private void Load_DanhMuc()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }


            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM DanhMuc";

            SqlDataReader reader = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(reader);
            reader.Dispose();
            cboDanhMuc.Items.Clear();   
            cboDanhMuc.DisplayMember = "MaDanhMuc";
            cboDanhMuc.DataSource = dt;
            reader.Close( );


        }

        private void btnLuuKhongParameter_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }


            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
 //           cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            string sql = "INSERT INTO SanPham(MaSanPham, TenSanPham, DonGia, MaDanhMuc) " + 
                "values(" + txtMaSanPham.Text + ",N'" + txtTenSanPham.Text + "'," + txtGia.Text + "," + cboDanhMuc.Text+ ")";

            cmd.CommandText = sql;
            cmd.Connection = conn;
            
            int ret = cmd.ExecuteNonQuery();
            if (ret > 0)
            {
                HienThiToanBoSanPham();
            }
            else
            {
                MessageBox.Show("Them That Bai!");
            }
            
        }

        private void btnLuuParameter_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(strConn);
                }


                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand();
                //           cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sql = "INSERT INTO SanPham(MaSanPham, TenSanPham, DonGia, MaDanhMuc) " +
                "values(@MaSanPham , @TenSanPham , @DonGia, @MaDanhMuc)";

                cmd.CommandText = sql;
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = txtMaSanPham.Text;
                cmd.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value = txtTenSanPham.Text;
                cmd.Parameters.Add("@DonGia" , SqlDbType.Int).Value = txtGia.Text;
                cmd.Parameters.Add("@MaDanhMuc", SqlDbType.Int).Value = cboDanhMuc.Text;
                
                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    HienThiToanBoSanPham();
                }
                else
                {
                    MessageBox.Show("Them That Bai!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }
    }
}
