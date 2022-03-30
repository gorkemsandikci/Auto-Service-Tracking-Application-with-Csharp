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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.KullaniciAdi != string.Empty)
            {
                if (Properties.Settings.Default.BeniHatirla == true)
                {
                    txtEPosta.Text = Properties.Settings.Default.KullaniciAdi;
                    txtSifre.Text = Properties.Settings.Default.Sifre;
                    chkBeniHatirla.Checked = true;
                }
                else
                {
                    chkBeniHatirla.Checked = false;
                }
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici kul = KullaniciController.Login(txtEPosta.Text, txtSifre.Text);
            if (kul.id == 0)
            {
                MesajKutusu kutu = new MesajKutusu("hata", "E-Posta adresiniz veya Şifreniz hatalı", MesajIkon.hata, MesajButton.EvetHayir);
                kutu.ShowDialog();
                kutu.Dispose();
            }
            else
            {
                if (chkBeniHatirla.Checked == true)
                {
                    Properties.Settings.Default.KullaniciAdi = txtEPosta.Text;
                    Properties.Settings.Default.Sifre = txtSifre.Text;
                    Properties.Settings.Default.BeniHatirla = true;
                    Properties.Settings.Default.Save();
                    DashboardForm dashboardForm = new DashboardForm();
                    dashboardForm.ShowDialog();

                }
                else
                {
                    
                    Properties.Settings.Default.KullaniciAdi = "";
                    Properties.Settings.Default.Sifre = "";
                    Properties.Settings.Default.BeniHatirla = false;
                    Properties.Settings.Default.Save();

                }
                MessageBox.Show(kul.Email, kul.Sifre);
                MessageBox.Show(Properties.Settings.Default.BeniHatirla.ToString()+Properties.Settings.Default.KullaniciAdi.ToString()+Properties.Settings.Default.Sifre.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SifremiUnuttum frm = new SifremiUnuttum();
            frm.ShowDialog();
        }
    }
}
