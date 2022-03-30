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
                pictureBox1.ImageLocation = Application.StartupPath + "\\ProfilFotograflari\\" + kullanici.ProfilFoto;

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

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(Application.StartupPath + "\\ProfilFotograflari\\"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\ProfilFotograflari\\");
                }



                Image img = Image.FromFile(openFileDialog.FileName);
                string extention = Path.GetExtension(openFileDialog.FileName);

                string dosyaAdi = +kullanici.id + "-" + kullanici.Ad + kullanici.Soyad + "-ProfilFoto-" + Tools.TurkceKarakterTemizle(Tools.RandomString(6)) + extention;

                img.Save(Application.StartupPath + "\\ProfilFotograflari\\" + dosyaAdi);



                pictureBox1.Image = img;
                if (KullaniciController.ProfilFotoGuncelle(dosyaAdi, kullanici.id))
                {

                    MesajKutusu kutu = new MesajKutusu("Başarılı", "Profil Fotoğrafı başarılı şekilde yüklenmiştir", MesajIkon.hata, MesajButton.Tamam);
                    kutu.ShowDialog();
                    kutu.Dispose();

                }
                else
                {
                    MesajKutusu kutu = new MesajKutusu("Hata", "Profil fotoğrafı yüklenirken bir hata meydana geldi", MesajIkon.hata, MesajButton.Tamam);
                    kutu.ShowDialog();
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
            aracGoruntule.listboxAltAracListesi.DataSource = listboxAracListesi.DataSource;
            aracGoruntule.listboxAltAracListesi.ValueMember = "id";
            aracGoruntule.listboxAltAracListesi.DisplayMember = "Plaka";
            aracGoruntule.ShowDialog();
        }
    }
}
