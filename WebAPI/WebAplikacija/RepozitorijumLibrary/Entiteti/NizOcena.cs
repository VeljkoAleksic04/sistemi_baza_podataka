namespace RepozitorijumLibrary.Entiteti;

internal class NizOcena
{
    internal protected virtual int Id { get; set; }
    internal protected virtual int IdRundeRecenzije { get; set; }
    internal protected virtual int IdRecenzenta { get; set; }
    internal protected virtual string? Kriterijum { get; set; }
    internal protected virtual double Ocena { get; set; }
    internal protected virtual VrsiRecenziju? VrsiRecenziju { get; set; }
}
