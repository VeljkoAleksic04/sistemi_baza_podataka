namespace RepozitorijumLibrary.Mapiranja;
using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;

internal class SoftverskiArtefaktMap : SubclassMap<SoftverskiArtefakt>
{
    public SoftverskiArtefaktMap()
    {
        Table("SOFTVERSKI_ARTEFAKT");
        KeyColumn("ID_PUBLIKACIJE");

        Map(x => x.ProgramskiJezik, "Programski_Jezik");
        Map(x => x.LinkKaRepozitorijumu, "Link_Ka_Repozitorijumu");
        Map(x => x.NacinLicenciranja, "Nacin_Licenciranja");
    }
}
