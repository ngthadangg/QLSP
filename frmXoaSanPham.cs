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
    public partial class frmXoaSanPham : Form
    {
        public frmXoaSanPham()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = @"Data Source=DESKTOP-7DPCA8J;Initial Catalog=dbSanPham;Integrated Security=True";


        private void frmXoaSanPham_Load(object sender, EventArgs e)
        {
            HienThiSanPham();

        }
        private void HienThiSanPham()
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
            lsbSanPham.Items.Clear();

            while(reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                lsbSanPham.Items.Add(ma + " - "+ ten);
            }
            reader.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ( lsbSanPham.SelectedIndex  == -1 )
            {
                MessageBox.Show("Chua chon san pham de xoa !");
                return;
            }

            string line = lsbSanPham.SelectedItem + "";
            string[] arr = line.Split('-');

            int ma = int.Parse(arr[0]);
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
            cmd.CommandText = "DELETE FROM SanPham where MaSanPham =" + ma;

            int ret = cmd.ExecuteNonQuery();
            
            if (ret > 0)
            {
                HienThiSanPham();
                MessageBox.Show("Da xoa thanh cong!");


            }
            else
            {
                MessageBox.Show("Xoa That Bai");
            }

        }

        private void btnXoa_Para_Click(object sender, EventArgs e)
        {
            if (lsbSanPham.SelectedIndex == -1)
            {
                MessageBox.Show("Chua chon san pham de xoa !");
                return;
            }

            string line = lsbSanPham.SelectedItem + "";
            string[] arr = line.Split('-');

            int ma = int.Parse(arr[0]);
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

            cmd.CommandText = "DELETE FROM SanPham where MaSanPham =@MaSanPham";

            cmd.Parameters.Add("MaSanPham", SqlDbType.Int).Value = ma;
            int ret = cmd.ExecuteNonQuery() ;
            if (ret > 0)
            {
                HienThiSanPham();
                MessageBox.Show("Da xoa thanh cong!");


            }
            else
            {
                MessageBox.Show("Xoa That Bai");
            }


        }
    }
}
