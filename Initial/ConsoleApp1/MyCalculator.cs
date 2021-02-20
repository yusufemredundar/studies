using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MyCalculator
    {
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        public int Min(int n1, int n2)
        {
            return n1 - n2;
        }//Minus
        public int Mul(int n1, int n2)
        {
            return n1 * n2;
        }//Multiply
        public int Div(int n1, int n2)
        {
            return n1 / n2;
        }//Divide
        public ulong Fact(ulong number)
        {
            #region Recursive(Yinelenen) metot örneği
            /*
            if (number > 1)
            {
                var result = number * Fact(number - 1); //(17 * ( (17-1) * (16-1) .....( 4 * ( 3* ( 2 * (1)) )) )
                return result;
            }
            else return number;
            
            */
            #endregion

            ulong result = 1;
            for (ulong i = number; i > 1; i--)
            {
                result = result * number;
            }
            return result;
        }//factorial

        public int Consecutive(int number) //Girilen sayıya kadar olan sayilari toplama
        {
            int total = 0;
            for (int i = 0; i <= number; i++)
            {
                total += i;
            }
            return total;
        }//Consecutive numbers (Ardışık sayılar)
        public int SingleTotal(int number)
        {
            int total = 0;
            for (int i = 1; i <= number; i += 2)
            {
                total += i;
            }
            return total;
        }// Tek sayılar toplamı
        public int DoubleTotal(int number)
        {
            int total = 0;
            for (int i = 2; i <= number; i += 2)
            {
                total += i;
            }
            return total;
        }//Çift sayılar toplamı
        public bool PrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public void BasicCalculate(int n1, int n2)
        {
            int addResult = Add(n1, n2);
            int minResult = Min(n1, n2);
            int mulResult = Mul(n1, n2);
            int divResult = Div(n1, n2);

            //Console.WriteLine(primeResult==true ? "{0} sayısı asaldır.":"{0} sayısı asal değil",n1);
            Console.WriteLine("Toplam sonucu = " + addResult);
            Console.WriteLine("Çıkarma sonucu = " + minResult);
            Console.WriteLine("Çarpma sonucu = " + mulResult);
            Console.WriteLine("Bölme sonucu = " + divResult);

            Console.WriteLine("************Hesaplama Bitti*************");
        }
        public void ComplexCalculate(int n1, int n2)
        {
            int doubleResult = DoubleTotal(n1);
            int singleResult = SingleTotal(n1);
            ulong factResult = Fact((ulong)n2);
            int consResult = Consecutive(n1);
            //bool primeResult=PrimeNumber(n1);

            Console.WriteLine("tek ve çift toplamları ={0} ve {1} ", singleResult, doubleResult);
            Console.WriteLine("Sayi 2'nin faktoriyeli = " + factResult);
            Console.WriteLine("Sayi 1'e kadar olan sayilarin toplamı = " + consResult);

        }
    }
}
