
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection conn;
        private void Form1_Load(object sender, EventArgs e)
        {

            databaseConnection.OpenConnection();
            LoadProduct();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            databaseConnection.CloseConnection();
        }
        public void LoadProduct()
        {
            string query = "SELECT * FROM SANPHAM";
            using (SqlCommand cmd = new SqlCommand(query, databaseConnection.GetConnection()))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dsSanpham.DataSource = dt;
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO SANPHAM(ID, tenSP, motaSP, gia, sl) VALUES (@masp, @tensp, @mota, @gia, @sl)";
            using (SqlCommand cmd = new SqlCommand(sql, databaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@masp", txtID.Text);
                cmd.Parameters.AddWithValue("@tensp", txtTenSP.Text);
                cmd.Parameters.AddWithValue("@mota", txtMota.Text);
                cmd.Parameters.AddWithValue("@gia", txtGia.Text);
                cmd.Parameters.AddWithValue("@sl", txtSoluong.Text);

                cmd.ExecuteNonQuery();

            }
            LoadProduct();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE SANPHAM SET tenSP = @tensp, motaSP = @mota,gia = @gia, sl = @sl WHERE ID = @masp";
            using (SqlCommand cmd = new SqlCommand(sql, databaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@masp", txtID.Text);
                cmd.Parameters.AddWithValue("@tensp", txtTenSP.Text);
                cmd.Parameters.AddWithValue("@mota", txtMota.Text);
                cmd.Parameters.AddWithValue("@gia", txtGia.Text);
                cmd.Parameters.AddWithValue("@sl", txtSoluong.Text);

                cmd.ExecuteNonQuery();

            }
            LoadProduct();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM SANPHAM WHERE ID = @masp";
            using (SqlCommand cmd = new SqlCommand(sql, databaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@masp", txtID.Text);
                cmd.Parameters.AddWithValue("@tensp", txtTenSP.Text);
                cmd.Parameters.AddWithValue("@mota", txtMota.Text);
                cmd.Parameters.AddWithValue("@gia", txtGia.Text);
                cmd.Parameters.AddWithValue("@sl", txtSoluong.Text);

                cmd.ExecuteNonQuery();

            }
            LoadProduct();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM SANPHAM WHERE ID = @masp";
            using (SqlCommand cmd = new SqlCommand(sql, databaseConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@masp", txtTimkiem.Text);
                

                cmd.ExecuteNonQuery ();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dsSanpham.DataSource = dt;
                }
            }
        }
    }
}
