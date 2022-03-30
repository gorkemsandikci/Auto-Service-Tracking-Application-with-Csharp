using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public static class db
    {
        public static SqlConnection conn()
        {
            

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
            return conn;
        }

    }
}
