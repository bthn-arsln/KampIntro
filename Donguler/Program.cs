using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // array - dizi
            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java",
                "Python"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach(string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
