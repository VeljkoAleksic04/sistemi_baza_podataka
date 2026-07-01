using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.DTOs
{
    public class ObrazovniMaterijalView : PublikacijaView
    {
        public ObrazovniMaterijalView()
        {

        }

        internal ObrazovniMaterijalView(ObrazovniMaterijal? o) : base(o)
        {

        }
    }
}
