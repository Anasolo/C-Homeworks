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

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = r.Next(10);
                }
            }

            // ბეჭდვა
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            // ჯამი
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine($"Sum is {sum}");

            // ლუწი რიცხვების ჯამი
            int evenSum = 0, oddSum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] % 2 == 0)
                    {
                        evenSum +=array[i, j];
                    }
                    else
                    {
                        oddSum += array[i, j];
                    }
                }
               
            }
            Console.WriteLine($"Sum of even numbers is {evenSum}");
            Console.WriteLine($"Sum of odd numbers is {oddSum}");

            // საშუალო

            double average = (double)sum / array.Length;
            Console.WriteLine($"Average number is {Math.Round(average, 2)}");

            // ლუწი რიცხვების საშუალო

            int countEvens = 0, countOdds = 0;
            double oddAverage, evenAverage;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] % 2 == 0)
                    {
                        countEvens++;
                    }
                    else
                    {
                        countOdds++;
                    }
                }
            }
            Console.WriteLine($"Quantity of even numbers is  {countEvens}");
            Console.WriteLine($"Quantity of odd numbers is  {countOdds}");

            evenAverage = (double)sum / countEvens;
            oddAverage = (double)sum / countOdds;

            Console.WriteLine($"Average number of even numbers is {Math.Round(evenAverage, 2)}");
            Console.WriteLine($"Average number of odd numbers is {Math.Round(oddAverage, 2)}");

            // მაქსიმუმი

            int max = array[0,0];

            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i,j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            Console.WriteLine($"Maximum number is {max}");

            // მინიმუმი

            int min = array[0, 0];

            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            Console.WriteLine($"Minimum number is {min}");

            // ლუწი მაქსიმუმი და მინიმუმი

            if (countEvens > 0)
            {
                int evenMax = 0, evenMin = 0;
                int firstEvenIndex = 0;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] % 2 == 0 )
                        {
                            evenMax = array[i, j];
                            evenMin = array[i, j];
                            firstEvenIndex = i;
                            break;
                        }
                    }
                }
                for (int i = firstEvenIndex; i < array.GetLength(0); i++)
                {
                    for (int j = firstEvenIndex; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] % 2 == 0 && array[i, j] > evenMax)
                        {
                            evenMax = array[i,j];
                        }
                        if (array[i,j] % 2 == 0 && array[i,j] < evenMin)
                        {
                            evenMin = array[i,j];
                        }
                    }
                }
                Console.WriteLine($"Maximum even number is {evenMax}");
                Console.WriteLine($"Minimum even number is {evenMin}");
            }
            else
            {
                Console.WriteLine("No even numbers found");
            }
            // არასწორია მაქსიმუმი და მინიმუმი
        }
    }
}
