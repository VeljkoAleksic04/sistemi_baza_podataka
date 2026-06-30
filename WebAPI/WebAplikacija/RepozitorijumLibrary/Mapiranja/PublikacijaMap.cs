using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.Mapiranja
{
    internal class PublikacijaMap : ClassMap<Publikacija>
    {
        public PublikacijaMap()
        {
            Table("PUBLIKACIJA");

            Id(x => x.Id)
                .Column("ID")
                .GeneratedBy.TriggerIdentity();

            Map(x => x.Naslov)
                .Column("NASLOV");

            Map(x => x.Apstrakt)
                .Column("APSTRAKT");

            Map(x => x.Jezik)
                .Column("JEZIK");

            Map(x => x.DatumObjavljivanja)
                .Column("DATUM_OBJAVLJIVANJA");

            Map(x => x.DatumKreiranjaZapisa)
                .Column("DATUM_KREIRANJA_ZAPISA");

            Map(x => x.Status)
                .Column("STATUS");

            Map(x => x.Vidljivost)
                .Column("VIDLJIVOST");

            HasMany(x => x.Verzije)
                .Cascade.All()
                .Inverse();

            HasMany(x => x.KljucneReci)
                .Cascade.All()
                .Inverse();
        }

    }
}
