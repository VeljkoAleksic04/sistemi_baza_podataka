namespace RepozitorijumLibrary.Mapiranja;
using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;

internal class NizOcenaMap : ClassMap<NizOcena>
{
    public NizOcenaMap()
    {
        Id(x => x.Id, "Id_Ocene").GeneratedBy.TriggerIdentity();
        
        Map(x => x.IdRundeRecenzije, "Id_Runde_Recenzije");
        Map(x => x.IdRecenzenta, "Id_recenzenta");
        Map(x => x.Kriterijum, "Kriterijum");
        Map(x => x.Ocena, "Ocena");
        
        // Samo mapa unazad ka VrsiRecenziju
        References(x => x.VrsiRecenziju)
            .Not.LazyLoad();

    }
}