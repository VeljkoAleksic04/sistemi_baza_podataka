namespace RepozitorijumLibrary.Entiteti;

internal class Autorstvo
{
    internal protected virtual AutorstvoId Id { get; set; }
    internal protected virtual int RedosledAutora { get; set; }
    internal protected virtual string TipDoprinosa { get; set; }
    internal protected virtual string Uloga { get; set; }

    internal Autorstvo()
    {
        Id = new AutorstvoId();
    }
}
