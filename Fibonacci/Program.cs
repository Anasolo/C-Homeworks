using System;

namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter upper bound number: ");

            int upperBound = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Upper bound number is {upperBound}");

            // ჩამომიწერეთ ფიბონაჩის რიცხვების თანმიმდევრობა upperBound-მდე.

            // მაგალითად, თუ upperBound-ში შევიყვანთ 10-ს, უნდა ჩამოწეროთ შემდეგი რიცხვები:

            // 0,1,1,2,3,5,8

            int first = 0;
            Console.WriteLine(first);

            int second = 1;
            Console.WriteLine(second);

            int next = first + second;

            while (next < upperBound)
            {
                Console.WriteLine(next);
                next = first + second;
                first = second;
                second = next;
            }
            Console.ReadKey();
        }
    }
}
