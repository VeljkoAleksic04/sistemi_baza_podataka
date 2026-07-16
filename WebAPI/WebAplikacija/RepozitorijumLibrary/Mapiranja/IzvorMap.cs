using FluentNHibernate.Mapping;
using RepozitorijumLibrary.Entiteti;

namespace RepozitorijumLibrary.Mapiranja;

internal class IzvorMap : ClassMap<Izvor>
{
    public IzvorMap()
    {
        Table("IZVOR");

        Id(x => x.Id)
            .Column("ID")
            .GeneratedBy.TriggerIdentity();

        Map(x => x.Naziv)
            .Column("NAZIV")
            .Length(200)
            .Not.Nullable();

        HasMany(x => x.NaucniRadovi)
            .KeyColumn("ID_IZVORA")
            .Inverse()
            .Cascade.None();
    }
}