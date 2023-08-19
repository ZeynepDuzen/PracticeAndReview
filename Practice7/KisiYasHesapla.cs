using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7
{
    internal class KisiYasHesapla
    {

        public DateTime DogumYiliIste()
        {
            Console.WriteLine("Dogum yilinizi girin : gg/aa/yyyy");
            return Convert.ToDateTime(Console.ReadLine());
        }

        public int YasHesapla(DateTime girilenYil)
        {
            return DateTime.Now.Year - girilenYil.Year;
        }


    }
}
