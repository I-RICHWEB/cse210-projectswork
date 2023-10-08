using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to Mindfulness Program.");
        Console.WriteLine();

        string menu = "";

        while (menu != "4"){
            Console.Clear();

            Console.Write("Menu Option:\n  1. Breathing Activity\n  2. Reflection " + 
            "Activity\n  3. Listing Activity\n  4. Exit Program\n\nEnter an Option: ");
            menu = Console.ReadLine();

            if (menu == "1"){
                
                string b_name = "Breathing Activity";
                string b_description = "This activity will help you relax by walking your " +
                "through breathing in and out slowly. Clear your mind and focus on your breathing.";

                BreathingActivity breath = new(b_name, b_description);
                breath.Run();

            }else if (menu == "2"){

                string r_name = "Reflection Activity";
                string r_description = "This activity will help you reflect on times in your life when you have " + 
                "shown strength and resilience. This will help you recognize the power " + 
                "you have and how you can use it in other aspects of your life.";

                ReflectionActivity reflect = new(r_name, r_description);
                reflect.Run();

            }else if (menu == "3"){
                
                string l_name = "Listing Activity";
                string l_description = "This activity will help you reflect on the good things in your life by having you " + 
                "list as many things as you can in a certain area.";

                ListingActivity listing = new(l_name, l_description);
                listing.Run();
            }

        }

        

        
        //Activity activity1 = new();
        // activity1.ShowSpinner();
        // activity1.ShowCountDown(3);

    }
}