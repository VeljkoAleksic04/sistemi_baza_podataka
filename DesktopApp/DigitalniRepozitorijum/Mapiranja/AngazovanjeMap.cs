using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;

namespace DigitalniRepozitorijum.Mapiranja;

class AngazovanjeMap : ClassMap<Angazovanje>
{
    public AngazovanjeMap()
    {
        Table("ANGAZOVANJE");
        Id(x => x.Id).Column("ID_ANGAZOVANJA").GeneratedBy.TriggerIdentity();
        References(x => x.Institucija).Column("ID_INSTITUCIJE");
        References(x => x.Istrazivac).Column("ID_ISTRAZIVACA");
        Map(x => x.OrganizacionaJedinica).Column("ORGANIZACIONA_JEDINICA");
        Map(x => x.TipAngazovanja).Column("TIP_ANGAZOVANJA");
        Map(x => x.NazivPozicije).Column("NAZIV_POZICIJE");
        Map(x => x.DatumPocetka).Column("DATUM_POCETKA");
        Map(x => x.DatumZavrsetka).Column("DATUM_ZAVRSETKA");
    }
}
