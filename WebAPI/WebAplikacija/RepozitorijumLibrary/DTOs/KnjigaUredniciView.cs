using RepozitorijumLibrary.Entiteti;

namespace RepozitorijumLibrary.DTOs;

public class KnjigaUredniciView
{
    public int Id { get; set; }
    public int IdPublikacije { get; set; }
    public string? Urednik { get; set; }

    public string? NaslovKnjige { get; set; }

    public KnjigaUredniciView() { }

    internal KnjigaUredniciView(KnjigaUrednici? k)
    {
        if (k != null)
        {
            Id = k.Id;
            IdPublikacije = k.IdPublikacije;
            Urednik = k.Urednik;
            NaslovKnjige = k.Knjiga?.Naslov;
        }
    }
}