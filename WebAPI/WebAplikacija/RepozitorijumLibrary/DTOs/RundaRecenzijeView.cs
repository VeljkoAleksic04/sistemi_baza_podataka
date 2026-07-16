using System;
using RepozitorijumLibrary.Entiteti;

namespace RepozitorijumLibrary.DTOs;

public class RundaRecenzijeView
{
    public int Id { get; set; }
    public int BrojRunde { get; set; }
    public int IdPublikacije { get; set; }
    public int IdUrednika { get; set; }
    public DateTime Datum { get; set; }
    public string? KonacnaOdluka { get; set; }

    public string? NaslovPublikacije { get; set; }
    public string? ImeUrednika { get; set; }

    public RundaRecenzijeView() { }

    internal RundaRecenzijeView(RundaRecenzije? r)
    {
        if (r != null)
        {
            Id = r.Id;
            BrojRunde = r.BrojRunde;
            IdPublikacije = r.IdPublikacije;
            IdUrednika = r.IdUrednika;
            Datum = r.Datum;
            KonacnaOdluka = r.KonacnaOdluka;
            NaslovPublikacije = r.Publikacija?.Naslov;
            ImeUrednika = r.Urednik != null ? $"{r.Urednik.Ime} {r.Urednik.Prezime}" : null;
        }
    }
}