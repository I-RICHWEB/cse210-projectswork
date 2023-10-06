using System;


public class Activity{

    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;

    public Activity(){

    }
    public Activity(string name, string description, int duration){
        _activityName = name;
        _activityDescription = description;
        _activityDuration = duration;
    }

    public void DisplayStartMessage(){

    }

    public void DisplayEndMessage(){

    }

    public void ShowSpinner(int seconds){

    }

    public void ShowCountDown(int seconds){
        
    }
}