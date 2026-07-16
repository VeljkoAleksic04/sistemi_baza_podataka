namespace DigitalniRepozitorijum.Mapiranja;
using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;

public class PovezanSaMap : ClassMap<PovezanSa>
{
    public PovezanSaMap() 
    {
        Table("POVEZAN_SA");

        Id(x => x.Id, "Id_povezan").GeneratedBy.TriggerIdentity();
        
        Map(x => x.TipPovezanosti, "Tip_povezanosti");
        
        References(x => x.Publikacija1, "Id_publikacije_1")
            .Not.LazyLoad();
        References(x => x.Publikacija2, "Id_publikacije_2")
            .Not.LazyLoad();
    }
}