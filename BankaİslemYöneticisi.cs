using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaYönetim
{
    public class BankaİslemYöneticisi
    {
        public void ParaYatirma(Musteri musteri,double miktar)
        {
            musteri.BAKİYE += miktar;
            Console.WriteLine($"{miktar} Tl tutarında yatırma işlemi gerçekleşti.Yeni bakiyeniz:{musteri.BAKİYE}Tl");

        }
        public void ParaCekme(Musteri musteri,double miktar)
        {
            if(miktar <= musteri.BAKİYE)
            {
                musteri.BAKİYE -= miktar;
                Console.WriteLine($"{miktar}Tl çekilmiştir.Yeni bakiyeniz:{musteri.BAKİYE}");

            }
            else
            {
                Console.WriteLine("Bakiyeniz yetersizdir,lütfen tekrar deneyiniz.");
            }

        }
        public void KrediKartiTalebi(Musteri musteri)
        {
            if (!musteri.KrediKartiVarMi)
            {
                Console.Write("Kredi kartı ister misiniz? (evet/hayır): ");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() == "evet")
                {
                    Console.WriteLine("Kredi kartınız gönderiliyor.");
                    Console.WriteLine("Kredi Kartı Limitiniz:10.000TL");
                    Console.WriteLine("Aylık faiziniz:%2");
                    musteri.KrediKartiVarMi = true;
                }
            }
            else
            {
                Console.WriteLine("Zaten bir kredi kartınız bulunmaktadır.");
            }
        }

        public void KrediTalep(Musteri musteri)
        {
            Console.Write("Kredi talebiniz için teşekkür ederiz. Kredi teklifi için onay veriyor musunuz? (evet/hayır): ");
            string onay = Console.ReadLine();
            if (onay.ToLower() == "evet")
            {
                double maksimumKredi = musteri.BAKİYE / 2;
                Console.WriteLine($"Maksimum kredi tutarı: {maksimumKredi} TL");
                Console.Write("Kaç taksitte ödemek istersiniz? (1-5): ");
                int taksitSayisi = int.Parse(Console.ReadLine());
                if (taksitSayisi > 5)
                {
                    Console.WriteLine("Taksit sayısı 5'i geçemez.");
                    return;
                }
                double krediTutari = maksimumKredi / taksitSayisi;
                Console.WriteLine($"Kredi teklifi: {krediTutari} TL x {taksitSayisi} taksit");
            }
            else
            {
                Console.WriteLine("Kredi talebiniz reddedildi.");
            }

        }
    }

}
