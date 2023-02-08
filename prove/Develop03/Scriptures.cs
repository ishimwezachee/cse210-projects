using System;

class Scripture{
    // attributes 
    // It means that _reference is an instance of Reference class. 
    private Reference _reference;
    // private List<string> _words = new List<string>();
    private List<Word> _words = new List<Word>();
    // class constructors 
    public Scripture(Reference reference,string text){

    }
    // Methods 

    // Number of words to be hidden 
    public void HideWords(int number){}

    // Render the text of the descripture with reference at the beginning 
    public void GetDisplayText(){}
    
    public bool isCompletelyHidden(){
        // if there is no word in our list, then time to stop the program. 
        return true;
    }


}