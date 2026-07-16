using RepozitorijumLibrary.Entiteti;

namespace RepozitorijumLibrary.DTOs;

public class SoftverskiArtefaktPodrzanePlatformeView
{
    public int Id { get; set; }
    public int IdPublikacije { get; set; }
    public string? PodrzanaPlatforma { get; set; }

    public string? NazivArtefakta { get; set; }

    public SoftverskiArtefaktPodrzanePlatformeView() { }

    internal SoftverskiArtefaktPodrzanePlatformeView(SoftverskiArtefaktPodrzanePlatforme? s)
    {
        if (s != null)
        {
            Id = s.Id;
            IdPublikacije = s.IdPublikacije;
            PodrzanaPlatforma = s.PodrzanaPlatforma;
            NazivArtefakta = s.SoftverskiArtefakt?.Naslov;
        }
    }
}