using FluentNHibernate.Mapping;
using DigitalniRepozitorijum.Entiteti;

namespace DigitalniRepozitorijum.Mapiranja;

public class CitiraMap : ClassMap<Citira>
{
    public CitiraMap()
    {
        Table("CITIRA");

        Id(x => x.Id, "Id_citata").GeneratedBy.TriggerIdentity();


        Map(x => x.TipCitata, "Tip_citata");
        Map(x => x.MestoCitiranja, "Mesto_citiranja");
        Map(x => x.TekstualniKontekst, "Tekstualni_kontekst");

        References(x => x.PubCitirana, "Id_citirana");
        References(x => x.PubCitira, "Id_citira");
    }
}