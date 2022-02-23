using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Array,class,interface = referans tip
            //ref: bir değişkenin işaret ettiği adresi belirtir
            /*out: ref ile aynı işlevi görür tek farkı referansını alacağı değişkene öncesinde değer atanmış olması gerekmez.
            Fakat kullanılan metod içinde minimum bir kez değer atanması gerekir.*/


            Console.WriteLine(Add(1, 2, 3, 4, 5));
            Console.ReadKey();
        }

        // overloadda params key i kullanılabilir

        static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
