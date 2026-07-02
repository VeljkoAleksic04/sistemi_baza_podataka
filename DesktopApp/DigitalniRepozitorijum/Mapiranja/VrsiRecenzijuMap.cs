namespace DigitalniRepozitorijum.Mapiranja;
using FluentNHibernate.Mapping;
using DigitalniRepozitorijum.Entiteti;

public class VrsiRecenzijuMap : ClassMap<VrsiRecenziju>
{
    public VrsiRecenzijuMap()
    {
        Id(x => x.Id, "Id_Recenzije");
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