using System;


public class GoalManager{
    private List<Goal> _goals = new List<Goal>();
    private int _scores = 0;

    private string _checkBox;

    public GoalManager(){

    }

    public void Start(){
    
        string menu = "";
        

        while (menu != "6"){
            Console.WriteLine();

            DisplayPlayerInfo();

            Console.WriteLine("Menu Option:\n  1. Create New Goal\n  2. List Goals\n" +  
            "  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select your option from the menu: ");
            menu = Console.ReadLine();

            if (menu == "1"){

                CreateGoal();

            }else if (menu == "2"){

                ListGoalDetails();

            }else if (menu == "3"){

                SaveGoals();

            }else if (menu == "4"){

                LoadGoals();

            }else if (menu == "5"){

                RecordEvent();

            }else{

                if (menu != "6"){
                    
                    Console.WriteLine("\n------Enter a valid menu option!------\n");
                }
            }
        }
        
    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"You have {_scores} points.\n");
    }

    public void ListGoalNames(){
        Console.WriteLine();
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++){
            Goal goal = _goals[i];
            int indexNum = i + 1;
            Console.WriteLine($"{indexNum}. {goal.GetGoalName()}");
        }
        Console.WriteLine();
    }

    
    public void ListGoalDetails(){
        
        Console.WriteLine("\nThe Goals are:");
        for (int i = 0; i < _goals.Count; i++){
            Goal theGoal = _goals[i];
            bool isComplete = theGoal.IsComplete();
            int num = i + 1;
            if (isComplete == true){
                _checkBox = "[X]";
                Console.WriteLine($"{num}. {_checkBox} {theGoal.GetDetailsString()}");
            }else {
                _checkBox = "[ ]";
                Console.WriteLine($"{num}. {_checkBox} {theGoal.GetDetailsString()}");
            }
        }
    }

    public void CreateGoal(){
        Console.WriteLine($"The types of Goals are:\n  1. Simple Goals\n  2. Eternal Goals\n  3. Check List Goals\n");
        Console.Write("Which type of Goal Would you like to create?: ");
        string respond = Console.ReadLine();

        if (respond == "1"){
            Console.Write("What is the name of the Goal?: ");
            string name = Console.ReadLine();

            Console.Write("Give a short description of the Goal?: ");
            string descrip = Console.ReadLine();

            Console.Write("What is the amount of points associated with this Goal?: ");
            string point = Console.ReadLine();

            SimpleGoal simpleGoal = new(name, descrip, point);
            _goals.Add(simpleGoal);

        }else if (respond == "2"){
            Console.Write("What is the name of the Goal?: ");
            string name = Console.ReadLine();

            Console.Write("Give a short description of the Goal?: ");
            string descrip = Console.ReadLine();

            Console.Write("What is the amount of points associated with this Goal?: ");
            string point = Console.ReadLine();

            EternalGoal eternalGoal = new(name, descrip, point);
            _goals.Add(eternalGoal);

        }else if (respond == "3"){
            Console.Write("What is the name of the Goal?: ");
            string name = Console.ReadLine();

            Console.Write("Give a short description of the Goal?: ");
            string descrip = Console.ReadLine();

            Console.Write("What is the amount of points associated with this Goal?: ");
            string point = Console.ReadLine();

            Console.Write("What is your target for this Goal?: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus point for completing this Goal?: ");
            int bonus = int.Parse(Console.ReadLine());

            CheckListGoal checkListlGoal = new(name, descrip, point, target, bonus);
            _goals.Add(checkListlGoal);

        }else{
            Console.WriteLine("------ Invalid goal type! ------");
        }
    }

    public void RecordEvent(){

        ListGoalNames();

        Console.Write("What goal did you accomplish?: ");
        int record = int.Parse(Console.ReadLine());
        int recordIndex = record - 1;
        Goal theAccomplishGoal = _goals[recordIndex];
        
        theAccomplishGoal.RecordEvent();

        int theScore = theAccomplishGoal.ReturnScore();
        _scores = _scores + theScore;
        theAccomplishGoal.ClearScoring();

    }

    public void SaveGoals(){

        Console.Write("\nWhat is the file name?: ");
        string fileName = Console.ReadLine() + ".txt";

        using (StreamWriter saveGoal = new StreamWriter(fileName)){
            saveGoal.WriteLine(_scores);
            foreach(Goal goal in _goals){
                string GoalRep = goal.GetStringRepresentation();
                saveGoal.WriteLine(GoalRep);
            }
        }
        Console.WriteLine("\n------Your Goals are save!------");

    }

    public void LoadGoals(){

        Console.Write("\nWhat is the file name?: ");
        string fileName = Console.ReadLine() + ".txt";
        _goals.Clear();

        if (File.Exists(fileName)){
            string[] lines = System.IO.File.ReadAllLines(fileName);

            for (int i = 0; i < lines.Length; i++){
                if (i < 1){
                    _scores = int.Parse(lines[i]);
                }else {

                    string[] parts = lines[i].Split("~~");
                    string goalType = parts[0];
                    string name = parts[1];
                    string desc = parts[2];
                    string point = parts[3];

                    if (goalType == "SimpleGoal"){
                        bool isComplete = bool.Parse(parts[4]);
                        SimpleGoal newSimpleGoal = new(name, desc, point, isComplete);
                        _goals.Add(newSimpleGoal);

                    }else if (goalType == "EternalGoal"){

                        int accomp = int.Parse(parts[4]);
                        EternalGoal newEternalGoal = new(name, desc, point, accomp);
                        _goals.Add(newEternalGoal);

                    }else if (goalType == "CheckListGoal"){

                        int bonus = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int amountCompleted = int.Parse(parts[6]);

                        CheckListGoal newCheckListGoal = new(name, desc, point, target, bonus, amountCompleted);
                        _goals.Add(newCheckListGoal);
                    }
                }


            }

            Console.WriteLine("\n------Your goals are loaded!------\n");

        }else {
            Console.WriteLine($"\nOoop! It looks like this {fileName} file does not exist.\n");
        }

    }

}