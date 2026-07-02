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
            Map(x => x.IdArtefakta, "Id_Publikacije");
            Map(x => x.ProgramskiJezik, "Programski_Jezik");
            Map(x => x.Dokumentacija, "Dokumentacija");
            Map(x => x.LinkKaRepozitorijumu, "Link_Ka_Repozitorijumu");
            Map(x => x.NacinLicenciranja, "Nacin_Licenciranja");
        }
    }
}
