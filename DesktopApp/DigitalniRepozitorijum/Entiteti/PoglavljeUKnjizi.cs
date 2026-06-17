using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Entiteti
{
    internal class PoglavljeUKnjizi : Publikacija
    {
        public virtual string Izdavac { get; set; }

        public virtual string MestoIzdanja { get; set; }
    }
}
