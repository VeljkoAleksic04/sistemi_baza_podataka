using System;
using RepozitorijumLibrary.Entiteti;

namespace RepozitorijumLibrary.DTOs;

public class DatasetView : PublikacijaView
{
    public int BrojZapisa { get; set; }
    public int Velicina { get; set; }          // in MB or KB, adjust as per your DB
    public string? OpisStrukture { get; set; }
    public string? Format { get; set; }
    public string? LicencaKoriscenja { get; set; }
    public DateTime? DatumOd { get; set; }
    public DateTime? DatumDo { get; set; }

    public DatasetView() { }

    internal DatasetView(Dataset? d) : base(d)
    {
        if (d != null)
        {
            BrojZapisa = d.BrojZapisa;
            Velicina = d.Velicina;
            OpisStrukture = d.OpisStrukture;
            Format = d.Format;
            LicencaKoriscenja = d.LicencaKoriscenja;
            DatumOd = d.DatumOd;
            DatumDo = d.DatumDo;
        }
    }
}