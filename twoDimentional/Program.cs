using System;

namespace twoDimentional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int [3, 4];

            // მინიჭება
            Random r = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i,j] = r.Next(10);
                }
            }

            // ჯამი
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum += array[i,j];
                }
            }
            Console.WriteLine($"Sum is {sum}");

            // ბეჭდვა
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(array[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
