using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.DTOs
{
    public class FajlView
    {
        public int Id { get; set; }
        public VerzijaView? Verzija { get; set; }
        public string? Putanja { get; set; }

        public FajlView()
        {
        }

        internal FajlView(Fajl? f)
        {
            if (f != null)
            {
                Id = f.Id;
                Putanja = f.Putanja;
            }
        }

        internal FajlView(Fajl? f, Verzija? v) : this(f)
        {
            if (v != null)
            {
                Verzija = new VerzijaView(v);
            }
        }
    }
}
