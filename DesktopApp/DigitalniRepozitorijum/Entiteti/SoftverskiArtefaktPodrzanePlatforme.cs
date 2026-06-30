namespace DigitalniRepozitorijum.Entiteti;

public class SoftverskiArtefaktPodrzanePlatforme
{
    public virtual int Id { get; set; }
    public virtual int IdPublikacije { get; set; }
    public virtual required string PodrzanaPlatforma { get; set; }
    public virtual SoftverskiArtefakt? SoftverskiArtefakt { get; set; }
}