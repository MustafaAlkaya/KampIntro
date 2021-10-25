using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();

            
            IKrediManager tasıtKrediManager = new TasıtKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ıhtiyacKrediManager, new DataBaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager , tasıtKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
