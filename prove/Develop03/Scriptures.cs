using System;
using System.Collections.Generic;

class Scripture {
  // attributes 
  Reference reference = new Reference("John", 3, 17, 18);
  private List < string > _words = new List < string > ();
  // private List<Word> _words = new List<Word>();
  // Methods 
  // Load from a file 
  public string LoadFromFile() {
    string filename = "script.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);
    string fileData = "";

    foreach(string line in lines) {
      fileData += line + Environment.NewLine;
    }
    return fileData;
  }
  // Number of words to be hidden 
  public void HideWords() {
    Word word = new Word();
    //  An array of words 
    _words = word.getDisplayText().Split(' ').ToList();
    Console.WriteLine($"{reference.Book} {reference.Chapter}:{reference.StartVerse} - {reference.EndVerse} {LoadFromFile()}");
    while (true) {
      string input = Console.ReadLine();
      ConsoleKeyInfo keyInfo = Console.ReadKey();
      if (keyInfo.Key == ConsoleKey.Enter && input != "quit") {
        Random rnd = new Random();
        int randomIndex1 = rnd.Next(_words.Count);
        int randomIndex2 = rnd.Next(_words.Count);
        int randomIndex3 = rnd.Next(_words.Count);
        string hiddenWord1 = _words[randomIndex1];
        string hiddenWord2 = _words[randomIndex2];
        string hiddenWord3 = _words[randomIndex3];
        Console.Clear();
        for (int i = 0; i < _words.Count; i++) {


          if (_words[i] == hiddenWord1) {
            int len = _words[i].Length;
            string hiddenWord = new string('_', len);
            _words[i] = _words[i].Replace(_words[i], hiddenWord);
          }

          if (_words[i] == hiddenWord2) {
            int len = _words[i].Length;
            string hiddenWord = new string('_', len);
            _words[i] = _words[i].Replace(_words[i], hiddenWord);
          }

          if (_words[i] == hiddenWord3) {
            int len = _words[i].Length;
            string hiddenWord = new string('_', len);
            _words[i] = _words[i].Replace(_words[i], hiddenWord);
          }
          Console.Write(_words[i] + " ");
        }

        }else if (input == "quit"){
        Console.WriteLine("The program is done");
        return;
      }

       if (input =="" && _words.All(s => s.All(c=>c=='_'))){
          Console.WriteLine("All words are hidden");
          return;
        }

    }

  }

  // Render the text of the descripture with reference at the beginning 
  public void GetDisplayText() {
    // Console.WriteLine(verse);
  }

  public bool isCompletelyHidden() {
    // if there is no word in our list, then time to stop the program. 
    return true;
  }

}