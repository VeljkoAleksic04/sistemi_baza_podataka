namespace RepozitorijumLibrary.Mapiranja;
using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;

internal class KonferencijaMap : SubclassMap<Konferencija>
{
    public KonferencijaMap()
    {
        Table("KONFERENCIJA");

        KeyColumn("ID_IZVORA");

        Map(x => x.ISBN)
            .Column("ISBN");
    }
}