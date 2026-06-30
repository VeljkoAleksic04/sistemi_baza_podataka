namespace DigitalniRepozitorijum.Entiteti;

public class IstrazivacEmail
{
    public virtual int Id { get; set; }
    public virtual Istrazivac Istrazivac { get; set; }
    public virtual string Email { get; set; }
}
