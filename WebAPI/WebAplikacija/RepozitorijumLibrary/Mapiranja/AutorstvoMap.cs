using RepozitorijumLibrary.Entiteti;
using FluentNHibernate.Mapping;

namespace RepozitorijumLibrary.Mapiranja;

internal class AutorstvoMap : ClassMap<Autorstvo>
{
    public AutorstvoMap()
    {
        Table("AUTORSTVO");

        CompositeId(x => x.Id)
            .KeyReference(x => x.Publikacija, "ID_PUBLIKACIJE")
            .KeyReference(x => x.Autor, "ID_AUTORA");

        Map(x => x.RedosledAutora).Column("REDOSLED_AUTORA");
        Map(x => x.TipDoprinosa).Column("TIP_DOPRINOSA");
        Map(x => x.Uloga).Column("ULOGA");
    }
}
