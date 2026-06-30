using FluentNHibernate.Mapping;
using DigitalniRepozitorijum.Entiteti;

namespace DigitalniRepozitorijum.Mapiranja;

public class IzvorMap : ClassMap<Izvor>
{
    public IzvorMap()
    {
        Table("IZVOR");

        Id(x => x.Id)
            .Column("ID")
            .GeneratedBy.Sequence("SEQ_IZVOR");

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