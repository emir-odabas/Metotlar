using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi"+product.Name);
        }

        public void Add2(string productName,string productComment,double Price,int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi:" +" " + productName+" "+productComment+" "+Price);
        }


    }
}
