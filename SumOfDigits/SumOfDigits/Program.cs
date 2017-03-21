using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int number, sumOfTheDigits = 0;

            System.IO.StreamReader file = new System.IO.StreamReader(args[0]);

            while ((line = file.ReadLine()) != null)
            {
                number = Convert.ToInt32(line);

                while (number >= 1)
                {
                    sumOfTheDigits += (number % 10);
                    number /= 10;
                }

                Console.WriteLine(sumOfTheDigits);
                sumOfTheDigits = 0;
            }
        }
    }
}
