using System;
using System.IO;
using System.Net;

public class Prompt {
    public List<string> _promptList = new List<string>();
    public string _promptFileName = "Promptings.txt";

    public string GenPrompt(){
        int oldRandomNum;
        string[] lines = System.IO.File.ReadAllLines(_promptFileName);
        foreach (string line in lines){
            _promptList.Add(line);
        }
        Random randomNumber = new Random();
        int randomIndex = randomNumber.Next(_promptList.Count);
        oldRandomNum = randomIndex;
        while (randomIndex == oldRandomNum){
            randomIndex = randomNumber.Next(_promptList.Count);
        }
        string newPrompt = _promptList[randomIndex];
        return newPrompt;
    }

}
