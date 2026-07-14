using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;

namespace DigitalniRepozitorijum.Mapiranja;

class AutorstvoMap : ClassMap<Autorstvo>
{
    public AutorstvoMap()
    {
        Table("AUTORSTVO");
        Id(x => x.Id).Column("ID_AUTORSTVA").GeneratedBy.TriggerIdentity();
        References(x => x.Publikacija).Column("ID_PUBLIKACIJE");
        References(x => x.Autor).Column("ID_AUTORA");
        Map(x => x.RedosledAutora).Column("REDOSLED_AUTORA");
        Map(x => x.TipDoprinosa).Column("TIP_DOPRINOSA");
        Map(x => x.Uloga).Column("ULOGA");
    }
}
