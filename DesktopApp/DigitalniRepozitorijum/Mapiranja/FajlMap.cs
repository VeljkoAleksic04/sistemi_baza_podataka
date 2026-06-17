using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Mapiranja
{
    public class FajlMap : ClassMap<Fajl>
    {
        public FajlMap()
        {
            Table("FAJLOVI");

            Id(x => x.Id)
                .Column("ID_FAJLA")
                .GeneratedBy.TriggerIdentity();

            Map(x => x.Putanja)
                .Column("FAJL");

            References(x => x.Verzija)
                .Column("ID_VERZIJE");
        }
    }
}
