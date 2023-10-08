using System;


public class BreathingActivity : Activity{

    public BreathingActivity(string name, string descrip) : base(name, descrip){

    }

    public void Run(){

        Console.Clear();

        DisplayStartMessage();

        Console.Clear();

        Console.WriteLine($"Get Ready...");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        while (DateTime.Now < endTime){
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breath in....");
            ShowCountDown(4);

            Console.WriteLine();
            Console.Write("Breath out....");
            ShowCountDown(6);

            Console.WriteLine();

        }

        Console.WriteLine();
        DisplayEndMessage();
        Console.WriteLine();


    }
}