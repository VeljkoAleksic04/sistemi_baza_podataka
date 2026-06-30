using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.DTOs
{
    public class PublikacijaView
    {
        public int Id { get; set; }

        public string? Naslov { get; set; }
        public string? Apstrakt { get; set; }
        public string? Jezik { get; set; }

        public DateTime? DatumObjavljivanja { get; set; }
        public DateTime? DatumKreiranjaZapisa { get; set; }

        public string? Status { get; set; }
        public string? Vidljivost { get; set; }

        public virtual IList<VerzijaView> Verzije { get; set; }
        public virtual IList<PublikacijaKljucnaRecView> KljucneReci { get; set; }

        public PublikacijaView()
        {
            Verzije = new List<VerzijaView>();
            KljucneReci = new List<PublikacijaKljucnaRecView>();
        }

        internal PublikacijaView(Publikacija? p) : this()
        {
            if (p != null)
            {
                Id = p.Id;
                Naslov = p.Naslov; 
                Apstrakt = p.Apstrakt; 
                Jezik = p.Jezik;
                DatumObjavljivanja = p.DatumObjavljivanja;
                DatumKreiranjaZapisa = p.DatumKreiranjaZapisa;
                Status = p.Status;
                Vidljivost = p.Vidljivost;
            }
        }
    }
}
