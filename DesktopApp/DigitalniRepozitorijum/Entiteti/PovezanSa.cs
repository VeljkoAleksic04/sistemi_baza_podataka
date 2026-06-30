namespace DigitalniRepozitorijum.Entiteti;

public class PovezanSa
{
    public virtual int Id { get; set; }
    public virtual int IdPublikacije1 { get; set; }
    public virtual int IdPublikacije2 { get; set; }
    public virtual required string TipPovezanosti { get; set; }
    public virtual Publikacija? Publikacija1 { get; set; }
    public virtual Publikacija? Publikacija2 { get; set; }
}