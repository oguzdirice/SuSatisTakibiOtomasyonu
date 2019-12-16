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
    public partial class YeniKayit : Form
    {
        Form1 f = new Form1(); //Globalde form1 den referans üretttim.
        public YeniKayit()
        {
            InitializeComponent();
        }

        private void YeniKayit_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adi = txtAdi.Text;
            string soyadi = txtSoyadi.Text;
            string telefon = txtTelefon.Text;
            string adres = txtAdres.Text;

            var ff = Helper.MusteriEkleModele(adi, soyadi, telefon, adres);
            var donut=Helper.MusteriEkleVeriye(ff);
            if (donut==true)
            {
                MessageBox.Show("Müşteri başarıyla eklenmiştir", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Müşteri ekleme işlemi başarısız oldu", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextTemizle();
            }  
        }

        public void TextTemizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtAdres.Clear();
            txtTelefon.Clear();
        }

        
    }
}
