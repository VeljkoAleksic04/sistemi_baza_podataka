using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Entiteti
{
    public class Fajl
    {
        public virtual int Id { get; set; }

        public virtual Verzija Verzija { get; set; }
        public virtual string Putanja { get; set; } // ne moze da se zove FAJL kao u bazi jer je to ime klase
    }
}
