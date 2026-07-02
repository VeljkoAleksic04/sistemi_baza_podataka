using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Mapiranja
{
    public class SoftverskiArtefaktMap : SubclassMap<SoftverskiArtefakt>
    {
        public SoftverskiArtefaktMap()
        {
            Table("SOFTVERSKI_ARTEFAKT");
            KeyColumn("ID_PUBLIKACIJE");

            Map(x => x.ProgramskiJezik, "Programski_Jezik");
            Map(x => x.Dokumentacija, "Dokumentacija");
            Map(x => x.LinkKaRepozitorijumu, "Link_Ka_Repozitorijumu");
            Map(x => x.NacinLicenciranja, "Nacin_Licenciranja");
        }
    }
}
