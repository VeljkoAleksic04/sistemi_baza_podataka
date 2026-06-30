using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;

namespace RepozitorijumLibrary.Mapiranja;

internal class IstrazivacTelefonMap : ClassMap<IstrazivacTelefon>
{
    public IstrazivacTelefonMap()
    {
        Table("ISTRAZIVAC_TELEFONI");

        Id(x => x.Id).Column("ID_ISTR_TEL").GeneratedBy.TriggerIdentity();

        Map(x => x.Telefon).Column("TELEFON");

        References(x => x.Istrazivac).Column("ID_ISTRAZIVACA");
    }
}
