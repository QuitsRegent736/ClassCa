using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCa
{
    class Progarm
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Ulysses", "James joyce", "Literature", 730, 02 / 02 / 1922);
            Book b2 = new Book("The C progarmming Language", "D ritche", "computing", 279, 28 / 02 / 1978);
            Book b3 = new Book("Walter Isaacson", "Steve Jobs", "Biography", 627, 24 / 10 / 2011);
            Book b4 = new Book("The Hobbit", "Jrr Tolkien", "Fiiction", 310, 21 / 09 / 1937);
            Book b5 = new Book("Portrait of the artist", "James joyce", "Literature", 299, 29 / 12 / 1916);

            Book[] allBooks = new Book[5];
            allBooks [0] = b1;
            allBooks[1] = b2;
            allBooks[2] = b3;
            allBooks[3] = b4;
            allBooks[4] = b5;








            string fiction;
            string Biography;
            string Computing;
            string Literature;
        }

        static void DisplayBooks(Book[] allBooks)
        {
            
        }
    }
}
