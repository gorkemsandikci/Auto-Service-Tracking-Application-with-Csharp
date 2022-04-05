using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    internal class DosyaKategoriController
    {
        public static List<DosyaKategori> List()
        {
            List<DosyaKategori> list = new List<DosyaKategori>();

            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select id, Ad from DosyalarKategoriler ", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new DosyaKategori { Ad = dr["Ad"].ToString(), id = (int)dr["id"] });
            }
            conn.Close();
            return list;    
        }
    }
}
