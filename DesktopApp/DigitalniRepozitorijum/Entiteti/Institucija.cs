namespace DigitalniRepozitorijum.Entiteti;

public class Institucija
{
    public virtual int Id { get; set; }
    public virtual string Naziv { get; set; }
    public virtual string Adresa { get; set; }

    public virtual IList<InstitucijaKontaktMail> KontaktMailovi {  get; set; }
    public virtual IList<InstitucijaKontaktTel> KontaktTelefoni {  get; set; }
    public virtual IList<InstitucijaNaucnaOblast> NaucneOblasti {  get; set; }

    public virtual IList<Angazovanje> Angazovanje { get; set; }

    public Institucija()
    {
        KontaktMailovi = new List<InstitucijaKontaktMail>();
        KontaktTelefoni = new List<InstitucijaKontaktTel>();
        NaucneOblasti= new List<InstitucijaNaucnaOblast>();
        Angazovanje = new List<Angazovanje>();
    }





}
