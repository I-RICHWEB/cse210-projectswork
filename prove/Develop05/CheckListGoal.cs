using System;


public class CheckListGoal : Goal{

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string desc, string points) : base(name, desc, points){
        _amountCompleted = 0;
        _target = 0;
        _bonus = 0;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override void IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}