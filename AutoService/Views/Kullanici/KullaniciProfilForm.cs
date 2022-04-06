using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class KullaniciProfilForm : Form
    {
        Kullanici kullanici = new Kullanici();

        public KullaniciProfilForm(int secim)
        {
            InitializeComponent();
            kullanici = KullaniciController.Bilgilergetir(secim);
        }

        private void KullaniciProfilForm_Load(object sender, EventArgs e)
        {
            lblAd.Text = kullanici.Ad;
            lblAdres.Text = kullanici.Adres;
            lblDurum.Text = kullanici.Durum.ToString();
            lblEmail.Text = kullanici.Email;
            lblSoyad.Text = kullanici.Soyad;
            lblKayitTarihi.Text = kullanici.OlusturmaTarihi.ToString();
            if (kullanici.MusteriTipi == 0)
            {
                lblTicariUnvan.Visible = false;
                lblVergidairesi.Visible = false;
                lblVergiNo.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                lblMusteritipi.Text = "Bireysel";
            }
            else
            {
                lblTicariUnvan.Visible = true;
                lblVergidairesi.Visible = true;
                lblVergiNo.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                lblMusteritipi.Text = "Kurumsal";
                lblTicariUnvan.Text = kullanici.TicariUnvan;
                lblVergidairesi.Text = kullanici.VergiDairesi;
                lblVergiNo.Text = kullanici.VergiNo;
            }
            lblGsm.Text = kullanici.Gsm;
            if (kullanici.ProfilFoto != "")
            {
                picProfilFoto.ImageLocation = Application.StartupPath + "\\ProfilFotolari\\" + kullanici.ProfilFoto;
            }
            listboxAracListesi.DataSource = (AracController.Listele(kullanici.id));
            listboxAracListesi.ValueMember = "id";
            listboxAracListesi.DisplayMember = "Plaka";
        }

        private void btnFotoYukle_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Ekle";
            openFileDialog.DefaultExt = ".png";
            openFileDialog.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg";

            {
                if (!Directory.Exists(Application.StartupPath + "\\ProfilFotolari\\"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\ProfilFotolari\\");
                }

                DialogResult sonuc = openFileDialog.ShowDialog();

                if (sonuc == DialogResult.OK)
                {
                    Image img = Image.FromFile(openFileDialog.FileName);

                    //yuklenen dosyanın dosya uzantısını alıyoruz.
                    string extension = Path.GetExtension(openFileDialog.FileName);

                    string dosyaAdi = kullanici.id + "-" + Tools.TurkceKarakterTemizle(kullanici.Ad + " " + kullanici.Soyad) + "-ProfilFotolari-" + Tools.RandomString(6) + extension;

                    //Fotografi diske kaydettiğimiz yer burası.
                    img.Save(Application.StartupPath + "\\ProfilFotolari\\" + dosyaAdi);

                    picProfilFoto.Image = img;

                    if (KullaniciController.ProfilFotoGuncelle(dosyaAdi, kullanici.id))
                    {

                        MesajKutusu kutu = new MesajKutusu("Başarılı", "Profil Fotografi Basarili Sekilde Yuklenmistir", MesajIkon.hata, MesajButton.Tamam);
                        kutu.ShowDialog();
                        kutu.Dispose();

                    }
                    else
                    {
                        MesajKutusu kutu = new MesajKutusu("Bir hata oluştu", "Fotograf yolu veri tabanına yazdırılırken hata mejdana geldi", MesajIkon.hata, MesajButton.Tamam);
                        kutu.ShowDialog();
                        kutu.Dispose();

                    }

                }

            }

        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            AracEkleForm aracEkle = new AracEkleForm();
            aracEkle.ShowDialog();
        }

        private void btnAracGoruntule_Click(object sender, EventArgs e)
        {

            AracGoruntuleForm aracGoruntule = new AracGoruntuleForm((int)listboxAracListesi.SelectedValue);
            aracGoruntule.listboxDosyaListesi.DataSource = listboxAracListesi.DataSource;
            aracGoruntule.listboxDosyaListesi.ValueMember = "id";
            aracGoruntule.listboxDosyaListesi.DisplayMember = "Plaka";
            aracGoruntule.ShowDialog();
        }
    }
}
