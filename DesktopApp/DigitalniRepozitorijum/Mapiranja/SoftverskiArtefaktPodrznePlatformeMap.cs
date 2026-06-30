namespace DigitalniRepozitorijum.Mapiranja;
using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;

public class SoftverskiArtefaktPodrznePlatformeMap : ClassMap<SoftverskiArtefaktPodrzanePlatforme>
{
    public SoftverskiArtefaktPodrznePlatformeMap()
    {
        Id(x => x.Id, "Id_SA_Platforma");
        
        Map(x => x.IdPublikacije, "Id_Publikacije");
        Map(x => x.PodrzanaPlatforma, "Podrzana_Platforma");
        
        References(x => x.SoftverskiArtefakt, "Id_Publikacije")
            .Not.LazyLoad();
    }
}