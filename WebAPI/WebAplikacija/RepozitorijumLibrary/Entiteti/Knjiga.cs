using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.Entiteti
{
    internal class Knjiga : Publikacija
    {
        internal protected virtual string Izdavac { get; set; }

        internal protected virtual string MestoIzdanja { get; set; }
    }
}
