namespace RepozitorijumLibrary.Mapiranja;
using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;

internal class CasopisMap : SubclassMap<Casopis>
{
    public CasopisMap()
    {
        Table("CASOPIS");

        KeyColumn("ID_IZVORA");

        Map(x => x.ISSN)
            .Column("ISSN");

        Map(x => x.BrojSveske)
            .Column("BROJ_SVESKE");

        Map(x => x.BrojIzdanja)
            .Column("BROJ_IZDANJA");
    }
}