using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.Entiteti
{
    internal class PublikacijaKljucnaRec
    {
        internal protected virtual int Id { get; set; }

        internal protected virtual Publikacija Publikacija { get; set; }
        internal protected virtual string KljucnaRec { get; set; }

    }
}
