using System;
using System.IO;

public class Journal {
    public List<Entry> _entries = new List<Entry>();
    public string _fileName;



    public void AddEntry(Entry newEntries){
        _entries.Add(newEntries);
    }

    public void DisplayJournal(){
        int i = 0; 
        foreach (Entry jentry in _entries)
        {
            i ++;
            Console.Write($"{i}. ");
            jentry.Display();
        }
    }

    public void SaveJournal(){
        Console.Write("Enter file name without file type: ");
        _fileName = Console.ReadLine();
        using (StreamWriter theFile = new StreamWriter(_fileName + ".txt")){
            foreach (Entry entry in _entries) {
                theFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._response}");
            }
        }
        _entries.Clear();
        Console.WriteLine("Your journal has been saved. Choose Load option to load journal.");

    }

    public void LoadJournal(){
        Console.Write("Enter file name without file type: ");
        _fileName = Console.ReadLine();
        if (File.Exists(_fileName + ".txt")){
            _entries.Clear();
            string[] lines = File.ReadAllLines(_fileName + ".txt");
            foreach( string line in lines){
                string[] parts = line.Split("~");
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];

                AddEntry(entry);
            }
            DisplayJournal();
        }else {
            Console.WriteLine("Oops! The file does not exist.");
        }
    }

    public void EditJournal()
    {
        LoadJournal();
        DisplayJournal();
        Console.Write("Enter the entry number you want to edit: ");
        int singleEntry = int.Parse(Console.ReadLine());
        int theIndex = singleEntry - 1;
        Entry theEntry = _entries[theIndex];
        string date = theEntry._date;
        string prom = theEntry._prompt;
        string oldrespond = theEntry._response;
        Console.WriteLine($"Date: {date}. Prompt: {prom}.");
        Console.WriteLine(oldrespond);
        Console.WriteLine();
        Console.WriteLine("Enter your new respond");
        Console.Write(">");
        string theNewRespond = Console.ReadLine();
        Entry editEntry = new()
        {
            _date = date,
            _prompt = prom,
            _response = theNewRespond
        };
        _entries[theIndex] = editEntry;
        Console.WriteLine();
        Console.WriteLine("Your journal has been updated. Click Save journal to save it.");
        Console.WriteLine();

    }


}
