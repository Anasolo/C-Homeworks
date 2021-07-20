using System;
namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x1, x2;

            // გააკეთეთ ისე, რომ თუ a-ში შევიყვანთ 0-ს, დაგვიწეროს რომ ეს არ შეიძლება და თავიდან გვთხოვოს იგივე კოეფიციენტის შეყვანა.

            Console.Write("A = ");
            double a = Convert.ToDouble(Console.ReadLine());

            if(a == 0)
            {
                Console.WriteLine("0 is invalid, try another one.");
                a = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("B = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("C = ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                double d = GetD(a, b, c);

                Console.WriteLine($"D = {d}");

                bool hasRoots = GetRoots(a, b, c, out x1, out x2);

                if (hasRoots == true)
                {
                    Console.WriteLine($"X1 = {x1}");
                    Console.WriteLine($"X2 = {x2}");
                }
                else
                {
                    Console.WriteLine("No roots found");
                }
                Console.ReadKey();
            }

            static double GetD(double a, double b, double c)
            {
                return Math.Pow(b, 2) - 4 * a * c;
            }

            static bool GetRoots(double a, double b, double c, out double? x1, out double? x2)
            {
                double d = GetD(a, b, c);

                if (d > 0)
                {
                    x1 = (-b - Math.Sqrt(d)) / (2 * a);
                    x2 = (-b + Math.Sqrt(d)) / (2 * a);
                    return true;
                }
                else if (d == 0)
                {
                    x1 = x2 = (-b - d) / (2 * a);
                    return true;
                }
                x1 = x2 = null;
                return false;
            }
        }
    }
}
