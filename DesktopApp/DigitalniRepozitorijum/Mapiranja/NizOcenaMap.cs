namespace DigitalniRepozitorijum.Mapiranja;
using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;

public class NizOcenaMap : ClassMap<NizOcena>
{
    public NizOcenaMap()
    {
        Table("NIZ_OCENA");

        Id(x => x.Id).Column("ID_OCENE").GeneratedBy.Sequence("seq_niz_ocena");

        Map(x => x.Kriterijum, "Kriterijum");
        Map(x => x.Ocena, "Ocena");


        References(x => x.RundaRecenzije, "ID_RUNDE_RECENZIJE")
            .Cascade.None();

        References(x => x.Recenzent, "ID_RECENZENTA")
            .Cascade.None();

        //References(x => x.VrsiRecenziju, "ID_RECENZIJE")  // једна колона директно ка Id_Recenzije
        //    .Cascade.None()
        //    .Not.LazyLoad();
    }
}