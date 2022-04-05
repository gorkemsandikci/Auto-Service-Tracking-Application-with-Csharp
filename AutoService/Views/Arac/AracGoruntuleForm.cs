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
    public partial class AracGoruntuleForm : Form
    {
        Arac arac = new Arac();

        public AracGoruntuleForm(int secim)
        {
            arac = AracController.Getir(secim);
            InitializeComponent();
        }

        private void AracGoruntuleForm_Load(object sender, EventArgs e)
        {
            lblPlaka.Text = arac.Plaka;
            lblRenk.Text = arac.Renk;
            lblSasiNo.Text = arac.SasiNo;
            lblYil.Text = arac.Yil.ToString();
            lblModel.Text = arac.Model.Ad;

            List<DosyaKategori> dosyaKategoris = DosyaKategoriController.List();
            dosyaKategoris.Add(new DosyaKategori { id = 0, Ad = "Hepsi" });
            comboBoxSecim.DataSource = dosyaKategoris;

            comboBoxSecim.ValueMember = "id";
            comboBoxSecim.DisplayMember = "Ad";
            comboBoxSecim.SelectedValue = 0;
            listboxDosyaListesi.DataSource = arac.Dosyalar;
            listboxDosyaListesi.ValueMember = "id";
            listboxDosyaListesi.DisplayMember = "Ad";
        }

        private void comboBoxSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSecim.SelectedItem != null)
            {


                if (((DosyaKategori)comboBoxSecim.SelectedItem).id == 0)
                {
                    listboxDosyaListesi.DataSource = DosyaController.ListeGetir(arac.id);

                }
                else
                {
                    listboxDosyaListesi.DataSource = DosyaController.ListeGetir(arac.id, ((DosyaKategori)comboBoxSecim.SelectedItem).id);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (((DosyaKategori)comboBoxSecim.SelectedItem).id != 0)
            {
                if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\AracDosyalari\\"+arac.id+"\\"+ ((DosyaKategori)comboBoxSecim.SelectedItem).Ad))
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\AracDosyalari\\" + arac.id + "\\" + ((DosyaKategori)comboBoxSecim.SelectedItem).Ad);
                }
                string dosyaAdi = Tools.TurkceKarakterTemizle(Tools.RandomString(6) + "-" + openCarFileDialog.SafeFileName);
                File.Copy(openCarFileDialog.FileName, (Directory.GetCurrentDirectory() + "\\AracDosyalari\\" + arac.id + "\\" + ((DosyaKategori)comboBoxSecim.SelectedItem).Ad) + "\\" + dosyaAdi);
                DosyaController.AracDosyaEkle(new Dosya
                {
                    Ad = dosyaAdi,
                    AracID = arac.id,
                    KategoriID = ((DosyaKategori)comboBoxSecim.SelectedItem).id,
                    Path = dosyaAdi
                });
            }
            else
            {
                MesajKutusu kutu = new MesajKutusu("Bilgi", "Lütfen Bir Klasör Seçin!", MesajIkon.hata, MesajButton.Tamam);
                kutu.ShowDialog();
                kutu.Dispose();
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (groupBoxDosyaYukle.Visible == false)
            {
                groupBoxDosyaYukle.Location = groupBoxAracListesi.Location;
                groupBoxAracListesi.Location = new Point(groupBoxAracListesi.Location.X, groupBoxAracListesi.Location.Y + groupBoxDosyaYukle.Size.Height);
                groupBoxDosyaYukle.Visible = true;
            }
            else
            {
                groupBoxAracListesi.Location = new Point(groupBoxAracListesi.Location.X, groupBoxAracListesi.Location.Y - groupBoxDosyaYukle.Size.Height);
                groupBoxDosyaYukle.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openCarFileDialog.ShowDialog();
            txtDosya.Text = openCarFileDialog.FileName;
        }
    }
}
