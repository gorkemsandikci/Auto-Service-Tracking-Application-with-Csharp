using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    internal class FotoController
    {
        public static List<Foto> Getir(int aracID)
        {
            List<Foto> list = new List<Foto>();

            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select [id],[Ad],[Path],[AracID] from Fotolar where AracID=@aracid", conn);
            cmd.Parameters.AddWithValue("@aracid", aracID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Foto { Ad = dr["Ad"].ToString(), id = (int)dr["id"], AracID = (int)dr["AracID"], Path = dr["Path"].ToString() });
            }
            conn.Close();
            return list;
        }
    }
}
