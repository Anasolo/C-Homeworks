using System;

namespace UniqueTwoDimentional
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[,] array = new int[10, 8];

            // რიცხვები უნდა იყოს უნიკალური.

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {

                    array[i, j] = r.Next(10, 100);

                    for (int m = 0; m <= i; m++)
                    {
                        int stop = 0;
                        for (int n = 0; n < array.GetLength(1); n++)
                        {
                            if (i == m && j == n)
                            {
                                continue;
                            }
                            if (array[m, n] == array[i, j])
                            {
                                if (j == 0)
                                {
                                    i--;
                                    j = array.GetLength(1);
                                }
                                else
                                {
                                    j--;
                                }
                                stop = 1;
                                break;
                            }
                        }
                        if (stop == 1)
                        {
                            break;
                        }
                    }

                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            // Check
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int m = 0; m < array.GetLength(0); m++)
                    {
                        for (int n = 0; n < array.GetLength(1); n++)
                        {
                            if (array[i, j] == array[m, n] && i != m && j != n)
                            {
                                Console.WriteLine($"Not unique -> {array[i, j]} , Index {i},{j}");
                            }
                        }
                    }
                }
            }
        }
    }
}