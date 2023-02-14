using System;

// The purpose of this class is to to show or hide a word

class Word{
    // attributes 
    private bool _isHidden;

    private string _text; // this a string which will be considered as an array 
    // class constructors 
    public Word(){
        _text = "For God did not send his Son into the world to condemn the world, but to save the world through him. Whoever believes in him is not condemned, but whoever does not believe stands condemned already because they have not believed in the name of God's one and only Son.";
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