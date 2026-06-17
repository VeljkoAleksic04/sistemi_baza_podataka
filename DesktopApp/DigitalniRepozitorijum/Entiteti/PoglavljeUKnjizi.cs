using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Entiteti
{
    public class PoglavljeUKnjizi : Publikacija
    {
        public virtual string Izdavac { get; set; }

        public virtual string MestoIzdanja { get; set; }
    }
}
