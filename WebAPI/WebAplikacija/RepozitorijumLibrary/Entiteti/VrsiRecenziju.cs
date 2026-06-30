namespace RepozitorijumLibrary.Entiteti;

internal class VrsiRecenziju
{
    internal protected virtual int Id { get; set; }
    internal protected virtual int IdRundeRecenzije { get; set; }
    internal protected virtual int IdRecenzenta { get; set; }
    internal protected virtual string? Preporuka { get; set; }
    internal protected virtual RundaRecenzije? RundaRecenzije { get; set; }
    internal protected virtual Istrazivac? Recenzent { get; set; }
    internal protected virtual ICollection<NizOcena> Ocene { get; set; } = new List<NizOcena>();
}