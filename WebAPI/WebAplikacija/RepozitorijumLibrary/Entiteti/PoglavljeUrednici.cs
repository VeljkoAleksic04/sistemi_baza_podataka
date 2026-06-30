namespace RepozitorijumLibrary.Entiteti;

internal class PoglavljeUrednici
{
    internal protected virtual int Id { get; set; }
    internal protected virtual int IdPublikacije { get; set; }
    internal protected virtual string? Urednik { get; set; }
    internal protected virtual PoglavljeUKnjizi? PoglavljeUKnjizi { get; set; }
}
