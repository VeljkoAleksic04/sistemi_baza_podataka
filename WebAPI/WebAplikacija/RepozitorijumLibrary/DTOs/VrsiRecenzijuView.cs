using System;
using RepozitorijumLibrary.Entiteti;

namespace RepozitorijumLibrary.DTOs;

public class VrsiRecenzijuView
{
    public int Id { get; set; }
    public int IdRundeRecenzije { get; set; }
    public int IdRecenzenta { get; set; }
    public string? Preporuka { get; set; }

    public string? ImeRecenzenta { get; set; }
    public int? BrojRunde { get; set; }

    public VrsiRecenzijuView() { }

    internal VrsiRecenzijuView(VrsiRecenziju? v)
    {
        if (v != null)
        {
            Id = v.Id;
            IdRundeRecenzije = v.IdRundeRecenzije;
            IdRecenzenta = v.IdRecenzenta;
            Preporuka = v.Preporuka;
            ImeRecenzenta = v.Recenzent != null ? $"{v.Recenzent.Ime} {v.Recenzent.Prezime}" : null;
            BrojRunde = v.RundaRecenzije?.BrojRunde;
        }
    }
}