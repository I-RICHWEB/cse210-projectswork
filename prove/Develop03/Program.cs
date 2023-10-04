using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorizer program!");
        Console.WriteLine("This program will help you to memorize scriptures by hidding words at random.");
        Console.WriteLine();

        Scripture scripture = new();

        string option = "";
        Console.WriteLine();

        while (option != "4"){
            Console.WriteLine("1. Add scripture.\n2. Random verse(Matthew 5).\n3. Load added scriptures.\n4. Close the program.\n ");
            Console.Write("Enter an option. >");
            option = Console.ReadLine();
            if (option == "1")
            {
                Console.WriteLine();
                scripture.AddPersonalScripture();
                int r = scripture.RandomIndex();
                Console.WriteLine();
                scripture.DisplayScrip(r);
                Console.WriteLine();
                
                int wtc = scripture.GetWordTextCount();
                Console.WriteLine(wtc);
                
                int rtc = scripture.GetRemoveTextCount();
                Console.WriteLine(rtc);

                Console.WriteLine("Click Enter button to hide random words, or type (quit) to cancel:");
                Console.Write(">");
                string quit = Console.ReadLine();
                
                while ( rtc <= wtc && quit != "quit"){
                    Console.Clear();

                    scripture.HideScriptureWords(r);

                    Console.WriteLine(rtc);
                    
                    Console.WriteLine("Click Enter button to hide random words, or type (quit) to cancel:");
                    Console.Write(">");
                    quit = Console.ReadLine();
                }
                Console.WriteLine(rtc);
            }
            else if (option == "2")
            {
                scripture.Matthew();
                int r = scripture.RandomIndex();
                Console.WriteLine();
                scripture.DisplayScrip(r);
                Console.WriteLine();

                Console.WriteLine("Click Enter button to hide random words, or type (quit) to cancel:");
                Console.Write(">");
                string quit = Console.ReadLine();
                
                while ( quit != "quit"){
                    Console.Clear();

                    scripture.HideScriptureWords(r);
                    
                    Console.WriteLine("Click Enter button to hide random words, or type (quit) to cancel:");
                    Console.Write(">");
                    quit = Console.ReadLine();
                }

                
            }
            else if (option == "3")
            {
            
                scripture.Load();
                int r = scripture.RandomIndex();
                Console.WriteLine();
                scripture.DisplayScrip(r);
                Console.WriteLine();

                Console.WriteLine("Click Enter button to hide random words, or type (quit) to cancel:");
                Console.Write(">");
                string quit = Console.ReadLine();
                
                while ( quit != "quit"){
                    Console.Clear();

                    scripture.HideScriptureWords(r);
                    
                    Console.WriteLine("Click Enter button to hide random words, or type (quit) to cancel:");
                    Console.Write(">");
                    quit = Console.ReadLine();
                }
               
            }
        }
    }
}