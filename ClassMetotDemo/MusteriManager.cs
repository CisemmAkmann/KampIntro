using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi.");
            Console.WriteLine("Müşteri Bilgileri -->");
            Console.WriteLine("Müşteri Adı-Soyadı: " + musteri.MusteriAd + " " + musteri.MusteriSoyad);
            Console.WriteLine("Müşteri ID : " + musteri.MusteriId);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi!!");
        }
    }
}
