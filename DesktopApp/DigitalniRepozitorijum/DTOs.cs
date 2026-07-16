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

        public int ID { get { return Id; } }
        public string NASLOV { get { return Naslov; } }

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
    public class PovezanSaPregled
    {
        public int Id;
        public int IdPublikacije2;
        public string Naslov;
        public string TipPovezanosti;
        public PovezanSaPregled() { }
        public PovezanSaPregled(int id,int idPublikacije2, string naslov, string tipPovezanosti)
        {
            Id = id;
            IdPublikacije2 = idPublikacije2;
            Naslov = naslov;
            TipPovezanosti = tipPovezanosti;
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
        public IList<PublikacijaKljucnaRecBasic> KljucneReci { get; set; }

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

        public static implicit operator KnjigaBasic(Knjiga v)
        {
            throw new NotImplementedException();
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

    public class FajlPregled
    {
        public int Id;
        public string Putanja;


        public FajlPregled() { }

        public FajlPregled(int id, string putanja)
        {
            Id = id;
            Putanja = putanja;
        }
    }
    #endregion


    public class InstitucijaPregled
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }

        public InstitucijaPregled() { }
        public InstitucijaPregled(int id, string naziv, string adresa)
        {
            Id = id;
            Naziv = naziv;
            Adresa = adresa;
        }
    }

    public class InstitucijaBasic
    {
        public int Id;
        public string Naziv;
        public string Adresa;

        public IList<InstitucijaKontaktMailBasic> KontaktMailovi { get; set; }
        public IList<InstitucijaKontaktTelBasic> KontaktTelefoni { get; set; }
        public IList<InstitucijaNaucnaOblastBasic> NaucneOblasti { get; set; }

        public InstitucijaBasic()
        {
            KontaktMailovi = new List<InstitucijaKontaktMailBasic>();
            KontaktTelefoni = new List<InstitucijaKontaktTelBasic>();
            NaucneOblasti = new List<InstitucijaNaucnaOblastBasic>();
        }
        public InstitucijaBasic(int id, string naziv, string adresa) : this()
        {
            Id = id; Naziv = naziv; Adresa = adresa;
        }
    }

    public class InstitucijaKontaktMailPregled
    {
        public int Id;
        public string KontaktMail;

        public InstitucijaKontaktMailPregled() { }
        public InstitucijaKontaktMailPregled(int id, string kontaktMail)
        {
            Id = id;
            KontaktMail = kontaktMail;
        }
    }

    public class InstitucijaKontaktMailBasic
    {
        public int Id;
        public InstitucijaBasic Institucija;
        public string KontaktMail;

        public InstitucijaKontaktMailBasic() { }
        public InstitucijaKontaktMailBasic(int id, InstitucijaBasic institucija, string kontaktMail)
        {
            Id = id;
            Institucija = institucija;
            KontaktMail = kontaktMail;
        }
    }

    public class InstitucijaKontaktTelPregled
    {
        public int Id;
        public string KontaktTel;

        public InstitucijaKontaktTelPregled() { }
        public InstitucijaKontaktTelPregled(int id, string kontaktTel)
        {
            Id = id;
            KontaktTel = kontaktTel;
        }
    }

    public class InstitucijaKontaktTelBasic
    {
        public int Id;
        public InstitucijaBasic Institucija;
        public string KontaktTel;

        public InstitucijaKontaktTelBasic() { }
        public InstitucijaKontaktTelBasic(int id, InstitucijaBasic institucija, string kontaktTel)
        {
            Id = id;
            Institucija = institucija;
            KontaktTel = kontaktTel;
        }
    }

    public class InstitucijaNaucnaOblastPregled
    {
        public int Id;
        public string NaucnaOblast;

        public InstitucijaNaucnaOblastPregled() { }
        public InstitucijaNaucnaOblastPregled(int id, string naucnaOblast)
        {
            Id = id;
            NaucnaOblast = naucnaOblast;
        }
    }

    public class InstitucijaNaucnaOblastBasic
    {
        public int Id;
        public InstitucijaBasic Institucija;
        public string NaucnaOblast;

        public InstitucijaNaucnaOblastBasic() { }
        public InstitucijaNaucnaOblastBasic(int id, InstitucijaBasic institucija, string naucnaOblast)
        {
            Id = id;
            Institucija = institucija;
            NaucnaOblast = naucnaOblast;
        }
    }

    public class IstrazivacPregled
    {
        public int Id;
        public string Ime;
        public string Prezime;
        public DateTime DatumRodjenja;
        public string Drzava;
        public string StatusNaloga;
        public string NaucnoZvanje;
        public string NaucnaOblast;


        public int ID { get { return Id; } }
        public string PunoIme // za ispis u ComboBox-u
        {
            get { return $"{Ime} {Prezime}"; }
        }

        public IstrazivacPregled() { }
        public IstrazivacPregled(int id, string ime, string prezime, DateTime datumRodjenja,
            string drzava, string statusNaloga, string naucnoZvanje, string naucnaOblast)
        {
            Id = id; Ime = ime; Prezime = prezime; DatumRodjenja = datumRodjenja;
            Drzava = drzava; StatusNaloga = statusNaloga; NaucnoZvanje = naucnoZvanje;
            NaucnaOblast = naucnaOblast;
        }
    }

    public class IstrazivacBasic
    {
        public int Id;
        public string Ime;
        public string Prezime;
        public DateTime DatumRodjenja;
        public string Drzava;
        public string StatusNaloga;
        public string NaucnoZvanje;
        public string NaucnaOblast;
        public bool JeAutor;
        public bool JeRecenzent;
        public bool JeUrednik;
        public bool JeAdmin;
        public bool JeRukovodilacProjekta;
        public string ORCID;
        public string OblastEkspertize;
        public string UredjivackaSekcija;
        public string AdministratorskaOvlascenja;

        public IList<IstrazivacEmailBasic> Emailovi { get; set; }
        public IList<IstrazivacTelefonBasic> Telefoni { get; set; }

        public IstrazivacBasic()
        {
            Emailovi = new List<IstrazivacEmailBasic>();
            Telefoni = new List<IstrazivacTelefonBasic>();
        }

        public IstrazivacBasic(int id, string ime, string prezime, DateTime datumRodjenja,
            string drzava, string statusNaloga, string naucnoZvanje, string naucnaOblast,
            bool jeAutor, bool jeRecenzent, bool jeUrednik, bool jeAdmin, bool jeRukovodilac,
            string orcid, string oblastEkspertize, string uredjivackaSekcija, string administratorskaOvlascenja) : this()
        {
            Id = id; Ime = ime; Prezime = prezime; DatumRodjenja = datumRodjenja;
            Drzava = drzava; StatusNaloga = statusNaloga; NaucnoZvanje = naucnoZvanje;
            NaucnaOblast = naucnaOblast;
            JeAutor = jeAutor; JeRecenzent = jeRecenzent; JeUrednik = jeUrednik;
            JeAdmin = jeAdmin; JeRukovodilacProjekta = jeRukovodilac;
            ORCID = orcid; OblastEkspertize = oblastEkspertize;
            UredjivackaSekcija = uredjivackaSekcija;
            AdministratorskaOvlascenja = administratorskaOvlascenja;
        }
    }

    public class IstrazivacEmailPregled
    {
        public int Id;
        public string Email;

        public IstrazivacEmailPregled() { }
        public IstrazivacEmailPregled(int id, string email)
        {
            Id = id;
            Email = email;
        }
    }

    public class IstrazivacEmailBasic
    {
        public int Id;
        public IstrazivacBasic Istrazivac;
        public string Email;

        public IstrazivacEmailBasic() { }
        public IstrazivacEmailBasic(int id, IstrazivacBasic istrazivac, string email)
        {
            Id = id;
            Istrazivac = istrazivac;
            Email = email;
        }
    }

    public class IstrazivacTelefonPregled
    {
        public int Id;
        public string Telefon;

        public IstrazivacTelefonPregled() { }
        public IstrazivacTelefonPregled(int id, string telefon)
        {
            Id = id;
            Telefon = telefon;
        }
    }

    public class IstrazivacTelefonBasic
    {
        public int Id;
        public IstrazivacBasic Istrazivac;
        public string Telefon;

        public IstrazivacTelefonBasic() { }
        public IstrazivacTelefonBasic(int id, IstrazivacBasic istrazivac, string telefon)
        {
            Id = id;
            Istrazivac = istrazivac;
            Telefon = telefon;
        }
    }

    public class AngazovanjePregled
    {
        public int Id;
        public int IdInstitucije;
        public int IdIstrazivaca;
        public string NazivInstitucije;
        public string ImeIstrazivaca;
        public string OrganizacionaJedinica;
        public string TipAngazovanja;
        public string NazivPozicije;
        public DateTime DatumPocetka;
        public DateTime? DatumZavrsetka;

        public AngazovanjePregled() { }
        public AngazovanjePregled(int id, int idInstitucije, int idIstrazivaca, string nazivInstitucije,
            string imeIstrazivaca, string organizacionaJedinica,
            string tipAngazovanja, string nazivPozicije, DateTime datumPocetka, DateTime? datumZavrsetka)
        {
            Id = id; IdInstitucije = idInstitucije; IdIstrazivaca = idIstrazivaca;
            NazivInstitucije = nazivInstitucije; ImeIstrazivaca = imeIstrazivaca;
            OrganizacionaJedinica = organizacionaJedinica;
            TipAngazovanja = tipAngazovanja; NazivPozicije = nazivPozicije;
            DatumPocetka = datumPocetka; DatumZavrsetka = datumZavrsetka;
        }
    }

    public class AngazovanjeBasic
    {
        public int Id;
        public int IdInstitucije;
        public int IdIstrazivaca;
        public string NazivInstitucije;
        public string ImeIstrazivaca;
        public string NazivPozicije;
        public DateTime DatumPocetka;
        public string OrganizacionaJedinica;
        public string TipAngazovanja;
        public DateTime? DatumZavrsetka;

        public AngazovanjeBasic() { }
        public AngazovanjeBasic(int id, int idInstitucije, int idIstrazivaca, string nazivInstitucije,
            string imeIstrazivaca, string nazivPozicije, DateTime datumPocetka,
            string organizacionaJedinica, string tipAngazovanja, DateTime? datumZavrsetka)
        {
            Id = id;
            IdInstitucije = idInstitucije; IdIstrazivaca = idIstrazivaca;
            NazivInstitucije = nazivInstitucije; ImeIstrazivaca = imeIstrazivaca;
            NazivPozicije = nazivPozicije; DatumPocetka = datumPocetka;
            OrganizacionaJedinica = organizacionaJedinica;
            TipAngazovanja = tipAngazovanja;
            DatumZavrsetka = datumZavrsetka;
        }
    }

    public class AutorstvoPregled
    {
        public int Id;
        public int IdPublikacije;
        public int IdAutora;
        public string NaslovPublikacije;
        public string ImeAutora;
        public int RedosledAutora;

        public AutorstvoPregled() { }
        public AutorstvoPregled(int id, int idPublikacije, int idAutora, string naslovPublikacije,
            string imeAutora, int redosledAutora)
        {
            Id = id;  IdPublikacije = idPublikacije; IdAutora = idAutora;
            NaslovPublikacije = naslovPublikacije; ImeAutora = imeAutora;
            RedosledAutora = redosledAutora;
        }
    }

    public class AutorstvoBasic
    {
        public int Id;
        public int IdPublikacije;
        public int IdAutora;
        public string NaslovPublikacije;
        public string ImeAutora;
        public int RedosledAutora;
        public string TipDoprinosa;
        public string Uloga;

        public AutorstvoBasic() { }
        public AutorstvoBasic(int id, int idPublikacije, int idAutora, string naslovPublikacije,
            string imeAutora, int redosledAutora, string tipDoprinosa, string uloga)
        {
            Id = id;
            IdPublikacije = idPublikacije; IdAutora = idAutora;
            NaslovPublikacije = naslovPublikacije; ImeAutora = imeAutora;
            RedosledAutora = redosledAutora;
            TipDoprinosa = tipDoprinosa; Uloga = uloga;
        }
    }

    #region NaucniRad

    public class NaucniRadPregled : PublikacijaPregled
    {
        public string DOI;
        public string TipRada;
        public string Stranice;
        public int Izvor;

        public NaucniRadPregled() { }

        public NaucniRadPregled(int id, string naslov, string jezik, string status, string vidljivost,
            DateTime datumObjavljivanja, string doi, string tipRada, string stranice, int izvor)
            : base(id, naslov, jezik, status, vidljivost, datumObjavljivanja)
        {
            DOI = doi;
            TipRada = tipRada;
            Stranice = stranice;
            Izvor = izvor;
        }
    }

    public class NaucniRadBasic : PublikacijaBasic
    {
        public string DOI;
        public string TipRada;
        public string Stranice;
        public int IdIzvora;

        public NaucniRadBasic() { }

        public NaucniRadBasic(int id, string naslov, string apstrakt, string jezik, string status,
            string vidljivost, DateTime datumObjavljivanja, DateTime datumKreiranjaZapisa,
            string doi, string tipRada, string stranice, int idIzvora)
            : base(id, naslov, apstrakt, jezik, status, vidljivost, datumObjavljivanja, datumKreiranjaZapisa)
        {
            DOI = doi;
            TipRada = tipRada;
            Stranice = stranice;
            IdIzvora = idIzvora;
        }
    }

    #endregion


    #region Dataset

    public class DatasetPregled : PublikacijaPregled
    {
        public string Format;
        public int BrojZapisa;
        public int Velicina;

        public DatasetPregled() { }

        public DatasetPregled(int id, string naslov, string jezik, string status, string vidljivost,
            DateTime datumObjavljivanja, string format, int brojZapisa, int velicina)
            : base(id, naslov, jezik, status, vidljivost, datumObjavljivanja)
        {
            Format = format;
            BrojZapisa = brojZapisa;
            Velicina = velicina;
        }
    }

    public class DatasetBasic : PublikacijaBasic
    {
        public int BrojZapisa;
        public int Velicina;
        public string Format;
        public string LicencaKoriscenja;

        public DatasetBasic() { }

        public DatasetBasic(int id, string naslov, string apstrakt, string jezik, string status,
            string vidljivost, DateTime datumObjavljivanja, DateTime datumKreiranjaZapisa,
            int brojZapisa, int velicina, string format, string licencaKoriscenja)
            : base(id, naslov, apstrakt, jezik, status, vidljivost, datumObjavljivanja, datumKreiranjaZapisa)
        {
            BrojZapisa = brojZapisa;
            Velicina = velicina;
            Format = format;
            LicencaKoriscenja = licencaKoriscenja;
        }
    }

    #endregion


    #region SoftverskiArtefakt

    public class SoftverskiArtefaktPregled : PublikacijaPregled
    {
        public string ProgramskiJezik;
        public string LinkKaRepozitorijumu;

        public SoftverskiArtefaktPregled() { }

        public SoftverskiArtefaktPregled(int id, string naslov, string jezik, string status,
            string vidljivost, DateTime datumObjavljivanja,
            string programskiJezik, string linkKaRepozitorijumu)
            : base(id, naslov, jezik, status, vidljivost, datumObjavljivanja)
        {
            ProgramskiJezik = programskiJezik;
            LinkKaRepozitorijumu = linkKaRepozitorijumu;
        }
    }

    public class SoftverskiArtefaktBasic : PublikacijaBasic
    {
        public string ProgramskiJezik;
        public string LinkKaRepozitorijumu;
        public string NacinLicenciranja;

        public SoftverskiArtefaktBasic() { }

        public SoftverskiArtefaktBasic(int id, string naslov, string apstrakt, string jezik,
            string status, string vidljivost, DateTime datumObjavljivanja,
            DateTime datumKreiranjaZapisa, string programskiJezik,
            string linkKaRepozitorijumu, string nacinLicenciranja)
            : base(id, naslov, apstrakt, jezik, status, vidljivost, datumObjavljivanja, datumKreiranjaZapisa)
        {
            ProgramskiJezik = programskiJezik;
            LinkKaRepozitorijumu = linkKaRepozitorijumu;
            NacinLicenciranja = nacinLicenciranja;
        }
    }

    #endregion

    #region Citiri

    public class CitatBasic
    {
        public int Id { get; set; }
        public PublikacijaBasic PubCitira { get; set; }
        public PublikacijaBasic PubCitirana { get; set; }
        public string TipCitata { get; set; }
        public string MestoCitiranja { get; set; }
        public string TekstualniKontekst { get; set; }
    }
    #endregion

    #region RundeRecenzije

    public class RundaRecenzijePregled
    {
        public int Id { get; set; }
        public int BrojRunde { get; set; }
        public int IdPublikacije { get; set; }
        public int IdUrednika { get; set; }
        public DateTime Datum { get; set; }
        public string KonacnaOdluka { get; set; }
    }

    public class RundaRecenzijeBasic
    {
        public int Id { get; set; }
        public int BrojRunde { get; set; }
        public int IdPublikacije { get; set; }
        public int IdUrednika { get; set; }
        public DateTime Datum { get; set; }
        public string KonacnaOdluka { get; set; }
    }
    #endregion

    #region KnjigaUrednici

    public class KnjigaUredniciBasic
    {
        public int Id { get; set; }
        public KnjigaBasic? Knjiga { get; set; }
        public string? Urednik { get; set; }
    }
    #endregion

    #region PoglavljeUrednici

    public class PoglavljeUredniciBasic
    {
        public int Id { get; set; }
        public PoglavljeUKnjiziBasic? PoglavljeUKnjizi { get; set; }
        public string? Urednik { get; set; }
    }
    #endregion

}