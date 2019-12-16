using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuOtomasyon
{
    public partial class Guncelle : Form
    {
        public Guncelle()
        {
            InitializeComponent();
        }

        private void btnGuncelleForm_Click(object sender, EventArgs e)
        {
            int musId = Convert.ToInt32(txtGuncelleId.Text);
            string musAd = txtGuncelleAdi.Text;
            string musSoy = txtGuncelleSoyadi.Text;
            string musTel = txtGuncelleTelefon.Text;
            string musAdres = txtGuncelleAdres.Text;

            Helper.MusteriGuncelle(musId, musAd, musSoy, musTel, musAdres);

            MessageBox.Show("Müşteri Başarıyla Güncellendi");

            this.Close();
        }

        private void Guncelle_Load(object sender, EventArgs e)
        {

        }

        public void GuncelleSet(int id) //Helper dan id ye göre model musteri çekecem.
        {
            var ff = Helper.IdyeGoreModelMusteri(id);

            txtGuncelleId.Enabled = false;

            txtGuncelleId.Text = ff.MusteriID.ToString();
            txtGuncelleAdi.Text = ff.MusteriAdi.ToString();
            txtGuncelleSoyadi.Text = ff.MusteriSoyadi.ToString();
            txtGuncelleTelefon.Text = ff.MusteriTelefon.ToString();
            txtGuncelleAdres.Text = ff.MusteriAdres.ToString();
        }
    }
}
