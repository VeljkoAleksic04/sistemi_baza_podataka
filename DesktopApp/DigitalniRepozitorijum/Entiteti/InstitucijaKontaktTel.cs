namespace DigitalniRepozitorijum.Entiteti;

public class InstitucijaKontaktTel
{
    public virtual int Id { get; set; }
    public virtual Institucija Institucija { get; set; }
    public virtual string KontaktTel { get; set; }
}
