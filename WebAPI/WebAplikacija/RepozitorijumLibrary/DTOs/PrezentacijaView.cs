using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.DTOs
{
    public class PrezentacijaView : PublikacijaView
    {
        public PrezentacijaView()
        {

        }

        internal PrezentacijaView(Prezentacija? p) : base(p)
        {

        }
    }
}
