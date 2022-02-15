using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Salam, sizi IsPrime saytinda xosh gorduk");
                Console.WriteLine("Her hansi deyeri daxil edin, biz size sade ya murekkeb oludugunu deyek!");

                string inputuser = Console.ReadLine();
                int value = int.Parse(inputuser);

                if (value <= 2)
                {
                    Console.WriteLine("daxil edilen eded 2-dir ya da 2-den azdir.");
                }
                else if (IsPrime(value) == true)
                {
                    Console.WriteLine("Sade ededdir.");
                }
                else
                {
                    Console.WriteLine("Murekkeb ededdir.");
                }
            }
        }
        static bool IsPrime(int a) 
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            } return true;
        }
    }
}
