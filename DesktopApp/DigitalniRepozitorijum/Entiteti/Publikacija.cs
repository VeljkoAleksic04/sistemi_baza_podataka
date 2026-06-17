using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Entiteti
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

    public class Publikacija
    {
        public virtual int Id { get; set; }


        public virtual string Naslov { get; set; }

        public virtual string Apstrakt { get; set; }

        public virtual string Jezik { get; set; }

        public virtual DateTime DatumObjavljivanja { get; set; }

        public virtual DateTime DatumKreiranjaZapisa { get; set; }

        public virtual string Status { get; set; }

        public virtual string Vidljivost { get; set; }


        public virtual IList<Verzija> Verzije { get; set; }
        public virtual IList<PublikacijaKljucnaRec> KljucneReci { get; set; }


        public Publikacija()
        {
            Verzije = new List<Verzija>();
            KljucneReci = new List<PublikacijaKljucnaRec>();
        }
    }

    public class DoktorskaDisertacija : Publikacija { }
    public class ObrazovniMaterijal : Publikacija { }
    public class Prezentacija : Publikacija { }
    public class TehnickiIzvestaj : Publikacija { }

}
