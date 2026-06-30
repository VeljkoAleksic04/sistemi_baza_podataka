namespace RepozitorijumLibrary.Entiteti;

internal abstract class Izvor
{
    internal protected virtual int Id { get; protected set; }
    internal protected virtual string Naziv { get; set; }
    internal protected virtual IList<NaucniRad> NaucniRadovi { get; set; }

    internal Izvor()
    {
        NaucniRadovi = new List<NaucniRad>();
    }
}