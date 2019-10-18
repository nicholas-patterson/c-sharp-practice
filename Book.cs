using System;

namespace myApp
{
    class Book
    {
        // members or fields
        public string title;
        public string author;
        public int pages;



        // Constructor
        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }
    }
}