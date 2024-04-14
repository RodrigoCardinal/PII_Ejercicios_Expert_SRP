using System;
using System.Collections.Generic;
namespace Ucu.Poo.Expert
{
    public class Sector
    {
        public string LibrarySector { get; set; }
        public List<Shelve> shelveInSector = new List<Shelve>();

        public Sector(String sector)
        {
            this.LibrarySector = sector;
        }

        public void AddShelveToSector(Shelve shelve)
        {
            shelveInSector.Add(shelve);
        }

        public override string ToString()
        {
            return $"Estantería {this.LibrarySector} contiene {String.Join("", shelveInSector)}";
        }
    }
}