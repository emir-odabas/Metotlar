﻿using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {


            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);


            //List arka planda bir array i yonetıyor
            List<string> isimler2 = new List<string>() {"emir","mehmet","ahmet","ali" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);


            //normal arraylerde sonradan ekleme oldugunda yeni bir "heap" acıp yeni eklenen verileri oraya eklıyor ama eskileri kalkıyor iş bunun çözümü olarak
            //koleksiyonlarda degerlerı kaybetmemızı engelleıycek bir altyapı vardır.
        }
    }
}
