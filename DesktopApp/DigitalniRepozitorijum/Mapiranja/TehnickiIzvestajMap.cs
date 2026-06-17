using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Mapiranja
{
    public class TehnickiIzvestajMap : SubclassMap<TehnickiIzvestaj>
    {
        public TehnickiIzvestajMap()
        {
            Table("TEHNICKI_IZVESTAJ");

            KeyColumn("ID_PUBLIKACIJE");
        }
    }
}
