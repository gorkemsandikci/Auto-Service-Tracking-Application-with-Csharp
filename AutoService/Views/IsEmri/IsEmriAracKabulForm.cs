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
    public partial class IsEmriAracKabulForm : Form
    {
        public List<Arac> _araclar = AracController.TumunuGetir();


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

            if (liste.Count > 0)
            {
                txtModel.Text = liste[0].Model.Ad;
                txtPlaka.Text = liste[0].Plaka;
                txtRenk.Text = liste[0].Renk;
                txtSasiNo.Text = liste[0].SasiNo;
                txtYil.Text = liste[0].Yil.ToString();
            }

            //List<Arac> liste = _araclar.Where(a => a.Plaka.ToUpper() == txtPlaka.Text.ToUpper()).ToList();


        }

        private void IsEmriAracKabulForm_Load(object sender, EventArgs e)
        {
        }
    }
}
