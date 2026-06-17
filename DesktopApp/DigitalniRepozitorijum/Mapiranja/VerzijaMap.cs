using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Mapiranja
{
    public class VerzijaMap : ClassMap<Verzija>
    {
        public VerzijaMap() 
        {
            Table("VERZIJA");

            Id(x => x.Id)
                .Column("ID_VERZIJE")
                .GeneratedBy.TriggerIdentity();

            Map(x => x.BrojVerzije)
                .Column("BROJ_VERZIJE");

            Map(x => x.DatumPostavljanja)
                .Column("DATUM_POSTAVLJANJA");

            Map(x => x.OpisIzmene)
                .Column("OPIS_IZMENE");

            Map(x => x.OdgovornaOsoba)
                .Column("ODGOVORNA_OSOBA");

            References(x => x.Publikacija)
                .Column("ID_PUBLIKACIJE");

            HasMany(x => x.Fajlovi)
                .Cascade.All()
                .Inverse();
        }
    }
}
