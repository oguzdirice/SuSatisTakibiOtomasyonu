using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuOtomasyon.Model
{
    public class ModelSiparisler
    {
        public int SiparisID { get; set; }
        public Nullable<int> SiparisTutar { get; set; }

        private string _siparisDurum;
        public string SiparisDurum
        {
            get { return _siparisDurum; }
            set
            {
                _siparisDurum = value;
            }
        }

        private DateTime _siparisTarih;
        public Nullable<System.DateTime> SiparisTarih
        {
            get { return _siparisTarih; }
            set
            {
                _siparisTarih = Convert.ToDateTime(value);
            }
        }

        public ModelMusteriler m = new ModelMusteriler();

    }
    
}
