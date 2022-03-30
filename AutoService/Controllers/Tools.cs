using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    static class Tools
    {
        public static string MD5Uret(string input)
        {
            // Step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public static string TurkceKarakterTemizle(string s)
        {
            s = s.Replace("İ", "I");
            s = s.Replace("ı", "i");
            s = s.Replace("Ğ", "G");
            s = s.Replace("ğ", "g");
            s = s.Replace("Ö", "O");
            s = s.Replace("ö", "o");
            s = s.Replace("Ü", "U");
            s = s.Replace("ü", "u");
            s = s.Replace("Ş", "S");
            s = s.Replace("ş", "s");
            s = s.Replace("Ç", "C");
            s = s.Replace("ç", "c");
            s = s.Replace(" ", "-");

            return s;
        }
        public static string RandomString(int uzunluk)
        {
            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < uzunluk; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }
        //public static MesajKutusu kutu(string )
        //{

        //    MesajKutusu kutu = new MesajKutusu("Hata", "Profil fotoğrafı yüklenirken bir hata meydana geldi", MesajIkon.hata, MesajButton.Tamam);
        //    return kutu;
        //}
    }
}
