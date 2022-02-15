using System;

namespace qwerty
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Console.WriteLine("Salam, sechdiyiniz 3 mehsulun qiymetin daxil edin, biz size endirimnen qiymeti teqdim edek.");
            string a = Console.ReadLine();
            double num = double.Parse(a);

            string b = Console.ReadLine();
            double num1 = double.Parse(b);

            string c = Console.ReadLine();
            double num2 = double.Parse(c);
            if (num < 0 || num1 < 0 || num2 < 0)
            {
                Console.WriteLine("Duzgun deyer daxil et!");
            }
                Console.WriteLine("Bu da odeyeceyiniz mebleg.");
                Console.WriteLine(SumOfGoods(num, num1, num2));
            }
        }
        static double SumOfGoods(double a, double b, double c)
        {

            if (a > c && b > c)
            {
                return a + b;
            }
            else if (b > a && c > a)
            {
                return b + c;
            }
            else
            {
                return a + c;
            }
        }
    }
}

