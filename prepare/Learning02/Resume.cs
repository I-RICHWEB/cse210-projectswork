using System;

public class Resume {
    public string name;
    public List<Job> joblist = new List<Job>();

    public void DisplayResume (){
        Console.WriteLine();
        Console.WriteLine($"Name: {name}");
        
        Console.WriteLine("Jobs:");
        foreach ( Job j in joblist){
            j.DisplayJob();
        }
        Console.WriteLine();

    }
}