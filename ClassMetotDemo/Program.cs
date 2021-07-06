using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Yasemin";
            musteri1.Surname = "Sucu";
            musteri1.Id = 1234;
            musteri1.Job = "Computer Engineer";

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Melek";
            musteri2.Surname = "Sucu";
            musteri2.Id = 1235;
            musteri2.Job = "anesthesia technician";

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Simge";
            musteri3.Surname = "Kılıç";
            musteri3.Id = 1236;
            musteri3.Job = "psychological counselor ";

            Musteri[] musteriler = new Musteri[] { musteri1 , musteri2, musteri3 };


            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Name);
                Console.WriteLine(musteri.Surname);
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Job);
                Console.WriteLine("***************************");

            };


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri1);
            musteriManager.Listing(musteri1);
            musteriManager.Update(musteri1);

            Console.WriteLine("********************************");

            musteriManager.Add(musteri2);
            musteriManager.Delete(musteri2);
            musteriManager.Listing(musteri2);
            musteriManager.Update(musteri2);

            Console.WriteLine("********************************");


            musteriManager.Add(musteri3);
            musteriManager.Delete(musteri3);
            musteriManager.Listing(musteri3);
            musteriManager.Update(musteri3);
        }
    }
}
