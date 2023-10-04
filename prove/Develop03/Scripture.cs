public class Scripture
{
    private List<Words> _wordList = new List<Words>();
   
    private List<Reference> _reference = new();
    private List<string> _scriptureText = new();
    private List<string> _wordsTextList = new List<string>();
    private string _fileName = "Matthew 5.txt";
    private string _userFileName;

    private List<int> _compare = new();

    private  List<string> _removeWord = new();

    public void DisplayScrip(int scriptIndex)
    {
        
        MakeWord(scriptIndex);
        SetDisplayTextList();
        Display(scriptIndex);
    }
    public void AddPersonalScripture()
    {
        _scriptureText.Clear();
        _reference.Clear();
        Console.Write("Enter the book name: ");
        string book = Console.ReadLine();
        Console.Write("Enter the chapter: ");
        int chapter = int.Parse(Console.ReadLine());
        Console.Write("Enter the verse, or Start Verse: ");
        int startVerse = int.Parse(Console.ReadLine());
        Console.Write("Enter the end verse, or click enter if it is just a verse: ");
        string endVerse = Console.ReadLine();
        if (endVerse == ""){
            Reference scriptureSingleRef = new(book, chapter, startVerse);
            _reference.Add(scriptureSingleRef);

        }else {
            int lastVerse = int.Parse(endVerse);
            Reference scriptureDoubleRef = new(book, chapter, startVerse, lastVerse);
            _reference.Add(scriptureDoubleRef);
        }

        Console.Write("Enter the verse text: ");
        string scriptWords = Console.ReadLine();
        _scriptureText.Add(scriptWords);
        

        Console.Write("Do you want to save this scripture (yes or no)?: ");
        string save = Console.ReadLine();
        if (save == "yes")
        {
            Console.Write("Enter a file name: ");
            _userFileName = Console.ReadLine();
            SaveScripture();

        }
    }

    public void SaveScripture() {
        for ( int i = 0; i < _reference.Count; i++){
            Reference eachRef = _reference[i];
            string eachText = _scriptureText[i];
            string refer = eachRef.GetRefer();
            using (StreamWriter scriptureFile = new StreamWriter(_userFileName))
            {
                scriptureFile.WriteLine($"{refer}#{eachText}");
            }
        }
        Console.WriteLine("Your scripture has been saved.");      
    }

    public void Load()
    {
        Console.Write("Enter a file name: ");
        _userFileName = Console.ReadLine();
        _wordList.Clear();
        if (File.Exists(_userFileName))
        {
            string[] lines = File.ReadAllLines(_userFileName);
            foreach (string line in lines)
            {
                string[] newLine = line.Split("#");
                if (newLine.Length == 4){
                    string book = newLine[0];
                    int chapter = int.Parse(newLine[1]);
                    int firstVerse = int.Parse(newLine[2]);
                    string scriptureWords = newLine[3];
                    Reference newRef = new(book, chapter, firstVerse);
                    _reference.Add(newRef);
                    _scriptureText.Add(scriptureWords);

                }else if (newLine.Length == 5){
                    string book = newLine[0];
                    int chapter = int.Parse(newLine[1]);
                    int firstVerse = int.Parse(newLine[2]);
                    int lastVerse = int.Parse(newLine[3]);
                    string scriptureWords = newLine[4];
                    Reference newRef = new(book, chapter, firstVerse, lastVerse);
                    _reference.Add(newRef);
                    _scriptureText.Add(scriptureWords);
                }
                Console.WriteLine("Your scripture has been loaded.");
            }
        }
        else
        {
            Console.WriteLine("Oops! It looks like there is no such file");
        }
        
    }
    public void Matthew()
    {
        _reference.Clear();
        _scriptureText.Clear();
        string[] mattLines = File.ReadAllLines(_fileName);
        foreach (string line in mattLines)
        {
            string[] mattParts = line.Split("#");
            string book = mattParts[0];
            int chapter = int.Parse(mattParts[1]);
            int firstVerse = int.Parse(mattParts[2]);
            string scriptureWords = mattParts[3];
            Reference newRef = new(book, chapter, firstVerse);
            _reference.Add(newRef);
            _scriptureText.Add(scriptureWords);
        }
    }
    public int RandomIndex()
    {
        Random rnd = new Random();
        int index = rnd.Next(_scriptureText.Count);
        return index;
    }

    public int RandomToHide(int count){
        
        Random r = new();

        int random1 = r.Next(count);

        return random1;
    }

    private void MakeWord(int ranNum){
        
        string theText = _scriptureText[ranNum];
        string[] textPart = theText.Split(" ");

        for(int i = 0; i < textPart.Length; i++){
            Words newWord = new(textPart[i]);
            _wordList.Add(newWord);
        }
    }

    public int GetWordTextCount(){
    
        return _wordsTextList.Count;
    }
    public int GetRemoveTextCount(){
    
        return _compare.Count;
    }

    private void SetDisplayTextList(){
        _wordsTextList.Clear();

        foreach (Words word in _wordList){

            string texts = word.GetStringWord();
            _wordsTextList.Add(texts);
        }
        _wordList.Clear();
        

    }
    public void Display(int ranIndex){
        Reference disRef = _reference[ranIndex];
        string disWords = String.Join(" ", _wordsTextList);
        Console.WriteLine($"{disRef.DisplayRefer()} {disWords}");
    }
    public void HideScriptureWords(int refRan){
        Words hideInstance = new();
        int indexRange = _wordsTextList.Count;
        for (int j = 0; j < 3; j++){

            int random = RandomToHide(indexRange);

            while (_compare.Contains(random) && _compare.Count < _wordsTextList.Count){
                random = RandomToHide(indexRange);

            }
            for (int i = 0; i < _wordsTextList.Count; i++){

                string hiddenWord = _wordsTextList[i];

                if (random == i){

                    if (hiddenWord != ""){
                        _removeWord.Add(hiddenWord);
                        string thehideWord = hideInstance.HideWord(hiddenWord);
                        _wordsTextList.RemoveAt(i);
                        _wordsTextList.Insert(i, thehideWord);                
                    }else {
                        _wordsTextList.Remove(hiddenWord);
                    }
                    _compare.Add(random);
                }
            }
        }
        
        Display(refRan);
    }
    

}