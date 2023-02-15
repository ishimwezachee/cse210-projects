using System;

class Reference{
    // private attributes 
    private string _book;
    private int _chapter;
    private int _verse;

    private int _startVerse;
    private int _endVerse;
  
    // public properties sample (getter and setters )
     public string Book{
        get {return _book;}
        set {_book = value;}
     }


     public int Chapter{
        get {return _chapter;}
        set {_chapter = value;}
     }

        public int StartVerse{
        get {return _startVerse;}
        set {_startVerse = value;}
     }

     public int EndVerse{
        get {return _endVerse;}
        set {_endVerse = value;}
     }

     public int Verse{
        get {return _verse;}
        set {_verse = value;}
     }

    // class constructors 
     public Reference(string book, int chapter,int verse){
         _book = book;
         _chapter = chapter;
         _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse,int endVerse){
         _book = book;
         _chapter = chapter;
         _startVerse = startVerse;
         _endVerse  = endVerse;
    }
    // Methods/behavours 
    
    // Will display the texts in the format we will expect. 
    public void getReferenceText(){
      //   Console.WriteLine("John 3:16");
    }

}