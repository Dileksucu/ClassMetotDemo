using MusteriTanım.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriTanım
{
   public class MusteriManager
    {
        List<Musteri> _list = new List<Musteri>();
        public void Ekle(Musteri model) {

            _list.Add(model);
            Console.WriteLine("başarıyla eklendi.");
        }
        public List<Musteri> Listele()
        {
            return _list;
        }
        public void Sil()
        {
            
        }
    }
}
