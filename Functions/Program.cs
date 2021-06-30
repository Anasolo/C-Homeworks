using System;

namespace Functions
{
    class Program
    {
        static void Main()
        {
            int[] x = { 41, 10, 20, 43 };
            int[] y = { 12, 32, 22, 11 };

            int k = Sum(x);
            Console.WriteLine($"Sum is {k}");
            int z = Sum(y);
            Console.WriteLine($"Sum is {z}");
            Max(x);
            Max(y);
            Min(x);
            Min(y);
            Average(x);
            Average(y);

            Console.ReadKey();
        }
        static int Sum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
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
            }
            Console.WriteLine($"Minimum number is {min}");
        }
        // 3. საშუალო არითმეტიკული
        static void Average(int[] array)
        {
            int sum = Sum(array);
            double average = (double)sum / array.Length;

            Console.WriteLine($"Average number is {average}");
        }
    }
}
