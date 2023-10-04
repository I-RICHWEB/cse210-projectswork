using System;
using System.IO;
public class Words
{

    private string _text;
    private bool _isHidden;
    
    
    public Words(){
        
    }
    public Words(string text){
        _text = text;
    }

    public bool True { get; private set; }
    public string HideWord(string wd){

        List<string> letters = new();
        string underScores = "";
        
        for (int i = 0; i < wd.Length; i++){
            char letter = wd[i];
            string nletter = letter.ToString();
            
            letters.Add(nletter);
            underScores = underScores + "_";

        }
        string toRep = String.Join("", letters);
        
        string wordRet = wd.Replace(toRep, underScores);
        return wordRet;
    }

    
    public string GetStringWord(){
        return _text;
    }


    public bool isHide(string theWord){
        foreach (char item in theWord)
        {
            string iString = item.ToString();
            if (iString == "_"){
                continue;
            }
            
        }
        _isHidden = True;
        return _isHidden;
    }

    
}  