namespace RepozitorijumLibrary;

public static class DataProvider
{
    #region Publikacija

    public static Result<List<PublikacijaView>, ErrorMessage> VratiSvePublikacije()
    {
        ISession? s = null;

        List<PublikacijaView> publikacije = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<Publikacija> svePublikacije = from o in s.Query<Publikacija>()
                                                      select o;

            foreach (Publikacija p in svePublikacije)
            {
                publikacije.Add(new PublikacijaView(p));
            }
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve publikacije.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return publikacije;
    }

    public async static Task<Result<bool, ErrorMessage>> DodajPublikacijuAsync(PublikacijaView p)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Publikacija o = new()
            {
                Naslov = p.Naslov,
                Apstrakt = p.Apstrakt,
                Jezik = p.Jezik,
                DatumObjavljivanja = p.DatumObjavljivanja ?? default,
                DatumKreiranjaZapisa = p.DatumKreiranjaZapisa ?? default,
                Status = p.Status,
                Vidljivost = p.Vidljivost
            };

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće dodati publikaciju.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<PublikacijaView, ErrorMessage>> AzurirajPublikacijuAsync(PublikacijaView p)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Publikacija o = await s.LoadAsync<Publikacija>(p.Id);

            o.Naslov = p.Naslov;
            o.Apstrakt = p.Apstrakt;
            o.Jezik = p.Jezik;
            o.DatumObjavljivanja = p.DatumObjavljivanja ?? default;
            o.DatumKreiranjaZapisa = p.DatumKreiranjaZapisa ?? default;
            o.Status = p.Status;
            o.Vidljivost = p.Vidljivost;

            await s.UpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati publikaciju.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return p;
    }

    public async static Task<Result<PublikacijaView, ErrorMessage>> VratiPublikacijuAsync(int id)
    {
        ISession? s = null;

        PublikacijaView publikacijaView = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Publikacija o = await s.LoadAsync<Publikacija>(id);
            publikacijaView = new PublikacijaView(o);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti publikaciju sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return publikacijaView;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiPublikacijuAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Publikacija o = await s.LoadAsync<Publikacija>(id);

            await s.DeleteAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati publikaciju.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    #endregion

    #region Knjiga
    public static Result<List<KnjigaView>, ErrorMessage> VratiSveKnjige()
    {
        ISession? s = null;

        List<KnjigaView> knjige = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<Knjiga> sveKnjige = from o in s.Query<Knjiga>()
                                            select o;

            foreach (Knjiga k in sveKnjige)
            {
                knjige.Add(new KnjigaView(k));
            }
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve knjige.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return knjige;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiKnjiguAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Knjiga knjiga = await s.LoadAsync<Knjiga>(id);

            await s.DeleteAsync(knjiga);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Greška prilikom brisanja knjige.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<KnjigaView, ErrorMessage>> VratiKnjiguAsync(int id)
    {
        ISession? s = null;

        KnjigaView knjigaView = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Knjiga k = await s.LoadAsync<Knjiga>(id);
            knjigaView = new KnjigaView(k);

            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće vratiti knjigu sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return knjigaView;
    }

    public async static Task<Result<bool, ErrorMessage>> IzmeniKnjiguAsync(KnjigaView knjiga)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Knjiga k = await s.LoadAsync<Knjiga>(knjiga.Id);

            k.Naslov = knjiga.Naslov;
            k.Apstrakt = knjiga.Apstrakt;
            k.Jezik = knjiga.Jezik;
            k.DatumObjavljivanja = knjiga.DatumObjavljivanja ?? default;
            k.DatumKreiranjaZapisa = knjiga.DatumKreiranjaZapisa ?? default;
            k.Status = knjiga.Status;
            k.Vidljivost = knjiga.Vidljivost;
            k.Izdavac = knjiga.Izdavac;
            k.MestoIzdanja = knjiga.MestoIzdanja;

            await s.SaveOrUpdateAsync(k);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće izmeniti knjigu.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<int, ErrorMessage>> SacuvajKnjiguAsync(KnjigaView knjiga)
    {
        ISession? s = null;
        int id = default;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Knjiga k = new()
            {
                Naslov = knjiga.Naslov,
                Apstrakt = knjiga.Apstrakt,
                Jezik = knjiga.Jezik,
                DatumObjavljivanja = knjiga.DatumObjavljivanja ?? default,
                DatumKreiranjaZapisa = knjiga.DatumKreiranjaZapisa ?? default,
                Status = knjiga.Status,
                Vidljivost = knjiga.Vidljivost,
                Izdavac = knjiga.Izdavac,
                MestoIzdanja = knjiga.MestoIzdanja
            };

            await s.SaveAsync(k);
            await s.FlushAsync();

            id = k.Id;
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati knjigu.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return id;
    }
    #endregion

    #region DoktorskaDisertacija
    public static Result<List<DoktorskaDisertacijaView>, ErrorMessage> VratiSveDoktorskeDisertacije()
    {
        ISession? s = null;

        List<DoktorskaDisertacijaView> disertacije = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<DoktorskaDisertacija> sveDisertacije =
                from o in s.Query<DoktorskaDisertacija>()
                select o;

            foreach (DoktorskaDisertacija d in sveDisertacije)
            {
                disertacije.Add(new DoktorskaDisertacijaView(d));
            }
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve doktorske disertacije.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return disertacije;
    }

    public static Result<bool, ErrorMessage> ObrisiDoktorskuDisertaciju(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            DoktorskaDisertacija disertacija = s.Load<DoktorskaDisertacija>(id);

            s.Delete(disertacija);
            s.Flush();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati doktorsku disertaciju.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public static Result<DoktorskaDisertacijaView, ErrorMessage> VratiDoktorskuDisertaciju(int id)
    {
        DoktorskaDisertacijaView o = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            DoktorskaDisertacija disertacija = s.Load<DoktorskaDisertacija>(id);

            o.Id = disertacija.Id;
            o.Naslov = disertacija.Naslov;
            o.Apstrakt = disertacija.Apstrakt;
            o.Jezik = disertacija.Jezik;
            o.DatumObjavljivanja = disertacija.DatumObjavljivanja;
            o.DatumKreiranjaZapisa = disertacija.DatumKreiranjaZapisa;
            o.Status = disertacija.Status;
            o.Vidljivost = disertacija.Vidljivost;

            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće pronaći doktorsku disertaciju.".ToError(400);
        }

        return o;
    }

    public static Result<bool, ErrorMessage> IzmeniDoktorskuDisertaciju(DoktorskaDisertacijaView disertacija)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            DoktorskaDisertacija d = s.Load<DoktorskaDisertacija>(disertacija.Id);

            d.Naslov = disertacija.Naslov;
            d.Apstrakt = disertacija.Apstrakt;
            d.Jezik = disertacija.Jezik;
            d.DatumObjavljivanja = disertacija.DatumObjavljivanja ?? default;
            d.DatumKreiranjaZapisa = disertacija.DatumKreiranjaZapisa ?? default;
            d.Status = disertacija.Status;
            d.Vidljivost = disertacija.Vidljivost;

            s.SaveOrUpdate(d);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće izmeniti doktorsku disertaciju.".ToError(400);
        }

        return true;
    }

    public static Result<bool, ErrorMessage> SacuvajDoktorskuDisertaciju(DoktorskaDisertacijaView disertacija)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            DoktorskaDisertacija d = new();

            d.Naslov = disertacija.Naslov;
            d.Apstrakt = disertacija.Apstrakt;
            d.Jezik = disertacija.Jezik;
            d.DatumObjavljivanja = disertacija.DatumObjavljivanja ?? default;
            d.DatumKreiranjaZapisa = disertacija.DatumKreiranjaZapisa ?? default;
            d.Status = disertacija.Status;
            d.Vidljivost = disertacija.Vidljivost;

            s.SaveOrUpdate(d);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {

            return "Nemoguće sačuvati doktorsku disertaciju.".ToError(400);
        }

        return true;
    }
    #endregion

    #region ObrazovniMaterijal
    public static Result<List<ObrazovniMaterijalView>, ErrorMessage> VratiSveObrazovneMaterijale()
    {
        ISession? s = null;

        List<ObrazovniMaterijalView> materijali = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<ObrazovniMaterijal> sviMaterijali =
                from o in s.Query<ObrazovniMaterijal>()
                select o;

            foreach (ObrazovniMaterijal m in sviMaterijali)
            {
                materijali.Add(new ObrazovniMaterijalView(m));
            }
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve obrazovne materijale.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return materijali;
    }

    public static Result<bool, ErrorMessage> ObrisiObrazovniMaterijal(int id)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            ObrazovniMaterijal materijal = s.Load<ObrazovniMaterijal>(id);

            s.Delete(materijal);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati obrazovni materijal.".ToError(400);
        }

        return true;
    }

    public static Result<ObrazovniMaterijalView, ErrorMessage> VratiObrazovniMaterijal(int id)
    {
        ObrazovniMaterijalView o = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            ObrazovniMaterijal materijal = s.Load<ObrazovniMaterijal>(id);

            o.Id = materijal.Id;
            o.Naslov = materijal.Naslov;
            o.Apstrakt = materijal.Apstrakt;
            o.Jezik = materijal.Jezik;
            o.DatumObjavljivanja = materijal.DatumObjavljivanja;
            o.DatumKreiranjaZapisa = materijal.DatumKreiranjaZapisa;
            o.Status = materijal.Status;
            o.Vidljivost = materijal.Vidljivost;

            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće vratiti obrazovni materijal.".ToError(400);
        }

        return o;
    }

    public static Result<bool, ErrorMessage> IzmeniObrazovniMaterijal(ObrazovniMaterijalView materijal)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            ObrazovniMaterijal o = s.Load<ObrazovniMaterijal>(materijal.Id);

            o.Naslov = materijal.Naslov;
            o.Apstrakt = materijal.Apstrakt;
            o.Jezik = materijal.Jezik;
            o.DatumObjavljivanja = materijal.DatumObjavljivanja ?? default;
            o.DatumKreiranjaZapisa = materijal.DatumKreiranjaZapisa ?? default;
            o.Status = materijal.Status;
            o.Vidljivost = materijal.Vidljivost;

            s.SaveOrUpdate(o);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće izmeniti obrazovni materijal.".ToError(400);
        }

        return true;
    }

    public static Result<bool, ErrorMessage> SacuvajObrazovniMaterijal(ObrazovniMaterijalView materijal)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            ObrazovniMaterijal o = new();

            o.Naslov = materijal.Naslov;
            o.Apstrakt = materijal.Apstrakt;
            o.Jezik = materijal.Jezik;
            o.DatumObjavljivanja = materijal.DatumObjavljivanja ?? default;
            o.DatumKreiranjaZapisa = materijal.DatumKreiranjaZapisa ?? default;
            o.Status = materijal.Status;
            o.Vidljivost = materijal.Vidljivost;

            s.Save(o);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati obrazovni materijal.".ToError(400);
        }

        return true;
    }
    #endregion

    #region Prezentacija
    public static Result<List<PrezentacijaView>, ErrorMessage> VratiSvePrezentacije()
    {
        ISession? s = null;

        List<PrezentacijaView> prezentacije = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<Prezentacija> svePrezentacije =
                from o in s.Query<Prezentacija>()
                select o;

            foreach (Prezentacija p in svePrezentacije)
            {
                prezentacije.Add(new PrezentacijaView(p));
            }
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve prezentacije.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return prezentacije;
    }

    public static Result<bool, ErrorMessage> ObrisiPrezentaciju(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Prezentacija prezentacija = s.Load<Prezentacija>(id);

            s.Delete(prezentacija);
            s.Flush();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati prezentaciju.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public static Result<PrezentacijaView, ErrorMessage> VratiPrezentaciju(int id)
    {
        PrezentacijaView o = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Prezentacija prezentacija = s.Load<Prezentacija>(id);

            o.Id = prezentacija.Id;
            o.Naslov = prezentacija.Naslov;
            o.Apstrakt = prezentacija.Apstrakt;
            o.Jezik = prezentacija.Jezik;
            o.DatumObjavljivanja = prezentacija.DatumObjavljivanja;
            o.DatumKreiranjaZapisa = prezentacija.DatumKreiranjaZapisa;
            o.Status = prezentacija.Status;
            o.Vidljivost = prezentacija.Vidljivost;

            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće pronaći prezentaciju.".ToError(400);
        }

        return o;
    }

    public static Result<bool, ErrorMessage> IzmeniPrezentaciju(PrezentacijaView prezentacija)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Prezentacija p = s.Load<Prezentacija>(prezentacija.Id);

            p.Naslov = prezentacija.Naslov;
            p.Apstrakt = prezentacija.Apstrakt;
            p.Jezik = prezentacija.Jezik;
            p.DatumObjavljivanja = prezentacija.DatumObjavljivanja ?? default;
            p.DatumKreiranjaZapisa = prezentacija.DatumKreiranjaZapisa ?? default;
            p.Status = prezentacija.Status;
            p.Vidljivost = prezentacija.Vidljivost;

            s.SaveOrUpdate(p);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće izmeniti prezentaciju.".ToError(400);
        }

        return true;
    }

    public static Result<bool, ErrorMessage> SacuvajPrezentaciju(PrezentacijaView prezentacija)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Prezentacija p = new();

            p.Naslov = prezentacija.Naslov;
            p.Apstrakt = prezentacija.Apstrakt;
            p.Jezik = prezentacija.Jezik;
            p.DatumObjavljivanja = prezentacija.DatumObjavljivanja ?? default;
            p.DatumKreiranjaZapisa = prezentacija.DatumKreiranjaZapisa ?? default;
            p.Status = prezentacija.Status;
            p.Vidljivost = prezentacija.Vidljivost;

            s.SaveOrUpdate(p);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {

            return "Nemoguće sačuvati prezentaciju.".ToError(400);
        }

        return true;
    }
    #endregion

    #region TehnickiIzvestaj
    public static Result<List<TehnickiIzvestajView>, ErrorMessage> VratiSveTehnickeIzvestaje()
    {
        ISession? s = null;

        List<TehnickiIzvestajView> izvestaji = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<TehnickiIzvestaj> sviIzvestaji =
                from o in s.Query<TehnickiIzvestaj>()
                select o;

            foreach (TehnickiIzvestaj t in sviIzvestaji)
            {
                izvestaji.Add(new TehnickiIzvestajView(t));
            }
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve tehničke izveštaje.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return izvestaji;
    }
    public static Result<bool, ErrorMessage> ObrisiTehnickiIzvestaj(int id)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            TehnickiIzvestaj izvestaj = s.Load<TehnickiIzvestaj>(id);

            s.Delete(izvestaj);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati tehnički izveštaj.".ToError(400);
        }

        return true;
    }

    public static Result<TehnickiIzvestajView, ErrorMessage> VratiTehnickiIzvestaj(int id)
    {
        TehnickiIzvestajView o = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            TehnickiIzvestaj izvestaj = s.Load<TehnickiIzvestaj>(id);

            o.Id = izvestaj.Id;
            o.Naslov = izvestaj.Naslov;
            o.Apstrakt = izvestaj.Apstrakt;
            o.Jezik = izvestaj.Jezik;
            o.DatumObjavljivanja = izvestaj.DatumObjavljivanja;
            o.DatumKreiranjaZapisa = izvestaj.DatumKreiranjaZapisa;
            o.Status = izvestaj.Status;
            o.Vidljivost = izvestaj.Vidljivost;

            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće vratiti tehnički izveštaj.".ToError(400);
        }

        return o;
    }

    public static Result<bool, ErrorMessage> IzmeniTehnickiIzvestaj(TehnickiIzvestajView izvestaj)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            TehnickiIzvestaj t = s.Load<TehnickiIzvestaj>(izvestaj.Id);

            t.Naslov = izvestaj.Naslov;
            t.Apstrakt = izvestaj.Apstrakt;
            t.Jezik = izvestaj.Jezik;
            t.DatumObjavljivanja = izvestaj.DatumObjavljivanja ?? default;
            t.DatumKreiranjaZapisa = izvestaj.DatumKreiranjaZapisa ?? default;
            t.Status = izvestaj.Status;
            t.Vidljivost = izvestaj.Vidljivost;

            s.SaveOrUpdate(t);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće izmeniti tehnički izveštaj.".ToError(400);
        }

        return true;
    }

    public static Result<bool, ErrorMessage> SacuvajTehnickiIzvestaj(TehnickiIzvestajView izvestaj)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            TehnickiIzvestaj t = new();

            t.Naslov = izvestaj.Naslov;
            t.Apstrakt = izvestaj.Apstrakt;
            t.Jezik = izvestaj.Jezik;
            t.DatumObjavljivanja = izvestaj.DatumObjavljivanja ?? default;
            t.DatumKreiranjaZapisa = izvestaj.DatumKreiranjaZapisa ?? default;
            t.Status = izvestaj.Status;
            t.Vidljivost = izvestaj.Vidljivost;

            s.Save(t);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati tehnički izveštaj.".ToError(400);
        }

        return true;
    }
    #endregion

    #region PoglavljeUKnjizi
    public static Result<List<PoglavljeUKnjiziView>, ErrorMessage> VratiSvaPoglavljaUKnjizi()
    {
        ISession? s = null;

        List<PoglavljeUKnjiziView> poglavlja = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<PoglavljeUKnjizi> svaPoglavlja =
                from o in s.Query<PoglavljeUKnjizi>()
                select o;

            foreach (PoglavljeUKnjizi p in svaPoglavlja)
            {
                poglavlja.Add(new PoglavljeUKnjiziView(p));
            }
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sva poglavlja u knjizi.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return poglavlja;
    }

    public static Result<bool, ErrorMessage> ObrisiPoglavljeUKnjizi(int id)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            PoglavljeUKnjizi poglavlje = s.Load<PoglavljeUKnjizi>(id);

            s.Delete(poglavlje);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati poglavlje u knjizi.".ToError(400);
        }

        return true;
    }

    public static Result<PoglavljeUKnjiziView, ErrorMessage> VratiPoglavljeUKnjizi(int id)
    {
        PoglavljeUKnjiziView o = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            PoglavljeUKnjizi poglavlje = s.Load<PoglavljeUKnjizi>(id);

            o.Id = poglavlje.Id;
            o.Naslov = poglavlje.Naslov;
            o.Apstrakt = poglavlje.Apstrakt;
            o.Jezik = poglavlje.Jezik;
            o.DatumObjavljivanja = poglavlje.DatumObjavljivanja;
            o.DatumKreiranjaZapisa = poglavlje.DatumKreiranjaZapisa;
            o.Status = poglavlje.Status;
            o.Vidljivost = poglavlje.Vidljivost;
            o.Izdavac = poglavlje.Izdavac;
            o.MestoIzdanja = poglavlje.MestoIzdanja;

            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće vratiti poglavlje u knjizi.".ToError(400);
        }

        return o;
    }

    public static Result<bool, ErrorMessage> IzmeniPoglavljeUKnjizi(PoglavljeUKnjiziView poglavlje)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            PoglavljeUKnjizi p = s.Load<PoglavljeUKnjizi>(poglavlje.Id);

            p.Naslov = poglavlje.Naslov;
            p.Apstrakt = poglavlje.Apstrakt;
            p.Jezik = poglavlje.Jezik;
            p.DatumObjavljivanja = poglavlje.DatumObjavljivanja ?? default;
            p.DatumKreiranjaZapisa = poglavlje.DatumKreiranjaZapisa ?? default;
            p.Status = poglavlje.Status;
            p.Vidljivost = poglavlje.Vidljivost;
            p.Izdavac = poglavlje.Izdavac;
            p.MestoIzdanja = poglavlje.MestoIzdanja;

            s.SaveOrUpdate(p);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće izmeniti poglavlje u knjizi.".ToError(400);
        }

        return true;
    }

    public static Result<bool, ErrorMessage> SacuvajPoglavljeUKnjizi(PoglavljeUKnjiziView poglavlje)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            PoglavljeUKnjizi p = new();

            p.Naslov = poglavlje.Naslov;
            p.Apstrakt = poglavlje.Apstrakt;
            p.Jezik = poglavlje.Jezik;
            p.DatumObjavljivanja = poglavlje.DatumObjavljivanja ?? default;
            p.DatumKreiranjaZapisa = poglavlje.DatumKreiranjaZapisa ?? default;
            p.Status = poglavlje.Status;
            p.Vidljivost = poglavlje.Vidljivost;
            p.Izdavac = poglavlje.Izdavac;
            p.MestoIzdanja = poglavlje.MestoIzdanja;

            s.Save(p);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati poglavlje u knjizi.".ToError(400);
        }

        return true;
    }
    #endregion

    #region Verzije
    public static Result<List<VerzijaView>, ErrorMessage> VratiSveVerzije()
    {
        List<VerzijaView> verzije = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<Verzija> sveVerzije = from o in s.Query<Verzija>()
                                            select o;

            foreach (Verzija v in sveVerzije)
            {
                verzije.Add(new VerzijaView(v, v.Publikacija));
            }

            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve verzije.".ToError(400);
        }

        return verzije;
    }

    public static Result<List<VerzijaView>, ErrorMessage> VratiVerzijePublikacije(int publikacijaId)
    {
        ISession? s = null;

        List<VerzijaView> verzije = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<Verzija> verzijePublikacije = from o in s.Query<Verzija>()
                                                      where o.Publikacija != null && o.Publikacija.Id == publikacijaId
                                                      select o;

            verzije = verzijePublikacije.Select(v => new VerzijaView(v, v.Publikacija)).ToList();
        }
        catch (Exception)
        {
            return "Nemoguće vratiti verzije publikacije sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return verzije;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiVerzijuAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Verzija v = await s.LoadAsync<Verzija>(id);

            await s.DeleteAsync(v);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati verziju sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<VerzijaView, ErrorMessage>> VratiVerzijuAsync(int id)
    {
        ISession? s = null;

        VerzijaView verzijaView = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Verzija v = await s.LoadAsync<Verzija>(id);
            verzijaView = new VerzijaView(v, v.Publikacija);

            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće vratiti verziju sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return verzijaView;
    }

    public async static Task<Result<int, ErrorMessage>> SacuvajVerzijuAsync(VerzijaView verzija, int idPublikacije)
    {
        ISession? s = null;

        int id = default;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Publikacija p = await s.LoadAsync<Publikacija>(idPublikacije);

            Verzija v = new()
            {
                BrojVerzije = verzija.BrojVerzije ?? default,
                DatumPostavljanja = verzija.DatumPostavljanja ?? default,
                OpisIzmene = verzija.OpisIzmene,
                OdgovornaOsoba = verzija.OdgovornaOsoba,
                Publikacija = p
            };

            id = (int)await s.SaveAsync(v);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati verziju.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return id;
    }

    public async static Task<Result<VerzijaView, ErrorMessage>> AzurirajVerzijuAsync(VerzijaView r)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Verzija v = await s.LoadAsync<Verzija>(r.Id);

            v.BrojVerzije = r.BrojVerzije ?? default;
            v.DatumPostavljanja = r.DatumPostavljanja ?? default;
            v.OpisIzmene = r.OpisIzmene;
            v.OdgovornaOsoba = r.OdgovornaOsoba;

            s.Update(v);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati verziju.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return r;
    }

    public static Result<List<VerzijaView>, ErrorMessage> GetVerzijaInfos(int publikacijaId)
    {
        ISession? s = null;
        List<VerzijaView> verInfos = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<Verzija> verzije = from o in s.Query<Verzija>()
                                           where o.Publikacija != null && o.Publikacija.Id == publikacijaId
                                           select o;

            foreach (Verzija o in verzije)
            {
                verInfos.Add(new VerzijaView(o, o.Publikacija));
            }

        }
        catch (Exception)
        {
            return "Nemoguće pronaći verzije ili pripadajuće publikacije.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return verInfos;
    }
    #endregion

    #region Fajlovi

    public async static Task<Result<int, ErrorMessage>> SacuvajFajlAsync(FajlView fajl, int idVerzije)
    {
        ISession? s = null;

        int id = default;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Fajl f = new()
            {
                Putanja = fajl.Putanja,
                Verzija = await s.LoadAsync<Verzija>(idVerzije)
            };

            id = (int)await s.SaveAsync(f);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati fajl.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return id;
    }

    public static Result<FajlView, ErrorMessage> VratiFajl(int id)
    {
        FajlView fajlView;

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Fajl f = s.Load<Fajl>(id);
            fajlView = new FajlView(f, f.Verzija);

            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće vratiti fajl sa zadatim ID-jem.".ToError(400);
        }

        return fajlView;
    }

    public static Result<FajlView, ErrorMessage> AzurirajFajl(FajlView r)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Fajl f = s.Load<Fajl>(r.Id);

            f.Putanja = r.Putanja;

            s.Update(f);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati fajl.".ToError(400);
        }

        return r;
    }

    public static Result<List<FajlView>, ErrorMessage> VratiFajloveVerzije(int verzijaId)
    {
        ISession? s = null;

        List<FajlView> fajlovi = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<Fajl> fajloviVerzije = from o in s.Query<Fajl>()
                                               where o.Verzija != null && o.Verzija.Id == verzijaId
                                               select o;

            fajlovi = fajloviVerzije.Select(f => new FajlView(f, f.Verzija)).ToList();
        }
        catch (Exception)
        {
            return "Nemoguće vratiti fajlove verzije sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return fajlovi;
    }

    public static Result<bool, ErrorMessage> ObrisiFajl(int id)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Fajl f = s.Load<Fajl>(id);

            s.Delete(f);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati fajl iz sistema.".ToError(400);
        }

        return true;
    }
    #endregion

    #region PublikacijaKljucnaRec
    public static Result<List<PublikacijaKljucnaRecView>, ErrorMessage> VratiSveKljucneReci()
    {
        List<PublikacijaKljucnaRecView> kljucneReci = new();

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<PublikacijaKljucnaRec> sveKljucneReci = from o in s.Query<PublikacijaKljucnaRec>()
                                                                select o;

            foreach (PublikacijaKljucnaRec pkr in sveKljucneReci)
            {
                kljucneReci.Add(new PublikacijaKljucnaRecView(pkr, pkr.Publikacija));
            }

            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve ključne reči.".ToError(400);
        }

        return kljucneReci;
    }

    public static Result<List<PublikacijaKljucnaRecView>, ErrorMessage> VratiKljucneReciPublikacije(int publikacijaId)
    {
        ISession? s = null;

        List<PublikacijaKljucnaRecView> kljucneReci = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            IEnumerable<PublikacijaKljucnaRec> kljucneReciPublikacije = from o in s.Query<PublikacijaKljucnaRec>()
                                                                        where o.Publikacija != null && o.Publikacija.Id == publikacijaId
                                                                        select o;

            kljucneReci = kljucneReciPublikacije.Select(pkr => new PublikacijaKljucnaRecView(pkr, pkr.Publikacija)).ToList();
        }
        catch (Exception)
        {
            return "Nemoguće vratiti ključne reči publikacije sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return kljucneReci;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiKljucnuRecAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            PublikacijaKljucnaRec pkr = await s.LoadAsync<PublikacijaKljucnaRec>(id);

            await s.DeleteAsync(pkr);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati ključnu reč sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public static Result<PublikacijaKljucnaRecView, ErrorMessage> VratiKljucnuRec(int id)
    {
        PublikacijaKljucnaRecView kljucnaRecView;

        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            PublikacijaKljucnaRec pkr = s.Load<PublikacijaKljucnaRec>(id);
            kljucnaRecView = new PublikacijaKljucnaRecView(pkr, pkr.Publikacija);

            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće vratiti ključnu reč sa zadatim ID-jem.".ToError(400);
        }

        return kljucnaRecView;
    }

    public static Result<bool, ErrorMessage> IzmeniKljucnuRec(PublikacijaKljucnaRecView kljucnaRec)
    {
        try
        {
            ISession? s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            PublikacijaKljucnaRec pkr = s.Load<PublikacijaKljucnaRec>(kljucnaRec.Id);

            pkr.KljucnaRec = kljucnaRec.KljucnaRec;

            s.SaveOrUpdate(pkr);
            s.Flush();
            s.Close();
        }
        catch (Exception)
        {
            return "Nemoguće izmeniti ključnu reč.".ToError(400);
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> SacuvajKljucnuRecAsync(PublikacijaKljucnaRecView p, int publikacijaId)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Publikacija pub = await s.LoadAsync<Publikacija>(publikacijaId);

            PublikacijaKljucnaRec a = new()
            {
                Publikacija = pub,
                KljucnaRec = p.KljucnaRec
            };

            await s.SaveAsync(a);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće sačuvati ključnu reč publikacije.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    #endregion
}
