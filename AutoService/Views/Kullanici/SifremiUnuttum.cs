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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (KullaniciController.SifremiSifirla(txtEPosta.Text))
            {
                MesajKutusu mesajKutusu = new MesajKutusu("Bilgilendirme","Yeni şifreniz e-posta adresinize gönderilmiştir", MesajIkon.hata, MesajButton.Tamam);
                mesajKutusu.ShowDialog();
            }
            else
            {
                MesajKutusu mesajKutusu = new MesajKutusu("Bilgilendirme", "E-Posta adresiniz sistemde kayıtlı değildir", MesajIkon.hata, MesajButton.Tamam);
                mesajKutusu.ShowDialog();
            }
        }
    }
}
