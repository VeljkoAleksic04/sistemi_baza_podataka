using RepozitorijumLibrary.Entiteti;

namespace RepozitorijumLibrary.DTOs;

public class SoftverskiArtefaktView : PublikacijaView
{
    public int? IdArtefakta { get; set; }
    public string? ProgramskiJezik { get; set; }
    public string? LinkKaRepozitorijumu { get; set; }
    public string? NacinLicenciranja { get; set; }

    public SoftverskiArtefaktView() { }

    internal SoftverskiArtefaktView(SoftverskiArtefakt? s) : base(s)
    {
        if (s != null)
        {
            IdArtefakta = s.IdArtefakta;
            ProgramskiJezik = s.ProgramskiJezik;
            LinkKaRepozitorijumu = s.LinkKaRepozitorijumu;
            NacinLicenciranja = s.NacinLicenciranja;
        }
    }
}