using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;

namespace RepozitorijumLibrary.Mapiranja;

internal class InstitucijaKontaktMailMap : ClassMap<InstitucijaKontaktMail>
{
    public InstitucijaKontaktMailMap()
    {
        Table("INSTITUCIJA_KONTAKT_MAIL");

        Id(x => x.Id).Column("ID_INST_MAIL").GeneratedBy.TriggerIdentity();

        Map(x => x.KontaktMail).Column("KONTAKT_MAIL");

        References(x => x.Institucija).Column("ID_INSTITUCIJE");
    }
}
