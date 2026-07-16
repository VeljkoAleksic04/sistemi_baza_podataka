namespace RepozitorijumLibrary.Mapiranja;
using FluentNHibernate.Mapping;
using RepozitorijumLibrary.Entiteti;

internal class VrsiRecenzijuMap : ClassMap<VrsiRecenziju>
{
    public VrsiRecenzijuMap()
    {
        Table("VRSI_RECENZIJU");

        Id(x => x.Id, "Id_Recenzije").GeneratedBy.TriggerIdentity();
        Map(x => x.Preporuka, "Preporuka");

        References(x => x.RundaRecenzije, "Id_Runde_Recenzije")
            .Cascade.None();

        References(x => x.Recenzent, "Id_recenzenta")
            .Cascade.None();

        HasMany(x => x.Ocene)
            .Cascade.All()
            .ForeignKeyCascadeOnDelete()
            .Inverse()
            .Not.LazyLoad();
    }
}
