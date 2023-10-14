using System;

public class SimpleGoal : Goal{
     private bool _isComplete;


    public SimpleGoal(string name, string desc, string points) : base(name, desc, points){
        _isComplete = false;
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


