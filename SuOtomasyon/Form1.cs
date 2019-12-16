using SuOtomasyon.Entity;
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
    public partial class Form1 : Form
    {
        YeniKayit yk = new YeniKayit();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormAcilis();
        }

        public void FormAcilis()
        {
            MusteriYukle();
            SiparisleriYukle();
        }

        public void MusteriYukle() //Müşterileri Listeliyor
        {
            var musteriList = Helper.ModelMusteriListesiVer();
            var ff = from item in musteriList
                     orderby item.MusteriID descending
                     select new
                     {
                         Id = item.MusteriID,
                         Adı = item.MusteriAdi,
                         Soyadı = item.MusteriSoyadi,
                         Telefon = item.MusteriTelefon,
                         Adres = item.MusteriAdres
                     };

            dtgMusteriler.DataSource = ff.ToList();
        }

        public void SiparisleriYukle() //Siparişleri Listeliyor
        {
            var musteri=Helper.ModelMusteriListesiVer();
            var siparisler = Helper.SiparisListele();
            var ff = from item in siparisler
                     join m in musteri
                     on item.m.MusteriID equals m.MusteriID
                     orderby item.SiparisID descending
                     select new
                     {
                         Id = item.SiparisID,
                         Musteri = string.Concat(m.MusteriAdi +" "+ m.MusteriSoyadi),
                         SiparisTarihi = item.SiparisTarih,
                         SiparisDurumu = item.SiparisDurum,
                         Tutar = item.SiparisTutar
                     };
            dtgSiparisler.DataSource = ff.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            YeniKayit y = new YeniKayit();
            y.Show();
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dtgMusteriler.CurrentRow.Cells[0].Value);
            
            Guncelle g = new Guncelle();
            g.GuncelleSet(id);
            g.Show();
        }

        private void btnYeniSiparis_Click(object sender, EventArgs e)//YeniSipariş Formuna seçili Müşteriyi Gönderiyor.
        {
            var ff = new ModelMusteriler
            {
                MusteriID = Convert.ToInt32(dtgMusteriler.CurrentRow.Cells[0].Value),
                MusteriAdi = dtgMusteriler.CurrentRow.Cells[1].Value.ToString(),
                MusteriSoyadi = dtgMusteriler.CurrentRow.Cells[2].Value.ToString(),
                MusteriTelefon = dtgMusteriler.CurrentRow.Cells[3].Value.ToString(),
                MusteriAdres = dtgMusteriler.CurrentRow.Cells[4].Value.ToString()
            };

            YeniSiparis yeniSiparis = new YeniSiparis(); //YeniSiparişler Formununa metod ile değerleri gönderiyorum.
            yeniSiparis.set(ff);
            yeniSiparis.Show();
            SiparisleriYukle();
        }

        

        private void dtgMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)  //Messagebox dan dönen dönüte göre silecek.
        {
            var mesaj = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz?", "Uyarı Mesajı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (mesaj == DialogResult.Yes)
            {
                Helper.MusteriSi(new ModelMusteriler
                {
                    MusteriID = Convert.ToInt32(dtgMusteriler.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Müşteri Başarıyla Silinmiştir");
                MusteriYukle();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e) // Yenile Butonu her ikisini de yeniliyor.
        {
            MusteriYukle();
            SiparisleriYukle();
        }

        private void tbxMusteriAdiAra_TextChanged(object sender, EventArgs e) //Anlık arama
        {
            var musteriList = Helper.ModelMusteriListesiVer();
            var aranan = tbxMusteriAdiAra.Text.ToUpper();
            var ff = from item in musteriList
                     orderby item.MusteriID descending
                     where item.MusteriAdi.Contains(aranan)
                     select new
                     {
                         Id = item.MusteriID,
                         Adı = item.MusteriAdi,
                         Soyadı = item.MusteriSoyadi,
                         Telefon = item.MusteriTelefon,
                         Adres = item.MusteriAdres
                     };
            dtgMusteriler.DataSource = ff.ToList();
        }

        private void btnYeniCikti_Click(object sender, EventArgs e) //Yeni Çıktı Butonu
        {
            var id = Convert.ToInt32(dtgSiparisler.CurrentRow.Cells[0].Value);
            Helper.SiparisDurumuDegistir(id, (int)Enums.SiparisOnay.YeniCikti);
            SiparisleriYukle();
        }

        private void btnTeslimEdildi_Click(object sender, EventArgs e) //Teslim Edldi Butonu
        {
            var id = Convert.ToInt32(dtgSiparisler.CurrentRow.Cells[0].Value);
            Helper.SiparisDurumuDegistir(id, (int)Enums.SiparisOnay.TeslimEdildi);
            SiparisleriYukle();
        }

        private void btnSeciliSil_Click(object sender, EventArgs e) //ModelSipariş üzerinden seçilen siparişi siliyor.
        {
            var mesaj = MessageBox.Show("Seçili siparişi silmek istediğinize emin misiniz?", "Uyarı Mesajı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (mesaj == DialogResult.Yes)
            {
                Helper.SiparisSil(new ModelSiparisler
                {
                    SiparisID = Convert.ToInt32(dtgSiparisler.CurrentRow.Cells[0].Value),
                });
            }
            MessageBox.Show("Sipariş silinmiştir");
            SiparisleriYukle();
        }

        private void btnBugunSiparisler_Click(object sender, EventArgs e) //Bugünun siparişlerini listeliyor.
        {

            var ff = Helper.SiparisListesiVer();
            var gg = Helper.ModelMusteriListesiVer();
            var sorgu = from item in ff
                        join m in gg
                        on item.MusteriID equals m.MusteriID
                        orderby item.SiparisID descending
                        where item.SiparisTarih == Convert.ToDateTime(DateTime.Now.ToShortDateString()) //Sadece gümn ay yıl alsın diye yaptım
                        select new
                        {
                            Id = item.SiparisID,
                            Musteri = string.Concat(m.MusteriAdi + " " + m.MusteriSoyadi),
                            SiparisTarihi = item.SiparisTarih,
                            SiparisDurumu = item.SiparisDurum,
                            Tutar = item.SiparisTutar
                        };
            dtgSiparisler.DataSource = sorgu.ToList();
        }
    }
}
