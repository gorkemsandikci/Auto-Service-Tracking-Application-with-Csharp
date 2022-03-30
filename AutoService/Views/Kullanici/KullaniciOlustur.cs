using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class KullaniciOlustur : Form
    {
        public KullaniciOlustur()
        {
            InitializeComponent();
        }


        private void btnKullaniciKaydet_Click(object sender, EventArgs e)
        {
            if (KullaniciController.Ekle(
             new Kullanici
             {
                 Ad = txtAd.Text,
                 Soyad = txtSoyad.Text,
                 Gsm = mtxtTelefon.Text,
                 Email = txtEposta.Text.ToString(),
                 Sifre = Tools.MD5Uret(Properties.Settings.Default.SecretKey + txtSifre.Text.ToString()),
                 TicariUnvan = txtTicariUnvan.Text.ToString(),
                 VergiDairesi = txtVergiDairesi.Text.ToString(),
                 VergiNo = txtVergiNo.Text.ToString(),
                 Adres = txtAdres.Text.ToString(),
                 KullaniciTipi = 1,
                 MusteriTipi = (radioBireysel.Checked ? (short)0 : (short)1),
                 Durum = true,
             }
             ))
            {
                MesajKutusu kutu = new MesajKutusu("Başarılı", "Kullanıcı Başarıyla Oluşturuldu", MesajIkon.Bilgi, MesajButton.Tamam);
                kutu.ShowDialog();
            }
            else
            {
                MesajKutusu kutu = new MesajKutusu("Hata Oluştu", "Alanları hatasız şekilde doldurduğunuzdan emin olun", MesajIkon.Bilgi, MesajButton.Tamam);
                kutu.ShowDialog();

            }


        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }


        private void radioKurumsal_CheckedChanged(object sender, EventArgs e)
        {
            groupKurumsalBilgiler.Enabled = ((RadioButton)sender).Checked;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control ctl in control.Controls)
                    {
                        if (ctl is TextBox || ctl is MaskedTextBox)
                            ctl.Text = String.Empty;
                        else if (ctl is RadioButton)
                            ((RadioButton)ctl).Checked = false;
                    }
                }
                    
            }
            //this.Controls.Clear();
            //InitializeComponent();

        }
    }
}
