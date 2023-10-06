using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Assignment assignment1 = new("Uyiosa Richmond", "Programming with classes");
        Console.WriteLine(assignment1.GetSummary());


        Console.WriteLine();
        MathAssignment math = new("Uyiosa Richmond", "Subtraction", "3.7", "3-5");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeWorkList());

        Console.WriteLine();
        WritingAssignment writing = new("Izekor Stone","Social Science", "The Causes Of Depression In Youth");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
        Console.WriteLine();
    }
}