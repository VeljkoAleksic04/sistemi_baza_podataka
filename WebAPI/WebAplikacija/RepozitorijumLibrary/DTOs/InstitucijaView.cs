namespace RepozitorijumLibrary.DTOs;

public class InstitucijaView
{
    public int Id { get; set; }
    public string? Naziv { get; set; }
    public string? Adresa { get; set; }

    public virtual IList<InstitucijaKontaktMailView> KontaktMailovi { get; set; }
    public virtual IList<InstitucijaKontaktTelView> KontaktTelefoni { get; set; }
    public virtual IList<InstitucijaNaucnaOblastView> NaucneOblasti { get; set; }

    public InstitucijaView()
    {
        KontaktMailovi = new List<InstitucijaKontaktMailView>();
        KontaktTelefoni = new List<InstitucijaKontaktTelView>();
        NaucneOblasti = new List<InstitucijaNaucnaOblastView>();
    }

    internal InstitucijaView(Institucija? i) : this()
    {
        if (i != null)
        {
            Id = i.Id;
            Naziv = i.Naziv;
            Adresa = i.Adresa;
        }
    }
}
