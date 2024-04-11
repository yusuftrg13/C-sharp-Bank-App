using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaYönetim
{
    public class Musteri : BankaİslemYöneticisi
    {
        // Müşteri özellikleri
        private string ad;
        private string soyad;
        private int yas;
        private string meslek;
        private DateTime hesapAcilisTarihi;
        private double bakiye;
        private bool krediKartiVarMi;
        private bool aktifKrediVarMi;
        private string isBilgisi;
        private bool tasarrufHesabiVarMi;
        
        // Ad özelliğinin özellikleri
        public string AD
        {
            get { return ad; }
            set { ad = value; }
        }

        // Soyad özelliğinin özellikleri
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value; }
        }

        // Yaş özelliğinin özellikleri
        public int YAS
        {
            get { return yas; }
            set { yas = value; }
        }

        // Meslek özelliğinin özellikleri
        public string MESLEK
        {
            get { return meslek; }
            set { meslek = value; }
        }

        // Hesap Açılış Tarihi özelliğinin özellikleri
        public DateTime HesapAcilisTarihi
        {
            get { return hesapAcilisTarihi; }
            set { hesapAcilisTarihi = value; }
        }

        // Bakiye özelliğinin özellikleri
        public double BAKİYE
        {
            get { return bakiye; }
            set { bakiye = value; }
        }

        // Kredi Kartı Var Mı özelliğinin özellikleri
        public bool KrediKartiVarMi
        {
            get { return krediKartiVarMi; }
            set { krediKartiVarMi = value; }
        }

        // Aktif Kredi Var Mı özelliğinin özellikleri
        public bool AktifKrediVarMi
        {
            get { return aktifKrediVarMi; }
            set { aktifKrediVarMi = value; }
        }

        // İş Bilgisi özelliğinin özellikleri
        public string IsBilgisi
        {
            get { return isBilgisi; }
            set { isBilgisi = value; }
        }

        // Tasarruf Hesabı Var Mı özelliğinin özellikleri
        public bool TasarrufHesabiVarMi
        {
            get { return tasarrufHesabiVarMi; }
            set { tasarrufHesabiVarMi = value; }
        }
        //Bireysel Emeklilik Var Mı Özelliğinini Özelliği
    }




}
