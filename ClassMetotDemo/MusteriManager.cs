using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi :" + musteri.Name);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi :" + musteri.Name);

        }

        public void Update (Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri Güncellendi  :" + musteri.Name + musteri.Id);

        }

        public void Listing (Musteri musteri)
        {
            Console.WriteLine("Müşteriler Listelendi  :" + musteri.Name);
        }
    }
}
