namespace RepozitorijumLibrary.Entiteti;

internal class RundaRecenzijeWE // RundaRecenzijeWeakEntity
{
    internal protected virtual int Id { get; set; }
    internal protected virtual int BrojRunde { get; set; }
    internal protected virtual int IdPublikacije { get; set; }
    internal protected virtual DateTime Datum { get; set; }
    internal protected virtual string KonacnaOdluka { get; set; }
}
