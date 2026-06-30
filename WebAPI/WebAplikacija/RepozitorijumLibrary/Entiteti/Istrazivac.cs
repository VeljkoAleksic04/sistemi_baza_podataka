using System;
using System.Collections.Generic;


namespace RepozitorijumLibrary.Entiteti;

internal class Istrazivac
{

    internal protected virtual int Id { get; set; }
    internal protected virtual string Ime { get; set; }
    internal protected virtual string Prezime { get; set; }
    internal protected virtual DateTime DatumRodjenja { get; set; }
    internal protected virtual string Drzava { get; set; }
    internal protected virtual string StatusNaloga { get; set; }
    internal protected virtual string NaucnoZvanje { get; set; }
    internal protected virtual string NaucnaOblast { get; set; }
    internal protected virtual bool JeAutor { get; set; }
    internal protected virtual bool JeRecenzent { get; set; }
    internal protected virtual bool JeUrednik { get; set; }
    internal protected virtual bool JeAdmin { get; set; }
    internal protected virtual bool JeRukovodilacProjekta { get; set; }
    internal protected virtual string ORCID { get; set; }
    internal protected virtual string OblastEkspertize { get; set; }
    internal protected virtual string UredjivackaSekcija { get; set; }
    internal protected virtual string AdministratorskaOvlascenja { get; set; }

    internal protected virtual IList<IstrazivacEmail> Emailovi { get; set; }
    internal protected virtual IList<IstrazivacTelefon> Telefoni { get; set; }
    internal protected virtual IList<Angazovanje> Angazovanja { get; set; }
    internal protected virtual IList<Autorstvo> Autorstva { get; set; }

    internal Istrazivac()
    {
        Emailovi = new List<IstrazivacEmail>();
        Telefoni = new List<IstrazivacTelefon>();
        Angazovanja = new List<Angazovanje>();
        Autorstva = new List<Autorstvo>();
    }
}
