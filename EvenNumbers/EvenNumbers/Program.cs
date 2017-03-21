using System;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int num = 0;

            System.IO.StreamReader file = new System.IO.StreamReader(args[0]);

            while ((line = file.ReadLine()) != null)
            {
                num = Int32.Parse(line);

                if (num % 2 == 0)
                {
                    Console.WriteLine(1);
                } else
                {
                    Console.WriteLine(0);
                }
            }
            file.Close();
        }
    }
}
