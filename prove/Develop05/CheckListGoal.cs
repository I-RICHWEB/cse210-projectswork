using System;


public class CheckListGoal : Goal{

    private int _amountCompleted;
    private int _target;
    private int _bonus;
    

    public CheckListGoal(string name, string desc, string points, int target, int bonus, int amountCompleted = 0) : base(name, desc, points){
        
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        Console.Clear();
        if (_amountCompleted != _target){

            _amountCompleted += 1;

            if (_amountCompleted != _target){
                Console.WriteLine($"Congratulation you earn {_points} points.");
                _scoring = GetPoints();
            
            }else if (_amountCompleted == _target){
                Console.WriteLine($"Congratulation! You've earn {_points} points, and a bonus of {_bonus} for completing the goal.");
                _scoring = GetPoints();
            }
        }else{
            Console.WriteLine("It looks like you have already completed this goal.");
        }
        
        
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target){
            return true;
        }else{
            return false;
        }
    }

    public override string GetDetailsString()
    {

        return $"{_name} ({_description}) --Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {

        return $"CheckListGoal~~{_name}~~{_description}~~{_points}~~{_bonus}~~{_target}~~{_amountCompleted}";
    }

    public override int GetPoints()
    {
        int score = int.Parse(_points);
        if (_amountCompleted != _target){
            
            return score;
        }else {
            int addBonus = score + _bonus;
            return addBonus;
        }

        
    }
}