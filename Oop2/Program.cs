using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "2333";
            musteri1.Adi = "Mustafa";
            musteri1.Soyadi = "Alkaya";
            musteri1.TcNo = "235145141";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1;
            musteri2.MusteriNo = "232323";
            musteri2.SirketAdi = "Ankazel";
            musteri2.VergiNo = "23123213";

            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);


        }
    }
}
