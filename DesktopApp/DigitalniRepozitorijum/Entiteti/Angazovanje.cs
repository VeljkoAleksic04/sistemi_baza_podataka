using System;

namespace DigitalniRepozitorijum.Entiteti;

public class Angazovanje
{
    public virtual AngazovanjeId Id { get; set; }
    public virtual string OrganizacionaJedinica { get; set; }
    public virtual string TipAngazovanja { get; set; }
    public virtual string NazivPozicije { get; set; }
    public virtual DateTime DatumPocetka { get; set; }
    public virtual DateTime? DatumZavrsetka { get; set; }

    public Angazovanje()
    {
        Id = new AngazovanjeId();
    }
}
