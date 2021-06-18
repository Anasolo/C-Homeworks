using System;

public class Program
{
    public static void Main()

    {
        Random r = new Random();

        int[] array = new int[10];
        int index = 0;

        while (index < array.Length)
        {
            array[index] = r.Next(100);
            Console.WriteLine($"array[{index}] = {array[index]}");
            index++;
        }
        // მთლიანი რიცხვების ჯამის პოვნა.
        index = 0;
        int sum = 0;

        while (index < array.Length)
        {
            sum += array[index];
            index++;
        }

        Console.WriteLine("Sum is " + sum);

        // ლუწი რიცხვების ჯამი, კენტი რიცხვების ჯამი.
        int evenSum = 0, oddSum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                evenSum += array[i];
            }
            else
            {
                oddSum += array[i];
            }
        }
        Console.WriteLine($"Sum of even numbers is {evenSum}");
        Console.WriteLine($"Sum of odd numbers is {oddSum}");

        // მთლიანი რიცხვების საშუალო

        double average = (double)sum / array.Length;

        Console.WriteLine("Average number is " + average);

        // ლუწი რიცხვების რაოდენობა, კენტი რიცხვების რაოდენობა.

        int countEvens = 0, countOdds = 0;
        double oddAverage, evenAverage;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                countEvens++;
            }
            else
            {
                countOdds++;
            }
        }

        Console.WriteLine($"Quantity of even numbers is  {countEvens}");
        Console.WriteLine($"Quantity of odd numbers is  {countOdds}");

        // ლუწი რიცხვების საშუალო, კენტი რიცხვების საშუალო.

        evenAverage = (double)evenSum / countEvens;
        Console.WriteLine($"Average number of even numbers is {Math.Round(evenAverage, 2)}");

        oddAverage = (double)oddSum / countOdds;
        Console.WriteLine($"Average number of odd numbers is {Math.Round(oddAverage, 2)}");

        // მთლიან რიცხვებში ყველაზე დიდი რიცხვი.

        index = 1;
        int max = array[0];

        while (index < array.Length)
        {
            if (array[index] > max)
            {
                max = array[index];
            }
            index++;
        }
        Console.WriteLine($"Maximum number is {max}");

        // მთლიან რიცხვებში ყველაზე პატარა რიცხვი.

        index = 1;
        int min = array[0];

        while (index < array.Length)
        {
            if (array[index] < min)
            {
                min = array[index];
            }
            index++;
        }
        Console.WriteLine($"Minimum number is {min}");

        // ყველაზე დიდი ლუწი რიცხვის მოძებნა.

        if (countEvens > 0)
        {
            int evenMax = 0;
            int evenMin = 0;

            // პირველი ლუწი რიცხვის პოვნა.
            int firstEvenIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenMax = array[i];
                    evenMin = array[i];
                    firstEvenIndex = i;
                    break;
                }
            }
            // უფრო დიდი და პატარა რიცხვის მოძებნა.

            // firstEvenIndex ცვლადს ვიყენებთ იმისთვის, რომ შევინახოთ i-ს მნიშვნელობა სადაც გაჩერდა და მეორე for-მა იმ ადგილიდან გააგრძელოს.

            for (int i = firstEvenIndex; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] > evenMax)
                {
                    evenMax = array[i];
                }
                if (array[i] % 2 == 0 && array[i] < evenMin)
                {
                    evenMin = array[i];
                }
            }
            Console.WriteLine($"Maximum even number is {evenMax}");
            Console.WriteLine($"Minimum even number is {evenMin}");
        }
        else
        {
            Console.WriteLine("No Even Numbers Found.");
        }
    }

}