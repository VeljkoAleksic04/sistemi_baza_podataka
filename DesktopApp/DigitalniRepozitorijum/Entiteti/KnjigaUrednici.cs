namespace DigitalniRepozitorijum.Entiteti;

public class KnjigaUrednici
{
    public virtual int Id { get; set; }
    public virtual string? Urednik { get; set; }
    public virtual Knjiga? Knjiga { get; set; }
}