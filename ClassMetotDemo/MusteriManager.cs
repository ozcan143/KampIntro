using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
     class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla eklendi"+ musteri.Adi);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla silindi"+musteri.Adi);
        }

        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi : "+ musteri.Adi+ " "+ musteri.Soyadi +" " + musteri.Yas);
        }
    }
}
