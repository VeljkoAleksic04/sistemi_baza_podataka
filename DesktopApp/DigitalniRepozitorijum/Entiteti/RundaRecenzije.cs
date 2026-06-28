namespace DigitalniRepozitorijum.Entiteti;

public class RundaRecenzije
{
    public virtual int Id { get; set; }
    public virtual int BrojRunde { get; set; }
    public virtual int IdPublikacije { get; set; }
    public virtual int IdUrednika { get; set; }
    public virtual DateTime Datum { get; set; }
    public virtual string? KonacnaOdluka { get; set; }
}