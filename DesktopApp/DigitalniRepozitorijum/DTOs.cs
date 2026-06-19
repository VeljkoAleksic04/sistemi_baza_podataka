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

        public IList<VerzijaBasic> Verzije { get; set; }
        public IList<PublikacijaKljucnaRecBasic> KljucneReci {  get; set; }

        public PublikacijaBasic() 
        {
            Verzije = new List<VerzijaBasic>();
            KljucneReci = new List<PublikacijaKljucnaRecBasic>();
        }

        public PublikacijaBasic(int id, string naslov, string apstrakt, string jezik, string status, string vidljivost, DateTime datumObjavljivanja, DateTime datumKreiranjaZapisa) : this()
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

    public class DoktorskaDisertacijaPregled : PublikacijaPregled
    {
        public DoktorskaDisertacijaPregled() { }
        public DoktorskaDisertacijaPregled(int id, string naslov, string jezik, string status, string vidljivost, DateTime datumObjavljivanja)
            : base(id, naslov, jezik, status, vidljivost, datumObjavljivanja) { }
    }

    public class DoktorskaDisertacijaBasic : PublikacijaBasic
    {
        public DoktorskaDisertacijaBasic() { }
        public DoktorskaDisertacijaBasic(int id, string naslov, string apstrakt, string jezik, string status, string vidljivost, DateTime datumObjavljivanja, DateTime datumKreiranjaZapisa)
            : base(id, naslov, apstrakt, jezik, status, vidljivost, datumObjavljivanja, datumKreiranjaZapisa) { }
    }

    public class ObrazovniMaterijalPregled : PublikacijaPregled
    {
        public ObrazovniMaterijalPregled() { }
        public ObrazovniMaterijalPregled(int id, string naslov, string jezik, string status, string vidljivost, DateTime datumObjavljivanja)
            : base(id, naslov, jezik, status, vidljivost, datumObjavljivanja) { }
    }

    public class ObrazovniMaterijalBasic : PublikacijaBasic
    {
        public ObrazovniMaterijalBasic() { }
        public ObrazovniMaterijalBasic(int id, string naslov, string apstrakt, string jezik, string status, string vidljivost, DateTime datumObjavljivanja, DateTime datumKreiranjaZapisa)
            : base(id, naslov, apstrakt, jezik, status, vidljivost, datumObjavljivanja, datumKreiranjaZapisa) { }
    }

    public class PrezentacijaPregled : PublikacijaPregled
    {
        public PrezentacijaPregled() { }
        public PrezentacijaPregled(int id, string naslov, string jezik, string status, string vidljivost, DateTime datumObjavljivanja)
            : base(id, naslov, jezik, status, vidljivost, datumObjavljivanja) { }
    }

    public class PrezentacijaBasic : PublikacijaBasic
    {
        public PrezentacijaBasic() { }
        public PrezentacijaBasic(int id, string naslov, string apstrakt, string jezik, string status, string vidljivost, DateTime datumObjavljivanja, DateTime datumKreiranjaZapisa)
            : base(id, naslov, apstrakt, jezik, status, vidljivost, datumObjavljivanja, datumKreiranjaZapisa) { }
    }

    public class TehnickiIzvestajPregled : PublikacijaPregled
    {
        public TehnickiIzvestajPregled() { }
        public TehnickiIzvestajPregled(int id, string naslov, string jezik, string status, string vidljivost, DateTime datumObjavljivanja)
            : base(id, naslov, jezik, status, vidljivost, datumObjavljivanja) { }
    }

    public class TehnickiIzvestajBasic : PublikacijaBasic
    {
        public TehnickiIzvestajBasic() { }
        public TehnickiIzvestajBasic(int id, string naslov, string apstrakt, string jezik, string status, string vidljivost, DateTime datumObjavljivanja, DateTime datumKreiranjaZapisa)
            : base(id, naslov, apstrakt, jezik, status, vidljivost, datumObjavljivanja, datumKreiranjaZapisa) { }
    }

    #endregion


    #region Verzija
    public class VerzijaPregled
    {
        public int Id;
        public int BrojVerzije;
        public DateTime DatumPostavljanja;
        public string OpisIzmene;
        public string OdgovornaOsoba;

        public VerzijaPregled() { }

        public VerzijaPregled(int id, int brojVerzije, DateTime datumPostavljanja, string opisIzmene, string odgovornaOsoba)
        {
            Id = id;
            BrojVerzije = brojVerzije;
            DatumPostavljanja = datumPostavljanja;
            OpisIzmene = opisIzmene;
            OdgovornaOsoba = odgovornaOsoba;
        }
    }

    public class VerzijaBasic
    {
        public int Id;
        public int BrojVerzije;
        public PublikacijaBasic Publikacija;
        public DateTime DatumPostavljanja;
        public string OpisIzmene;
        public string OdgovornaOsoba;

        public IList<FajlBasic> Fajlovi { get; set; }

        public VerzijaBasic()
        {
            Fajlovi = new List<FajlBasic>();
        }

        public VerzijaBasic(int id, int brojVerzije, PublikacijaBasic publikacija, DateTime datumPostavljanja, string opisIzmene, string odgovornaOsoba) : this()
        {
            Id = id;
            BrojVerzije = brojVerzije;
            Publikacija = publikacija;
            DatumPostavljanja = datumPostavljanja;
            OpisIzmene = opisIzmene;
            OdgovornaOsoba = odgovornaOsoba;
        }
    }
    #endregion


    #region PublikacijaKljucnaRec
    public class PublikacijaKljucnaRecPregled
    {
        public int Id;
        public string KljucnaRec;

        public PublikacijaKljucnaRecPregled() { }

        public PublikacijaKljucnaRecPregled(int id, string kljucnaRec)
        {
            Id = id;
            KljucnaRec = kljucnaRec;
        }
    }

    public class PublikacijaKljucnaRecBasic
    {
        public int Id;
        public PublikacijaBasic Publikacija;
        public string KljucnaRec;

        public PublikacijaKljucnaRecBasic() { }

        public PublikacijaKljucnaRecBasic(int id, PublikacijaBasic publikacija, string kljucnaRec) : this()
        {
            Id = id;
            Publikacija = publikacija;
            KljucnaRec = kljucnaRec;
        }
    }
    #endregion


    #region PoglavljeUKnjizi
    public class PoglavljeUKnjiziPregled : PublikacijaPregled
    {
        public string Izdavac;
        public string MestoIzdanja;

        public PoglavljeUKnjiziPregled() { }

        public PoglavljeUKnjiziPregled(int id, string naslov, string jezik, string status, string vidljivost, DateTime datumObjavljivanja, string izdavac, string mestoIzdanja)
            : base(id, naslov, jezik, status, vidljivost, datumObjavljivanja)
        {
            Izdavac = izdavac;
            MestoIzdanja = mestoIzdanja;
        }
    }

    public class PoglavljeUKnjiziBasic : PublikacijaBasic
    {
        public string Izdavac;
        public string MestoIzdanja;

        public PoglavljeUKnjiziBasic() { }

        public PoglavljeUKnjiziBasic(int id, string naslov, string apstrakt, string jezik, string status, string vidljivost, DateTime datumObjavljivanja, DateTime datumKreiranjaZapisa, string izdavac, string mestoIzdanja)
            : base(id, naslov, apstrakt, jezik, status, vidljivost, datumObjavljivanja, datumKreiranjaZapisa)
        {
            Izdavac = izdavac;
            MestoIzdanja = mestoIzdanja;
        }
    }
    #endregion


    #region Knjiga
    public class KnjigaPregled : PublikacijaPregled
    {
        public string Izdavac;
        public string MestoIzdanja;

        public KnjigaPregled() { }

        public KnjigaPregled(int id, string naslov, string jezik, string status, string vidljivost, DateTime datumObjavljivanja, string izdavac, string mestoIzdanja)
            : base(id, naslov, jezik, status, vidljivost, datumObjavljivanja)
        {
            Izdavac = izdavac;
            MestoIzdanja = mestoIzdanja;
        }
    }

    public class KnjigaBasic : PublikacijaBasic
    {
        public string Izdavac;
        public string MestoIzdanja;

        public KnjigaBasic() { }

        public KnjigaBasic(int id, string naslov, string apstrakt, string jezik, string status, string vidljivost, DateTime datumObjavljivanja, DateTime datumKreiranjaZapisa, string izdavac, string mestoIzdanja)
            : base(id, naslov, apstrakt, jezik, status, vidljivost, datumObjavljivanja, datumKreiranjaZapisa)
        {
            Izdavac = izdavac;
            MestoIzdanja = mestoIzdanja;
        }
    }
    #endregion


    #region Fajl
    public class FajlBasic
    {
        public int Id;
        public string Putanja;

        public VerzijaBasic Verzija;

        public FajlBasic() { }

        public FajlBasic(int id, string putanja, VerzijaBasic verzija)
        {
            Id = id;
            Putanja = putanja;
            Verzija = verzija;
        }
    }

    // fajl nema prikaz na formi
    #endregion


}