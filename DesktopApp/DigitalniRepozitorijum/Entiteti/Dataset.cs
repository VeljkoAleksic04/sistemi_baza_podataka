using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum.Entiteti;
public class Dataset : Publikacija
{
    public virtual int BrojZapisa { get; set; }
    public virtual int  Velicina { get; set; }
    public virtual string? OpisStrukture { get; set; }
    public virtual string? Format { get; set; }
    public virtual string? LicencaKoriscenja { get; set; }
    public virtual DateTime DatumOd { get; set; }
    public virtual DateTime DatumDo { get; set; }
}
