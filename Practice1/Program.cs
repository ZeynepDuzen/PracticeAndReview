using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* kullanicidan sayi adeti al,
               kullanicidan sayilari al ve
               bu sayilari listele
             */

            int[] numbers = SayilariAl(SayiAdetiAl());
            SayilariListele(numbers);


            Console.Read();
        }

        static int SayiAdetiAl()
        {
            Console.WriteLine("Lutfen sayi adeti girin : ");
            int sayiAdeti = Convert.ToInt32(Console.ReadLine());
            return sayiAdeti;
        }

        static int[] SayilariAl(int sayiAdeti)
        {
            int[] sayilar = new int[sayiAdeti];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(i+1+" .sayiyi girin : ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            return sayilar;
        }

        static void SayilariListele(int[] paramDizi)
        {
            for (int i = 0; i < paramDizi.Length; i++)
            {
                Console.WriteLine(i+1+" .sayi : " + paramDizi[i]);
            }
        }
    }
}
