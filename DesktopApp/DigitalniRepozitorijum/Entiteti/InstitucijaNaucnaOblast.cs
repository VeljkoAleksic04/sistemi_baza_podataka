namespace DigitalniRepozitorijum.Entiteti;

public class InstitucijaNaucnaOblast
{
    public virtual int Id { get; set; }
    public virtual Institucija Institucija { get; set; }
    public virtual string NaucnaOblast { get; set; }
}
