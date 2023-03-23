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
using System.Runtime.InteropServices;

namespace Check_Connect_DB
{
    public partial class CheckConnectDatabase : Form
    {
        public CheckConnectDatabase()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = @"Data Source=DESKTOP-7DPCA8J;Initial Catalog=dbSanPham;Integrated Security=True";


         private void btnKetNoi_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Kết nối thành công !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Kết nối không thành công");
            }

        }
        private void btnHuyKetNoi_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                txtGia.Text = " ";
                txtMaDanhMuc.Text = " ";
                txtMaMuonTim.Text = " ";
                txtMaSanPham.Text = " ";
                txtSoSanPham.Text = " ";
                txtTenSanPham.Text = " ";
//                lvSanPham.Groups.Clear();
                lvSanPham.Items.Clear();
                MessageBox.Show("Đã hủy kết nối!");

            }
            else
            {
                MessageBox.Show("Chưa tạo kết nối");
            }
        }

        private void lblMaDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void btnDemSoSanPham_Click(object sender, EventArgs e)
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
            cmd.CommandText = "select count(*) from SanPham";

            object data = cmd.ExecuteScalar();
            int sosp = (int)data;
            txtSoSanPham.Text = "Có " + sosp.ToString() + " sản phẩm.";
        }

        private void btnXemChiTietSanPham_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (txtMaMuonTim.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sản phẩm muốn tìm!");
            }    
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM SanPham WHERE  MaSanPham = " + txtMaMuonTim.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtMaSanPham.Text = reader.GetInt32(0).ToString();
                    txtTenSanPham.Text = reader.GetString(1).ToString();
                    txtGia.Text = reader.GetInt32(2).ToString();
                    txtMaDanhMuc.Text = reader.GetInt32(3).ToString();

                }
                reader.Close();

            }    
                
            
        }

        private void btnHienThiChiTietSanPham_Click(object sender, EventArgs e)
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

            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetInt32(0) + " ");
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetInt32(2) + " ");
                lvi.SubItems.Add(reader.GetInt32(3) + " ");

                lvSanPham.Items.Add(lvi);
                //               lvi.Checked = true;

            }
            reader.Close();
        }

        private void btnHIenThiSanPhamTheoDanhMuc_Click(object sender, EventArgs e)
        {
            frmDanhMuc frmDM = new frmDanhMuc();
            frmDM.ShowDialog();          
        }

        private void btnThemMoiSanPham_Click(object sender, EventArgs e)
        {
            frmThemMoiSanPham frmThem = new frmThemMoiSanPham();
            frmThem.ShowDialog();
        }

        private void btnCapNhatSanPham_Click(object sender, EventArgs e)
        {
            frmCapNhatSanPham frmCapNhat = new frmCapNhatSanPham();
            frmCapNhat.ShowDialog();

        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            frmXoaSanPham frmXoa = new frmXoaSanPham();
            frmXoa.ShowDialog();
        }

        private void CheckConnectDatabase_Load(object sender, EventArgs e)
        {

        }
    }
}
