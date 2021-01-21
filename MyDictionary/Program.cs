using System;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> sayilar = new MyDictionary<string, int>();
            sayilar.Add("sayi1", 1);
            sayilar.Add("sayi2", 2);
            sayilar.Add("sayi3", 3);
            sayilar.Add("sayi4", 4);

            foreach (var key in sayilar.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var value in sayilar.Values)
            {
                Console.WriteLine(value);
            }
           
        }
    }
}
