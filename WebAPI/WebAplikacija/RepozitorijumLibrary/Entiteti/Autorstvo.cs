namespace RepozitorijumLibrary.Entiteti;

internal class Autorstvo
{
    internal protected virtual int Id { get; set; }
    internal protected virtual Publikacija Publikacija { get; set; }
    internal protected virtual Istrazivac Autor { get; set; }
    internal protected virtual int RedosledAutora { get; set; }
    internal protected virtual string TipDoprinosa { get; set; }
    internal protected virtual string Uloga { get; set; }
}
