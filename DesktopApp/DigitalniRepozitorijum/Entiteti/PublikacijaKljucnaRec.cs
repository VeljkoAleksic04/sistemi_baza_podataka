using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Entiteti
{
    public class PublikacijaKljucnaRec
    {
        public virtual int Id { get; set; }

        public virtual Publikacija Publikacija { get; set; }
        public virtual string KljucnaRec { get; set; }

    }
}
