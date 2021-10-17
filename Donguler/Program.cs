using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            // array = dizi

            string[] kurslar = new string[] {"Kamp","Java","Temel Kurs","Python"} ;

            for (int i =0 ; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
