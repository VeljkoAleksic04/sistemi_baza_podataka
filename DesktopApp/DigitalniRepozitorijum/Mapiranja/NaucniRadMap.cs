namespace DigitalniRepozitorijum.Mapiranja;
using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;

public class NaucniRadMap : SubclassMap<NaucniRad>
{
    public NaucniRadMap()
    {
        Table("NAUCNI_RAD");
        KeyColumn("ID_PUBLIKACIJE");

        Map(x => x.DOI, "DOI");
        Map(x => x.TipRada, "Tip_Rada");
        Map(x => x.Stranice, "Stranice");
        
        References(x => x.Izvor)
            .Column("ID_IZVORA")
            .Not.Nullable()
            .Cascade.None();
    }
}