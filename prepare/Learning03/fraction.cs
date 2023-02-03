class Fractions{
    // create private attributes 
    private int _top;
    private int _bottom;
   // create constructors 
    public Fractions(){
        _top = 1;
        _bottom =1;
    }

    public Fractions(int top){
        _top = top;
        _bottom = 1;
    }

    public Fractions(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }
    // create getter and setters 
    public int GetTopNumber(){
       return _top;
    }

    public void setTop(int top){
        _top = top;
    }

     public int GetBottomNumber(){
       return _bottom;
    }

    public void setBottom(int bottom){
        _bottom = bottom;
    }

    public string GetFractionString(int top, int bottom){
        return $"{top}/{bottom}";
    }


}