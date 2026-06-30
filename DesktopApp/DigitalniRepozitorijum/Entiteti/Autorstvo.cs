namespace DigitalniRepozitorijum.Entiteti;

public class Autorstvo
{
    public virtual AutorstvoId Id { get; set; }
    public virtual int RedosledAutora { get; set; }
    public virtual string TipDoprinosa { get; set; }
    public virtual string Uloga { get; set; }

    public Autorstvo()
    {
        Id = new AutorstvoId();
    }
}
