using System;
using System.Collections.Generic;

namespace DictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ogrenci1 = new Dictionary<string, int>();
            Console.WriteLine(ogrenci1.Count);
            //ogrenci1.Add("Ayşe", 1);
           // Console.WriteLine(ogrenci1.Count);

            MyDictionary<string, int> ogrenci2 = new MyDictionary<string, int>();
            ogrenci2.Add("Çisem", 1);
            Console.WriteLine(ogrenci2.Count);

            
        }
    }
}
