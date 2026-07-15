namespace RepozitorijumLibrary.Mapiranja;
using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;

internal class DatasetMap : SubclassMap<Dataset>
{
    public DatasetMap()
    {
        Table("DATASET");
        KeyColumn("ID_PUBLIKACIJE");

        Map(x => x.BrojZapisa, "Broj_Zapisa");
        Map(x => x.Velicina, "Velicina");
        Map(x => x.OpisStrukture, "Opis_Strukture");
        Map(x => x.Format, "Format");
        Map(x => x.LicencaKoriscenja, "Licenca_Koriscenja");
        Map(x => x.DatumOd, "Datum_Od");
        Map(x => x.DatumDo, "Datum_Do");
    }
}
