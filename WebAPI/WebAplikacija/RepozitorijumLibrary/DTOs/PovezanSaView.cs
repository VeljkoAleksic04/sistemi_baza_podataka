using RepozitorijumLibrary.Entiteti;

namespace RepozitorijumLibrary.DTOs;

public class PovezanSaView
{
    public int Id { get; set; }
    public int IdPublikacije1 { get; set; }
    public int IdPublikacije2 { get; set; }
    public string? TipPovezanosti { get; set; }

    public string? Naslov1 { get; set; }
    public string? Naslov2 { get; set; }

    public PovezanSaView() { }

    internal PovezanSaView(PovezanSa? p)
    {
        if (p != null)
        {
            Id = p.Id;
            IdPublikacije1 = p.IdPublikacije1;
            IdPublikacije2 = p.IdPublikacije2;
            TipPovezanosti = p.TipPovezanosti;
        }
    }
}