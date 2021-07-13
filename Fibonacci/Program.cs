using System;

namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter upper bound number: ");

            int upperBound = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[upperBound];

            int first = 0;
            array[0] = first;
            Console.WriteLine(first);

            int second = 1;

            int next = first + second;
            int i = 1;
            while (next < upperBound)
            {
                array[i] = next;
                i++;
                Console.WriteLine(next);
                next = first + second;
                first = second;
                second = next;
                
            }

            Console.WriteLine("====================");

            for (int j = 0; j < array.Length; j++)
            {
                if(array[j] != 0 || j== 0)
                {
                    Console.Write(array[j]);
                    Console.Write(" ");
                }
                // ეს ამოხსნა იმხელა მასივს ქმნის რამდენიც upperBound-ია. ბეჭდვისას ნოლებს ვაკლებთ და ვტოვებთ მარტო პირველ ნოლს.
            }
        }
    }
}
