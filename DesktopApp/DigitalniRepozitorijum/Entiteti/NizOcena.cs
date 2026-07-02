namespace DigitalniRepozitorijum.Entiteti;

public class NizOcena
{
    public virtual int Id { get; set; }
    public virtual RundaRecenzije RundaRecenzije { get; set; }
    public virtual Istrazivac Recenzent { get; set; }
    public virtual string? Kriterijum { get; set; }
    public virtual double Ocena { get; set; }
    public virtual VrsiRecenziju? VrsiRecenziju { get; set; }
}