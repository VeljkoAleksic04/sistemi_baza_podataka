using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.Mapiranja
{
    internal class PrezentacijaMap : SubclassMap<Prezentacija>
    {
        public PrezentacijaMap()
        {
            Table("PREZENTACIJA");

            KeyColumn("ID_PUBLIKACIJE");
        }
    }
}
