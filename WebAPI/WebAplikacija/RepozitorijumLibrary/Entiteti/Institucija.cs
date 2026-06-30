namespace RepozitorijumLibrary.Entiteti;

internal class Institucija
{
    internal protected virtual int Id { get; set; }
    internal protected virtual string Naziv { get; set; }
    internal protected virtual string Adresa { get; set; }

    internal protected virtual IList<InstitucijaKontaktMail> KontaktMailovi {  get; set; }
    internal protected virtual IList<InstitucijaKontaktTel> KontaktTelefoni {  get; set; }
    internal protected virtual IList<InstitucijaNaucnaOblast> NaucneOblasti {  get; set; }

    internal protected virtual IList<Angazovanje> Angazovanje { get; set; }

    internal Institucija()
    {
        KontaktMailovi = new List<InstitucijaKontaktMail>();
        KontaktTelefoni = new List<InstitucijaKontaktTel>();
        NaucneOblasti= new List<InstitucijaNaucnaOblast>();
        Angazovanje = new List<Angazovanje>();
    }



}
