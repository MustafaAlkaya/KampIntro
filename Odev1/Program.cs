using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.urunAdi = "Bebek Bezi";
            urun1.urunAdet = 12;

            Product urun2 = new Product();
            urun2.urunAdi = "Oyuncak Ayı";
            urun2.urunAdet = 345;

            Product[] urunler = new Product[] { urun1,urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunAdi);
                Console.WriteLine(urun.urunAdet);
            }
        }
    }

    class Product
    {
        public string urunAdi { get; set; }

        public int urunAdet { get; set; }
    }



}
