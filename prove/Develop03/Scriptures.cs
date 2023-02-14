using System;

class Scripture{
    // attributes 
    // It means that _reference is an instance of Reference class. 
    //  Journal j = new Journal();
    // string verse = "If my people who are called by My name humble themselves, and pray and seek My face and turn from their wicked ways, then I will hear from heaven and will forgive their sin and heal their land.";
    private Reference _reference;
    private List<string> _words = new List<string>();    
    // private List<Word> _words = new List<Word>();
    // class constructors 
    // public Scripture(Reference reference,string text){}
    // Methods 

    // Load from a file 
public string LoadFromFile()
{
    string filename = "script.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);
    string fileData = "";

    foreach (string line in lines)
    {
        fileData += line + Environment.NewLine;
    }

    return fileData;
}
    // Number of words to be hidden 
    public void HideWords(){
         Word word = new Word();
        //  An array of words 
          _words = word.getDisplayText().Split(' ').ToList();
        string result = String.Join(" ",_words);
        // Console.WriteLine("For God did not send his Son into the world to condemn the world, but to save the world through him. Whoever believes in him is not condemned, but whoever does not believe stands condemned already because they have not believed in the name of God's one and only Son.");
        Console.WriteLine(LoadFromFile());
        while(true){
        string input = Console.ReadLine();
              {
                 ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter && input != "quit"){
                    // Console.Clear();
                    // pick a three random words form my list 
                    Random rnd = new Random();
                    int randomIndex1 = rnd.Next(_words.Count);
                    int randomIndex2 = rnd.Next(_words.Count);
                    int randomIndex3 = rnd.Next(_words.Count);
                    string hiddenWord1 = _words[randomIndex1];
                    string hiddenWord2 = _words[randomIndex2];
                    string hiddenWord3 = _words[randomIndex3];
                     Console.Clear();
                    for (int i = 0; i < _words.Count; i++){
                       
                    if(_words[i] == hiddenWord1){
                       int len = _words[i].Length;
                        string hiddenWord = new string('_',len);
                        _words[i] = _words[i].Replace(_words[i],hiddenWord);
                    }
                    
                    if(_words[i] == hiddenWord2){
                       int len = _words[i].Length;
                        string hiddenWord = new string('_',len);
                        _words[i] = _words[i].Replace(_words[i],hiddenWord);
                    }
                    if(_words[i] == hiddenWord3){
                       int len = _words[i].Length;
                        string hiddenWord = new string('_',len);
                        _words[i] = _words[i].Replace(_words[i],hiddenWord);
                    } 
                    
                    // string [] words = new string[_words.Count];
                    // List<string> words = _words.ToList();
                    // _words.CopyTo(words,0);
                    // words[i] = _words[i];
                    // words.Add(_words[i]);
                    // int siz = words.Count;
                    // if(siz>0){
                        // Console.Clear();
                    // }
                    
                    Console.Write(_words[i] + " ");
                    // Console.Clear();
                    // _words.Clear();
                    }
                    }
                    else 
                    {
                    Console.WriteLine("The program is done");
                    return;
                }

                }
                
        }
    }

    // Render the text of the descripture with reference at the beginning 
    public void GetDisplayText(){
        // Console.WriteLine(verse);
    }
    
    public bool isCompletelyHidden(){
        // if there is no word in our list, then time to stop the program. 
        return true;
    }


}