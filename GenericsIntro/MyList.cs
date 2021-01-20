using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList <T>   //T yerine a yazabilirdin. Verdiğin tipe karşılık geliyor.
    {
        T[] items;

        //constructor
        public MyList() //ctor yaz tab tab
        {
            items = new T[0]; //elimde dizim var artık 0 elemanlı
        }
        public void Add(T item) //item eleman demek
        {
            T[] tempArray = items // geçici dizi, elemanları tutuyor. Geçici olarak tutuyor.
            items = new T[items.Length + 1]; // dizimin eleman sayısını 1 arttırıyorum. new dediğin anda eski referans numaraları uçar.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // burada items eski değerlerine kavuştu.
            }

            items[items.Length - 1] = item // aslında eklenmek istenilen elemanı şu an eklenebilir.
        } 
    }
}
