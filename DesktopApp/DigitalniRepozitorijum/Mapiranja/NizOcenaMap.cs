namespace DigitalniRepozitorijum.Mapiranja;
using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;

public class NizOcenaMap : ClassMap<NizOcena>
{
    public NizOcenaMap()
    {
        Id(x => x.Id, "Id_Ocene");
        
        Map(x => x.Kriterijum, "Kriterijum");
        Map(x => x.Ocena, "Ocena");


        References(x => x.RundaRecenzije, "ID_RUNDE_RECENZIJE")
            .Cascade.None();

        References(x => x.Recenzent, "ID_RECENZENTA")
            .Cascade.None();
        // Samo mapa unazad ka VrsiRecenziju
        References(x => x.VrsiRecenziju)
            .Not.LazyLoad();

    }
}