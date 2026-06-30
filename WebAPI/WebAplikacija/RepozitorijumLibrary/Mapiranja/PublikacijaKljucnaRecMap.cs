using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.Mapiranja
{
    internal class PublikacijaKljucnaRecMap : ClassMap<PublikacijaKljucnaRec>
    {
        public PublikacijaKljucnaRecMap() 
        {
            Table("PUBLIKACIJA_KLJUCNE_RECI");

            Id(x => x.Id)
                .Column("ID_PUB_REC")
                .GeneratedBy.TriggerIdentity();

            Map(x => x.KljucnaRec)
                .Column("KLJUCNA_REC");

            References(x => x.Publikacija)
                .Column("ID_PUBLIKACIJE");
        }

    }
}
