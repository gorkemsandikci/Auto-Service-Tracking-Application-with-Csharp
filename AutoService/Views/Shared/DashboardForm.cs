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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miKullaniciOlustur_Click(object sender, EventArgs e)
        {
            KullaniciOlustur kullaniciOlustur = new KullaniciOlustur();
            kullaniciOlustur.Show();
        }

        private void miKullanicilariListele_Click(object sender, EventArgs e)
        {
            KullaniciListele kullaniciListele = new KullaniciListele();
            kullaniciListele.Show();

        }
    }
}
