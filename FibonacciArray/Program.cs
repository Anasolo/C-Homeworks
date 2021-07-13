using System;

namespace FibonacciArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter upper bound number: ");
            int upperBound = Convert.ToInt32(Console.ReadLine());
            int first = 0;
            Console.WriteLine(first);

            int second = 1;

            int next = first + second;
            int k = 0;
            while (next < upperBound)
            {
                k++;
                Console.WriteLine(next);
                next = first + second;
                first = second;
                second = next;

            }
            k++;
            int[] numbers = new int[k];

           
            numbers[0] = 0;
            numbers[1] = 1;

            // მასივის შევსება

            for (int i = 2; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i - 2] + numbers[i - 1];
            }

            // მასივის ბეჭდვა

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
