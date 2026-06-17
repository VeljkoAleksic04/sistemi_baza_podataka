using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Mapiranja
{
    public class ObrazovniMaterijalMap : SubclassMap<ObrazovniMaterijal>
    {
        public ObrazovniMaterijalMap()
        {
            Table("OBRAZOVNI_MATERIJAL");

            KeyColumn("ID_PUBLIKACIJE");
        }
    }
}
