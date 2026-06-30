using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.Entiteti;
internal class NaucniRad : Publikacija
{
    internal protected virtual string? DOI { get; set; }
    internal protected virtual string? TipRada { get; set; }
    internal protected virtual string? Stranice { get; set; }
    internal protected virtual int IdIzvora { get; set; }
    internal protected virtual Izvor? Izvor { get; set; }
}
