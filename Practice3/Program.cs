using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = PersonelIsimleriIste(PersonelSayisiIste());
            PersonelListesiYazdir(isimler);

            // kullanicidan personel sayisini ve ismlerini isteyen, bunu konsola yazdiran yapi

            Console.Read();
        }

        static int PersonelSayisiIste()
        {
            Console.WriteLine("Personel sayisi girin : ");
            int personelSayisi = Convert.ToInt32(Console.ReadLine());
            return personelSayisi;
        }

        static string[] PersonelIsimleriIste(int personelSayisi)
        {
            string[] personeller = new string[personelSayisi];

            for (int i = 0; i < personeller.Length; i++)
            {
                Console.WriteLine(i+1+" .personelin ismi : ");
                personeller[i] = Console.ReadLine();
            }
            return personeller;
        }

        static void PersonelListesiYazdir(string[] paramDizi)
        {
            for (int i = 0; i < paramDizi.Length; i++)
            {
                Console.WriteLine(i+1+" .personelin adi : " + paramDizi[i]);
            }
        }
    }
}
