using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;

namespace RepozitorijumLibrary.Mapiranja;

internal class InstitucijaMap : ClassMap<Institucija>
{
    public InstitucijaMap()
    {
        Table("INSTITUCIJA");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.Naziv).Column("NAZIV");
        Map(x => x.Adresa).Column("ADRESA");

        HasMany(x => x.KontaktMailovi).KeyColumn("ID_INSTITUCIJE").Cascade.All().Inverse();
        HasMany(x => x.KontaktTelefoni).KeyColumn("ID_INSTITUCIJE").Cascade.All().Inverse();
        HasMany(x => x.NaucneOblasti).KeyColumn("ID_INSTITUCIJE").Cascade.All().Inverse();
        HasMany(x => x.Angazovanje).KeyColumn("ID_INSTITUCIJE").Cascade.All().Inverse();
    }
}
