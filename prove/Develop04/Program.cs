using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        int ani = -1;
        while (ani != 100) {
            Console.Write(@"\");

            Thread.Sleep(100);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("|"); // Replace it with the - character

            Thread.Sleep(100);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("/");

            Thread.Sleep(100);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b \b"); // Erase the + character
            
            ani++;
        }
    }
}