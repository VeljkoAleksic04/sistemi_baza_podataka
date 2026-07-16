namespace RepozitorijumLibrary.Mapiranja;
using FluentNHibernate.Mapping;
using RepozitorijumLibrary.Entiteti;

internal class RundaRecenzijeMap : ClassMap<RundaRecenzije>
{
    public RundaRecenzijeMap()
    {
        Table("RUNDA_RECENZIJE");

        Id(x => x.Id, "Id_Runde_Recenzije").GeneratedBy.TriggerIdentity();

        Map(x => x.BrojRunde, "Broj_Runde");
        Map(x => x.Datum, "Datum");
        Map(x => x.KonacnaOdluka, "Konacna_Odluka");

        References(x => x.Publikacija, "Id_Publikacije")
            .Not.LazyLoad();
        References(x => x.Urednik, "Id_Urednika")
            .Not.LazyLoad();
        HasMany(x => x.Recenzije)
            .Cascade.All()
            .KeyColumn("Id_Runde_Recenzije");
    }
}
