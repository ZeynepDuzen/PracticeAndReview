using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* kullanicidan alinan ad ve soyadi arasinda bosluk olacak sekilde consola yazdiran yapiyi 
               KisiTanim adli bir class ile olusturun

               kullanicidan alinan dogum tarihine gore yas hesaplayan kod yapisini consola yazdiran
               KisiYaasHesapla adli bir class ile olusturun
             */

            KisTanim kisTanim = new KisTanim();
            string isim = kisTanim.IsimAl();
            string soyIsim = kisTanim.SoyIsimAl();

            Console.WriteLine("Isim : " + isim + "\n" + "Soyisim : " + soyIsim);



            KisiYasHesapla kisiYasHesapla = new KisiYasHesapla();

            Console.WriteLine(kisiYasHesapla.YasHesapla(kisiYasHesapla.DogumYiliIste()));
            
            
            


            Console.Read();
        }
    }
}
