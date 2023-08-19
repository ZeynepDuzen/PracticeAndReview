using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanicidan alinan 3 adet sayiyi toplayan ve carpan kod blogunu class yapısı ile olusturun

            SayiIslemleri sayiIslemleri = new SayiIslemleri();
            int sayi1 = sayiIslemleri.SayiAl();
            int sayi2 = sayiIslemleri.SayiAl();
            int sayi3 = sayiIslemleri.SayiAl();
            int topla = sayiIslemleri.SayilariTopla(sayi1,sayi2,sayi3);
            int carp = sayiIslemleri.SayilariCarp(sayi1,sayi2,sayi3);

            Console.WriteLine("Uc sayinin toplami : " + topla);
            Console.WriteLine("Uc sayinin carpimi : " + carp);


            Console.Read(); 
        }
    }
}
