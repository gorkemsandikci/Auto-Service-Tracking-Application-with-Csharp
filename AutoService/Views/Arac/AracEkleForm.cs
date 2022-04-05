using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class AracEkleForm : Form
    {

        public AracEkleForm()
        {
            InitializeComponent();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            if(
            AracController.AracEkle(new Arac
            {
                Plaka = txtPlaka.Text,
                ModelID = ((Arac)cbModel.SelectedItem).ModelID,
                SasiNo = txtSasiNo.Text,
                Renk = txtRenk.Text,
                Yil = int.Parse(txtYil.Text),
                KullaniciID = int.Parse(lblId.Text)

            }))
            {
                MesajKutusu kutu = new MesajKutusu("Başarılı", "Araç Başarıyla Eklendi", MesajIkon.Bilgi, MesajButton.Tamam);
                kutu.ShowDialog();
            }
            else
            {
                MesajKutusu kutu = new MesajKutusu("Hata Oluştu", "Alanları hatasız şekilde doldurduğunuzdan emin olun", MesajIkon.Bilgi, MesajButton.Tamam);
                kutu.ShowDialog();

            }
        }

        private void AracEkleForm_Load(object sender, EventArgs e)
        {
        }

        
       

        private void cbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {

        }

        private void lblModelId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
