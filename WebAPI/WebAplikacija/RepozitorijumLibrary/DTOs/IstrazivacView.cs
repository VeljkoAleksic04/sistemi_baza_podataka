namespace RepozitorijumLibrary.DTOs;

public class IstrazivacView
{
    public int Id { get; set; }
    public string? Ime { get; set; }
    public string? Prezime { get; set; }
    public DateTime? DatumRodjenja { get; set; }
    public string? Drzava { get; set; }
    public string? StatusNaloga { get; set; }
    public string? NaucnoZvanje { get; set; }
    public string? NaucnaOblast { get; set; }
    public bool JeAutor { get; set; }
    public bool JeRecenzent { get; set; }
    public bool JeUrednik { get; set; }
    public bool JeAdmin { get; set; }
    public bool JeRukovodilacProjekta { get; set; }
    public string? ORCID { get; set; }
    public string? OblastEkspertize { get; set; }
    public string? UredjivackaSekcija { get; set; }
    public string? AdministratorskaOvlascenja { get; set; }

    public virtual IList<IstrazivacEmailView> Emailovi { get; set; }
    public virtual IList<IstrazivacTelefonView> Telefoni { get; set; }

    public IstrazivacView()
    {
        Emailovi = new List<IstrazivacEmailView>();
        Telefoni = new List<IstrazivacTelefonView>();
    }

    internal IstrazivacView(Istrazivac? i) : this()
    {
        if (i != null)
        {
            Id = i.Id;
            Ime = i.Ime;
            Prezime = i.Prezime;
            DatumRodjenja = i.DatumRodjenja;
            Drzava = i.Drzava;
            StatusNaloga = i.StatusNaloga;
            NaucnoZvanje = i.NaucnoZvanje;
            NaucnaOblast = i.NaucnaOblast;
            JeAutor = i.JeAutor;
            JeRecenzent = i.JeRecenzent;
            JeUrednik = i.JeUrednik;
            JeAdmin = i.JeAdmin;
            JeRukovodilacProjekta = i.JeRukovodilacProjekta;
            ORCID = i.ORCID;
            OblastEkspertize = i.OblastEkspertize;
            UredjivackaSekcija = i.UredjivackaSekcija;
            AdministratorskaOvlascenja = i.AdministratorskaOvlascenja;
        }
    }
}
