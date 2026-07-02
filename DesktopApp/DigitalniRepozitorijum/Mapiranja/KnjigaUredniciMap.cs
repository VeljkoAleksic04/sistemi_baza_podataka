namespace DigitalniRepozitorijum.Mapiranja;
using FluentNHibernate.Mapping;
using DigitalniRepozitorijum.Entiteti;

public class KnjigaUredniciMap : ClassMap<KnjigaUrednici>
{
    public KnjigaUredniciMap()
    {
        Id(x => x.Id, "Id_Knjiga_Urednik");
        
        Map(x => x.Urednik, "Urednik");
        
        References(x => x.Knjiga, "Id_Publikacije")
            .Not.LazyLoad();
    }
}