using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Entiteti
{
    public class NaucniRad : Publikacija
    {
        public virtual int IdPublikacije { get; set; }
        public virtual string? DOI { get; set; }
        public virtual string? TipRada { get; set; }
        public virtual string? Stranice { get; set; }
    }
}
