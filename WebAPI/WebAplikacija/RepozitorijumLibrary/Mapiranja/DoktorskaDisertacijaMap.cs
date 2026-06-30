using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.Mapiranja
{
    internal class DoktorskaDisertacijaMap : SubclassMap<DoktorskaDisertacija>
    {
        public DoktorskaDisertacijaMap() 
        {
            Table("DOKTORSKA_DISERTACIJA");

            KeyColumn("ID_PUBLIKACIJE");
        }
    }
}
