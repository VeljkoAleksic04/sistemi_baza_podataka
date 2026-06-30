using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Entiteti;
public class NaucniRad : Publikacija
{
    public virtual string? DOI { get; set; }
    public virtual string? TipRada { get; set; }
    public virtual string? Stranice { get; set; }
    public virtual int IdIzvora { get; set; }
    public virtual Izvor? Izvor { get; set; }
}
