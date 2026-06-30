using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.DTOs
{
    public class PublikacijaKljucnaRecView
    {
        public int Id { get; set; }

        public PublikacijaView? Publikacija { get; set; }

        public string? KljucnaRec { get; set; }

        public PublikacijaKljucnaRecView()
        {
        }

        internal PublikacijaKljucnaRecView(PublikacijaKljucnaRec? pkr)
        {
            if (pkr != null)
            {
                Id = pkr.Id;
                KljucnaRec = pkr.KljucnaRec;
            }
        }

        internal PublikacijaKljucnaRecView(PublikacijaKljucnaRec? pkr, Publikacija? p) : this(pkr)
        {
            if (p != null)
            {
                Publikacija = new PublikacijaView(p);
            }
        }
    }
}
