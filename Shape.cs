using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GroupWorks
{
    internal class Shape
    {
        //Çizdirme
        public virtual void draw()
        {
            Console.WriteLine("Bir şekil Çiz.");
        }

        //Alan hesapla
        public virtual void alanHesapla()
        {
            Console.WriteLine("Alan verisi yok.");

        }

        public virtual void cevreHesapla()
        {
            Console.WriteLine("Çevre verisi yok.");
        }
    }

    //Dikdörtgen
    class dikdortgen:Shape
    {
        double uzunKenar;
        double kisaKenar;

        public override void draw()
        {
            Console.WriteLine("Dikdörtgen Hesabı için gerekli bilgileri giriniz.");

            Console.Write("Uzun Kenar Giriniz: ");
             uzunKenar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kısa Kenar Giriniz: ");
             kisaKenar = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < kisaKenar; i++)
            {
                for (int j = 0; j <= uzunKenar; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Dikdörtgen Çizildi.");
            Console.WriteLine("-------------------");

        }

        public override void alanHesapla()
        {
            double uk = Convert.ToDouble(uzunKenar);
            double kk = Convert.ToDouble(kisaKenar);
            double sonuc = uk * kk;
            Console.WriteLine("Dikdörtgen Alan Hesab Sonucu: " + sonuc);
            Console.WriteLine("Dikdörtgen Alanı Hesaplandı");
            Console.WriteLine("---------------------------");

        }


        public override void cevreHesapla()
        {
            Console.WriteLine("Dikdörtgen Çevre Hesabı: ");
            double uk = Convert.ToDouble(uzunKenar);
            double kk = Convert.ToDouble(kisaKenar);
            double sonuc = 2 * (uk + kk);
            Console.WriteLine("Dikdörtgen Çevre Hesab Sonucu: " + sonuc);
            Console.WriteLine("Dikdörtgen Çevre Hesaplandı");
            Console.WriteLine("---------------------------");

        }

    }

    //Uçgen

    class triangle:Shape
    {
        double yukseklik;
        double taban;

        public override void draw()
        {
            Console.WriteLine("Dik Üçgen Hesabı için gerekli bilgileri giriniz.");

            Console.Write("Yükseklik Giriniz: ");
            yukseklik = Convert.ToDouble(Console.ReadLine());
            Console.Write("Taban Giriniz: ");
            taban = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i <= yukseklik; i++) //satır
            {
                int deger = Convert.ToInt32(Math.Floor(i/(yukseklik / taban)));
                
                for (int j = 0; j < deger; j++) //sütun j <= i şeklinde de yazılabilir
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Üçgen Çizildi.");
            Console.WriteLine("--------------");

        }

        public override void alanHesapla()
        {
            double h = Convert.ToDouble(yukseklik);
            double t = Convert.ToDouble(taban);
            double sonuc = (h * t)/2;
            Console.WriteLine("Dik Üçgen Alan Hesab Sonucu: " + sonuc);
            Console.WriteLine("Dik Üçgen Alanı Hesaplandı");
            Console.WriteLine("--------------------------");

        }

        public override void cevreHesapla()
        {
            Console.WriteLine("Dik Üçgenin Alan Hesabı: " 
                + ((yukseklik + taban+Math.Sqrt(Math.Pow(yukseklik, 2)+ Math.Pow(taban, 2)))));

        }

    }




}
