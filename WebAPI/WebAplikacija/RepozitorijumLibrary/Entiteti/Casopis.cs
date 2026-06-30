namespace RepozitorijumLibrary.Entiteti;

internal class Casopis : Izvor
{
    internal protected virtual string ISSN { get; set; }
    internal protected virtual int? BrojSveske { get; set; }
    internal protected virtual int? BrojIzdanja { get; set; }
}