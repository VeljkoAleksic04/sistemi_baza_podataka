namespace DigitalniRepozitorijum.Entiteti;

public class Casopis : Izvor
{
    public virtual string ISSN { get; set; }

    public virtual int? BrojSveske { get; set; }

    public virtual int? BrojIzdanja { get; set; }
}