using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Mapiranja
{
    public class KnjigaMap : SubclassMap<Knjiga>
    {
        public KnjigaMap() 
        {
            Table("KNJIGA");

            KeyColumn("ID_PUBLIKACIJE");

            Map(x => x.Izdavac)
                .Column("IZDAVAC");

            Map(x => x.MestoIzdanja)
                .Column("MESTO_IZDANJA");
        }
    }
}
