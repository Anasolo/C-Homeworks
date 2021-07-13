using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b  ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c  ");
            int c = Convert.ToInt32(Console.ReadLine());

            double x1 = 0, x2 = 0;
            QuadraticEquation(ref a, ref b, ref c, out x1, out x2);

            Console.WriteLine($"X1 = {x1}");
            Console.WriteLine($"X2 = {x2}");
        }

        static void QuadraticEquation(ref int a, ref int b, ref int c, out double x1, out double x2)
        {

            int D = b * b - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("No roots found");
            }
            if (D == 0)
            {
                x1 = -b / 2 * a;
                x2 = x1;
            }
            if (D > 0)
            {
                x1 = (-b - Math.Sqrt(D)) / 4 * a;
                x2 = (-b + Math.Sqrt(D)) / 4 * a;
            }
            x1 = 0;
            x2 = 0;
        }
    }
}
