using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //kullanicidan alinan sayilari toplayan yapiyi SayiIslemleri adli bir class ile olusturun

            SayiIslemleri sayiIslemleri = new SayiIslemleri();

            //int sayi = sayiIslemleri.SayiIste();
            List<int> sayilar = sayiIslemleri.SayiDevamMi();
            int toplam = sayiIslemleri.SayilariTopla(sayilar);

            Console.WriteLine("Girilen sayilarin toplami : " + toplam);
            

            Console.Read();
        }
    }
}
