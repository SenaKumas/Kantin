namespace Kantin
{
    internal class Program
    {
        static void MenuGoster()
        {
            Console.WriteLine("1 - Tost (30 TL)");
            Console.WriteLine("2 - Ayran (10 TL)");
            Console.WriteLine("3 - Çay (5 TL)");
        }

        static int SecimAl()
        {
            Console.WriteLine("Seçiminizi yapın (1, 2 veya 3): ");
            string secim = Console.ReadLine();
            
            while (true)
            {
                if (secim != "1" && secim != "2" && secim != "3")
                {
                    Console.WriteLine("Yanlış giriş yaptınız. Tekrar deneyin...");
                    secim = Console.ReadLine();
                }
                return int.Parse(secim);
            }
            
        }

        static int AdetAl()
        {
            Console.WriteLine("Kaç adet istiyorsunuz?...");
            int adet = int.Parse(Console.ReadLine());
            
            while (true)
            {
                if (adet <= 0)
                {
                    Console.WriteLine("Geçersiz giriş.Tekrar deneyiniz...");
                    adet = int.Parse(Console.ReadLine());
                }
                return adet;

            }
        }

        static int FiyatGetir(int urunkodu)
        { 
           if(urunkodu == 1)
                return 30;

            else if (urunkodu == 2)
                return 10;

            else if (urunkodu == 3)
                return 5;

           else 
                return 0;

        }

        static int SatirTutariHesapla(int adet, int birimfiyat)
        { 
          return adet * birimfiyat;
        }

        static bool IndirimHakkiVArMi(int toplamTutar)
        {
            if (toplamTutar > 100)
                return true;
            else
                return false;
        }

        static int IndirimliTutarHesapla(int toplamTutar)
        {

            if (toplamTutar > 100)
            { 
              int fiyat = toplamTutar - (toplamTutar * 10 / 100);
            }
            return toplamTutar;
        }

        static void Main(string[] args)
        {
           MenuGoster();
            Console.WriteLine("--------------");
           int secim = SecimAl();
            Console.WriteLine("--------------");
           int adet = AdetAl();
            Console.WriteLine("--------------");
           int birimfiyat = FiyatGetir(secim);
            Console.WriteLine("Birim fiyat: " + birimfiyat);
            Console.WriteLine("--------------");
            int satirtutari = SatirTutariHesapla(adet, birimfiyat);
            Console.WriteLine("Satır tutarı: " + satirtutari);
            Console.WriteLine("--------------");
            bool indirimhakkivarmi = IndirimHakkiVArMi(satirtutari);
            if (indirimhakkivarmi)
            {
                int indirimlitutar = IndirimliTutarHesapla(satirtutari);
                Console.WriteLine("İndirim hakkı var. İndirimli tutar: " + indirimlitutar);
            }
            else 
            {
                Console.WriteLine("İndirim yok. Son tutar: " + satirtutari + "TL");
            }
            Console.WriteLine("--------------");



        }
    }
}
