using FluentNHibernate.Mapping;
using DigitalniRepozitorijum.Entiteti;

namespace DigitalniRepozitorijum.Mapiranja;

public class CitiraMap : ClassMap<Citira>
{
    public CitiraMap()
    {
        Table("CITIRA");

        Id(x => x.Id, "Id_citata").GeneratedBy.TriggerIdentity();
        
        Map(x => x.IdCitira, "Id_citira");
        Map(x => x.IdCitirana, "Id_citirana");
        Map(x => x.TipCitata, "Tip_citata");
        Map(x => x.MestoCitiranja, "Mesto_citiranja");
        Map(x => x.TekstualniKontekst, "Tekstualni_kontekst");
    }
}