using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainsite.Common
{
    public class Database
    {
        private SqlConnection _conn = new SqlConnection();
        protected readonly string _connection_string = "Data Source=DESKTOP-P48NJER\\SQLSERVER2022;Initial Catalog=Course_Registration;Persist Security Info=True;User ID=sa;Password=rumtinus7;TrustServerCertificate=True";
  
        public void connect()
        {
            _conn.ConnectionString = _connection_string;
            _conn.Open();
        }

        public void disConnect()
        {
            _conn.Close();
        }

        public SqlDataReader QueryResult(string query)
        {
            SqlCommand cmd = new SqlCommand(query, _conn);
            SqlDataReader dread = cmd.ExecuteReader();
            return dread;
        }

        public void QueryNonResult(string query)
        {
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.ExecuteNonQuery();
        }
    }
}
