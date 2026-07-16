using RepozitorijumLibrary.Entiteti;

namespace RepozitorijumLibrary.DTOs;

public class CitiraView
{
    public int Id { get; set; }
    public int IdCitira { get; set; }          // ID publikacije koja citira
    public int IdCitirana { get; set; }        // ID publikacije koja je citirana
    public string? TipCitata { get; set; }
    public string? MestoCitiranja { get; set; }
    public string? TekstualniKontekst { get; set; }

    // dodatne informacije za prikaz
    public string? NaslovCitirajuci { get; set; }
    public string? NaslovCitirani { get; set; }

    public CitiraView() { }

    internal CitiraView(Citira? c)
    {
        if (c != null)
        {
            Id = c.Id;
            IdCitira = c.IdCitira;
            IdCitirana = c.IdCitirana;
            TipCitata = c.TipCitata;
            MestoCitiranja = c.MestoCitiranja;
            TekstualniKontekst = c.TekstualniKontekst;
            // Naslovi se mogu dohvatiti posebno ako želimo, ali ovde ne učitavamo reference
        }
    }
}