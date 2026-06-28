namespace DigitalniRepozitorijum.Entiteti;

public class Citira
{
    public virtual int Id { get; set; }
    public virtual int IdCitira { get; set; }
    public virtual int IdCitirana { get; set; }
    public virtual required string TipCitata { get; set; }
    public virtual string? MestoCitiranja { get; set; }
    public virtual string? TekstualniKontekst { get; set; }
}