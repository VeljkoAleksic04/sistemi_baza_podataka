using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;

namespace RepozitorijumLibrary.Mapiranja;

internal class InstitucijaKontaktTelMap : ClassMap<InstitucijaKontaktTel>
{
    public InstitucijaKontaktTelMap()
    {
        Table("INSTITUCIJA_KONTAKT_TEL");

        Id(x => x.Id).Column("ID_INST_TEL").GeneratedBy.TriggerIdentity();

        Map(x => x.KontaktTel).Column("KONTAKT_TEL");

        References(x => x.Institucija).Column("ID_INSTITUCIJE");
    }
}
