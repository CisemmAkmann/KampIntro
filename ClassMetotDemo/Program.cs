using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAd = "Çisem";
            musteri1.MusteriId = "1111111";
            musteri1.MusteriSoyad = "Akman";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAd = "Ece";
            musteri2.MusteriId = "2222222";
            musteri2.MusteriSoyad = "Akgül";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            Console.WriteLine("*****************");
            musteriManager.MusteriEkle(musteri2);
            Console.WriteLine("*****************");
            Console.WriteLine("Müşteri Listesi: ");

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad);
            }




            Console.WriteLine("*****************");

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);

            Console.WriteLine("*****************");

            Console.WriteLine("Müşteri Listesi: ");
            Console.WriteLine("Hiçbir müşteriniz bulunmamaktadır.");
        }
    }
}
