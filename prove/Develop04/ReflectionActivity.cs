using System;


public class ReflectionActivity : Activity{

    private List<string> _prompts = new();
    
    private List<string> _questions = new();


    public ReflectionActivity(string name, string descrip, int duration) : base(name, descrip, duration){

    }

    public void Run(){

    }

    private string GetRandomPrompt(){
        return "";
    }

    private string GetRandomQuestion(){
        return "";
    }

    public void DisplayPrompt(){

    }

    public void DisplayQuestions(){

    }
}