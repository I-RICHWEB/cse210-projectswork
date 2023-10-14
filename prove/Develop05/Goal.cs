using System;

public abstract class Goal {
    private string _name;
    private string _description;
    private string _points;

    public Goal(){

    }


    public Goal(string name, string description, string point){
        _name = name;
        _description = description;
        _points = point;
    }

    public abstract void RecordEvent();

    public abstract void IsComplete();

    public virtual string GetDetailsString(){
        return "";
    }

    public abstract string GetStringRepresentation();
}