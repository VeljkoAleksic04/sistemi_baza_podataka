using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;

namespace RepozitorijumLibrary.Mapiranja;

internal class IstrazivacEmailMap : ClassMap<IstrazivacEmail>
{
    public IstrazivacEmailMap()
    {
        Table("ISTRAZIVAC_EMAIL");

        Id(x => x.Id).Column("ID_ISTR_EMAIL").GeneratedBy.TriggerIdentity();

        Map(x => x.Email).Column("EMAIL");

        References(x => x.Istrazivac).Column("ID_ISTRAZIVACA");
    }
}
