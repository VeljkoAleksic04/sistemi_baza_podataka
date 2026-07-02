using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Entiteti
{
    public class SoftverskiArtefakt : Publikacija
    {
        public virtual int IdArtefakta { get; set; }
        public virtual string? ProgramskiJezik { get; set; }
        public virtual string? Dokumentacija { get; set; }
        public virtual string? LinkKaRepozitorijumu { get; set; }
        public virtual string? NacinLicenciranja { get; set; }
    }
}
