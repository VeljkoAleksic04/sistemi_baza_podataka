using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;

namespace DigitalniRepozitorijum.Mapiranja;

class InstitucijaNaucnaOblastMap : ClassMap<InstitucijaNaucnaOblast>
{
    public InstitucijaNaucnaOblastMap()
    {
        Table("INSTITUCIJA_NAUCNE_OBLASTI");

        Id(x => x.Id).Column("ID_INST_OBLAST").GeneratedBy.TriggerIdentity();

        Map(x => x.NaucnaOblast).Column("NAUCNA_OBLAST");

        References(x => x.Institucija).Column("ID_INSTITUCIJE");
    }
}
