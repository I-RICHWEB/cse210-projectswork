using System;

public abstract class Goal {
    protected string _name;
    protected string _description;
    protected string _points;
    protected int _scoring = 0;
    

    public Goal(){

    }


    public Goal(string name, string description, string point){
        _name = name;
        _description = description;
        _points = point;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();

    public virtual int ReturnScore(){
        return _scoring;
    }
    public virtual void ClearScoring(){
        _scoring = 0;
    }

    public virtual int GetPoints(){
        int score = int.Parse(_points);
        return score;
    }

    public virtual string GetDetailsString(){

        return $"{_name} ({_description})";
    }

    public string GetGoalName(){
        return _name;
    }

    
}