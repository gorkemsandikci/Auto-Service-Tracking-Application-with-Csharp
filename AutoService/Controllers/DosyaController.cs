using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public static class DosyaController
    {
        public static List<Dosya> ListeGetir(int aracID)
        {
            List<Dosya> liste = new List<Dosya>();
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select id, Ad, Path, KategoriID, AracID from Dosyalar where AracID=@aracid",conn);
            cmd.Parameters.AddWithValue("aracid", aracID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                liste.Add(new Dosya { AracID=aracID,Ad=dr["Ad"].ToString(),id=(int)dr["id"], KategoriID=(int)dr["KategoriID"], Path=dr["Path"].ToString()});
            }
            conn.Close();
            return liste;
        }
        public static List<Dosya> ListeGetir(int aracID, int KategoriID)
        {
            List<Dosya> liste = new List<Dosya>();

            if (KategoriID != 0)
            {

                SqlConnection conn = db.conn();
                SqlCommand cmd = new SqlCommand("Select id,Ad,Path,KategoriID,AracID from Dosyalar where AracID=@aracid and KategoriID=@kategoriid", conn);
                cmd.Parameters.AddWithValue("@aracid", aracID);
                cmd.Parameters.AddWithValue("@kategoriid", KategoriID);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    liste.Add(new Dosya { AracID = aracID, Ad = dr["Ad"].ToString(), id = (int)dr["id"], KategoriID = (int)dr["KategoriID"], Path = dr["Path"].ToString() });
                }
                conn.Close();

                return liste;
            }
            else
            {
                return liste;
            }

        }
        public static bool AracDosyaEkle(Dosya dosya)
        {
            try
            {
                SqlConnection conn = db.conn();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[[Dosyalar]] ([Ad],[Path],[KategoriID],[AracID]) VALUES (@ad,@path,@kategoriid,@aracid)", conn);
                cmd.Parameters.AddWithValue("@ad", dosya.Ad);
                cmd.Parameters.AddWithValue("@path", dosya.Path);
                cmd.Parameters.AddWithValue("@kategoriid", dosya.KategoriID);
                cmd.Parameters.AddWithValue("@id", dosya.AracID);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

}
