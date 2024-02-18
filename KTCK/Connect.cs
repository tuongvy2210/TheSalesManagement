using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KTCK
{
    class Connect
    {
        public static SqlConnection ConnectDB()
        {
            String connString = "Data Source=MSI\\SQLEXPRESS; Database=WF_QuanLyBanHang;Integrated Security = True";
            SqlConnection con = new SqlConnection(connString);
            return con;
        }

    }
}
