using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuOtomasyon.Model;

namespace SuOtomasyon
{
    public partial class YeniSiparis : Form
    {
        public YeniSiparis()
        {
            InitializeComponent();
        }
        public void set(ModelMusteriler mm) //Form1 deki datagridden veriler set metodu ile geliyor.
        {
            txtSiparisMusteriId.Text = mm.MusteriID.ToString();
            txtSiparisAdi.Text = mm.MusteriAdi;
            txtSiparisSoyadi.Text = mm.MusteriSoyadi;
            txtSiparisTelefon.Text = mm.MusteriTelefon.ToString();
        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e) //Butona tıkladığımda model türünden yeni bir sipariş oluşturuyor.
        {
            ModelSiparisler ms = new ModelSiparisler();
            ms.SiparisTutar = Convert.ToInt32(txtSiparisTutar.Text);
            ms.SiparisDurum = Enums.SiparisOnay.YeniSiparis.ToString();
            ms.SiparisTarih = Convert.ToDateTime(DateTime.Now.ToShortDateString()); // Saat kısmnı almamak için
            ms.m.MusteriID = Convert.ToInt32(txtSiparisMusteriId.Text);

            var siparis=Helper.SiparisEkle(ms);
            if (siparis==true)
            {
                MessageBox.Show("Sipariş başarıyla oluşturuldu.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sipariş oluşturma işlemi başarısız oldu.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void YeniSiparis_Load(object sender, EventArgs e)
        {
            MusteriKilitle();
        }

        public void MusteriKilitle()
        {
            txtSiparisMusteriId.Enabled = false; //Musteri İd textini kilitliyorum.
            txtSiparisAdi.Enabled = false;
            txtSiparisSoyadi.Enabled = false;
            txtSiparisTelefon.Enabled = false;
        }
    }
}
