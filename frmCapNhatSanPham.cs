using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Check_Connect_DB
{
    public partial class frmCapNhatSanPham : Form
    {
        public frmCapNhatSanPham()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = @"Data Source=DESKTOP-7DPCA8J;Initial Catalog=dbSanPham;Integrated Security=True";

        private void frmCapNhatSanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhMuc();

        }
        private void HienThiDanhMuc()
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
            cboDanhMuc.Items.Clear();
            while (reader.Read())
            { 
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                cboDanhMuc.Items.Add(ma + " - " +ten);
            }
            reader.Close();
           
            
        }
        int maDM = -1;
        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhMuc.SelectedIndex  == -1)
            {
                return;
            }
            string line = cboDanhMuc.SelectedItem + "";
            string[] arr = line.Split('-');
            maDM = int.Parse(arr[0]);
            HienThiSanPhamTheoDanhMuc(maDM);

        }
        private void HienThiSanPhamTheoDanhMuc(int maDM)
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
            cmd.CommandText = "SELECT * FROM SanPham where MaDanhMuc = "+ maDM;

            lvSanPham.Items.Clear();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem  lvi = new ListViewItem(reader.GetInt32(0)+" ");
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetInt32(2)+"");

                lvSanPham.Items.Add(lvi);

            }
            reader.Close();

        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( lvSanPham.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem lvi = lvSanPham.SelectedItems[0];
            txtMaSanPham.Text = lvi.SubItems[0].Text;
            txtTenSanPham.Text  = lvi.SubItems[1].Text;
            txtGia.Text = lvi.SubItems[2].Text;
        }

        private void btnCapNhatSanPham_Click(object sender, EventArgs e)
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
            string sql = "UPDATE SanPham set TenSanPham = N'" + txtTenSanPham.Text + "', DonGia =" + txtGia.Text + " WHERE MaSanPham = " + txtMaSanPham.Text;
            cmd.CommandText = sql;

            int ret = cmd.ExecuteNonQuery();
            if (ret >0)
            {
                HienThiSanPhamTheoDanhMuc(maDM);
                MessageBox.Show("Cap Nhat Thanh Cong!");

            }
            else
            {
                MessageBox.Show("Cap Nhat That Bai!");
            }    

        }

        private void btnCapNhat_Parameter_Click(object sender, EventArgs e)
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
            string sql = "UPDATE SanPham set TenSanPham = @TenSanPham ,DonGia = @Gia  WHERE MaSanPham = @MaSanPham";
            cmd.CommandText = sql;

            cmd.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value = txtTenSanPham.Text;
            cmd.Parameters.Add("@Gia", SqlDbType.Int).Value = txtGia.Text;
            cmd.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = txtMaSanPham.Text;

            if (cmd.ExecuteNonQuery() >0)
            {
                HienThiSanPhamTheoDanhMuc(maDM);
                MessageBox.Show("Cap Nhat Thanh Cong !");

            }
            else
            {
                MessageBox.Show("Cap Nhat That Bai!");
            }
        }
    }
}
