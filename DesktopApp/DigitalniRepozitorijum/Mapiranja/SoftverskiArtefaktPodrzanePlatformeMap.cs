namespace DigitalniRepozitorijum.Mapiranja;
using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;

public class SoftverskiArtefaktPodrzanePlatformeMap : ClassMap<SoftverskiArtefaktPodrzanePlatforme>
{
    public SoftverskiArtefaktPodrzanePlatformeMap()
    {
        Table("SA_PODRZANE_PLATFORME");
        Id(x => x.Id, "Id_SA_Platforma").GeneratedBy.TriggerIdentity();

        Map(x => x.PodrzanaPlatforma, "Podrzana_Platforma");

        References(x => x.SoftverskiArtefakt, "Id_Publikacije")
            .Not.LazyLoad();
    }
}