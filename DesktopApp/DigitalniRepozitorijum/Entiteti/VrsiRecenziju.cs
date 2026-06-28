namespace DigitalniRepozitorijum.Entiteti;

public class VrsiRecenziju
{
    public virtual int  Id { get; set; }
    public virtual int BrojRunde { get; set; }
    public virtual int IdPublikacije { get; set; }
    public virtual int IdRecenzenta { get; set; }
    public virtual string? Preporuka { get; set; }
}