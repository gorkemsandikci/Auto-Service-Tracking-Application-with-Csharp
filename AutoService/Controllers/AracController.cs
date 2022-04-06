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
                list.Add(new Arac { id = (int)dr["id"], KullaniciID = kullaniciID, ModelID = (int)dr["ModelID"], Plaka = dr["Plaka"].ToString(), Renk = dr["Renk"].ToString(), SasiNo = dr["SasiNo"].ToString(), Yil = (int)dr["Yil"], Model = ModelController.GetirByAracID((int)dr["id"]) });
            }

            return list;
        }


        public static Arac Getir(int aracID)
        {
            Arac arac = new Arac();

            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select [id],[Plaka],[ModelID],[SasiNo],[Yil],[Renk],[KullaniciID] from Araclar where id=@id", conn);
            cmd.Parameters.AddWithValue("@id", aracID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            arac.Renk = dr["Renk"].ToString();
            arac.KullaniciID = (int)dr["KullaniciID"];
            arac.Plaka = dr["Plaka"].ToString();
            arac.ModelID = (int)dr["ModelID"];
            arac.SasiNo = dr["SasiNo"].ToString();
            arac.Yil = (int)dr["Yil"];
            arac.Dosyalar = DosyaController.ListeGetir(aracID);
            arac.Model = ModelController.GetirByAracID(aracID);
            arac.Fotolar = FotoController.Getir(aracID);
            arac.id = (int)dr["id"];

            return arac;

        }


        public static Arac Getir(string Plaka)
        {
            Arac arac = new Arac();

            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select [id],[Plaka],[ModelID],[SasiNo],[Yil],[Renk],[KullaniciID] from Araclar where Plaka LIKE @plaka", conn);
            cmd.Parameters.AddWithValue("@plaka", Plaka);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                arac.Renk = dr["Renk"].ToString();
                arac.KullaniciID = (int)dr["KullaniciID"];
                arac.Plaka = dr["Plaka"].ToString();
                arac.ModelID = (int)dr["ModelID"];
                arac.SasiNo = dr["SasiNo"].ToString();
                arac.Yil = (int)dr["Yil"];
                arac.Dosyalar = DosyaController.ListeGetir((int)dr["id"]);
                arac.Model = ModelController.GetirByAracID((int)dr["id"]);
                arac.Fotolar = FotoController.Getir((int)dr["id"]);
                arac.id = (int)dr["id"];
            }
            else
            {
                arac.id = 0;
            }
            conn.Close();

            return arac;

        }
        public static List<Arac> TumunuGetir()
        {
            List<Arac> list = new List<Arac>();
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select * From Araclar ", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list.Add(new Arac { id = (int)dr["id"], KullaniciID = (int)dr["KullaniciID"], ModelID = (int)dr["ModelID"], Plaka = dr["Plaka"].ToString(), Renk = dr["Renk"].ToString(), SasiNo = dr["SasiNo"].ToString(), Yil = (int)dr["Yil"], Model = ModelController.GetirByAracID((int)dr["id"]) });
            }

            return list;
        }
    




    }
}
