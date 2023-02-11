using System;

// The purpose of this class is to to show or hide a word

class Word{
    // attributes 
    private bool _isHidden;

    private string _text; // this a string which will be considered as an array 
    // class constructors 
    public Word(){
        _text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Adipiscing enim eu turpis egestas pretium aenean pharetra magna ac.";
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