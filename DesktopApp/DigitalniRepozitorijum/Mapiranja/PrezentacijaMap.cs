using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Mapiranja
{
    public class PrezentacijaMap : SubclassMap<Prezentacija>
    {
        public PrezentacijaMap()
        {
            Table("PREZENTACIJA");

            KeyColumn("ID_PUBLIKACIJE");
        }
    }
}
