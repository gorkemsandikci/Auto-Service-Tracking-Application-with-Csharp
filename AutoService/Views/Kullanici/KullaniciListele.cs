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
    public partial class KullaniciListele : Form
    {
        public KullaniciListele()
        {
            InitializeComponent();
        }

        private void KullaniciListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'autoSerciceDataSet.Kullanicilar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanicilarTableAdapter.Fill(this.autoSerciceDataSet.Kullanicilar);

        }

        private void dgwKullaniciListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && e.ColumnIndex==14)
            {
                int secim = (int)dgwKullaniciListele.Rows[e.RowIndex].Cells[0].Value;

                KullaniciProfilForm kullaniciProfilForm = new KullaniciProfilForm(secim);
                kullaniciProfilForm.ShowDialog();
            }
        }
    }
}
