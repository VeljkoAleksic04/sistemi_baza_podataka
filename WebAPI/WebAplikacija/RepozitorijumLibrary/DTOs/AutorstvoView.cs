namespace RepozitorijumLibrary.DTOs;

public class AutorstvoView
{
    public int Id { get; set; }
    public int IdPublikacije { get; set; }
    public int IdAutora { get; set; }
    public string? NaslovPublikacije { get; set; }
    public string? ImeAutora { get; set; }
    public int RedosledAutora { get; set; }
    public string? TipDoprinosa { get; set; }
    public string? Uloga { get; set; }

    public AutorstvoView() { }

    internal AutorstvoView(Autorstvo? a)
    {
        if (a != null)
        {
            Id = a.Id;
            IdPublikacije = a.Publikacija?.Id ?? 0;
            IdAutora = a.Autor?.Id ?? 0;
            NaslovPublikacije = a.Publikacija?.Naslov;
            ImeAutora = a.Autor != null ? $"{a.Autor.Ime} {a.Autor.Prezime}" : null;
            RedosledAutora = a.RedosledAutora;
            TipDoprinosa = a.TipDoprinosa;
            Uloga = a.Uloga;
        }
    }
}
