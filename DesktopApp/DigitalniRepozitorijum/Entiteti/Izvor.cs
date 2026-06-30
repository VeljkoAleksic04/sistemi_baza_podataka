namespace DigitalniRepozitorijum.Entiteti;

public abstract class Izvor
{
    public virtual int Id { get; protected set; }

    public virtual string Naziv { get; set; }

    public virtual IList<NaucniRad> NaucniRadovi { get; set; }

    public Izvor()
    {
        NaucniRadovi = new List<NaucniRad>();
    }
}