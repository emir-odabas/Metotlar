using ClassLibrary1;
using System;

namespace Examples1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Basket oyuncu1 = new Basket();
            oyuncu1.Ad = "Emir";
            oyuncu1.Soyad = "Odabas";
            oyuncu1.Boy = 1.83;

            Basket oyuncu2 = new Basket();
            oyuncu2.Ad = "Fikri";
            oyuncu2.Soyad = "Kızıldag";
            oyuncu2.Boy = 1.75;

            Basket oyuncu3 = new Basket();
            oyuncu3.Ad = "Cabir";
            oyuncu3.Soyad = "Guner";
            oyuncu3.Boy = 1.90;

            Basket oyuncu4 = new Basket();
            oyuncu4.Ad = "Ahmet";
            oyuncu4.Soyad = "Kavras";
            oyuncu4.Boy = 1.60;


            Basket player1 = new Basket { Ad = "A", Soyad = "B", Boy = 1.90 };

            Basket player2 = new Basket { Ad = "C", Soyad = "D", Boy = 1.70 };

            Basket player3 = new Basket { Ad = "E", Soyad = "F", Boy = 1.80 };

            Basket player4 = new Basket { Ad = "G", Soyad = "H", Boy = 1.60};


            Basket[] players = new Basket[] {player1,player2,player3,player4 };

            foreach(Basket player in players )
            {
                if (player.Boy<1.80)
                {
                    Console.WriteLine("Ad: " + player.Ad + " Soyad: " + player.Soyad + " Boy: " + player.Boy + " Boy Grubu: UZUN");
                }
                else
                {
                    Console.WriteLine("Ad: " + player.Ad + " Soyad: " + player.Soyad + " Boy: " + player.Boy + " Boy Grubu: KISA");
                }

            }
            */

            /* ÜRÜNLERİ FOR FOREACH VE WHİLE İLE LİSTELEME
            Product teknoloji = new Product();
            Product temizlik = new Product();
            Product dekorasyon = new Product();


            teknoloji.telefon = "Iphone";
            teknoloji.kulaklık = "AirPods";

            temizlik.parfum = "Elle";
            temizlik.sampuan = "Head&Shoulders";

            dekorasyon.halı = "İstikbal";
            dekorasyon.yastık = "EnglishHome";
            dekorasyon.perde = "Perdex";


            string[] products = new string[] { "Iphone", "AirPods", "Elle", "Head&Shoulders", "İstikbal", "EnglishHome", "Perdex" };

            Product[] products1 = new Product[] {teknoloji,temizlik,dekorasyon};

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i]);
            }

            Console.WriteLine("\n**********\n");

            foreach (Product urun in products1)
            {
                Console.WriteLine( urun.telefon+urun.kulaklık+urun.parfum +urun.sampuan+urun.halı + urun.yastık+ urun.perde);
                
            }

            Console.WriteLine("\n**********\n");

            int j = 0;
            while(j<7)
            {
                Console.WriteLine(products[j]);
                j++;
            }
            */


        }
    }
}
