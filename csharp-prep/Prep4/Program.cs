using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine();

        List<int> userNumbers = new List<int>();
        int maxNumber = 0;
        int smallest = 1000000;
        string number = "";
        while (number != "0")
        {
            Console.Write("Enter positive or negative number. Enter zero(0) when you're done: ");
            number = Console.ReadLine();
            int num = int.Parse(number);
            if (num != 0)
            {
                userNumbers.Add(num);
            }
            
        }
        foreach (int i in userNumbers)
        {
            if (i > maxNumber)
            {
                maxNumber = i;
            }
        }
        foreach (int small in userNumbers)
        {
            if (small > -1 && small < smallest)
            {
                smallest = small;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The sum is: " + userNumbers.Sum());
        Console.WriteLine("The average is: " + userNumbers.Average());
        Console.WriteLine("The largest number is: " + maxNumber);
        Console.WriteLine("The smallest positive number is: " + smallest);
        Console.WriteLine();
        userNumbers.Sort();
        foreach (int item in userNumbers)
        {
            Console.WriteLine(item);
        }
    }
}