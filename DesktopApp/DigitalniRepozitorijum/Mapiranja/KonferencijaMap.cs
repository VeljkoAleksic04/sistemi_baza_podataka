namespace DigitalniRepozitorijum.Mapiranja;
using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;

public class KonferencijaMap : SubclassMap<Konferencija>
{
    public KonferencijaMap()
    {
        Table("KONFERENCIJA");

        KeyColumn("ID_IZVORA");

        Map(x => x.ISBN)
            .Column("ISBN");
    }
}