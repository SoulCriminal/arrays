using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama yoları;
            //1.
            string [] dizi1 = {"1","2","3"};//3 elemanlı değer atamalı dizi
            string [] dizi2 = new string[3]; // değer atanmamış eleman sayısı belli dizi tanımı
            string [] dizi3; // eleman sayısı ve değer tanımı yapılamış dizi
            dizi3 = new string [3];// tukarıdaki eleman sayısı tanımsız dizimize eleman sayısı tanımladık
            dizi3 [0] = "4";// eleman sayısı tanımladığımız dizimize 0. index değerini atadık.

            // ekrana yazdırma
            Console.WriteLine(dizi3[0]);// dizi3 isimli dizinin 0. elemanını ekrana yazdırma


            // Klavyeden girilen sayıların ortalamasını alan algoritma yazalım
            Console.Write("Lütfen oluşturulacak dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int [] sayiDizisi = new int [diziUzunlugu];

            // kullanıcıdan dizi uzunluğu kadar sayı girmesini ve bu sayıları for döngüsünde diziye atamasını sağlıyoruz
            for (int i =0; i < diziUzunlugu; i++){
                Console.Write("lütfen {0}. sayıyı giriniz: ", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());


            }
            // for döngüsünde oluşturduğumuz diziyi foreach döngüsünde topluyoruz
            int toplam = 0;
            foreach(var sayi in sayiDizisi){
                toplam += sayi;
                
            }
            // aldığımız toplam değeri ve dizi uzunluğunu ortalama almakta kullanıp ekrana yazdırıyoruz.
            Console.WriteLine("Ortalama: "+toplam/diziUzunlugu);

    
        }
    }
}
