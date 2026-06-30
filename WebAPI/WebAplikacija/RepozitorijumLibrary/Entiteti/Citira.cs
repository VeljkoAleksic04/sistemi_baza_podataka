namespace RepozitorijumLibrary.Entiteti;

internal class Citira
{
    internal protected virtual int Id { get; set; }
    internal protected virtual int IdCitira { get; set; }
    internal protected virtual int IdCitirana { get; set; }
    internal protected virtual required string TipCitata { get; set; }
    internal protected virtual string? MestoCitiranja { get; set; }
    internal protected virtual string? TekstualniKontekst { get; set; }
}
