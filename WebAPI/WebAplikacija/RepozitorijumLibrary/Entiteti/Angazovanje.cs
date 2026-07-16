using System;

namespace RepozitorijumLibrary.Entiteti;

internal class Angazovanje
{
    internal protected virtual int Id { get; set; }
    internal protected virtual Institucija Institucija { get; set; }
    internal protected virtual Istrazivac Istrazivac { get; set; }
    internal protected virtual string OrganizacionaJedinica { get; set; }
    internal protected virtual string TipAngazovanja { get; set; }
    internal protected virtual string NazivPozicije { get; set; }
    internal protected virtual DateTime DatumPocetka { get; set; }
    internal protected virtual DateTime? DatumZavrsetka { get; set; }
}
