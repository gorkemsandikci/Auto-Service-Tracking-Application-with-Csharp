using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace AutoService
{
    public partial class IsEmriAracKabulForm : Form
    {
        public List<Arac> _araclar = AracController.TumunuGetir();
        public Arac _SeciliArac { get; set; }

        public IsEmriAracKabulForm()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            MesajKutusu kutu = new MesajKutusu("Bilgi", "İşlemi iptal etmek istediğinizden emin misiniz?", MesajIkon.hata, MesajButton.EvetHayir);
            kutu.ShowDialog();
            if (kutu._mesajKutusuCevap.ToString() == "Evet")
            {
                kutu.Dispose();
                this.Close();
            }
            else
            {
                kutu.Dispose();
            }
        }

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {
            //Arac arc = _araclar.Find(a => a.Plaka.ToUpper() == txtPlaka.Text.ToUpper());
            //if (arc != null)
            //{
            //    txtModel.Text = arc.Model.Ad;
            //    txtPlaka.Text = arc.Plaka;
            //    txtRenk.Text = arc.Renk;
            //    txtSasiNo.Text = arc.SasiNo;
            //    txtYil.Text = arc.Yil.ToString();
            //}

            List<Arac> liste = _araclar.Where(a => a.Plaka.ToUpper() == txtPlaka.Text.ToUpper()).ToList();

            _SeciliArac = _araclar.Find(a => a.Plaka.ToUpper() == txtPlaka.Text.ToUpper());

            if (_SeciliArac != null)
            {
                txtModel.Text = _SeciliArac.Model.Ad;
                txtPlaka.Text = _SeciliArac.Plaka;
                txtRenk.Text = _SeciliArac.Renk;
                txtSasiNo.Text = _SeciliArac.SasiNo;
                txtYil.Text = _SeciliArac.Yil.ToString();
            }


            //List<Arac> liste = _araclar.Where(a => a.Plaka.ToUpper() == txtPlaka.Text.ToUpper()).ToList();


        }

        private void IsEmriAracKabulForm_Load(object sender, EventArgs e)
        {

            List<IsEmriTuru> IsEmriTurus = IsEmriTuruController.List();
            IsEmriTurus.Add(new IsEmriTuru { id = 0, Ad = "Lütfen Seçiniz.." });

            comboBoxGelisSebebi.DataSource = IsEmriTurus;
            comboBoxGelisSebebi.ValueMember = "id";
            comboBoxGelisSebebi.DisplayMember = "Ad";
            comboBoxGelisSebebi.SelectedValue = 0;
        }

        private void btnAracKabul_Click(object sender, EventArgs e)
        {
            if (comboBoxGelisSebebi.SelectedValue.ToString() != "0")
            {
                if (IsEmriController.Ekle(
                 new IsEmri
                 {
                     AracID = _SeciliArac.id,
                     Aciklama = txtAciklama.Text,
                     TeslimEden = txtTeslimEden.Text,
                     TeslimAlan = txtTeslimAlan.Text,
                     IsEmriTuru = comboBoxGelisSebebi.SelectedItem as IsEmriTuru,
                     Durum = 0,
                 }
                 ))
                {
                    MesajKutusu kutu = new MesajKutusu("Başarılı", "Kabul Başarıyla Gerçekleşti. Yeni Kayıt Eklemek ister misiniz?", MesajIkon.Bilgi, MesajButton.EvetHayir);
                    kutu.ShowDialog();
                    if (kutu._mesajKutusuCevap == MesajKutusuCevap.Evet)
                    {
                        Temizle();
                    }
                    else
                    {
                        this.Dispose();
                    }
                }
                else
                {
                    MesajKutusu kutu = new MesajKutusu("Hata Oluştu", "Plakanın sistemde bulunduğundan emin olun", MesajIkon.Bilgi, MesajButton.Tamam);
                    kutu.ShowDialog();
                }

            }
            else
            {
                MesajKutusu kutu = new MesajKutusu("Hata Oluştu", "İşlem Türü Seçiniz..", MesajIkon.Bilgi, MesajButton.Tamam);
                kutu.ShowDialog();
            }
        }
        private void PdfOlustur()
        {
            //Create a new pdf document
            PdfDocument pdfDocument = new PdfDocument();
            pdfDocument.Info.Title = "Araç Kabul Formu";

            //Create an empty page
            PdfPage page = pdfDocument.AddPage();
            page.Orientation = PdfSharp.PageOrientation.Landscape;

            //Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);


            //Create a font
            XFont h1 = new XFont("Verdana", 20, XFontStyle.Bold);
            XFont h3 = new XFont("Montserrat", 14, XFontStyle.Regular);
            XBrush KirmiziFirca = XBrushes.Red;
            XBrush SiyahFirca = XBrushes.Black;

            //Draw the text
            gfx.DrawString("Araç Kabul Formu", h1, KirmiziFirca, new XRect(0, 0, page.Width, page.Height), XStringFormats.TopCenter);
            gfx.DrawString("07.04.2022", h3, SiyahFirca, page.Width* 0.85, 20) ;

            int offsetX = 100;
            int offsetY = 100;
            int yanbosluk = 100;
            int altbosluk = 20;

            int satirSirasi = 1;
            gfx.DrawString("Araç Plakası : ", h3, SiyahFirca, offsetX, offsetY+altbosluk*satirSirasi);
            gfx.DrawString(_SeciliArac.Plaka, h3, KirmiziFirca, offsetX+yanbosluk, offsetY+altbosluk*satirSirasi);

            satirSirasi++;
            gfx.DrawString("Araç Modeli : ", h3, SiyahFirca, offsetX, offsetY+altbosluk*satirSirasi);
            gfx.DrawString(_SeciliArac.Model.Ad, h3, KirmiziFirca, offsetX+yanbosluk, offsetY+altbosluk*satirSirasi);

            satirSirasi++;
            gfx.DrawString("Açıklama : ", h3, SiyahFirca, offsetX, offsetY+altbosluk*satirSirasi);
            gfx.DrawString(txtAciklama.Text, h3, KirmiziFirca, offsetX+yanbosluk, offsetY+altbosluk*satirSirasi);

            satirSirasi++;
            gfx.DrawString("Geliş Sebebi : ", h3, SiyahFirca, offsetX, offsetY+altbosluk*satirSirasi);
            gfx.DrawString((comboBoxGelisSebebi.SelectedItem as IsEmriTuru).Ad, h3, KirmiziFirca, offsetX+yanbosluk, offsetY+altbosluk*satirSirasi);
            
            satirSirasi++;
            gfx.DrawString("Teslim Alan: ", h3, SiyahFirca, offsetX, offsetY+altbosluk*satirSirasi);
            gfx.DrawString(txtTeslimAlan.Text, h3, KirmiziFirca, offsetX+yanbosluk, offsetY+altbosluk*satirSirasi);
            
            satirSirasi++;
            gfx.DrawString("Teslim Eden: ", h3, SiyahFirca, offsetX, offsetY+altbosluk*satirSirasi);
            gfx.DrawString(txtTeslimEden.Text, h3, KirmiziFirca, offsetX+yanbosluk, offsetY+altbosluk*satirSirasi);

            //Save the document
            string dosyaAdi = Tools.TurkceKarakterTemizle(_SeciliArac.Plaka) + "-" + Tools.RandomString(7) + ".pdf";

            pdfDocument.Save(Directory.GetCurrentDirectory() + "\\PDFs\\" + dosyaAdi);

            //Start the viewer
            Process.Start(Directory.GetCurrentDirectory() + "\\PDFs\\" + dosyaAdi);
        }
        private void Temizle()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
            comboBoxGelisSebebi.SelectedValue = 0;
        }

        private void btnPdfOlustur_Click(object sender, EventArgs e)
        {
            PdfOlustur();
        }
    }
}
