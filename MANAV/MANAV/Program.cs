using System;

namespace MANAV
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim;
            int kilo;
            int tutar;
            Console.WriteLine("ELMA => 1");
            Console.WriteLine("KİRAZ => 2");
            Console.WriteLine("ARMUT => 3");
            Console.WriteLine("ÇİLEK => 4");
            Console.WriteLine("BİR MEYVE SEÇİNİZ");
            secim = int.Parse(Console.ReadLine());
            if (secim == 1)
            {
                Console.WriteLine("KİLO MİKTARI GİRİNİZ");
                kilo = int.Parse(Console.ReadLine());
                tutar = kilo * 5;
                Console.Write("{0} KİLO ELMA ALDINIZ. ÖDENECEK TUTAR {1} TL", tutar);
            }
            else if (secim == 2)
            {
                Console.WriteLine("KİLO MİKTARI GİRİNİZ");
                kilo = int.Parse(Console.ReadLine());
                tutar = kilo * 12;
                Console.Write("{0} KİLO KİRAZ ALDINIZ. ÖDENECEK TUTAR {1} TL", kilo, tutar);
            }
            else if (secim == 3)
            {
                Console.WriteLine("KİLO MİKTARI GİRİNİZ");
                kilo = int.Parse(Console.ReadLine());
                tutar = kilo * 7;
                Console.Write("{0} KİLO ARMUT ALDINIZ. ÖDENECEK TUTAR {1} TL", kilo, tutar);
            }
            else if (secim == 4)
            {
                Console.WriteLine("KİLO MİKTARI GİRİNİZ");
                kilo = int.Parse(Console.ReadLine());
                tutar = kilo * 15;
                Console.Write("{0} KİLO ÇİLEK ALDINIZ. ÖDENECEK TUTAR {1} TL", kilo, tutar);
            }
            else
            {
                Console.Write("GEÇERSİZ SAYI GİRDİNİZ !!");
            }
        }
    }
}
