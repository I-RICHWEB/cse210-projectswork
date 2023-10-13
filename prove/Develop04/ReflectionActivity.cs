using System;


public class ReflectionActivity : Activity{

    private List<string> _prompts = new();
    
    private List<string> _questions = new();

    private List<string> _reload = new();


    public ReflectionActivity(string name, string descrip) : base(name, descrip){

    }

    public void Run(){
        Console.Clear();
        DisplayStartMessage();
        Console.Clear();

        SetLists();

        Console.WriteLine($"Get Ready...");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:\n");
    
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
        Console.WriteLine("When you have something in mind press enter to continue.  ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        while (DateTime.Now < endTime){
            Console.Write($"> {GetRandomQuestion()}");
            ShowSpinner(7);
            Console.WriteLine();
            Console.WriteLine();
        }
        DisplayEndMessage();

    }

    private void SetLists(){
        //Adding items to the Prompt list.
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        //Adding items to the questions list.
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    private string GetRandomPrompt(){
       
        
        Random r = new();
        string prompt = _prompts[r.Next(_prompts.Count)];
        return prompt;
    }
    
    private string GetRandomQuestion(){        

        Random r = new();
            
        int index = r.Next(_questions.Count);
        string question = _questions[index];
        _reload.Add(question);
        _questions.RemoveAt(index);

        if (_questions.Count == 0){
            foreach (string item in _reload){
                _questions.Add(item);
            }
            _reload.Clear();
        }

        return question;
    }
}