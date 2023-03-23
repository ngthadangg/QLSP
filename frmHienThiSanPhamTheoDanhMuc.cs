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
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = @"Data Source=DESKTOP-7DPCA8J;Initial Catalog=dbSanPham;Integrated Security=True";

        private void frmDanhMuc_Load(object sender, EventArgs e)
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

            lsbDanhMuc.Items.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string line = reader.GetInt32(0) + " - " + reader.GetString(1);
                lsbDanhMuc.Items.Add(line);
            }
            reader.Close();

        }
        private void lsbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbDanhMuc.SelectedIndex == -1) 
            { 
                return; 
            }
            string line = lsbDanhMuc.SelectedItem.ToString();
            string[] arr = line.Split(' ');
            int maDM = int.Parse(arr[0]);

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
            cmd.CommandText = "SELECT * FROM SanPham WHERE MaDanhMuc = @maDM";


            SqlParameter parMaDM = new SqlParameter("maDM",SqlDbType.Int);
            parMaDM.Value = maDM;
            cmd.Parameters.Add(parMaDM);

            lvSanPham.Items.Clear();
            SqlDataReader reader = cmd.ExecuteReader(); 
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                int gia = reader.GetInt32(2);
                ListViewItem lvi = new ListViewItem(ma+"");
                lvi.SubItems.Add(ten);
                lvi.SubItems.Add(gia + "");

                lvSanPham.Items.Add(lvi);
            }
            reader.Close();


        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
