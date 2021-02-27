using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOdev
{
   
    class MyDictionary<T,A>
    {
        T[] key_items;
        A[] value_items;

        public MyDictionary()
        {
            key_items = new T[0];
            value_items = new A[0];
        }

        public void Add(T item1 , A item2)
        {
            T[] tempArray1 = key_items;
            A[] tempArray2 = value_items;

            key_items = new T[key_items.Length + 1];
            value_items = new A[value_items.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                tempArray1[i] = key_items[i];
            }

            for (int i = 0; i < tempArray2.Length; i++)
            {
                tempArray2[i] = value_items[i];
            }

            key_items[key_items.Length - 1] = item1;
            value_items[value_items.Length - 1] = item2;



        }

       

        public int Count
        {
            get { return value_items.Length; }
           
        }

    }
}
