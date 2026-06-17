using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Mapiranja
{
    public class PoglavljeUKnjiziMap : SubclassMap<PoglavljeUKnjizi>
    {
        public PoglavljeUKnjiziMap()
        {
            Table("POGLAVLJE_U_KNJIZI");

            KeyColumn("ID_PUBLIKACIJE");

            Map(x => x.Izdavac)
                .Column("IZDAVAC");

            Map(x => x.MestoIzdanja)
                .Column("MESTO_IZDANJA");
        }
    }
}
