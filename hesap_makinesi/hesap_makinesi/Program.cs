using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesap_makinesi
{
    using System;

    class HesapMakinesi
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("**** Hesap Makinesi ****");
                Console.WriteLine("1. Toplama");
                Console.WriteLine("2. Çıkarma");
                Console.WriteLine("3. Çarpma");
                Console.WriteLine("4. Bölme");
                Console.WriteLine("5. Üs Alma");
                Console.WriteLine("6. Mod Alma");
                Console.WriteLine("0. Çıkış");

                Console.Write("Yapmak istediğiniz işlemin numarasını girin: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Toplama();
                        break;
                    case "2":
                        Cikarma();
                        break;
                    case "3":
                        Carpma();
                        break;
                    case "4":
                        Bolme();
                        break;
                    case "5":
                        UsAlma();
                        break;
                    case "6":
                        ModAlma();
                        break;
                    case "0":
                        Console.WriteLine("Hesap Makinesi kapatılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız, lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        static void Toplama()
        {
            Console.Write("Toplamak istediğiniz sayıları aralarında boşluk bırakarak girin: ");
            string[] sayilar = Console.ReadLine().Split(' ');
            double toplam = 0;

            foreach (string sayi in sayilar)
            {
                toplam += Convert.ToDouble(sayi);
            }

            Console.WriteLine("Toplam: " + toplam);
        }

        static void Cikarma()
        {
            Console.Write("Çıkarmak istediğiniz sayıları aralarında boşluk bırakarak girin: ");
            string[] sayilar = Console.ReadLine().Split(' ');
            double fark = Convert.ToDouble(sayilar[0]);

            for (int i = 1; i < sayilar.Length; i++)
            {
                fark -= Convert.ToDouble(sayilar[i]);
            }

            Console.WriteLine("Fark: " + fark);
        }

        static void Carpma()
        {
            Console.Write("Çarpmak istediğiniz sayıları aralarında boşluk bırakarak girin: ");
            string[] sayilar = Console.ReadLine().Split(' ');
            double carpim = 1;

            foreach (string sayi in sayilar)
            {
                carpim *= Convert.ToDouble(sayi);
            }

            Console.WriteLine("Çarpım: " + carpim);
        }

        static void Bolme()
        {
            Console.Write("Bölmek istediğiniz sayıları aralarında boşluk bırakarak girin: ");
            string[] sayilar = Console.ReadLine().Split(' ');
            double bolum = Convert.ToDouble(sayilar[0]);

            for (int i = 1; i < sayilar.Length; i++)
            {
                double sayi = Convert.ToDouble(sayilar[i]);
                if (sayi != 0)
                {
                    bolum /= sayi;
                }
                else
                {
                    Console.WriteLine("Hata: Bölen sayı sıfır olamaz!");
                    return;
                }
            }

            Console.WriteLine("Bölüm: " + bolum);
        }

        static void UsAlma()
        {
            Console.Write("Taban ve üs değerlerini girin (örneğin, 2 3): ");
            string[] input = Console.ReadLine().Split(' ');

            double taban = Convert.ToDouble(input[0]);
            double us = Convert.ToDouble(input[1]);

            double sonuc = Math.Pow(taban, us);
            Console.WriteLine("Sonuç: " + sonuc);
        }

        static void ModAlma()
        {
            Console.Write("Mod almak istediğiniz sayıları aralarında boşluk bırakarak girin: ");
            string[] sayilar = Console.ReadLine().Split(' ');

            if (sayilar.Length != 2)
            {
                Console.WriteLine("Hata: Mod almak için iki sayı girmelisiniz!");
                return;
            }

            double modSonuc = Convert.ToDouble(sayilar[0]) % Convert.ToDouble(sayilar[1]);
            Console.WriteLine("Mod: " + modSonuc);
        }
    }

}
