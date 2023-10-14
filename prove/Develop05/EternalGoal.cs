using System;


public class EternalGoal : Goal{

    public EternalGoal(string name, string desc, string points) : base(name, desc, points){
       
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