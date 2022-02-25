using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();

            List<string> adlar = new List<string>() { "emir", "ali", "veli", "deli" };

            foreach (var ad in adlar)
            {
                Console.WriteLine(ad.Length);
            }
            



            /*
            isimler.Add("Engin");

            Console.WriteLine(isimler.Length);

            isimler.Add("Emir");

            Console.WriteLine(isimler.Length);
            
            isimler.Add("Kerem");

            Console.WriteLine(isimler.Length);  // sayısal degerlerını gormek ıcın 

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim); // metinsel degerleri gormek ıcın
            }
            */
            
        }
    }
}
