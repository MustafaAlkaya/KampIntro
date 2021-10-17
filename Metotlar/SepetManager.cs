using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention = Yazma Tekniği
        // encapsulation = Class ile tek işlemde herşeyi değiştir (Ayrı ayrı yapmak yerine)
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);

        }

        
    }
}
