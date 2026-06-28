namespace DigitalniRepozitorijum.Entiteti;

public class NizOcena
{
    public virtual int Id { get; set; }
    public virtual int IdPublikacije { get; set; }
    public virtual int IdRecenzenta { get; set; }
    public virtual int BrojRunde { get; set; }
    public virtual string? Kriterijum { get; set; }
    public virtual double Ocena { get; set; }
}