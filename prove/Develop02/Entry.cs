using System;
using System.IO;

public class Entry {
    public string _prompt;
    public string _response;
    public string _date;

    public void Display(){
        
        Console.WriteLine($"Date: {_date}\n Prompt: {_prompt}\n > {_response}");
        Console.WriteLine();
    }
}