using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            Console.WriteLine(isimler.Length);

            isimler.Add("Kerem");

            Console.WriteLine(isimler.Length);  // sayısal degerlerını gormek ıcın 

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim); // metinsel degerleri gormek ıcın
            }
        }
    }
}
