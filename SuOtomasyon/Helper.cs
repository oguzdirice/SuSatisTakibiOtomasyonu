using SuOtomasyon.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuOtomasyon.Model;

namespace SuOtomasyon
{
    class Helper
    {

        //CONVERT METODLAR BAŞLANGIÇ********************************
        public static ModelMusteriler MusteriConvert(Musteriler m) //Tek bir musteriyi ModelMusteri türünde convert ettim.
        {
            ModelMusteriler mm = new ModelMusteriler();
            mm.MusteriID = m.MusteriID;
            mm.MusteriAdi = m.MusteriAdi;
            mm.MusteriSoyadi = m.MusteriSoyadi;
            mm.MusteriTelefon = m.MusteriTelefon;
            mm.MusteriAdres = m.MusteriAdres;

            return mm;
        }

        public static List<ModelMusteriler> MusterilerConvert(List<Musteriler> m) //Liste türünde verilen entity model i içerde convert ederek
        {
            List<ModelMusteriler> mm = new List<ModelMusteriler>();
            foreach (var item in m)
            {
                var yeniMusteri = MusteriConvert(item);
                mm.Add(yeniMusteri);
            }
            return mm;
        }

        public static List<ModelMusteriler> ModelMusteriListesiVer() //musteri türünden veriyi convert ederek ModelMusteri türünden veriyor.
        {
            using (SuOtomasyonEntities soe=new SuOtomasyonEntities())
            {
                List<ModelMusteriler> mml = new List<ModelMusteriler>();
                var musteriList = soe.Musteriler.ToList();
                foreach (var item in musteriList)
                {
                    var ff = MusteriConvert(item);
                    mml.Add(ff);
                }
                return mml;
            }
        }

        public static Musteriler ModelMusteriConvert(ModelMusteriler mm) //Model musteri gelen classımı Entity musteri ye çeviriyor.
        {
            var ff = new Musteriler
            {
                MusteriID = mm.MusteriID,
                MusteriAdi = mm.MusteriAdi,
                MusteriSoyadi = mm.MusteriSoyadi,
                MusteriAdres = mm.MusteriAdres,
                MusteriTelefon = mm.MusteriTelefon
            };
            return ff;
        }

        public static ModelSiparisler ModelSiparisConvert(Siparisler s) //Siparis Türünden veriri modele döndürür.
        {
            ModelSiparisler ms = new ModelSiparisler();
            ms.SiparisID = s.SiparisID;
            ms.SiparisTutar = s.SiparisTutar;
            ms.SiparisDurum = s.SiparisDurum;
            ms.SiparisTarih = s.SiparisTarih;
            ms.m.MusteriID = s.MusteriID;

            return ms;
        }

        public static Siparisler SiparisConvert(ModelSiparisler ms)//Modelden gelen bilgileri veriye döndüdürü.
        {
            var ff = new Siparisler
            {
                SiparisID = ms.SiparisID,
                SiparisTutar = ms.SiparisTutar,
                SiparisDurum = ms.SiparisDurum,
                SiparisTarih = ms.SiparisTarih,
                MusteriID = ms.m.MusteriID,
            };
            return ff;
        }

        #region gereksiz Siparis Listesini / Siparise çeviriyor.
        //public static Siparisler SiparsiListeConvert(List<Siparisler> ls)
        //{
        //    Siparisler s = new Siparisler();
        //    foreach (var item in ls)
        //    {
        //        s.SiparisID = item.SiparisID;
        //        s.SiparisTutar = item.SiparisTutar;
        //        s.SiparisTarih = item.SiparisTarih;
        //        s.SiparisDurum = item.SiparisDurum;
        //        s.MusteriID = item.MusteriID;
        //    }
        //    return s;
        //}
        #endregion

        //CONVERT METODLAR BİTİŞ***********************************





        //MUSTERİ İŞLEMLERİ BAŞLANGIÇ*************************************
        public static ModelMusteriler ListiCevir(List<ModelMusteriler> mm) //ModelMusteriler listesini ModelMusteriler turunden veriyor
        {
            ModelMusteriler mdf = new ModelMusteriler();
            foreach (var item in mm)
            {
                mdf.MusteriID = item.MusteriID;
                mdf.MusteriAdi = item.MusteriAdi;
                mdf.MusteriSoyadi = item.MusteriSoyadi;
                mdf.MusteriTelefon = item.MusteriTelefon;
                mdf.MusteriAdres = item.MusteriAdres;
            }
            return mdf;
        }

        public static List<Musteriler> MusterileriListele() //Tüm müşterileri liste türünde
        {
            using (SuOtomasyonEntities s = new SuOtomasyonEntities())
            {
                List<Musteriler> m = new List<Musteriler>();
                var ff = s.Musteriler.ToList();
                foreach (var item in ff)
                {
                    Musteriler musteri = new Musteriler();
                    musteri.MusteriID = item.MusteriID;
                    musteri.MusteriAdi = item.MusteriAdi;
                    musteri.MusteriSoyadi = item.MusteriSoyadi;
                    musteri.MusteriTelefon = item.MusteriTelefon;
                    musteri.MusteriAdres = item.MusteriAdres;
                    musteri.Siparisler = item.Siparisler;

                    m.Add(musteri);
                }
                return m;
            }
        }

        public static (List<ModelMusteriler>, bool) MusteriBul(string ad, string soyad) //Müşteri Adı ve Soyadına Göre Arama Yapıyor
        {
            using (SuOtomasyonEntities s = new SuOtomasyonEntities())
            {
                bool kontrol = false;
                List<ModelMusteriler> mm = new List<ModelMusteriler>();
                var ff = s.Musteriler.Where(x => x.MusteriAdi == ad && x.MusteriSoyadi == soyad).ToList();
                var ss = MusterilerConvert(ff);
                if (ss.Count > 0)
                {
                    kontrol = true;
                }
                else
                {
                    kontrol = false;
                }
                return (ss, kontrol);
            }
        }

        public static ModelMusteriler MusteriEkleModele(string ad, string soyad, string tel, string adres) //Muşteriyi Model Classına gönderiyor.
        {
            ModelMusteriler m = new ModelMusteriler();
            m.MusteriAdi = ad;
            m.MusteriSoyadi = soyad;
            m.MusteriTelefon = tel;
            m.MusteriAdres = adres;
            return m;
        }

        public static bool MusteriEkleVeriye(ModelMusteriler mm) //Musteriyi Veri Tabanına Ekleme İşi gerçekleşiyor.
        {
            var ff = ModelMusteriConvert(mm);
            using (SuOtomasyonEntities s = new SuOtomasyonEntities())
            {
                s.Musteriler.Add(ff);
                if (s.SaveChanges() > 0)
                { 
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public static void MusteriGuncelle(int id, string ad, string soyad, string tel, string adres) //müşteri Güncelle
        {
            using (SuOtomasyonEntities s = new SuOtomasyonEntities())
            {
                var ff = s.Musteriler.Find(id);
                ff.MusteriAdi = ad;
                ff.MusteriSoyadi = soyad;
                ff.MusteriTelefon = tel;
                ff.MusteriAdres = adres;
                s.SaveChanges();
            }
        }

        public static void MusteriSi(ModelMusteriler m) //Müşterileri datagrid den gelen bilgilere göre siliyor.
        {
            using (SuOtomasyonEntities s = new SuOtomasyonEntities())
            {
                var ff = ModelMusteriConvert(m);
                var id = s.Musteriler.Find(ff.MusteriID);
                s.Musteriler.Remove(id);
                s.SaveChanges();
            }
        }

        public static ModelMusteriler IdyeGoreModelMusteri(int id)
        {
            using (SuOtomasyonEntities soe=new SuOtomasyonEntities())
            {
                var ff = soe.Musteriler.Find(id);
                var gg = MusteriConvert(ff);
                return gg;
            }
        }


        //MUSTERİ İŞLEMLERİ BİTİŞ**************************************






        //SİPARİŞ İŞLEMLERİ BAŞLANGIÇ***********************************
        public static List<ModelSiparisler> SiparisListele()  //Siparişleri Listeliyor.
        {
            using (SuOtomasyonEntities s = new SuOtomasyonEntities())
            {
                var siparisList = s.Siparisler.ToList();
                List<ModelSiparisler> ms = new List<ModelSiparisler>();
                foreach (var item in siparisList)
                {
                    var ff = ModelSiparisConvert(item);
                    ms.Add(ff);
                }
                return ms;
            }
        }

        public static List<Siparisler> SiparisListesiVer()
        {
            using (SuOtomasyonEntities soe=new SuOtomasyonEntities())
            {
                var ff = soe.Siparisler.ToList();
                return ff;
            }
        }

        public static bool SiparisEkle(ModelSiparisler ms)
        {
            var ff = SiparisConvert(ms);
            using (SuOtomasyonEntities s = new SuOtomasyonEntities())
            {
                s.Siparisler.Add(ff);
                if (s.SaveChanges()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        } //Veri tbnına siparişi ekliyor.

        public static void SiparisSil(ModelSiparisler ms) //Seçili Siparişi Silmek için.
        {
            using (SuOtomasyonEntities s=new SuOtomasyonEntities())
            {
                var ff = SiparisConvert(ms);
                var id = s.Siparisler.Find(ff.SiparisID);
                s.Siparisler.Remove(id);
                s.SaveChanges();
            }
        }

        public static List<ModelSiparisler> ModelSiparislerListesi(List<Siparisler> s)
        {
            List<ModelSiparisler> ms = new List<ModelSiparisler>();
            foreach (var item in s)
            {
                var ff = ModelSiparisConvert(item);
                ms.Add(ff);
            }
            return ms;
        } 

        public static List<Siparisler> SiparislerListesi(List<ModelSiparisler> lms)
        {
            List<Siparisler> ls = new List<Siparisler>();
            foreach (var item in lms)
            {
                var ff = SiparisConvert(item);
                ls.Add(ff);
            }
            return ls;
        }

        public static void TumSiparislerSil(List<Siparisler> ls)
        {
            using (SuOtomasyonEntities s=new SuOtomasyonEntities())
            {
                foreach (var item in ls)
                {
                    var id = item.SiparisID;
                    var gg = s.Siparisler.Find(id);
                    s.Siparisler.Remove(gg);
                }
                s.SaveChanges();
            }
        } //Tüm siparişleri siliyor.


        public static void SiparisDurumuDegistir(int id,int DurumTip) //DurumTip = SiparisOnaydaki durumların intine göre gelecek.
        {
            using (SuOtomasyonEntities soe=new SuOtomasyonEntities())
            {
                if (DurumTip == 2) //DurumTip--->   SiparisOnay 2=Yeni Çıktı
                {
                    var ff = soe.Siparisler.Find(id);
                    ff.SiparisDurum = Enums.SiparisOnay.YeniCikti.ToString();
                    soe.SaveChanges();
                }
                else if (DurumTip == 3) //SiparisOnay 3=TeslimEdildi 
                {
                    var ff = soe.Siparisler.Find(id);
                    ff.SiparisDurum = Enums.SiparisOnay.TeslimEdildi.ToString();
                    soe.SaveChanges();
                }
            }
        }

        //SİPARİŞ İŞLEMLERİ BİTİŞ****************************************
    }

}
