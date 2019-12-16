using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuOtomasyon.Model
{
    public class ModelMusteriler
    {
        public int MusteriID { get; set; }

        private string _musteriAdi;
        public string MusteriAdi
        {
            get { return _musteriAdi; }
            set
            {
                _musteriAdi = value.Trim().ToUpper();
            }
        }

        private string _musteriSoyadi;
        public string MusteriSoyadi
        {
            get { return _musteriSoyadi; }
            set
            {
                _musteriSoyadi = value.Trim().ToUpper();
            }
        }
        public string MusteriTelefon { get; set; }

        private string _musteriAdres;
        public string MusteriAdres
        {
            get { return _musteriAdres; }
            set
            {
                _musteriAdres = value.Trim().ToUpper();
            }
        }
    }
}
