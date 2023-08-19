using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    internal class SayiIslemleri
    {

        public int SayiAl()
        {
            Console.WriteLine("Sayi girin : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int SayilariTopla(int sayi1,int sayi2,int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        public int SayilariCarp(int sayi1,int sayi2,int sayi3)
        {
            return sayi1 * sayi2 * sayi3;
        }


    }
}
