using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello welcome to your journal app!");
        Console.WriteLine();

        string option = "";

        while (option != "5"){
            
            Console.WriteLine("What would you like to do? Choose the number of your option.\n 1. Write\n 2. Display\n 3. Save\n 4. Load\n 5. Exit");
            Console.WriteLine();
            Console.Write("Enter an option: ");
            option = Console.ReadLine();

            if (option == "1"){
                WriteOption();
            }
            else if (option == "2"){
                DisplayOption();
            }
            else if (option == "3"){
                SaveOption();
            }
            else if (option == "4"){
                LoadOption();
            }

        }

        static void WriteOption(){
            string respond = "";
            Console.WriteLine("Respond to the prompts as your journal. Type in (quit) when done.");

            while (respond != "quit"){
                Prompt promptGen = new Prompt();
                string prompt = promptGen.GenPrompt();
                Console.WriteLine(prompt);
                Console.Write(">");
                respond = Console.ReadLine();

                Entry entryNew = new Entry();
                entryNew._date = Date();
                entryNew._prompt = prompt;
                entryNew._response = respond;

                Journal journal = new Journal();
                journal._entries.Add(entryNew);
                
            }

        }

        static void DisplayOption(){
            Journal journal = new Journal();
            journal.DisplayJournal();
        }

        static void SaveOption(){
            Journal journal = new Journal();
            journal.SaveJournal();
        }

        static void LoadOption(){
            Journal journal = new Journal();
            journal.LoadJournal();
        }

        static string Date(){
            DateTime theDate = DateTime.Now;
            string curDate = theDate.ToShortDateString();
            return curDate;
        }

    }
}
