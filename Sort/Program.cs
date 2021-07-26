using System;
namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] array = new int[10];
            Console.WriteLine("Before sorting...");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("\nAfter sorting...");

            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
