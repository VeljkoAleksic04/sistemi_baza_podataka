using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.Entiteti
{
    // ako treba?
    //public enum StatusPublikacije 
    //{
    //    UPripremi,
    //    PoslatNaRecenziju,
    //    UReviziji,
    //    Prihvacen,
    //    Odbijen,
    //    Objavljen,
    //    Arhiviran
    //} 

    internal class Publikacija
    {
        internal protected virtual int Id { get; set; }


        internal protected virtual string Naslov { get; set; }

        internal protected virtual string Apstrakt { get; set; }

        internal protected virtual string Jezik { get; set; }

        internal protected virtual DateTime DatumObjavljivanja { get; set; }

        internal protected virtual DateTime DatumKreiranjaZapisa { get; set; }

        internal protected virtual string Status { get; set; }

        internal protected virtual string Vidljivost { get; set; }


        internal protected virtual IList<Verzija> Verzije { get; set; }
        internal protected virtual IList<PublikacijaKljucnaRec> KljucneReci { get; set; }


        internal Publikacija()
        {
            Verzije = new List<Verzija>();
            KljucneReci = new List<PublikacijaKljucnaRec>();
        }
    }

    internal class DoktorskaDisertacija : Publikacija { }
    internal class ObrazovniMaterijal : Publikacija { }
    internal class Prezentacija : Publikacija { }
    internal class TehnickiIzvestaj : Publikacija { }

}
