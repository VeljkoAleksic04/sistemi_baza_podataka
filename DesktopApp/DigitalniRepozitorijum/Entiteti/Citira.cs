namespace DigitalniRepozitorijum.Entiteti;

public class Citira
{
    public virtual int Id { get; set; }
    public virtual Publikacija PubCitira { get; set; }
    public virtual Publikacija PubCitirana { get; set; }
    public virtual required string TipCitata { get; set; }
    public virtual string? MestoCitiranja { get; set; }
    public virtual string? TekstualniKontekst { get; set; }
}