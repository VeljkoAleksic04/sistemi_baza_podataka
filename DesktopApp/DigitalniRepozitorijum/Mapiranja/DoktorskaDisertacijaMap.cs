using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Mapiranja
{
    public class DoktorskaDisertacijaMap : SubclassMap<DoktorskaDisertacija>
    {
        public DoktorskaDisertacijaMap() 
        {
            Table("DOKTORSKA_DISERTACIJA");

            KeyColumn("ID_PUBLIKACIJE");
        }
    }
}
