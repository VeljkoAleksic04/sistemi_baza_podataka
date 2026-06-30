namespace RepozitorijumLibrary.Entiteti;

internal class KnjigaUrednici
{
    internal protected virtual int Id { get; set; }
    internal protected virtual int IdPublikacije { get; set; }
    internal protected virtual string? Urednik { get; set; }
    internal protected virtual Knjiga? Knjiga { get; set; }
}
