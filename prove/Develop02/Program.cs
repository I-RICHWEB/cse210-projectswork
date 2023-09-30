using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello welcome to your journal app!");
        Console.WriteLine();

        Journal journal = new Journal();

        string option = "";
        

        while (option != "6"){
            Console.WriteLine();
            Console.WriteLine("What would you like to do? Choose the number of your option.\n\n 1. Write journal\n 2. Display journal\n 3. Save journal\n 4. Load journal\n 5. Edit journal\n 6. Exit");
            Console.WriteLine();
            Console.Write("Enter an option: ");
            option = Console.ReadLine();

            if (option == "1"){
                string respond = "";
                Console.WriteLine("Respond to the prompts as your journal. Type in (quit) when done.");
            

                while (respond != "quit"){
                    Prompt promptGen = new Prompt();
                    string prompt = promptGen.GenPrompt();
                    Console.WriteLine(prompt);
                    Console.Write(">");
                    respond = Console.ReadLine();

                    if (respond != "quit"){
                        Entry entryNew = new Entry
                        {
                            _date = Date(),
                            _prompt = prompt,
                            _response = respond
                        };
                                   
                        journal.AddEntry(entryNew);
                    
                    }
                }
            }
            else if (option == "2"){
                journal.DisplayJournal();
            }
            else if (option == "3"){
                journal.SaveJournal();
            }
            else if (option == "4"){
                journal.LoadJournal();
            }
            else if (option == "5"){
                journal.EditJournal();
            }

        }

        static string Date(){
            DateTime theDate = DateTime.Now;
            string curDate = theDate.ToShortDateString();
            return curDate;
        }

    }
}
