using System;

namespace SameNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(10);
                Console.WriteLine(numbers[i]);
                if (i != 0 && numbers[i] == numbers[i - 1])
                {
                    Console.WriteLine("same");
                }
            }
           
        }
    }
}
