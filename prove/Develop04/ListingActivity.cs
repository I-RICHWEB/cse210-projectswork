using System;


public class ListingActivity : Activity{

    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string descrip) : base(name, descrip){

    }

    public void Run(){
        Console.Clear();
        DisplayStartMessage();
        Console.Clear();

        Console.WriteLine($"Get Ready...");
        ShowSpinner(3);
        Console.WriteLine();

        Console.WriteLine("List as many response as you can to the following prompt.\n");
        Console.Write("---- ");
        GetRandomPromp();
        Console.Write(" ----\n");

        Console.WriteLine();
        Console.Write("You may begin in...");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> resp = new();

       

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        while (DateTime.Now < endTime){
            Console.Write(">");
            string respond = Console.ReadLine();
            if (respond != ""){
                resp.Add(respond);
            }
            
            
        }
        
        _count = resp.Count; 

        Console.WriteLine($"You listed {_count} responses");
        DisplayEndMessage();
       
    }

    private void GetRandomPromp(){
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random r = new Random();
        int index = r.Next(_prompts.Count);

        Console.Write(_prompts[index]);
    }
}