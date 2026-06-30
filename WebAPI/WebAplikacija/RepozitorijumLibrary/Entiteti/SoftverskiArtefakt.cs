using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.Entiteti
{
    internal class SoftverskiArtefakt : Publikacija
    {
        internal protected virtual int IdArtefakta { get; set; }
        internal protected virtual string? ProgramskiJezik { get; set; }
        internal protected virtual string? LinkKaRepozitorijumu { get; set; }
        internal protected virtual string? NacinLicenciranja { get; set; }
    }
}
