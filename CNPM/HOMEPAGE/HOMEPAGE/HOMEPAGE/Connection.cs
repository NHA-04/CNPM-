using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HOMEPAGE
{
    static class Connenction
    {
        // thay chuỗi này để kết nối với SQL của ae
        private static readonly string baseConnectionString = @"Data Source=LAPTOP-6RA92RMF;Integrated Security=True;Encrypt=False";
        public static SqlConnection GetSqlConnection(string database)
        {
            string connectionString = $"{baseConnectionString};Initial Catalog={database};";
            return new SqlConnection(connectionString);
        }
        public static void CloseConnection(SqlConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
