using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

public class Reference
{
    private string _bookName;
    private int _chapter;
    private int _verseStart;
    private int _endVerse;
    private bool _checking;

    public Reference(){}
    
    public Reference(string book, int chapter, int startV){
        _bookName = book;
        _chapter = chapter;
        _verseStart = startV;
        _checking = true;
    }
    public Reference(string book, int chapter, int startV, int endV){
        _bookName = book;
        _chapter = chapter;
        _verseStart = startV;
        _endVerse = endV;
        _checking = false;
    }

    public string DisplayRefer(){
        if (_checking == true){
            return DisplaySingleRef();
        }
        else{
            return DisplayDoubleRef();
        }
    }

    private string DisplaySingleRef(){
        string singleRef = $"{_bookName} {_chapter}:{_verseStart}";
        return singleRef;
    }
    private string DisplayDoubleRef(){
        string doubleRef = $"{_bookName} {_chapter}:{_verseStart}-{_endVerse}";
        return doubleRef;
    }

    public string GetRefer(){
        if (_checking == true){
            return GetSingleReference();
        }
        else{
            return GetdoubleReference();
        }

    }

    private string GetSingleReference(){
        string book = _bookName;
        int chap = _chapter;
        int fVerse = _verseStart;
        return $"{book}#{chap}#{fVerse}";
    }

    private string GetdoubleReference(){
        string book = _bookName;
        int chap = _chapter;
        int fVerse = _verseStart;
        int lVerse = _endVerse;
        return $"{book}#{chap}#{fVerse}#{lVerse}";
    }
}

