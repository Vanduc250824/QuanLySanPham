using System;
using System.Data.SqlClient;

namespace QuanLySanPham
{
    public class DatabaseConnection
    {
        private string _connectionString;
        private SqlConnection conn;

        public DatabaseConnection()
        {
            _connectionString = "Data Source=VAN_DUC25\\SQLEXPRESS;Initial Catalog=QUANLYSANPHAM;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection(_connectionString);
        }

        public void OpenConnection()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}
