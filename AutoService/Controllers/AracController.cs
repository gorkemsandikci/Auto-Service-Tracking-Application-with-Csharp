using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public class AracController
    {
        public static bool AracEkle(Arac arac)
        {
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Insert into Araclar (Plaka, ModelID, SasiNo, Yil, Renk, KullaniciId) values(@plaka, @modelid, @sasino, @yil, @renk, @kullaniciid)", conn);
            cmd.Parameters.AddWithValue("@plaka", arac.Plaka);
            cmd.Parameters.AddWithValue("@modelid", arac.ModelID);
            cmd.Parameters.AddWithValue("@sasino", arac.SasiNo);
            cmd.Parameters.AddWithValue("@yil", arac.Yil);
            cmd.Parameters.AddWithValue("@renk", arac.Renk);
            cmd.Parameters.AddWithValue("@kullaniciid", arac.KullaniciID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        public static Arac AracListele(int aracID)
        {
            return new Arac()
            {
            };
        }
        public static List<Arac> Listele(int kullaniciID)
        {
            List<Arac> list = new List<Arac>();
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select * From Araclar where KullaniciID = @kullaniciid", conn);
            cmd.Parameters.AddWithValue("@kullaniciid", kullaniciID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list.Add(new Arac { id = (int)dr["id"], KullaniciID = kullaniciID, ModelID = (int)dr["ModelID"], Plaka = dr["Plaka"].ToString(), Renk = dr["Renk"].ToString(), SasiNo = dr["SasiNo"].ToString(), Yil = (int)dr["Yil"] });
            }

            return list;
        }
        public static Arac AracGetir(int aracID)
        {
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("select * from Araclar where id=@id",conn);
            cmd.Parameters.AddWithValue("@id", aracID);
          
            conn.Open ();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read ();
            return new Arac { id = (int)dr["id"], Plaka = dr["Plaka"].ToString(), SasiNo = dr["SasiNo"].ToString(), Renk = dr["Renk"].ToString(), Yil = (int)dr["Yil"] };
        }
        public static Arac AracModelGetir(int aracID)
        {
            SqlConnection conn = db.conn(); 
            SqlCommand cmd = new SqlCommand("Select Ad from Modeller where id=(select ModelID from Araclar where id=@id) ", conn);
            cmd.Parameters.AddWithValue("@id", aracID);


            conn.Open ();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read ();
            return new Arac { ModelAd = dr["Ad"].ToString() };
        }
        public static Arac AracMarkaGetir(int aracID)
        {
            SqlConnection conn = db.conn(); 
            SqlCommand cmd = new SqlCommand("Select Ad from Markalar where id=(Select id from Modeller where id=(select ModelID from Araclar where id=@id))", conn);
            cmd.Parameters.AddWithValue("@id", aracID);


            conn.Open ();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read ();
            return new Arac { MarkaAd = dr["Ad"].ToString() };
        }
    }
}
