using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input = -1;
        int sum = 0;

        while (input != 0)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        int lnumber = numbers[0];

        foreach (int number in numbers)
        {
            sum += number;

            if (number > lnumber)
            {
                lnumber = number;
            }
        }

        int count = numbers.Count;
        float average = (float)sum / count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {lnumber}");

        int sPositive = -1;
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (sPositive == -1 || number < sPositive)
                {
                    sPositive = number;
                }
            }
        }

        if (sPositive > 0)
        {
            Console.WriteLine($"The smallest positive number is: {sPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }

        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
