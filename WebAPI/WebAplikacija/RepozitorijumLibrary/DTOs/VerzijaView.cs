using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.DTOs
{
    public class VerzijaView
    {
        public int Id { get; set; }
        public int? BrojVerzije { get; set; }
        public PublikacijaView? Publikacija { get; set; }
        public DateTime? DatumPostavljanja { get; set; }
        public string? OpisIzmene { get; set; }
        public string? OdgovornaOsoba { get; set; }

        public IList<FajlView> Fajlovi { get; set; }

        public VerzijaView()
        {
            Fajlovi = new List<FajlView>();
        }

        internal VerzijaView(Verzija? v) : this()
        {
            if (v != null)
            {
                Id = v.Id;
                BrojVerzije = v.BrojVerzije;
                DatumPostavljanja = v.DatumPostavljanja;
                OpisIzmene = v.OpisIzmene;
                OdgovornaOsoba = v.OdgovornaOsoba;
            }
        }

        internal VerzijaView(Verzija? v, Publikacija? p) : this(v)
        {
            if (p != null)
            {
                Publikacija = new PublikacijaView(p);
            }
        }
    }
}
