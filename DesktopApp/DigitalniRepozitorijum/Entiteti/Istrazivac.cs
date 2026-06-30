using System;
using System.Collections.Generic;


namespace DigitalniRepozitorijum.Entiteti;

public class Istrazivac
{

    public virtual int Id { get; set; }
    public virtual string Ime { get; set; }
    public virtual string Prezime { get; set; }
    public virtual DateTime DatumRodjenja { get; set; }
    public virtual string Drzava { get; set; }
    public virtual string StatusNaloga { get; set; }
    public virtual string NaucnoZvanje { get; set; }
    public virtual string NaucnaOblast { get; set; }
    public virtual bool JeAutor { get; set; }
    public virtual bool JeRecenzent { get; set; }
    public virtual bool JeUrednik { get; set; }
    public virtual bool JeAdmin { get; set; }
    public virtual bool JeRukovodilacProjekta { get; set; }
    public virtual string ORCID { get; set; }
    public virtual string OblastEkspertize { get; set; }
    public virtual string UredjivackaSekcija { get; set; }
    public virtual string AdministratorskaOvlascenja { get; set; }

    public virtual IList<IstrazivacEmail> Emailovi { get; set; }
    public virtual IList<IstrazivacTelefon> Telefoni { get; set; }
    public virtual IList<Angazovanje> Angazovanja { get; set; }
    public virtual IList<Autorstvo> Autorstva { get; set; }

    public Istrazivac()
    {
        Emailovi = new List<IstrazivacEmail>();
        Telefoni = new List<IstrazivacTelefon>();
        Angazovanja = new List<Angazovanje>();
        Autorstva = new List<Autorstvo>();
    }
}

