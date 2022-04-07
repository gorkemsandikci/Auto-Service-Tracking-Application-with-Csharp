using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public class IsEmriController
    {
        public static bool Ekle(IsEmri isEmri)
        {
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("INSERT INTO[dbo].[IsEmirleri] ([AracID] ,[Aciklama],[Durum],[TeslimEden],[TeslimAlan],[TurID],[OlusturmaTarihi]) VALUES (@aracid, @aciklama, @durum, @teslimeden, @teslimalan, @turid, GETDATE() )", conn);
            // insert into Kullanicilar (Ad,Soyad,Durum) values(@ad,@soyad,@durum)
            cmd.Parameters.AddWithValue("@aracid", isEmri.AracID);
            cmd.Parameters.AddWithValue("@aciklama", isEmri.Aciklama);
            cmd.Parameters.AddWithValue("@durum", isEmri.Durum);
            cmd.Parameters.AddWithValue("@teslimeden", isEmri.TeslimEden);
            cmd.Parameters.AddWithValue("@teslimalan", isEmri.TeslimAlan);
            cmd.Parameters.AddWithValue("@turid", isEmri.IsEmriTuru.id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            return true;

        }
    }
}
