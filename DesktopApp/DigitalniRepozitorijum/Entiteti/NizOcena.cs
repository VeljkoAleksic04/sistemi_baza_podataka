namespace DigitalniRepozitorijum.Entiteti;

public class NizOcena
{
    public virtual int Id { get; set; }
    public virtual int IdRundeRecenzije { get; set; }
    public virtual int IdRecenzenta { get; set; }
    public virtual string? Kriterijum { get; set; }
    public virtual double Ocena { get; set; }
    public virtual VrsiRecenziju? VrsiRecenziju { get; set; }
}