using RepozitorijumLibrary.Entiteti;

namespace RepozitorijumLibrary.DTOs;

public class PoglavljeUredniciView
{
    public int Id { get; set; }
    public int IdPublikacije { get; set; }
    public string? Urednik { get; set; }

    public string? NaslovPoglavlja { get; set; }

    public PoglavljeUredniciView() { }

    internal PoglavljeUredniciView(PoglavljeUrednici? p)
    {
        if (p != null)
        {
            Id = p.Id;
            IdPublikacije = p.IdPublikacije;
            Urednik = p.Urednik;
            NaslovPoglavlja = p.PoglavljeUKnjizi?.Naslov;
        }
    }
}