namespace DigitalniRepozitorijum.Mapiranja;
using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;

public class PoglavljeUredniciMap : ClassMap<PoglavljeUrednici>
{
    public PoglavljeUredniciMap()
    {
        Table("POGLAVLJE_UREDNICI");

        Id(x => x.Id, "Id_Poglavlje_Urednik").GeneratedBy.TriggerIdentity();

        Map(x => x.Urednik, "Urednik");
        
        References(x => x.PoglavljeUKnjizi, "Id_Publikacije")
            .Not.LazyLoad();
    }
}