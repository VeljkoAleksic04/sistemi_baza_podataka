using DigitalniRepozitorijum.Entiteti;
using DigitalniRepozitorijum.Forme;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum
{
    #region Publikacija
    public class PublikacijaPregled
    {
        public int Id;
        public string Naslov;
        public string Jezik;
        public string Status;
        public string Vidljivost;
        public DateTime DatumObjavljivanja;

        public PublikacijaPregled() { }

        public PublikacijaPregled(int id, string naslov, string jezik, string status, string vidljivost, DateTime datumObjavljivanja)
        {
            Id = id;
            Naslov = naslov;
            Jezik = jezik;
            Status = status;
            Vidljivost = vidljivost;
            DatumObjavljivanja = datumObjavljivanja;
        }
    }
    public class PublikacijaBasic
    {
        public int Id;
        public string Naslov;
        public string Apstrakt;
        public string Jezik;
        public string Status;
        public string Vidljivost;
        public DateTime DatumObjavljivanja;
        public DateTime DatumKreiranjaZapisa;

        // public IList<VerzijaBasic> Verzije { get; set; }
        // public IList<PublikacijaKljucnaRecBasic> KljucneReci {  get; set; }

        public PublikacijaBasic() 
        {
            //Verzije = new List<VerzijaBasic>();
            //KljucneReci = new List<PublikacijaKljucnaRecBasic>();
        }

        public PublikacijaBasic(int id, string naslov, string apstrakt, string jezik, string status, string vidljivost, DateTime datumObjavljivanja, DateTime datumKreiranjaZapisa)
        {
            Id = id;
            Naslov = naslov;
            Apstrakt = apstrakt;
            Jezik = jezik;
            Status = status;
            Vidljivost = vidljivost;
            DatumObjavljivanja = datumObjavljivanja;
            DatumKreiranjaZapisa = datumKreiranjaZapisa;
        }
    }
    
    #endregion


}
