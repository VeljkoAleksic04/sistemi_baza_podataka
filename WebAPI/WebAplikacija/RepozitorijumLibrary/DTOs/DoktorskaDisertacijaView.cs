using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.DTOs
{
    public class DoktorskaDisertacijaView : PublikacijaView
    {
        public DoktorskaDisertacijaView()
        {

        }

        internal DoktorskaDisertacijaView(DoktorskaDisertacija? d) : base(d)
        {

        }
    }
}
