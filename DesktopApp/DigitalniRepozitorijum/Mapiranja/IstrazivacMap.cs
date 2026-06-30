using DigitalniRepozitorijum.Entiteti;
using FluentNHibernate.Mapping;

namespace DigitalniRepozitorijum.Mapiranja;

class IstrazivacMap : ClassMap<Istrazivac>
{
    public IstrazivacMap()
    {
        Table("ISTRAZIVAC");

        Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.Ime).Column("IME");
        Map(x => x.Prezime).Column("PREZIME");
        Map(x => x.DatumRodjenja).Column("DATUM_RODJENJA");
        Map(x => x.Drzava).Column("DRZAVA");
        Map(x => x.StatusNaloga).Column("STATUS_NALOGA");
        Map(x => x.NaucnoZvanje).Column("NAUCNO_ZVANJE");
        Map(x => x.NaucnaOblast).Column("NAUCNA_OBLAST");
        Map(x => x.JeAutor).Column("JE_AUTOR");
        Map(x => x.JeRecenzent).Column("JE_RECENZENT");
        Map(x => x.JeUrednik).Column("JE_UREDNIK");
        Map(x => x.JeAdmin).Column("JE_ADMIN");
        Map(x => x.JeRukovodilacProjekta).Column("JE_RUKOVODILAC_PROJEKTA");
        Map(x => x.ORCID).Column("ORCID");
        Map(x => x.OblastEkspertize).Column("OBLAST_EKSPERTIZE");
        Map(x => x.UredjivackaSekcija).Column("UREDJIVACKA_SEKCIJA");
        Map(x => x.AdministratorskaOvlascenja).Column("ADMINISTRATORSKA_OVLASCENJA");

        HasMany(x => x.Emailovi).KeyColumn("ID_ISTRAZIVACA").Cascade.All().Inverse();
        HasMany(x => x.Telefoni).KeyColumn("ID_ISTRAZIVACA").Cascade.All().Inverse();
        HasMany(x => x.Angazovanja).KeyColumn("ID_ISTRAZIVACA").Cascade.All().Inverse();
        HasMany(x => x.Autorstva).KeyColumn("ID_AUTORA").Cascade.All().Inverse();
    }
}
