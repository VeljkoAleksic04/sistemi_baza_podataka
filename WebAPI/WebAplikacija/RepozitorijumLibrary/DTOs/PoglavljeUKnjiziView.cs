using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.DTOs
{
    internal class PoglavljeUKnjiziView : PublikacijaView
    {
        public string? Izdavac { get; set; }
        public string? MestoIzdanja { get; set; }

        public PoglavljeUKnjiziView()
        {
        }

        internal PoglavljeUKnjiziView(PoglavljeUKnjizi? pk) : base(pk)
        {
            if (pk != null)
            {
                Izdavac = pk.Izdavac;
                MestoIzdanja = pk.MestoIzdanja;
            }
        }
    }
}
