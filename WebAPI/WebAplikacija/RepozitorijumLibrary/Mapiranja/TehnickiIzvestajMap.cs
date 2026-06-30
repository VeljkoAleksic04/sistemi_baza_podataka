using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.Mapiranja
{
    internal class TehnickiIzvestajMap : SubclassMap<TehnickiIzvestaj>
    {
        public TehnickiIzvestajMap()
        {
            Table("TEHNICKI_IZVESTAJ");

            KeyColumn("ID_PUBLIKACIJE");
        }
    }
}
