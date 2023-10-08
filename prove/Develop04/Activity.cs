using System;


public class Activity{

    private string _activityName;
    private string _activityDescription;
    protected int _activityDuration;

    public Activity(){

    }
    public Activity(string name, string description){
        _activityName = name;
        _activityDescription = description;
    }

    public void DisplayStartMessage(){

        Console.Write($"Welcome to the {_activityName}.\n\n{_activityDescription}\n\nHow long in seconds do you want to spend in this session?: ");
        _activityDuration = int.Parse(Console.ReadLine());

    }

    public void DisplayEndMessage(){
        Console.WriteLine($"Well done!!");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_activityDuration} of the {_activityName}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds){
        
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

    public void ShowCountDown(int seconds){

        for (int i = seconds; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}