using System;
namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] array = new int[5];

            Console.WriteLine("Before reverse...");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n\nAfter reverse...");
            for (int i = 0; i < array.Length/2; i++)
            {
                int temp = 0;
                temp = array[i];
                array[i] = array[(array.Length-1)-i];
                array[(array.Length - 1) - i] = temp;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
