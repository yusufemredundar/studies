﻿using System;//kullanılan kütüphane isim uzayları(namespaces)
using System.Collections.Generic;

namespace ConsoleApp1//geçerli olan projenin isim uzayı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişken tanımlama
            string s1 = "10";
            string s2 = "20";

            //Tür dönüşümü
            int s1Number = Convert.ToInt32(s1); //int.Parse("30"); 2.yolu
            int s2Number = Convert.ToInt32(s2);
            Console.WriteLine(s1Number + s2Number);

            //Şart ifadeleri
            if (s1Number > 5)
            {
                Console.WriteLine("Sayı bir beşten büyüktür");
            }
            else
            {
                Console.WriteLine("Sayı bir beşten küçüktür");
            }

            //Diziler
            //ilk index sıfırdan başlar
            int[] numbersStatic = new int[5];

            List<int> numberDynamic = new List<int>();
            numberDynamic.Add(300);
            numberDynamic.Add(150);

            //Döngüler
            //for,while,foreach,dowhile
            for (int i = 0; i < numberDynamic.Count; i++)
            {
                Console.WriteLine("Ekrana yaz="+numberDynamic[i]);
            }

            Console.ReadKey();
        }
    }
}
