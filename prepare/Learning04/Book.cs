using System;

namespace library_demo
{

    public class Book 
    {
    protected string _author;
    protected string _title;

    // constructors 
    public Book()
    {
        _author = "Anonymous";
        _title  = "Unknown";
    }

    public Book(string author, string title)
    {
        _author = author;
        _title = title;
    }

    // crate getters and setters 

    public string getAuthor()
    {
        return _author;
    }

    public void setAuthor(string author)
    {
        _author = author;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void setTitle(string title)
    {
      _title = title;
    }

    public string GetBookInfo()
    {
        return $"{_title} by {_author}";
    }
    }

}

