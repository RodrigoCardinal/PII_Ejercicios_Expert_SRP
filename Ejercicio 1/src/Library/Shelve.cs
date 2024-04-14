using System;
using System.Collections.Generic;


namespace Ucu.Poo.Expert

{
    public class  Shelve
    {

        public string LibraryShelve { get; set; }
        public List<Book> bookInShelve = new List<Book>();

        public Shelve(String shelve)
        {
            this.LibraryShelve = shelve;
        }

        public void AddBookToShelve(Book book)
        {
            bookInShelve.Add(book);
        }

        public override string ToString()
        {
            return $"Estantería {this.LibraryShelve} contiene el libro: {String.Join("", bookInShelve)}";
        }
    }
}