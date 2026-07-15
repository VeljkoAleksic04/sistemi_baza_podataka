namespace RepozitorijumLibrary.DTOs;

public class AngazovanjeView
{
    public int Id { get; set; }
    public int IdInstitucije { get; set; }
    public int IdIstrazivaca { get; set; }
    public string? NazivInstitucije { get; set; }
    public string? ImeIstrazivaca { get; set; }
    public string? OrganizacionaJedinica { get; set; }
    public string? TipAngazovanja { get; set; }
    public string? NazivPozicije { get; set; }
    public DateTime? DatumPocetka { get; set; }
    public DateTime? DatumZavrsetka { get; set; }

    public AngazovanjeView() { }

    internal AngazovanjeView(Angazovanje? a)
    {
        if (a != null)
        {
            Id = a.Id;
            IdInstitucije = a.Institucija?.Id ?? 0;
            IdIstrazivaca = a.Istrazivac?.Id ?? 0;
            NazivInstitucije = a.Institucija?.Naziv;
            ImeIstrazivaca = a.Istrazivac != null ? $"{a.Istrazivac.Ime} {a.Istrazivac.Prezime}" : null;
            OrganizacionaJedinica = a.OrganizacionaJedinica;
            TipAngazovanja = a.TipAngazovanja;
            NazivPozicije = a.NazivPozicije;
            DatumPocetka = a.DatumPocetka;
            DatumZavrsetka = a.DatumZavrsetka;
        }
    }
}
