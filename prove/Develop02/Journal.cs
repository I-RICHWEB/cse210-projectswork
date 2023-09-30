using System;
using System.IO;

public class Journal {
    public List<Entry> _entries = new List<Entry>();
    public string _fileName;



    public void AddEntry(Entry newEntries){
        _entries.Add(newEntries);
    }

    public void DisplayJournal(){
        Console.WriteLine(_entries.Count);
        foreach (Entry entry in _entries){
            entry.Display();
        }
    }

    public void SaveJournal(){
        Console.Write("Enter file name: ");
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
        Console.Write("Enter file name: ");
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
        Console.WriteLine("Your journal has been loaded. Choose display option to view journal.");
    }


}
