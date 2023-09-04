using System;
using System.Collections.Generic;

/*
El código ahora cumple con el princpio SRP ya que cada clase tiene una responsabilidad única. 
Libro se encarga de los libros, Shelve de los estantes y Sector de los sectores. 
Todo está encapsulado, de esta forma los libros se crean en la Clase Libro, luego se guardan en una estantería en la clase Shelve.
Por último, las estanterías son puestas en sectores en la clase Sector. 
*/

namespace SRP
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