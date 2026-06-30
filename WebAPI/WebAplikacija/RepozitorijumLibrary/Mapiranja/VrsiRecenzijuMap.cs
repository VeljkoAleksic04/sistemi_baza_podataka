namespace RepozitorijumLibrary.Mapiranja;
using FluentNHibernate.Mapping;
using RepozitorijumLibrary.Entiteti;

internal class VrsiRecenzijuMap : ClassMap<VrsiRecenziju>
{
    public VrsiRecenzijuMap()
    {
        Id(x => x.Id, "Id_Recenzije");
        Map(x => x.IdRundeRecenzije, "Id_Runde_Recenzije");
        Map(x => x.IdRecenzenta, "Id_recenzenta");
        Map(x => x.Preporuka, "Preporuka");
        
        References(x => x.RundaRecenzije, "Id_Runde_Recenzije")
            .Cascade.None();
        
        // Many-to-one sa Istrazivac (Recenzent)
        References(x => x.Recenzent, "Id_recenzenta")
            .Cascade.None();
        
        // One-to-many - OVO MAPIRA COMPOSITE FK
        HasMany(x => x.Ocene)
            .Cascade.All()
            .ForeignKeyCascadeOnDelete()
            .Inverse()
            .Not.LazyLoad();
    }
}