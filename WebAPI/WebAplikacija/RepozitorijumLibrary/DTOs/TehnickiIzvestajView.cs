using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.DTOs
{
    public class TehnickiIzvestajView : PublikacijaView
    {
        public TehnickiIzvestajView()
        {

        }

        internal TehnickiIzvestajView(TehnickiIzvestaj? t) : base(t)
        {

        }
    }
}
