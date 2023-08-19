using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanicidan alinan sayi adeti ve sayilari toplayip konsola yazdiran kod blogu

            int[] sayiListesi = SayilariIste(SayiAdetiIste());
            Topla(sayiListesi);

            Console.Read();
        }

        static int SayiAdetiIste()
        {
            Console.WriteLine("Sayi adeti girin : ");
            int sayiAdeti = Convert.ToInt32(Console.ReadLine());
            return sayiAdeti;
        }

        static int[] SayilariIste(int sayiAdeti)
        {
            int[] sayilar = new int[sayiAdeti];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(i+1+" .sayiyi girin : ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            return sayilar;
        }

        static void Topla(int[] paramDizi)
        {
            int toplam = 0;
            for (int i = 0; i < paramDizi.Length; i++)
            {
                toplam += paramDizi[i];
                
            }
            Console.WriteLine("Toplam : " + toplam);
        }
    }
}
