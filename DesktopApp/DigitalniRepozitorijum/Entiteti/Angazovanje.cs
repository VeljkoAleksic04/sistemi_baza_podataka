using System;

namespace DigitalniRepozitorijum.Entiteti;

public class Angazovanje
{
    public virtual int Id { get; set; }
    public virtual Institucija Institucija { get; set; }
    public virtual Istrazivac Istrazivac { get; set; }
    public virtual string OrganizacionaJedinica { get; set; }
    public virtual string TipAngazovanja { get; set; }
    public virtual string NazivPozicije { get; set; }
    public virtual DateTime DatumPocetka { get; set; }
    public virtual DateTime? DatumZavrsetka { get; set; }
}
