using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public static class KullaniciController
    {
        public static Kullanici Login(string email, string Sifre)
        {
            string md5Sifre = Tools.MD5Uret(Properties.Settings.Default.SecretKey + Sifre);
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select * from Kullanicilar where Email=@email and UPPER(Sifre)=@sifre and Durum = 1", conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@sifre", md5Sifre);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            Kullanici kul;
            if (dr.HasRows)
            {
                kul = new Kullanici();
                kul.Ad = dr["Ad"].ToString();
                kul.Adres = dr["Adres"].ToString();
                kul.Durum = (bool)dr["Durum"];
                kul.Email = dr["Email"].ToString();
                kul.Gsm = dr["Gsm"].ToString();
                kul.id = (int)dr["id"];
                kul.KullaniciTipi = (short)dr["KullaniciTİpi"];
                kul.MusteriTipi = (short)dr["MusteriTipi"];
                kul.OlusturmaTarihi = (DateTime)dr["OlusturmaTarihi"];
                kul.Sifre = dr["Sifre"].ToString();
                kul.Soyad = dr["Soyad"].ToString();
                kul.TicariUnvan = dr["TicariUnvan"].ToString();
                kul.VergiDairesi = dr["VergiDairesi"].ToString();
                kul.VergiNo = dr["VergiNo"].ToString();

            }
            else
            {
                kul = new Kullanici { id = 0 };
            }
            dr.Close();
            conn.Close();

            return kul;
        }
        public static bool SifremiSifirla(string email)
        {
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select Count(*) From Kullanicilar where Email=@email", conn);
            cmd.Parameters.AddWithValue("@email", email);
            conn.Open();
            int i = (int)cmd.ExecuteScalar();
            conn.Close();
            if (i != 0)
            {
                Random rnd = new Random();
                int YeniSifre = rnd.Next(1000, 9999);
                string md5Sifre = Tools.MD5Uret(Properties.Settings.Default.SecretKey + YeniSifre);

                cmd = new SqlCommand("Update Kullanicilar Set Sifre=@sifre where Email=@email", conn);
                cmd.Parameters.AddWithValue("@sifre", md5Sifre);
                cmd.Parameters.AddWithValue("@email", email);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                Controllers.Mailer.MailGonder(email, "AutoService Yeni Şifre", "Yeni şifreniz : " + YeniSifre);
                System.Windows.Forms.MessageBox.Show(YeniSifre.ToString());
            }
            return (i != 0);
        }
        public static bool Ekle(Kullanici kullanici)
        {
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Insert into Kullanicilar values (@ad, @soyad, @gsm, @email, @sifre, @ticariunvan, @vergidairesi, @vergino, @adres, @musteritipi, @kullanicitipi, @durum, GETDATE(),@ProfilFoto )", conn);
            // insert into Kullanicilar (Ad,Soyad,Durum) values(@ad,@soyad,@durum)
            cmd.Parameters.AddWithValue("@ad", kullanici.Ad);
            cmd.Parameters.AddWithValue("@soyad", kullanici.Soyad);
            cmd.Parameters.AddWithValue("@gsm", kullanici.Gsm);
            cmd.Parameters.AddWithValue("@email", kullanici.Email);
            cmd.Parameters.AddWithValue("@sifre", kullanici.Sifre);
            cmd.Parameters.AddWithValue("@ticariunvan", kullanici.TicariUnvan);
            cmd.Parameters.AddWithValue("@vergidairesi", kullanici.VergiDairesi);
            cmd.Parameters.AddWithValue("@vergino", kullanici.VergiNo);
            cmd.Parameters.AddWithValue("@adres", kullanici.Adres);
            cmd.Parameters.AddWithValue("@musteritipi", kullanici.MusteriTipi);
            cmd.Parameters.AddWithValue("@kullanicitipi", kullanici.KullaniciTipi);
            cmd.Parameters.AddWithValue("@durum", kullanici.Durum);
            cmd.Parameters.AddWithValue("@ProfilFoto", DBNull.Value);
            conn.Open();
            int sayi = cmd.ExecuteNonQuery();
            conn.Close();

            if (sayi > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool KullaniciDuzenle(Kullanici kullanici)
        {
            SqlConnection conn = db.conn();

            SqlCommand cmd = new SqlCommand(@"
                    UPDATE[dbo].[Kullanicilar]
   SET[Ad] = @ad
      ,[Soyad] = @soyad
      ,[Gsm] = @gsm
      ,[Email] = @email
      ,[TicariUnvan] = @ticariunvan
      ,[VergiDairesi] = @vergidairesi
      ,[VergiNo] = @vergino
      ,[Adres] = @adres
      ,[MusteriTipi] = @musteritipi
 WHERE id=@id", conn);

            cmd.Parameters.AddWithValue("@ad", kullanici.Ad);
            cmd.Parameters.AddWithValue("@soyad", kullanici.Soyad);
            cmd.Parameters.AddWithValue("@gsm", kullanici.Gsm);
            cmd.Parameters.AddWithValue("@email", kullanici.Email);
            cmd.Parameters.AddWithValue("@ticariunvan", kullanici.TicariUnvan);
            cmd.Parameters.AddWithValue("@vergidairesi", kullanici.VergiDairesi);
            cmd.Parameters.AddWithValue("@vergino", kullanici.VergiNo);
            cmd.Parameters.AddWithValue("@adres", kullanici.Adres);
            cmd.Parameters.AddWithValue("@musteritipi", kullanici.MusteriTipi);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            return true;

        }
        public static Kullanici Bilgilergetir(int kullaniciId)
        {
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("select * from Kullanicilar where id = " + kullaniciId, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            return new Kullanici()
            {
                Ad = dr["Ad"].ToString(),
                Soyad = dr["Soyad"].ToString(),
                Durum = (bool)dr["Durum"],
                Email = dr["Email"].ToString(),
                Gsm = dr["Gsm"].ToString(),
                id = (int)dr["id"],
                KullaniciTipi = (short)dr["KullaniciTipi"],
                OlusturmaTarihi = (DateTime)dr["OlusturmaTarihi"],
                TicariUnvan = dr["TicariUnvan"].ToString(),
                VergiDairesi = dr["VergiDairesi"].ToString(),
                Adres = dr["Adres"].ToString(),
                VergiNo = dr["VergiNo"].ToString(),
                ProfilFoto = dr["ProfilFoto"].ToString()
            };
        }
        public static bool ProfilFotoGuncelle(string dosyaAdi, int kullaniciID)
        {
            try
            {
                SqlConnection conn = db.conn();
                SqlCommand cmd = new SqlCommand("UPDATE[dbo].[Kullanicilar] SET[ProfilFoto] = @profilfoto WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@profilfoto", dosyaAdi);
                cmd.Parameters.AddWithValue("@id", kullaniciID);
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
