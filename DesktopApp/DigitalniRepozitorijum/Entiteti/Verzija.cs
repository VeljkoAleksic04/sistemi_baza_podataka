using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Entiteti
{
    public class Verzija
    {
        public virtual int Id { get; set; }
        public virtual int BrojVerzije { get; set; }

        public virtual Publikacija Publikacija { get; set; }
        public virtual DateTime DatumPostavljanja { get; set; }

        public virtual string OpisIzmene { get; set; }

        public virtual string OdgovornaOsoba { get; set; }


        public virtual IList<Fajl> Fajlovi { get; set; }

        public Verzija()
        {
            Fajlovi = new List<Fajl>();
        }
    }
}
