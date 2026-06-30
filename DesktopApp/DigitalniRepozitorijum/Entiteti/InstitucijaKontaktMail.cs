namespace DigitalniRepozitorijum.Entiteti;

public class InstitucijaKontaktMail
{
    public virtual int Id { get; set; }
    public virtual Institucija Institucija { get; set; }
    public virtual string KontaktMail { get; set; }
}
