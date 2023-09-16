using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine();

        Console.Write("What is your grade percentage?: ");
        int percentage = int.Parse(Console.ReadLine());
        Console.WriteLine();

        string signs = "";

        int signsDetermine = percentage % 10;

        string grade;
        if (percentage >= 90)
        {
            grade = "A";
            if (signsDetermine < 3)
            {
                signs = "-";
            }
        }
        else if (percentage < 90 && percentage >= 80)
        {
            grade = "B";
            if (signsDetermine >= 7)
            {
                signs = "+";
            }
            else if (signsDetermine < 3)
            {
                signs = "-";
            }
        }
        else if (percentage < 80 && percentage >= 70)
        {
            grade = "C";
            if (signsDetermine >= 7)
            {
                signs = "+";
            }
            else if (signsDetermine < 3)
            {
                signs = "-";
            }
        }
        else if (percentage < 70 && percentage >= 60)
        {
            grade = "D";
            if (signsDetermine >= 7)
            {
                signs = "+";
            }
            else if (signsDetermine < 3)
            {
                signs = "-";
            }
        }
        else
        {
            grade = "F";
        }

        string message;

        if (percentage >= 70)
        {
            message = "Congratulation you passed the exam!";
        }
        else
        {
            message = "Sorry, you did not pass the exam, try harder next time.";
        }

        Console.WriteLine($"Your grade is: \"{grade}{signs}\" \n{message}");
        Console.WriteLine();
    }
}