using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaYönetim
{
    public class MevduatHesabı
    {
        private double bakiye = 100000; // Başlangıç bakiyesi 1000 TL olsun

        // Mevduat hesabına para aktarma işlemi
        public void MevduatHesabinaParaAktar(Musteri musteri, double miktar)
        {
            if (musteri.BAKİYE >= miktar)
            {
                musteri.BAKİYE -= miktar;
                bakiye += miktar;
                Console.WriteLine($"{miktar} TL mevduat hesabınıza aktarıldı. Mevduat hesabınızın yeni bakiyesi: {bakiye} TL");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!,Lütfen tekrar deneyiniz...");
            }
        }

        // Fon hesabına para aktarma işlemi
        public void FonHesabinaParaAktar(Musteri musteri, double miktar)
        {
            if (musteri.BAKİYE >= miktar)
            {
                musteri.BAKİYE -= miktar;
                double getiri = miktar * 0.20; // Fon getirisi %20
                Console.WriteLine($"{miktar} TL fon hesabınıza aktarılmıştır. Fon hesabınızın yeni bakiyesi: {miktar + getiri} TL (Getiri: {getiri} TL)");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!");
            }
        }

        // Mevduat hesabına para yatırma işlemi
        public void MevduatHesabinaParaYatir(double miktar)
        {
            bakiye += miktar;
            Console.WriteLine($"{miktar} TL mevduat hesabınıza yatırıldı. Mevduat hesabınızın yeni bakiyesi: {bakiye} TL");
        }

        // Mevduat hesabından para çekme işlemi
        public void MevduatHesabindanParaCek(double miktar)
        {
            if (bakiye >= miktar)
            {
                bakiye -= miktar;
                Console.WriteLine($"{miktar} TL mevduat hesabınızdan çekildi. Mevduat hesabınızın yeni bakiyesi: {bakiye} TL");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!");
            }
        }
    }
}

