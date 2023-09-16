using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayMessage();
        Console.WriteLine();
        string userName = UserName();
        int number = UserNumber();
        int square = SquareNumber(number);
        Console.WriteLine();
        DisplayUserInfo(userName, square);
        Console.WriteLine();
    }
    static void DisplayMessage()
    {

        Console.WriteLine("Welcome to the program!");
    }
    static string UserName()
    {

        Console.Write("What is your name?: ");
        string response = Console.ReadLine();
        return response;
    }
    static int UserNumber()
    {

        Console.Write("What is your favorite number?: ");
        string response = Console.ReadLine();
        int number = int.Parse(response);
        return number;
    }
    static int SquareNumber(int num)
    {
        int square = num * num;

        return square;
    }
    static void DisplayUserInfo(string userName, int squareNum)
    {

        Console.WriteLine($"{userName}, the square of your number is {squareNum}");
    }

}