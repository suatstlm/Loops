using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LoopFor();
            // LoopWhile();
            //LoopDoWhile();
            //LoopForEach();
            if (IsPrimeNumber(15))
            {
                Console.WriteLine("Number is prime");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }


        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 1; i < number-1; i++)
            {
                if(number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }

        private static void LoopForEach()
        {
            string[] citys = new string[3] { "İstanbul", "Izmit", "Sivas" };
            foreach (var city in citys)
            {
                Console.WriteLine(city);
            }
        }

        private static void LoopDoWhile()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void LoopWhile()
        {
            int number = 0;
            while (number <= 10)
            {
                Console.WriteLine(number);
                number++;
            }
        }

        private static void LoopFor()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
