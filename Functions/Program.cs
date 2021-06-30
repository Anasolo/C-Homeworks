using System;

namespace Functions
{
    class Program
    {
        static void Main()
        {
            int[] x = { 1, 6, 2, 3 };
            int[] y = { 3, 1, 2, 8 };

            Sum(x);
            Sum(y);
            Max(x);
            Max(y);
            Min(x);
            Min(y);
            Average(x);
            Average(y);

            Console.ReadKey();
        }
        static void Sum(int[] array)

        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Sum is {sum}");
        }
        // დამიწერეთ Sum-ის მსგავსად 3 ფუნქცია, რომლებიც მიიღებს მასივს და დაბეჭდავს შემდეგ მნიშვნელობებს:
        // 1. მაქსიმუმი
        static void Max(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                i++;
            }
            Console.WriteLine($"Maximum number is {max}");
        }
        // 2. მინიმუმი
        static void Min(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                i++;
            }
            Console.WriteLine($"Minimum number is {min}");
        }
        // 3. საშუალო არითმეტიკული
        static void Average(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            double average = (double)sum / array.Length;

            Console.WriteLine($"Average number is {average}");
        }
    }
}
