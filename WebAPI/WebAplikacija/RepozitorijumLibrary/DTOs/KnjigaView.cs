using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.DTOs
{
    public class KnjigaView : PublikacijaView
    {
        public string? Izdavac { get; set; }
        public string? MestoIzdanja { get; set; }

        public KnjigaView() 
        {
        }

        internal KnjigaView(Knjiga? k) : base(k)
        {
            if (k != null)
            {
                Izdavac = k.Izdavac;
                MestoIzdanja = k.MestoIzdanja;
            }
        }
    }
}
