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
        Arac aracmodel = new Arac();
        Arac aracmarka = new Arac();

        public AracGoruntuleForm(int secim)
        {
            arac = AracController.AracGetir(secim);
            aracmodel = AracController.AracModelGetir(secim);
            aracmarka = AracController.AracMarkaGetir(secim);
            InitializeComponent();
        }

        private void btnAracFotoYukle_Click(object sender, EventArgs e)
        {
            

        }

        private void AracGoruntuleForm_Load(object sender, EventArgs e)
        {
            lblPlaka.Text = arac.Plaka;
            lblRenk.Text = arac.Renk;
            lblSasiNo.Text = arac.SasiNo;
            lblYil.Text = arac.Yil.ToString();
            lblModel.Text = aracmodel.ModelAd;
            lblMarka.Text = aracmarka.MarkaAd;
        }
    }
}
