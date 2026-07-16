using RepozitorijumLibrary.Entiteti;

namespace RepozitorijumLibrary.DTOs;

public class NizOcenaView
{
    public int Id { get; set; }
    public int IdRundeRecenzije { get; set; }
    public int IdRecenzenta { get; set; }
    public string? Kriterijum { get; set; }
    public double Ocena { get; set; }

    public int? IdVrsiRecenziju { get; set; } // povezanost sa VrsiRecenziju

    public NizOcenaView() { }

    internal NizOcenaView(NizOcena? n)
    {
        if (n != null)
        {
            Id = n.Id;
            IdRundeRecenzije = n.IdRundeRecenzije;
            IdRecenzenta = n.IdRecenzenta;
            Kriterijum = n.Kriterijum;
            Ocena = n.Ocena;
            IdVrsiRecenziju = n.VrsiRecenziju?.Id;
        }
    }
}