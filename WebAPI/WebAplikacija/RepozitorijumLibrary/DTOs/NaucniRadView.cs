using RepozitorijumLibrary.Entiteti;

namespace RepozitorijumLibrary.DTOs;

public class NaucniRadView : PublikacijaView
{
    public string? DOI { get; set; }
    public string? TipRada { get; set; }
    public string? Stranice { get; set; }
    public int? IdIzvora { get; set; }
    public string? NazivIzvora { get; set; }

    public NaucniRadView() { }

    internal NaucniRadView(NaucniRad? n) : base(n)
    {
        if (n != null)
        {
            DOI = n.DOI;
            TipRada = n.TipRada;
            Stranice = n.Stranice;
            IdIzvora = n.Izvor?.Id;
            NazivIzvora = n.Izvor?.Naziv;
        }
    }
}