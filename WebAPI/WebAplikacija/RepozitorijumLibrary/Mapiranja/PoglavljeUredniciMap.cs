namespace RepozitorijumLibrary.Mapiranja;
using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;

internal class PoglavljeUredniciMap : ClassMap<PoglavljeUrednici>
{
    public PoglavljeUredniciMap()
    {
        Id(x => x.Id, "Id_Poglavlje_Urednik");
        
        Map(x => x.IdPublikacije, "Id_Publikacije");
        Map(x => x.Urednik, "Urednik");
        
        References(x => x.PoglavljeUKnjizi, "Id_Publikacije")
            .Not.LazyLoad();
    }
}