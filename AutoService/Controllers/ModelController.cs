using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    internal class ModelController
    {
        public static List<Model> Getir(int markaID)
        {
            List<Model> list = new List<Model>();
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select id,Ad from Modeller WHERE MarkaID=@markaid", conn);
            cmd.Parameters.AddWithValue("@markaid", markaID);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                list.Add(new Model { id = (int)dr["id"], Ad = dr["Ad"].ToString() });
            }
            conn.Close();
            return list;
        }

        public static Model GetirByAracID(int aracID)
        {
            Model model = new Model();
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select id,Ad from Modeller where id=(select ModelID from Araclar where id=@id)", conn);
            cmd.Parameters.AddWithValue("@id", aracID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            model.id = (int)dr["id"];
            model.Ad = dr["Ad"].ToString();
            conn.Close();
            return model;

        }
    }
}
