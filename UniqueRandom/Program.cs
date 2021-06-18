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
                int k = r.Next(15);
                bool exist = false;
                // გავრბივართ მასივს და ვამოწმებთ წერია თუ არა რენდომ რიცხვი მასივში.
                // j < i იმიტომ რომ იქამდე გაირბინოს ციკლი სადამდეც მისულია.
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == k)
                    {
                        exist = true;
                        break;
                    }
                }

                if (exist == false)
                {
                    array[i] = k;
                }
                else
                {
                    array[i] = r.Next(15);
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
        }

    }
}



