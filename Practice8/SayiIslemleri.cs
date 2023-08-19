using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    internal class SayiIslemleri
    {
        public int SayiIste()
        {
            Console.WriteLine("Sayi girin : \nSayi girisini sonlandirmak icin : 0 ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public List<int> SayiDevamMi()
        {
            int deger = SayiIste();
            List<int> liste = new List<int>();

            while (deger != 0)
            {
                liste.Add(deger);
                deger = SayiIste();
            }
            return liste;
        }

        public int SayilariTopla(List<int> liste)
        {
            int toplam = 0;

            foreach (var eleman in liste)
            {
                toplam += eleman;
            }
            return toplam;

        }

    }
}
