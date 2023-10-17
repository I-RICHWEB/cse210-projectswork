using System;

public class SimpleGoal : Goal{
     private bool _isComplete;
     
    public SimpleGoal(string name, string desc, string points, bool complete = false) : base(name, desc, points){
       _isComplete = complete;
    }

    public override void RecordEvent()
    {
        Console.Clear();
        if (_isComplete != true){
            Console.WriteLine($"Congratulation you earn {_points} points.");
            _isComplete = true;
            _scoring = GetPoints();
        }else {
            Console.WriteLine("It looks like you have accomplished this goal.");
        }

    }

    public override bool IsComplete()
    {
       return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal~~{_name}~~{_description}~~{_points}~~{_isComplete}";
    }
}


