using System;

class Scripture{
    // attributes 
    // It means that _reference is an instance of Reference class. 
    //  Journal j = new Journal();
    // string verse = "If my people who are called by My name humble themselves, and pray and seek My face and turn from their wicked ways, then I will hear from heaven and will forgive their sin and heal their land.";

    //  Words = new List<Word>();
    private Reference _reference;
    private List<string> _words = new List<string>();    
    // private List<Word> _words = new List<Word>();
    // class constructors 
    // public Scripture(Reference reference,string text){}
    // Methods 

    // Number of words to be hidden 
    public void HideWords(string input){
         Word word = new Word();
        //  An array of words 
          _words = word.getDisplayText().Split(' ').ToList();
        // _words = word.getDisplayWord().Split(' ');
        // foreach(string text in _words){
        //     Console.WriteLine(_words.Count);
        //   }
        // the true will be replace with the one from the method. 
        while(true & input != "quit"){
              {
                //Console.WriteLine("Press Enter to hide the next two words...");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter){
                    // string[] words = input.Split(' ');
                    // pick a three random words form my list 
                    Random rnd = new Random();
                    int randomIndex1 = rnd.Next(_words.Count);
                    int randomIndex2 = rnd.Next(_words.Count);
                    int randomIndex3 = rnd.Next(_words.Count);
                    string hiddenWord1 = _words[randomIndex1];
                    string hiddenWord2 = _words[randomIndex2];
                    string hiddenWord3 = _words[randomIndex3];
                    Console.WriteLine(hiddenWord1);
                    Console.WriteLine(hiddenWord2);
                    Console.WriteLine(hiddenWord3);

                    for (int i = 0; i < _words.Count; i++){
                    //     for(int j =0;j <_words[i].Length;j++){
                    //         char charactor = _words[i][j];
                    //        Console.WriteLine($"{j}:{charactor}");
                    Console.WriteLine(_words[i]);
                    string currentWord = _words[i];
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
                    Console.WriteLine(_words[i]);
                    }
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