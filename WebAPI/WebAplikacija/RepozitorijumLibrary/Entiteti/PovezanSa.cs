namespace RepozitorijumLibrary.Entiteti;

internal class PovezanSa
{
    internal protected virtual int Id { get; set; }
    internal protected virtual int IdPublikacije1 { get; set; }
    internal protected virtual int IdPublikacije2 { get; set; }
    internal protected virtual required string TipPovezanosti { get; set; }
    internal protected virtual Publikacija? Publikacija1 { get; set; }
    internal protected virtual Publikacija? Publikacija2 { get; set; }
}
