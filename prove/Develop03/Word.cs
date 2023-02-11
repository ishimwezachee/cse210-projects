using System;

// The purpose of this class is to to show or hide a word

class Word{
    // attributes 
    private bool _isHidden;

    private string _text; // this a string which will be considered as an array 
    // class constructors 
    public Word(){
        _text = "If my people who are called by My name humble themselves, and pray and seek My face and turn from their wicked ways, then I will hear from heaven and will forgive their sin and heal their land. then I will hear from heaven and will forgive their sin and heal their land.";
    }
    // Methods 
    //  public string Text
    // {
    //     get { return _text; }
    //     set { _text = value; }
    // }
public String getDisplayText(){
   return _text;
   //  It will return either House or ____
}
// method to show or hide a workd 
public void hideWord(string word){
 word = "----";
}
public void showWord(string word){
  Console.WriteLine(word);
}
  public bool isHidden(){
        // check if a word is hidden or not
        return _isHidden;
    }
}