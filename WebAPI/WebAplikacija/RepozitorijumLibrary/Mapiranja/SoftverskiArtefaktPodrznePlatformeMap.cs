namespace RepozitorijumLibrary.Mapiranja;
using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;

internal class SoftverskiArtefaktPodrznePlatformeMap : ClassMap<SoftverskiArtefaktPodrzanePlatforme>
{
    public SoftverskiArtefaktPodrznePlatformeMap()
    {
        Table("SOFTVERSKI_ARTEFAKT_PLATFORME");

        Id(x => x.Id, "Id_SA_Platforma").GeneratedBy.TriggerIdentity();

        Map(x => x.PodrzanaPlatforma, "Podrzana_Platforma");

        References(x => x.SoftverskiArtefakt, "Id_Publikacije")
            .Not.LazyLoad();
    }
}
