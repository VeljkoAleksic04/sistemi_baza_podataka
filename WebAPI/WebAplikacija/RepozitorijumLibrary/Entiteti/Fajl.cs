using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.Entiteti
{
    internal class Fajl
    {
        internal protected virtual int Id { get; set; }

        internal protected virtual Verzija Verzija { get; set; }
        internal protected virtual string Putanja { get; set; } // ne moze da se zove FAJL kao u bazi jer je to ime klase
    }
}
