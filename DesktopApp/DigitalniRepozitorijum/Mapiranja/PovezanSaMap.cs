namespace DigitalniRepozitorijum.Mapiranja;
using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;

public class PovezanSaMap : ClassMap<PovezanSa>
{
    public PovezanSaMap() 
    {
        Id(x => x.Id, "Id_povezan");
        
        Map(x => x.IdPublikacije1, "Id_publikacije_1");
        Map(x => x.IdPublikacije2, "Id_publikacije_2");
        Map(x => x.TipPovezanosti, "Tip_povezanosti");
        
        References(x => x.Publikacija1, "Id_publikacije_1")
            .Not.LazyLoad();
        References(x => x.Publikacija2, "Id_publikacije_2")
            .Not.LazyLoad();
    }
}