namespace RepozitorijumLibrary.Entiteti;

internal class RundaRecenzije
{
    internal protected virtual int Id { get; set; }
    internal protected virtual int BrojRunde { get; set; }
    internal protected virtual int IdPublikacije { get; set; }
    internal protected virtual int IdUrednika { get; set; }
    internal protected virtual DateTime Datum { get; set; }
    internal protected virtual string? KonacnaOdluka { get; set; }
    
    internal protected virtual Publikacija? Publikacija { get; set; }
    internal protected virtual Istrazivac? Urednik { get; set; }
    
    internal protected virtual ICollection<VrsiRecenziju> Recenzije { get; set; } = new List<VrsiRecenziju>();

}
