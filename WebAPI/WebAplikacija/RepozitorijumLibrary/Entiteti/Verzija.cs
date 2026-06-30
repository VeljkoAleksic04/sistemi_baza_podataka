using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.Entiteti
{
    internal class Verzija
    {
        internal protected virtual int Id { get; set; }
        internal protected virtual int BrojVerzije { get; set; }
        internal protected virtual Publikacija Publikacija { get; set; }
        internal protected virtual DateTime DatumPostavljanja { get; set; }
        internal protected virtual string OpisIzmene { get; set; }
        internal protected virtual string OdgovornaOsoba { get; set; }
        
        internal protected virtual IList<Fajl> Fajlovi { get; set; }

        internal Verzija()
        {
            Fajlovi = new List<Fajl>();
        }
    }
}
