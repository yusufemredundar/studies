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
            return n1 * n2;
        }//Divide

        public void Calculate(int n1,int n2)
        {
            int addResult = Add(n1, n2);
            int minResult = Min(n1, n2);
            int mulResult = Mul(n1, n2);
            int divResult = Div(n1, n2);

            Console.WriteLine("Toplam sonucu = " + addResult);
            Console.WriteLine("Çıkarma sonucu = " + minResult);
            Console.WriteLine("Çarpma sonucu = " + mulResult);
            Console.WriteLine("Bölme sonucu = " + divResult);
            Console.WriteLine("************Hesaplama Bitti*************");
        }
    }
}
