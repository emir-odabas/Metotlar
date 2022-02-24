using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {

        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        //tempArray = geciciArray
        public void Add(T item)
        {
            T[] tempArray = items;  // geçici olarak itemleri tutuyor
            items = new T[items.Length + 1];  //dizinin eleman sayısını 1 arttırdık

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; // aslında eklenmek istenen eleman şimdi eklendi
        }

        public int Length
        {
            get { return items.Length; }  //sayısal değerlerini görmek için 
        }

        public T[] Items
        {
            get { return items; } //eleman isimlerinide gormek içins
        }

    }
}
