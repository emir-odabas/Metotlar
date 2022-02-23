using ClassIntro;
using System;

namespace CampIntro
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Emir a";
            kurs1.KursAdi = "C#";
            kurs1.İzlenmeOranı = 5;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Emir b";
            kurs2.KursAdi = "Java";
            kurs2.İzlenmeOranı = 6;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Emir c";
            kurs3.KursAdi = "Python";
            kurs3.İzlenmeOranı = 7;






            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };



            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs Eğüştmeni:"+kurs.Egitmen+"\n Kurs Adı:"+kurs.KursAdi);
            }




        }
    }
}
