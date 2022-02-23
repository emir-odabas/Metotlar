using ClassLibrary1;
using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };

            Product product1= new Product();

            product1.Name = "Elma";
            product1.Price = 15;
            product1.Comment = "Amasya elması";

            Product product2 = new Product();

            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Comment = "Diyarbakır karpuzu";


            Product[] products = new Product[] {product1 ,product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Comment);
            }

            Console.WriteLine("-------------METOTLAR-------------");


            //instance-örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut","Yesil armut",12,33);
            sepetManager.Add2("Elma", "Yesil elma", 12,9);
            sepetManager.Add2("Karpuz", "Yesil karpuz", 12,12);

        }
    }
}
