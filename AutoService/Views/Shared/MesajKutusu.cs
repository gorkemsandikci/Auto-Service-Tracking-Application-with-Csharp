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
    public partial class MesajKutusu : Form
    {
        public string _baslik { get; set; }
        public string _mesaj { get; set; }
        public MesajIkon _ikon { get; set; }
        public MesajButton _button { get; set; }
        public MesajKutusuCevap _mesajKutusuCevap { get; set; }
        public MesajKutusu(string baslik, string mesaj, MesajIkon ikon, MesajButton button)
        {
            InitializeComponent();
            _baslik = baslik;
            _mesaj = mesaj;
            _ikon = ikon;
            _button = button;
            lblBaslik.Text = _baslik;
            lblMesaj.Text = _mesaj;

            if (ikon == MesajIkon.hata)
            {
                pbMesaj.Image = Properties.Resources.warning;
            } else if(ikon == MesajIkon.Uyari)
            {
                pbMesaj.Image = Properties.Resources.warning;
            }

            if (button == MesajButton.Tamam)
            {
                btnTamam.Visible = true;
            }
            else if (button == MesajButton.EvetHayir)
            {
                btnEvet.Visible = true;
                btnHayir.Visible = true;
            }
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            _mesajKutusuCevap = MesajKutusuCevap.Tamam;
            this.Close();
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            _mesajKutusuCevap = MesajKutusuCevap.Evet;
            this.Close();
        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            _mesajKutusuCevap = MesajKutusuCevap.Hayir;
            this.Close();
        }
    }
}
