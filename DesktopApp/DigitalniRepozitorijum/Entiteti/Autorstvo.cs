namespace DigitalniRepozitorijum.Entiteti;

public class Autorstvo
{
    public virtual int Id { get; set; }
    public virtual Publikacija Publikacija { get; set; }
    public virtual Istrazivac Autor { get; set; }
    public virtual int RedosledAutora { get; set; }
    public virtual string TipDoprinosa { get; set; }
    public virtual string Uloga { get; set; }
}
