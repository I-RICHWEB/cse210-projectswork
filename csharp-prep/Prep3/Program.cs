using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine();
        string playAgain = "";
        while (playAgain != "no")
        {
            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1, 100);

            int response = -1;
            int count = 0;
            while (response != magicNumber)
            {
                Console.Write("Guess the number: ");
                response = int.Parse(Console.ReadLine());
                Console.WriteLine();
                count++;
                if (response > magicNumber)
                {
                    Console.WriteLine("Guess lower");
                }
                else if (response < magicNumber)
                {
                    Console.WriteLine("Guess higher");
                }
            }
            Console.WriteLine("You guess right!");
            Console.WriteLine($"Number of guess: {count}.");
            Console.WriteLine();
            Console.Write("Do you want to play again?(yes or no): ");
            playAgain = Console.ReadLine();
        }

    }
}