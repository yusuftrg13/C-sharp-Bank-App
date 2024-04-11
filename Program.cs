// Müşteri oluşturma ve özelliklerini belirleme
using BankaYönetim;

Musteri musteri=new Musteri();
musteri.AD = "Kemal";
musteri.SOYAD = "Türk";
musteri.YAS = 28;
musteri.MESLEK = "Doktor";
musteri.HesapAcilisTarihi = DateTime.Now;
musteri.BAKİYE = 200000;
musteri.KrediKartiVarMi = false;
musteri.AktifKrediVarMi=false;
musteri.IsBilgisi = "Özel Sektör-Doktor";
musteri.TasarrufHesabiVarMi = true;

BankaİslemYöneticisi bankaislem=new BankaİslemYöneticisi();
MevduatHesabı mevduat = new MevduatHesabı();

while (true)
{
    Console.WriteLine("Banka İşlem Yöneticisi");
    Console.WriteLine("1. Para Çekme");
    Console.WriteLine("2. Para Yatırma");
    Console.WriteLine("3. Kredi Kartı Talebi");
    Console.WriteLine("4. Kredi Talebi");
    Console.WriteLine("5. Mevduat Hesabına Para Aktarma");
    Console.WriteLine("6. Fon Hesabına Para Aktarma");
    Console.WriteLine("7. Mevduat Hesabına Para Yatırma");
    Console.WriteLine("8. Mevduat Hesabından Para Çekme");
    Console.WriteLine("9. Çıkış");
    Console.Write("Seçiminizi yapın: ");
    string secim = Console.ReadLine();

    switch (secim)
    {
        case "1":
            Console.Write("Çekilecek miktarı girin: ");
            double cekilecekMiktar = double.Parse(Console.ReadLine());
            bankaislem.ParaCekme(musteri, cekilecekMiktar);
            break;
        case "2":
            Console.Write("Yatırılacak miktarı girin: ");
            double yatirilacakMiktar = double.Parse(Console.ReadLine());
            bankaislem.ParaYatirma(musteri, yatirilacakMiktar);
            break;
        case "3":
            bankaislem.KrediKartiTalebi(musteri);
            break;
        case "4":
            bankaislem.KrediTalep(musteri);
            break;
        case "5":
            Console.Write("Mevduat hesabına aktarılacak miktarı girin: ");
            double mevduataAktarilacakMiktar = double.Parse(Console.ReadLine());
            mevduat.MevduatHesabinaParaAktar(musteri, mevduataAktarilacakMiktar);
            break;
        case "6":
            Console.Write("Fon hesabına aktarılacak miktarı girin: ");
            double fonaAktarilacakMiktar = double.Parse(Console.ReadLine());
            mevduat.FonHesabinaParaAktar(musteri, fonaAktarilacakMiktar);
            break;
        case "7":
            Console.Write("Mevduat hesabına yatırılacak miktarı girin: ");
            double mevduataYatirilacakMiktar = double.Parse(Console.ReadLine());
            mevduat.MevduatHesabinaParaYatir(mevduataYatirilacakMiktar);
            break;
        case "8":
            Console.Write("Mevduat hesabından çekilecek miktarı girin: ");
            double mevduattanCekilecekMiktar = double.Parse(Console.ReadLine());
            mevduat.MevduatHesabindanParaCek(mevduattanCekilecekMiktar);
            break;
        case "9":
            Console.WriteLine("Çıkış yapılıyor...");
            return;
        default:
            Console.WriteLine("Geçersiz seçim.");
            break;
    }

    Console.WriteLine();
}
 
