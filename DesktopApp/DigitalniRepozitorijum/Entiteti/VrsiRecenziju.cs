namespace DigitalniRepozitorijum.Entiteti;

public class VrsiRecenziju
{
    public virtual int Id { get; set; }
    public virtual int IdRundeRecenzije { get; set; }
    public virtual int IdRecenzenta { get; set; }
    public virtual string? Preporuka { get; set; }
    public virtual RundaRecenzije? RundaRecenzije { get; set; }
    public virtual Istrazivac? Recenzent { get; set; }
    public virtual IList<NizOcena> Ocene { get; set; } = new List<NizOcena>();
}