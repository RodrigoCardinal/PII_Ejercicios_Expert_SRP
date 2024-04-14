using System;
using System.Collections.Generic;

namespace Ucu.Poo.Expert
{

    public class Program
    {
        public static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            
            Shelve shelve1 = new Shelve("A");
            Shelve shelve2 = new Shelve("B");

            Sector sector1 = new Sector("7");
            sector1.AddShelveToSector(shelve1);
            shelve1.AddBookToShelve(book1);

            
            Sector sector2 = new Sector("8");
            sector2.AddShelveToSector(shelve2);
            shelve2.AddBookToShelve(book2);

            Console.WriteLine(shelve1);
            Console.WriteLine(shelve2);


            
            //book1.ShelveBook("A","7");
            //book2.ShelveBook("B","3");

        }
    }
}

/*Todo el código cumple con el principio de SRP ya que cada clase tiene una responsabilidad única.
-La clase Book se encarga de lo libros.
-La clase Shelve se encarga de las estanterias.
-La clase Sector se encarga de los sectores. 
*/