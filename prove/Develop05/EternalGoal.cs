using System;
using System.ComponentModel;


public class EternalGoal : Goal{

    private int _accomplished;

    public EternalGoal(string name, string desc, string points, int accomp = 0) : base(name, desc, points){
       _accomplished = accomp;
    }

    public override void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine($"Congratulation you earn {_points} points.");
        _scoring = GetPoints();
        _accomplished = _accomplished + 1;

        Console.Write("Enjoy Magic Number game for your accomplishment: ");
        ShowSpinner(4);
        MagicNumberGame();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString(){
        return $"{_name} ({_description}) --Accomplished: {_accomplished} times.";
    }


    public override string GetStringRepresentation()
    {
        return $"EternalGoal~~{_name}~~{_description}~~{_points}~~{_accomplished}";
    }

    private void MagicNumberGame(){
        Console.Clear();

        Console.WriteLine("Welcome to the Magic number game. Try guess the: \nMagic Number [🎡]");

        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 100);

        int response = -1;
        int count = 0;
        while (response != magicNumber && response != 0)
        {
            Console.Write("Guess the number (or enter zero[0] to quit): ");
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
        Console.WriteLine("You guess right!\n");
        Console.WriteLine($"Number of guess: {count}.\n");

    }

    private void ShowSpinner(int seconds){
        
        List<string> aniList = new List<string>{"|", "/", "-", "\\", "|", "/", "-", "\\"};
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int ani = 0;
        while (DateTime.Now < endTime) {
            
            Console.Write(aniList[ani]);
            Thread.Sleep(200);
            Console.Write("\b \b");

            ani++;
            if (ani >= aniList.Count){
                ani = 0;
            }
        }

    }
}