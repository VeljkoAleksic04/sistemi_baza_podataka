namespace DigitalniRepozitorijum.Entiteti;

public class IstrazivacTelefon
{
    public virtual int Id { get; set; }
    public virtual Istrazivac Istrazivac { get; set; }
    public virtual string Telefon { get; set; }
}
