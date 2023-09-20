using System;

public class Resume {
    public string _name;
    public List<Job> _joblist = new List<Job>();

    public void DisplayResume (){
        Console.WriteLine();
        Console.WriteLine($"Name: {_name}");
        
        Console.WriteLine("Jobs:");
        foreach ( Job j in _joblist){
            j.DisplayJob();
        }
        Console.WriteLine();

    }
}