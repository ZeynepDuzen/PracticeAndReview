using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanicidan personel sayisini, isimlerini,yaslarini ve maaslarini alip ekrana yazdirin

            int personelSayisi = PersonelSayisiIste();
            string[] personelIsimleri = PersonelIsimleriIste(personelSayisi);
            int[] yaslar = YasIste(personelIsimleri);
            double[] maaslar = MaasIste(personelIsimleri);
            TumListe(personelIsimleri,yaslar,maaslar);

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
            string[] isimler = new string[personelSayisi];
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(i+1+" . personelin ismini girin");
                isimler[i] = Console.ReadLine();
            }
            return isimler;
        }

        static int[] YasIste(string[] isimler)
        {
            int[] yaslar = new int[isimler.Length];
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(i+1+ " .personelin yasini girin : ");
                yaslar[i] = Convert.ToInt32(Console.ReadLine());
            }
            return yaslar;
        }

        static double[] MaasIste(string[] isimler)
        {
            double[] maaslar = new double[isimler.Length];
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(i+1+" .personelin maasini girin : ");
                maaslar[i] = Convert.ToDouble(Console.ReadLine());
            }
            return maaslar;
        }

        static void TumListe(string[] isimler, int[] yaslar, double[] maaslar)
        {
            Console.WriteLine("adi\tyasi\tmaasi");
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i] + "\t" + yaslar[i] + "\t" + maaslar[i]);
            }
        }
    }
}
