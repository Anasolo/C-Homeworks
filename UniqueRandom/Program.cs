using System;

namespace G11_20210607

{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(10);

                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
        }
    }
}
// თუ დაემთხვა უკან ბრუნდება, ცვლის რიცხვს და გამოდის ციკლიდან, ჩაიციკლება სანამ არაერთნაირი რიცხვები არ ამოვა