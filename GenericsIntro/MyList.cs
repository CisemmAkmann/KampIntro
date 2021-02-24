using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // generic class
    {
        T[] items;
        //constructor -- default olarak çalışır.
        public MyList()
        {
            items = new T[0]; // 0 elemanlı bir array oluşturdu ve buna bir adres tutturdu.
        }
        public void Add(T item)
        {
            T[] tempArray = items; // geçici referans tutucu array -- önceki değerleri korumak için 

            items = new T[items.Length+1]; // array sayısını arttıramadığımız için yeni bir eleman eklemek istediğimizde yeni bir 
            //adreste yeni bir dizi oluştu.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //eklenmek istenen eleman burada eklendi.
        }
    }
}
