using System;
using System.Collections.Generic;
using System.Text;

namespace RepozitorijumLibrary.Entiteti;
internal class Dataset : Publikacija
{
    internal protected virtual int BrojZapisa { get; set; }
    internal protected virtual int  Velicina { get; set; }
    internal protected virtual string? OpisStrukture { get; set; }
    internal protected virtual string? Format { get; set; }
    internal protected virtual string? LicencaKoriscenja { get; set; }
    internal protected virtual DateTime DatumOd { get; set; }
    internal protected virtual DateTime DatumDo { get; set; }
}
