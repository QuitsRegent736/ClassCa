using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCa
{
    class Book
    {
        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Published { get; set; }
        public string Genre { get; set; }

        //constructors
        public Book(string title, string author, string genre, int pages, int published)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Pages = pages;
            Published = published;
        }

        // ToString()
        public override string ToString()
        {
            return string.Format("Title: {0} Author: {1} Pages: {3} Genre: {4} Published: {5} ",
                Title, Author, Pages, Genre, Published);
                
        }

    }
}
