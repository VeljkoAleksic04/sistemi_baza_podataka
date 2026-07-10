namespace DigitalniRepozitorijum.Entiteti;

public class PoglavljeUrednici
{
    public virtual int Id { get; set; }
    public virtual string? Urednik { get; set; }
    public virtual PoglavljeUKnjizi? PoglavljeUKnjizi { get; set; }
}