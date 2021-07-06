using MusteriTanım.Model;
using System;
using System.Collections.Generic;

namespace MusteriTanım
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager help = new MusteriManager();
            var model1 = new Musteri()
            {
                Ad = "MEHMET",
                Soyad = "SUCU",
                Id = 9


            };
            var model2 = new Musteri()
            {
                Ad = "DİLEK",
                Soyad = "SUCU",
                Id = 8

            };
            
            var model3 = new Musteri()
            {
                Ad = "YASEMİN",
                Soyad = "SUCU",
                Id = 5

            };






            help.Ekle(model1);
            help.Ekle(model2);
            help.Ekle(model3);



        }
    }
}
