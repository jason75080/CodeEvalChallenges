using System;

namespace SumOfIntegersFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int number, total = 0;

            System.IO.StreamReader file = new System.IO.StreamReader(args[0]);

            while ((line = file.ReadLine()) != null)
            {
                number = Convert.ToInt32(line);
                total += number;
            }
            Console.WriteLine(total);
        }
    }
}
