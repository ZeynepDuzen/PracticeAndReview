using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = SayilariIste(SayiAdediIste());
            SayilariYazdir(numbers);


            Console.Read();
        }

        static int SayiAdediIste()
        {
            Console.WriteLine("Sayi adedi girin : ");
            int sayiAdedi = Convert.ToInt32(Console.ReadLine());
            return sayiAdedi;
        }

        static int[] SayilariIste(int sayiAdedi)
        {
            int[] sayilar = new int[sayiAdedi];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(i+1+" .sayiyi girin : ");
            }
            return sayilar;
        }

        static void SayilariYazdir(int[] paramDizi)
        {
            for (int i = 0; i < paramDizi.Length; i++)
            {
                Console.WriteLine(i+1+" .sayi : " + paramDizi[i]);
            }
        }
    }
}
