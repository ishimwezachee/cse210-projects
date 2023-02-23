using System;


namespace library_demo
{
    public class PictureBook: Book
    {
        // attributes 
        private string _illustrator;
        // constructors 

        public PictureBook():base()
        {
            
        }

        public PictureBook(string author, string title, string illustrator) : base(author,title)
        {
            _illustrator = illustrator;
        }

        public string GetIllustrator()
        {
            return _illustrator;
        }

        public void setIllustrator(string illustrator)
        {
            _illustrator = illustrator;
        }
        public string GetPictureBookInfo()
        {
            return $"{_title} by {_author} illustrated by {_illustrator}";
        }
    }
}