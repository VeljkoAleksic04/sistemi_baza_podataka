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

    #region Institucija

    public static Result<List<InstitucijaView>, ErrorMessage> VratiSveInstitucije()
    {
        ISession? s = null;
        List<InstitucijaView> data = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IEnumerable<Institucija> items = from o in s.Query<Institucija>() select o;

            foreach (Institucija i in items)
                data.Add(new InstitucijaView(i));
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve institucije.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public async static Task<Result<InstitucijaView, ErrorMessage>> VratiInstitucijuAsync(int id)
    {
        ISession? s = null;
        InstitucijaView view = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Institucija i = await s.LoadAsync<Institucija>(id);
            view = new InstitucijaView(i);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti instituciju sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return view;
    }

    public async static Task<Result<bool, ErrorMessage>> DodajInstitucijuAsync(InstitucijaView dto)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Institucija o = new()
            {
                Naziv = dto.Naziv,
                Adresa = dto.Adresa
            };

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće dodati instituciju.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<InstitucijaView, ErrorMessage>> AzurirajInstitucijuAsync(InstitucijaView dto)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Institucija o = await s.LoadAsync<Institucija>(dto.Id);
            o.Naziv = dto.Naziv;
            o.Adresa = dto.Adresa;

            await s.UpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati instituciju.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return dto;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiInstitucijuAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Institucija o = await s.LoadAsync<Institucija>(id);
            await s.DeleteAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati instituciju.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    #endregion

    #region InstitucijaKontaktMail

    public static Result<List<InstitucijaKontaktMailView>, ErrorMessage> VratiKontaktMailoveInstitucije(int idInstitucije)
    {
        ISession? s = null;
        List<InstitucijaKontaktMailView> data = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IEnumerable<InstitucijaKontaktMail> items = from o in s.Query<InstitucijaKontaktMail>()
                                                         where o.Institucija.Id == idInstitucije
                                                         select o;

            foreach (InstitucijaKontaktMail o in items)
                data.Add(new InstitucijaKontaktMailView(o));
        }
        catch (Exception)
        {
            return "Nemoguće vratiti kontakt mailove institucije.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public async static Task<Result<InstitucijaKontaktMailView, ErrorMessage>> VratiKontaktMailAsync(int id)
    {
        ISession? s = null;
        InstitucijaKontaktMailView view = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            InstitucijaKontaktMail o = await s.LoadAsync<InstitucijaKontaktMail>(id);
            view = new InstitucijaKontaktMailView(o);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti kontakt mail.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return view;
    }

    public async static Task<Result<int, ErrorMessage>> DodajKontaktMailAsync(InstitucijaKontaktMailView dto, int idInstitucije)
    {
        ISession? s = null;
        int id = default;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            InstitucijaKontaktMail o = new()
            {
                Institucija = await s.LoadAsync<Institucija>(idInstitucije),
                KontaktMail = dto.KontaktMail
            };

            id = (int)await s.SaveAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće dodati kontakt mail.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return id;
    }

    public async static Task<Result<bool, ErrorMessage>> AzurirajKontaktMailAsync(InstitucijaKontaktMailView dto)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            InstitucijaKontaktMail o = await s.LoadAsync<InstitucijaKontaktMail>(dto.Id);
            o.KontaktMail = dto.KontaktMail;

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati kontakt mail.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiKontaktMailAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            InstitucijaKontaktMail o = await s.LoadAsync<InstitucijaKontaktMail>(id);
            await s.DeleteAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati kontakt mail.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    #endregion

    #region InstitucijaKontaktTel

    public static Result<List<InstitucijaKontaktTelView>, ErrorMessage> VratiKontaktTelefoneInstitucije(int idInstitucije)
    {
        ISession? s = null;
        List<InstitucijaKontaktTelView> data = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IEnumerable<InstitucijaKontaktTel> items = from o in s.Query<InstitucijaKontaktTel>()
                                                        where o.Institucija.Id == idInstitucije
                                                        select o;

            foreach (InstitucijaKontaktTel o in items)
                data.Add(new InstitucijaKontaktTelView(o));
        }
        catch (Exception)
        {
            return "Nemoguće vratiti kontakt telefone institucije.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public async static Task<Result<InstitucijaKontaktTelView, ErrorMessage>> VratiKontaktTelefonAsync(int id)
    {
        ISession? s = null;
        InstitucijaKontaktTelView view = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            InstitucijaKontaktTel o = await s.LoadAsync<InstitucijaKontaktTel>(id);
            view = new InstitucijaKontaktTelView(o);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti kontakt telefon.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return view;
    }

    public async static Task<Result<int, ErrorMessage>> DodajKontaktTelefonAsync(InstitucijaKontaktTelView dto, int idInstitucije)
    {
        ISession? s = null;
        int id = default;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            InstitucijaKontaktTel o = new()
            {
                Institucija = await s.LoadAsync<Institucija>(idInstitucije),
                KontaktTel = dto.KontaktTel
            };

            id = (int)await s.SaveAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće dodati kontakt telefon.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return id;
    }

    public async static Task<Result<bool, ErrorMessage>> AzurirajKontaktTelefonAsync(InstitucijaKontaktTelView dto)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            InstitucijaKontaktTel o = await s.LoadAsync<InstitucijaKontaktTel>(dto.Id);
            o.KontaktTel = dto.KontaktTel;

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati kontakt telefon.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiKontaktTelefonAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            InstitucijaKontaktTel o = await s.LoadAsync<InstitucijaKontaktTel>(id);
            await s.DeleteAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati kontakt telefon.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    #endregion

    #region InstitucijaNaucnaOblast

    public static Result<List<InstitucijaNaucnaOblastView>, ErrorMessage> VratiNaucneOblastiInstitucije(int idInstitucije)
    {
        ISession? s = null;
        List<InstitucijaNaucnaOblastView> data = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IEnumerable<InstitucijaNaucnaOblast> items = from o in s.Query<InstitucijaNaucnaOblast>()
                                                           where o.Institucija.Id == idInstitucije
                                                           select o;

            foreach (InstitucijaNaucnaOblast o in items)
                data.Add(new InstitucijaNaucnaOblastView(o));
        }
        catch (Exception)
        {
            return "Nemoguće vratiti naučne oblasti institucije.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public async static Task<Result<InstitucijaNaucnaOblastView, ErrorMessage>> VratiNaucnuOblastAsync(int id)
    {
        ISession? s = null;
        InstitucijaNaucnaOblastView view = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            InstitucijaNaucnaOblast o = await s.LoadAsync<InstitucijaNaucnaOblast>(id);
            view = new InstitucijaNaucnaOblastView(o);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti naučnu oblast.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return view;
    }

    public async static Task<Result<int, ErrorMessage>> DodajNaucnuOblastAsync(InstitucijaNaucnaOblastView dto, int idInstitucije)
    {
        ISession? s = null;
        int id = default;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            InstitucijaNaucnaOblast o = new()
            {
                Institucija = await s.LoadAsync<Institucija>(idInstitucije),
                NaucnaOblast = dto.NaucnaOblast
            };

            id = (int)await s.SaveAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće dodati naučnu oblast.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return id;
    }

    public async static Task<Result<bool, ErrorMessage>> AzurirajNaucnuOblastAsync(InstitucijaNaucnaOblastView dto)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            InstitucijaNaucnaOblast o = await s.LoadAsync<InstitucijaNaucnaOblast>(dto.Id);
            o.NaucnaOblast = dto.NaucnaOblast;

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati naučnu oblast.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiNaucnuOblastAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            InstitucijaNaucnaOblast o = await s.LoadAsync<InstitucijaNaucnaOblast>(id);
            await s.DeleteAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati naučnu oblast.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    #endregion

    #region Istrazivac

    public static Result<List<IstrazivacView>, ErrorMessage> VratiSveIstrazivace()
    {
        ISession? s = null;
        List<IstrazivacView> data = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IEnumerable<Istrazivac> items = from o in s.Query<Istrazivac>() select o;

            foreach (Istrazivac i in items)
                data.Add(new IstrazivacView(i));
        }
        catch (Exception)
        {
            return "Nemoguće vratiti sve istraživače.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public async static Task<Result<IstrazivacView, ErrorMessage>> VratiIstrazivacaAsync(int id)
    {
        ISession? s = null;
        IstrazivacView view = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Istrazivac i = await s.LoadAsync<Istrazivac>(id);
            view = new IstrazivacView(i);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti istraživača sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return view;
    }

    public async static Task<Result<bool, ErrorMessage>> DodajIstrazivacaAsync(IstrazivacView dto)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Istrazivac o = new()
            {
                Ime = dto.Ime,
                Prezime = dto.Prezime,
                DatumRodjenja = dto.DatumRodjenja ?? default,
                Drzava = dto.Drzava,
                StatusNaloga = dto.StatusNaloga,
                NaucnoZvanje = dto.NaucnoZvanje,
                NaucnaOblast = dto.NaucnaOblast,
                JeAutor = dto.JeAutor,
                JeRecenzent = dto.JeRecenzent,
                JeUrednik = dto.JeUrednik,
                JeAdmin = dto.JeAdmin,
                JeRukovodilacProjekta = dto.JeRukovodilacProjekta,
                ORCID = dto.ORCID,
                OblastEkspertize = dto.OblastEkspertize,
                UredjivackaSekcija = dto.UredjivackaSekcija,
                AdministratorskaOvlascenja = dto.AdministratorskaOvlascenja
            };

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće dodati istraživača.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<IstrazivacView, ErrorMessage>> AzurirajIstrazivacaAsync(IstrazivacView dto)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Istrazivac o = await s.LoadAsync<Istrazivac>(dto.Id);

            o.Ime = dto.Ime;
            o.Prezime = dto.Prezime;
            o.DatumRodjenja = dto.DatumRodjenja ?? default;
            o.Drzava = dto.Drzava;
            o.StatusNaloga = dto.StatusNaloga;
            o.NaucnoZvanje = dto.NaucnoZvanje;
            o.NaucnaOblast = dto.NaucnaOblast;
            o.JeAutor = dto.JeAutor;
            o.JeRecenzent = dto.JeRecenzent;
            o.JeUrednik = dto.JeUrednik;
            o.JeAdmin = dto.JeAdmin;
            o.JeRukovodilacProjekta = dto.JeRukovodilacProjekta;
            o.ORCID = dto.ORCID;
            o.OblastEkspertize = dto.OblastEkspertize;
            o.UredjivackaSekcija = dto.UredjivackaSekcija;
            o.AdministratorskaOvlascenja = dto.AdministratorskaOvlascenja;

            await s.UpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati istraživača.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return dto;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiIstrazivacaAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Istrazivac o = await s.LoadAsync<Istrazivac>(id);
            await s.DeleteAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati istraživača.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    #endregion

    #region IstrazivacEmail

    public static Result<List<IstrazivacEmailView>, ErrorMessage> VratiEmailoveIstrazivaca(int idIstrazivaca)
    {
        ISession? s = null;
        List<IstrazivacEmailView> data = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IEnumerable<IstrazivacEmail> items = from o in s.Query<IstrazivacEmail>()
                                                  where o.Istrazivac.Id == idIstrazivaca
                                                  select o;

            foreach (IstrazivacEmail o in items)
                data.Add(new IstrazivacEmailView(o));
        }
        catch (Exception)
        {
            return "Nemoguće vratiti emailove istraživača.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public async static Task<Result<IstrazivacEmailView, ErrorMessage>> VratiEmailAsync(int id)
    {
        ISession? s = null;
        IstrazivacEmailView view = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IstrazivacEmail o = await s.LoadAsync<IstrazivacEmail>(id);
            view = new IstrazivacEmailView(o);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti email.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return view;
    }

    public async static Task<Result<int, ErrorMessage>> DodajEmailAsync(IstrazivacEmailView dto, int idIstrazivaca)
    {
        ISession? s = null;
        int id = default;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IstrazivacEmail o = new()
            {
                Istrazivac = await s.LoadAsync<Istrazivac>(idIstrazivaca),
                Email = dto.Email
            };

            id = (int)await s.SaveAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće dodati email.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return id;
    }

    public async static Task<Result<bool, ErrorMessage>> AzurirajEmailAsync(IstrazivacEmailView dto)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IstrazivacEmail o = await s.LoadAsync<IstrazivacEmail>(dto.Id);
            o.Email = dto.Email;

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati email.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiEmailAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IstrazivacEmail o = await s.LoadAsync<IstrazivacEmail>(id);
            await s.DeleteAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati email.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    #endregion

    #region IstrazivacTelefon

    public static Result<List<IstrazivacTelefonView>, ErrorMessage> VratiTelefoneIstrazivaca(int idIstrazivaca)
    {
        ISession? s = null;
        List<IstrazivacTelefonView> data = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IEnumerable<IstrazivacTelefon> items = from o in s.Query<IstrazivacTelefon>()
                                                    where o.Istrazivac.Id == idIstrazivaca
                                                    select o;

            foreach (IstrazivacTelefon o in items)
                data.Add(new IstrazivacTelefonView(o));
        }
        catch (Exception)
        {
            return "Nemoguće vratiti telefone istraživača.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public async static Task<Result<IstrazivacTelefonView, ErrorMessage>> VratiTelefonAsync(int id)
    {
        ISession? s = null;
        IstrazivacTelefonView view = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IstrazivacTelefon o = await s.LoadAsync<IstrazivacTelefon>(id);
            view = new IstrazivacTelefonView(o);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti telefon.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return view;
    }

    public async static Task<Result<int, ErrorMessage>> DodajTelefonAsync(IstrazivacTelefonView dto, int idIstrazivaca)
    {
        ISession? s = null;
        int id = default;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IstrazivacTelefon o = new()
            {
                Istrazivac = await s.LoadAsync<Istrazivac>(idIstrazivaca),
                Telefon = dto.Telefon
            };

            id = (int)await s.SaveAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće dodati telefon.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return id;
    }

    public async static Task<Result<bool, ErrorMessage>> AzurirajTelefonAsync(IstrazivacTelefonView dto)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IstrazivacTelefon o = await s.LoadAsync<IstrazivacTelefon>(dto.Id);
            o.Telefon = dto.Telefon;

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati telefon.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiTelefonAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IstrazivacTelefon o = await s.LoadAsync<IstrazivacTelefon>(id);
            await s.DeleteAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati telefon.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    #endregion

    #region Angazovanje

    public static Result<List<AngazovanjeView>, ErrorMessage> VratiAngazovanjaIstrazivaca(int idIstrazivaca)
    {
        ISession? s = null;
        List<AngazovanjeView> data = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IEnumerable<Angazovanje> items = from o in s.Query<Angazovanje>()
                                              where o.Istrazivac.Id == idIstrazivaca
                                              select o;

            foreach (Angazovanje a in items)
                data.Add(new AngazovanjeView(a));
        }
        catch (Exception)
        {
            return "Nemoguće vratiti angažovanja istraživača.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public static Result<List<AngazovanjeView>, ErrorMessage> VratiAngazovanjaInstitucije(int idInstitucije)
    {
        ISession? s = null;
        List<AngazovanjeView> data = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IEnumerable<Angazovanje> items = from o in s.Query<Angazovanje>()
                                              where o.Institucija.Id == idInstitucije
                                              select o;

            foreach (Angazovanje a in items)
                data.Add(new AngazovanjeView(a));
        }
        catch (Exception)
        {
            return "Nemoguće vratiti angažovanja institucije.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public async static Task<Result<AngazovanjeView, ErrorMessage>> VratiAngazovanjeAsync(int id)
    {
        ISession? s = null;
        AngazovanjeView view = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Angazovanje a = await s.LoadAsync<Angazovanje>(id);
            view = new AngazovanjeView(a);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti angažovanje sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return view;
    }

    public async static Task<Result<bool, ErrorMessage>> DodajAngazovanjeAsync(AngazovanjeView dto)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Angazovanje o = new()
            {
                Institucija = await s.LoadAsync<Institucija>(dto.IdInstitucije),
                Istrazivac = await s.LoadAsync<Istrazivac>(dto.IdIstrazivaca),
                OrganizacionaJedinica = dto.OrganizacionaJedinica,
                TipAngazovanja = dto.TipAngazovanja,
                NazivPozicije = dto.NazivPozicije,
                DatumPocetka = dto.DatumPocetka ?? default,
                DatumZavrsetka = dto.DatumZavrsetka
            };

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće dodati angažovanje.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> AzurirajAngazovanjeAsync(AngazovanjeView dto)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Angazovanje o = await s.LoadAsync<Angazovanje>(dto.Id);

            o.Institucija = await s.LoadAsync<Institucija>(dto.IdInstitucije);
            o.Istrazivac = await s.LoadAsync<Istrazivac>(dto.IdIstrazivaca);
            o.OrganizacionaJedinica = dto.OrganizacionaJedinica;
            o.TipAngazovanja = dto.TipAngazovanja;
            o.NazivPozicije = dto.NazivPozicije;
            o.DatumPocetka = dto.DatumPocetka ?? default;
            o.DatumZavrsetka = dto.DatumZavrsetka;

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati angažovanje.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiAngazovanjeAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Angazovanje o = await s.LoadAsync<Angazovanje>(id);
            await s.DeleteAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati angažovanje.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    #endregion

    #region Autorstvo

    public static Result<List<AutorstvoView>, ErrorMessage> VratiAutorePublikacije(int idPublikacije)
    {
        ISession? s = null;
        List<AutorstvoView> data = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IEnumerable<Autorstvo> items = from o in s.Query<Autorstvo>()
                                            where o.Publikacija.Id == idPublikacije
                                            select o;

            foreach (Autorstvo a in items)
                data.Add(new AutorstvoView(a));
        }
        catch (Exception)
        {
            return "Nemoguće vratiti autore publikacije.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public static Result<List<AutorstvoView>, ErrorMessage> VratiPublikacijeAutora(int idAutora)
    {
        ISession? s = null;
        List<AutorstvoView> data = new();

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            IEnumerable<Autorstvo> items = from o in s.Query<Autorstvo>()
                                            where o.Autor.Id == idAutora
                                            select o;

            foreach (Autorstvo a in items)
                data.Add(new AutorstvoView(a));
        }
        catch (Exception)
        {
            return "Nemoguće vratiti publikacije autora.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return data;
    }

    public async static Task<Result<AutorstvoView, ErrorMessage>> VratiAutorstvoAsync(int id)
    {
        ISession? s = null;
        AutorstvoView view = default!;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Autorstvo a = await s.LoadAsync<Autorstvo>(id);
            view = new AutorstvoView(a);
        }
        catch (Exception)
        {
            return "Nemoguće vratiti autorstvo sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return view;
    }

    public async static Task<Result<bool, ErrorMessage>> DodajAutorstvoAsync(AutorstvoView dto)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Autorstvo o = new()
            {
                Publikacija = await s.LoadAsync<Publikacija>(dto.IdPublikacije),
                Autor = await s.LoadAsync<Istrazivac>(dto.IdAutora),
                RedosledAutora = dto.RedosledAutora,
                TipDoprinosa = dto.TipDoprinosa,
                Uloga = dto.Uloga
            };

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće dodati autorstvo.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> AzurirajAutorstvoAsync(AutorstvoView dto)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Autorstvo o = await s.LoadAsync<Autorstvo>(dto.Id);

            o.Publikacija = await s.LoadAsync<Publikacija>(dto.IdPublikacije);
            o.Autor = await s.LoadAsync<Istrazivac>(dto.IdAutora);
            o.RedosledAutora = dto.RedosledAutora;
            o.TipDoprinosa = dto.TipDoprinosa;
            o.Uloga = dto.Uloga;

            await s.SaveOrUpdateAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati autorstvo.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiAutorstvoAsync(int id)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();

            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);

            Autorstvo o = await s.LoadAsync<Autorstvo>(id);
            await s.DeleteAsync(o);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati autorstvo.".ToError(400);
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }

    #endregion

    #region NaucniRad

    public static Result<List<NaucniRadView>, ErrorMessage> VratiSveNaucneRadove()
    {
        ISession? s = null;
        List<NaucniRadView> data = new();
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            IEnumerable<NaucniRad> items = from o in s.Query<NaucniRad>() select o;
            foreach (var n in items)
                data.Add(new NaucniRadView(n));
        }
        catch (Exception) { return "Nemoguće vratiti sve naučne radove.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return data;
    }

    public static Result<NaucniRadView, ErrorMessage> VratiNaucniRad(int id)
    {
        ISession? s = null;
        NaucniRadView view = default!;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            NaucniRad n = s.Load<NaucniRad>(id);
            view = new NaucniRadView(n);
        }
        catch (Exception) { return "Nemoguće vratiti naučni rad sa zadatim ID-jem.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return view;
    }

    public static Result<bool, ErrorMessage> SacuvajNaucniRad(NaucniRadView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            NaucniRad n = new()
            {
                Naslov = dto.Naslov,
                Apstrakt = dto.Apstrakt,
                Jezik = dto.Jezik,
                DatumObjavljivanja = dto.DatumObjavljivanja ?? default,
                DatumKreiranjaZapisa = dto.DatumKreiranjaZapisa ?? default,
                Status = dto.Status,
                Vidljivost = dto.Vidljivost,
                DOI = dto.DOI,
                TipRada = dto.TipRada,
                Stranice = dto.Stranice,
                Izvor = dto.IdIzvora.HasValue ? s.Load<Izvor>(dto.IdIzvora.Value) : null
            };
            s.SaveOrUpdate(n);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće sačuvati naučni rad.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> IzmeniNaucniRad(NaucniRadView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            NaucniRad n = s.Load<NaucniRad>(dto.Id);
            n.Naslov = dto.Naslov;
            n.Apstrakt = dto.Apstrakt;
            n.Jezik = dto.Jezik;
            n.DatumObjavljivanja = dto.DatumObjavljivanja ?? default;
            n.DatumKreiranjaZapisa = dto.DatumKreiranjaZapisa ?? default;
            n.Status = dto.Status;
            n.Vidljivost = dto.Vidljivost;
            n.DOI = dto.DOI;
            n.TipRada = dto.TipRada;
            n.Stranice = dto.Stranice;
            if (dto.IdIzvora.HasValue)
                n.Izvor = s.Load<Izvor>(dto.IdIzvora.Value);
            else
                n.Izvor = null;
            s.SaveOrUpdate(n);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće izmeniti naučni rad.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiNaucniRad(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            NaucniRad n = s.Load<NaucniRad>(id);
            s.Delete(n);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće obrisati naučni rad.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    #endregion

    #region Dataset

    public static Result<List<DatasetView>, ErrorMessage> VratiSveDatasetove()
    {
        ISession? s = null;
        List<DatasetView> data = new();
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            IEnumerable<Dataset> items = from o in s.Query<Dataset>() select o;
            foreach (var d in items)
                data.Add(new DatasetView(d));
        }
        catch (Exception) { return "Nemoguće vratiti sve datasetove.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return data;
    }

    public static Result<DatasetView, ErrorMessage> VratiDataset(int id)
    {
        ISession? s = null;
        DatasetView view = default!;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            Dataset d = s.Load<Dataset>(id);
            view = new DatasetView(d);
        }
        catch (Exception) { return "Nemoguće vratiti dataset sa zadatim ID-jem.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return view;
    }

    public static Result<bool, ErrorMessage> SacuvajDataset(DatasetView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            Dataset d = new()
            {
                Naslov = dto.Naslov,
                Apstrakt = dto.Apstrakt,
                Jezik = dto.Jezik,
                DatumObjavljivanja = dto.DatumObjavljivanja ?? default,
                DatumKreiranjaZapisa = dto.DatumKreiranjaZapisa ?? default,
                Status = dto.Status,
                Vidljivost = dto.Vidljivost,
                BrojZapisa = dto.BrojZapisa,
                Velicina = dto.Velicina,
                OpisStrukture = dto.OpisStrukture,
                Format = dto.Format,
                LicencaKoriscenja = dto.LicencaKoriscenja,
                DatumOd = dto.DatumOd ?? default,
                DatumDo = dto.DatumDo ?? default
            };
            s.SaveOrUpdate(d);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće sačuvati dataset.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> IzmeniDataset(DatasetView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            Dataset d = s.Load<Dataset>(dto.Id);
            d.Naslov = dto.Naslov;
            d.Apstrakt = dto.Apstrakt;
            d.Jezik = dto.Jezik;
            d.DatumObjavljivanja = dto.DatumObjavljivanja ?? default;
            d.DatumKreiranjaZapisa = dto.DatumKreiranjaZapisa ?? default;
            d.Status = dto.Status;
            d.Vidljivost = dto.Vidljivost;
            d.BrojZapisa = dto.BrojZapisa;
            d.Velicina = dto.Velicina;
            d.OpisStrukture = dto.OpisStrukture;
            d.Format = dto.Format;
            d.LicencaKoriscenja = dto.LicencaKoriscenja;
            d.DatumOd = dto.DatumOd ?? default;
            d.DatumDo = dto.DatumDo ?? default;
            s.SaveOrUpdate(d);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće izmeniti dataset.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiDataset(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            Dataset d = s.Load<Dataset>(id);
            s.Delete(d);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće obrisati dataset.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    #endregion

    #region SoftverskiArtefakt

    public static Result<List<SoftverskiArtefaktView>, ErrorMessage> VratiSveSoftverskeArtefakte()
    {
        ISession? s = null;
        List<SoftverskiArtefaktView> data = new();
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            IEnumerable<SoftverskiArtefakt> items = from o in s.Query<SoftverskiArtefakt>() select o;
            foreach (var a in items)
                data.Add(new SoftverskiArtefaktView(a));
        }
        catch (Exception) { return "Nemoguće vratiti sve softverske artefakte.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return data;
    }

    public static Result<SoftverskiArtefaktView, ErrorMessage> VratiSoftverskiArtefakt(int id)
    {
        ISession? s = null;
        SoftverskiArtefaktView view = default!;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            SoftverskiArtefakt a = s.Load<SoftverskiArtefakt>(id);
            view = new SoftverskiArtefaktView(a);
        }
        catch (Exception) { return "Nemoguće vratiti softverski artefakt sa zadatim ID-jem.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return view;
    }

    public static Result<bool, ErrorMessage> SacuvajSoftverskiArtefakt(SoftverskiArtefaktView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            SoftverskiArtefakt a = new()
            {
                Naslov = dto.Naslov,
                Apstrakt = dto.Apstrakt,
                Jezik = dto.Jezik,
                DatumObjavljivanja = dto.DatumObjavljivanja ?? default,
                DatumKreiranjaZapisa = dto.DatumKreiranjaZapisa ?? default,
                Status = dto.Status,
                Vidljivost = dto.Vidljivost,
                IdArtefakta = dto.IdArtefakta ?? 0,
                ProgramskiJezik = dto.ProgramskiJezik,
                LinkKaRepozitorijumu = dto.LinkKaRepozitorijumu,
                NacinLicenciranja = dto.NacinLicenciranja
            };
            s.SaveOrUpdate(a);
            s.Flush();
        }
        catch (Exception ex) { return $"Nemoguće sačuvati softverski artefakt. \n{ex.Message}\n\n{ex.InnerException}".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> IzmeniSoftverskiArtefakt(SoftverskiArtefaktView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            SoftverskiArtefakt a = s.Load<SoftverskiArtefakt>(dto.Id);
            a.Naslov = dto.Naslov;
            a.Apstrakt = dto.Apstrakt;
            a.Jezik = dto.Jezik;
            a.DatumObjavljivanja = dto.DatumObjavljivanja ?? default;
            a.DatumKreiranjaZapisa = dto.DatumKreiranjaZapisa ?? default;
            a.Status = dto.Status;
            a.Vidljivost = dto.Vidljivost;
            a.IdArtefakta = dto.IdArtefakta ?? 0;
            a.ProgramskiJezik = dto.ProgramskiJezik;
            a.LinkKaRepozitorijumu = dto.LinkKaRepozitorijumu;
            a.NacinLicenciranja = dto.NacinLicenciranja;
            s.SaveOrUpdate(a);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće izmeniti softverski artefakt.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiSoftverskiArtefakt(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            SoftverskiArtefakt a = s.Load<SoftverskiArtefakt>(id);
            s.Delete(a);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće obrisati softverski artefakt.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    #endregion

    #region Citira

    public static Result<List<CitiraView>, ErrorMessage> VratiCitiranjaPublikacije(int publikacijaId)
    {
        ISession? s = null;
        List<CitiraView> data = new();
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            IEnumerable<Citira> items = from o in s.Query<Citira>()
                                        where o.IdCitira == publikacijaId   // ova publikacija citira druge
                                        select o;
            foreach (var c in items)
                data.Add(new CitiraView(c));
        }
        catch (Exception) { return "Nemoguće vratiti citiranja publikacije.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return data;
    }

    public static Result<List<CitiraView>, ErrorMessage> VratiCitiranostiPublikacije(int publikacijaId)
    {
        ISession? s = null;
        List<CitiraView> data = new();
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            IEnumerable<Citira> items = from o in s.Query<Citira>()
                                        where o.IdCitirana == publikacijaId   // ovu publikaciju citiraju drugi
                                        select o;
            foreach (var c in items)
                data.Add(new CitiraView(c));
        }
        catch (Exception) { return "Nemoguće vratiti citiranosti publikacije.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return data;
    }

    public static Result<CitiraView, ErrorMessage> VratiCitira(int id)
    {
        ISession? s = null;
        CitiraView view = default!;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            Citira c = s.Load<Citira>(id);
            view = new CitiraView(c);
        }
        catch (Exception) { return "Nemoguće vratiti citat sa zadatim ID-jem.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return view;
    }

    public static Result<bool, ErrorMessage> DodajCitira(CitiraView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            Citira c = new()
            {
                IdCitira = dto.IdCitira,
                IdCitirana = dto.IdCitirana,
                TipCitata = dto.TipCitata,
                MestoCitiranja = dto.MestoCitiranja,
                TekstualniKontekst = dto.TekstualniKontekst
            };
            s.SaveOrUpdate(c);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće dodati citat.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> IzmeniCitira(CitiraView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            Citira c = s.Load<Citira>(dto.Id);
            c.IdCitira = dto.IdCitira;
            c.IdCitirana = dto.IdCitirana;
            c.TipCitata = dto.TipCitata;
            c.MestoCitiranja = dto.MestoCitiranja;
            c.TekstualniKontekst = dto.TekstualniKontekst;
            s.SaveOrUpdate(c);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće izmeniti citat.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiCitira(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            Citira c = s.Load<Citira>(id);
            s.Delete(c);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće obrisati citat.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    #endregion

    #region PovezanSa

    public static Result<List<PovezanSaView>, ErrorMessage> VratiPovezanePublikacije(int publikacijaId)
    {
        ISession? s = null;
        List<PovezanSaView> data = new();
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            IEnumerable<PovezanSa> items = from o in s.Query<PovezanSa>()
                                           where o.IdPublikacije1 == publikacijaId || o.IdPublikacije2 == publikacijaId
                                           select o;
            foreach (var p in items)
                data.Add(new PovezanSaView(p));
        }
        catch (Exception) { return "Nemoguće vratiti povezane publikacije.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return data;
    }

    public static Result<PovezanSaView, ErrorMessage> VratiPovezanSa(int id)
    {
        ISession? s = null;
        PovezanSaView view = default!;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            PovezanSa p = s.Load<PovezanSa>(id);
            view = new PovezanSaView(p);
        }
        catch (Exception) { return "Nemoguće vratiti vezu sa zadatim ID-jem.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return view;
    }

    public static Result<bool, ErrorMessage> DodajPovezanSa(PovezanSaView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            PovezanSa p = new()
            {
                IdPublikacije1 = dto.IdPublikacije1,
                IdPublikacije2 = dto.IdPublikacije2,
                TipPovezanosti = dto.TipPovezanosti
            };
            s.SaveOrUpdate(p);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće dodati vezu.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> IzmeniPovezanSa(PovezanSaView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            PovezanSa p = s.Load<PovezanSa>(dto.Id);
            p.IdPublikacije1 = dto.IdPublikacije1;
            p.IdPublikacije2 = dto.IdPublikacije2;
            p.TipPovezanosti = dto.TipPovezanosti;
            s.SaveOrUpdate(p);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće izmeniti vezu.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiPovezanSa(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            PovezanSa p = s.Load<PovezanSa>(id);
            s.Delete(p);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće obrisati vezu.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    #endregion

    #region RundaRecenzije

    public static Result<List<RundaRecenzijeView>, ErrorMessage> VratiRundeRecenzijePublikacije(int publikacijaId)
    {
        ISession? s = null;
        List<RundaRecenzijeView> data = new();
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            IEnumerable<RundaRecenzije> items = from o in s.Query<RundaRecenzije>()
                                                where o.IdPublikacije == publikacijaId
                                                select o;
            foreach (var r in items)
                data.Add(new RundaRecenzijeView(r));
        }
        catch (Exception) { return "Nemoguće vratiti runde recenzije publikacije.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return data;
    }

    public static Result<RundaRecenzijeView, ErrorMessage> VratiRundaRecenzije(int id)
    {
        ISession? s = null;
        RundaRecenzijeView view = default!;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            RundaRecenzije r = s.Load<RundaRecenzije>(id);
            view = new RundaRecenzijeView(r);
        }
        catch (Exception) { return "Nemoguće vratiti rundu recenzije sa zadatim ID-jem.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return view;
    }

    public static Result<bool, ErrorMessage> DodajRundaRecenzije(RundaRecenzijeView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            RundaRecenzije r = new()
            {
                BrojRunde = dto.BrojRunde,
                IdPublikacije = dto.IdPublikacije,
                IdUrednika = dto.IdUrednika,
                Datum = dto.Datum,
                KonacnaOdluka = dto.KonacnaOdluka
            };
            s.SaveOrUpdate(r);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće dodati rundu recenzije.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> IzmeniRundaRecenzije(RundaRecenzijeView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            RundaRecenzije r = s.Load<RundaRecenzije>(dto.Id);
            r.BrojRunde = dto.BrojRunde;
            r.IdPublikacije = dto.IdPublikacije;
            r.IdUrednika = dto.IdUrednika;
            r.Datum = dto.Datum;
            r.KonacnaOdluka = dto.KonacnaOdluka;
            s.SaveOrUpdate(r);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće izmeniti rundu recenzije.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiRundaRecenzije(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            RundaRecenzije r = s.Load<RundaRecenzije>(id);
            s.Delete(r);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće obrisati rundu recenzije.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    #endregion

    #region VrsiRecenziju

    public static Result<List<VrsiRecenzijuView>, ErrorMessage> VratiRecenzijeRunde(int rundaId)
    {
        ISession? s = null;
        List<VrsiRecenzijuView> data = new();
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            IEnumerable<VrsiRecenziju> items = from o in s.Query<VrsiRecenziju>()
                                               where o.IdRundeRecenzije == rundaId
                                               select o;
            foreach (var v in items)
                data.Add(new VrsiRecenzijuView(v));
        }
        catch (Exception) { return "Nemoguće vratiti recenzije runde.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return data;
    }

    public static Result<VrsiRecenzijuView, ErrorMessage> VratiVrsiRecenziju(int id)
    {
        ISession? s = null;
        VrsiRecenzijuView view = default!;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            VrsiRecenziju v = s.Load<VrsiRecenziju>(id);
            view = new VrsiRecenzijuView(v);
        }
        catch (Exception) { return "Nemoguće vratiti recenziju sa zadatim ID-jem.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return view;
    }

    public static Result<bool, ErrorMessage> DodajVrsiRecenziju(VrsiRecenzijuView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            VrsiRecenziju v = new()
            {
                IdRundeRecenzije = dto.IdRundeRecenzije,
                IdRecenzenta = dto.IdRecenzenta,
                Preporuka = dto.Preporuka
            };
            s.SaveOrUpdate(v);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće dodati recenziju.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> IzmeniVrsiRecenziju(VrsiRecenzijuView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            VrsiRecenziju v = s.Load<VrsiRecenziju>(dto.Id);
            v.IdRundeRecenzije = dto.IdRundeRecenzije;
            v.IdRecenzenta = dto.IdRecenzenta;
            v.Preporuka = dto.Preporuka;
            s.SaveOrUpdate(v);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće izmeniti recenziju.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiVrsiRecenziju(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            VrsiRecenziju v = s.Load<VrsiRecenziju>(id);
            s.Delete(v);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće obrisati recenziju.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    #endregion

    #region NizOcena

    public static Result<List<NizOcenaView>, ErrorMessage> VratiOceneRecenzije(int recenzijaId)  // recenzijaId = Id iz VrsiRecenziju
    {
        ISession? s = null;
        List<NizOcenaView> data = new();
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            // Pretpostavljamo da NizOcena ima vezu ka VrsiRecenziju, pa tražimo po toj vezi.
            // Ako nema direktne veze, možemo koristiti IdRundeRecenzije i IdRecenzenta da nađemo.
            // Ovde koristimo vezu VrsiRecenziju.
            IEnumerable<NizOcena> items = from o in s.Query<NizOcena>()
                                          where o.VrsiRecenziju != null && o.VrsiRecenziju.Id == recenzijaId
                                          select o;
            foreach (var n in items)
                data.Add(new NizOcenaView(n));
        }
        catch (Exception) { return "Nemoguće vratiti ocene recenzije.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return data;
    }

    public static Result<NizOcenaView, ErrorMessage> VratiNizOcena(int id)
    {
        ISession? s = null;
        NizOcenaView view = default!;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            NizOcena n = s.Load<NizOcena>(id);
            view = new NizOcenaView(n);
        }
        catch (Exception) { return "Nemoguće vratiti ocenu sa zadatim ID-jem.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return view;
    }

    public static Result<bool, ErrorMessage> DodajNizOcena(NizOcenaView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            NizOcena n = new()
            {
                IdRundeRecenzije = dto.IdRundeRecenzije,
                IdRecenzenta = dto.IdRecenzenta,
                Kriterijum = dto.Kriterijum,
                Ocena = dto.Ocena,
                VrsiRecenziju = dto.IdVrsiRecenziju.HasValue ? s.Load<VrsiRecenziju>(dto.IdVrsiRecenziju.Value) : null
            };
            s.SaveOrUpdate(n);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće dodati ocenu.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> IzmeniNizOcena(NizOcenaView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            NizOcena n = s.Load<NizOcena>(dto.Id);
            n.IdRundeRecenzije = dto.IdRundeRecenzije;
            n.IdRecenzenta = dto.IdRecenzenta;
            n.Kriterijum = dto.Kriterijum;
            n.Ocena = dto.Ocena;
            n.VrsiRecenziju = dto.IdVrsiRecenziju.HasValue ? s.Load<VrsiRecenziju>(dto.IdVrsiRecenziju.Value) : null;
            s.SaveOrUpdate(n);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće izmeniti ocenu.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiNizOcena(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            NizOcena n = s.Load<NizOcena>(id);
            s.Delete(n);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće obrisati ocenu.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    #endregion

    #region KnjigaUrednici

    public static Result<List<KnjigaUredniciView>, ErrorMessage> VratiUrednikeKnjige(int knjigaId)
    {
        ISession? s = null;
        List<KnjigaUredniciView> data = new();
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            IEnumerable<KnjigaUrednici> items = from o in s.Query<KnjigaUrednici>()
                                                where o.IdPublikacije == knjigaId
                                                select o;
            foreach (var k in items)
                data.Add(new KnjigaUredniciView(k));
        }
        catch (Exception) { return "Nemoguće vratiti urednike knjige.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return data;
    }

    public static Result<KnjigaUredniciView, ErrorMessage> VratiKnjigaUrednici(int id)
    {
        ISession? s = null;
        KnjigaUredniciView view = default!;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            KnjigaUrednici k = s.Load<KnjigaUrednici>(id);
            view = new KnjigaUredniciView(k);
        }
        catch (Exception) { return "Nemoguće vratiti urednika knjige sa zadatim ID-jem.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return view;
    }

    public static Result<bool, ErrorMessage> DodajKnjigaUrednici(KnjigaUredniciView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            KnjigaUrednici k = new()
            {
                IdPublikacije = dto.IdPublikacije,
                Urednik = dto.Urednik
            };
            s.SaveOrUpdate(k);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće dodati urednika knjige.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> IzmeniKnjigaUrednici(KnjigaUredniciView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            KnjigaUrednici k = s.Load<KnjigaUrednici>(dto.Id);
            k.IdPublikacije = dto.IdPublikacije;
            k.Urednik = dto.Urednik;
            s.SaveOrUpdate(k);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće izmeniti urednika knjige.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiKnjigaUrednici(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            KnjigaUrednici k = s.Load<KnjigaUrednici>(id);
            s.Delete(k);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće obrisati urednika knjige.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    #endregion

    #region PoglavljeUrednici

    public static Result<List<PoglavljeUredniciView>, ErrorMessage> VratiUrednikePoglavlja(int poglavljeId)
    {
        ISession? s = null;
        List<PoglavljeUredniciView> data = new();
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            IEnumerable<PoglavljeUrednici> items = from o in s.Query<PoglavljeUrednici>()
                                                   where o.IdPublikacije == poglavljeId
                                                   select o;
            foreach (var p in items)
                data.Add(new PoglavljeUredniciView(p));
        }
        catch (Exception) { return "Nemoguće vratiti urednike poglavlja.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return data;
    }

    public static Result<PoglavljeUredniciView, ErrorMessage> VratiPoglavljeUrednici(int id)
    {
        ISession? s = null;
        PoglavljeUredniciView view = default!;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            PoglavljeUrednici p = s.Load<PoglavljeUrednici>(id);
            view = new PoglavljeUredniciView(p);
        }
        catch (Exception) { return "Nemoguće vratiti urednika poglavlja sa zadatim ID-jem.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return view;
    }

    public static Result<bool, ErrorMessage> DodajPoglavljeUrednici(PoglavljeUredniciView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            PoglavljeUrednici p = new()
            {
                IdPublikacije = dto.IdPublikacije,
                Urednik = dto.Urednik
            };
            s.SaveOrUpdate(p);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće dodati urednika poglavlja.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> IzmeniPoglavljeUrednici(PoglavljeUredniciView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            PoglavljeUrednici p = s.Load<PoglavljeUrednici>(dto.Id);
            p.IdPublikacije = dto.IdPublikacije;
            p.Urednik = dto.Urednik;
            s.SaveOrUpdate(p);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće izmeniti urednika poglavlja.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiPoglavljeUrednici(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            PoglavljeUrednici p = s.Load<PoglavljeUrednici>(id);
            s.Delete(p);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće obrisati urednika poglavlja.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    #endregion

    #region SoftverskiArtefaktPodrzanePlatforme

    public static Result<List<SoftverskiArtefaktPodrzanePlatformeView>, ErrorMessage> VratiPlatformeArtefakta(int artefaktId)
    {
        ISession? s = null;
        List<SoftverskiArtefaktPodrzanePlatformeView> data = new();
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            IEnumerable<SoftverskiArtefaktPodrzanePlatforme> items = from o in s.Query<SoftverskiArtefaktPodrzanePlatforme>()
                                                                     where o.IdPublikacije == artefaktId
                                                                     select o;
            foreach (var p in items)
                data.Add(new SoftverskiArtefaktPodrzanePlatformeView(p));
        }
        catch (Exception) { return "Nemoguće vratiti platforme artefakta.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return data;
    }

    public static Result<SoftverskiArtefaktPodrzanePlatformeView, ErrorMessage> VratiPlatformu(int id)
    {
        ISession? s = null;
        SoftverskiArtefaktPodrzanePlatformeView view = default!;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            SoftverskiArtefaktPodrzanePlatforme p = s.Load<SoftverskiArtefaktPodrzanePlatforme>(id);
            view = new SoftverskiArtefaktPodrzanePlatformeView(p);
        }
        catch (Exception) { return "Nemoguće vratiti platformu sa zadatim ID-jem.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return view;
    }

    public static Result<bool, ErrorMessage> DodajPlatformu(SoftverskiArtefaktPodrzanePlatformeView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            SoftverskiArtefaktPodrzanePlatforme p = new()
            {
                IdPublikacije = dto.IdPublikacije,
                PodrzanaPlatforma = dto.PodrzanaPlatforma
            };
            s.SaveOrUpdate(p);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće dodati platformu.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> IzmeniPlatformu(SoftverskiArtefaktPodrzanePlatformeView dto)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            SoftverskiArtefaktPodrzanePlatforme p = s.Load<SoftverskiArtefaktPodrzanePlatforme>(dto.Id);
            p.IdPublikacije = dto.IdPublikacije;
            p.PodrzanaPlatforma = dto.PodrzanaPlatforma;
            s.SaveOrUpdate(p);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće izmeniti platformu.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    public static Result<bool, ErrorMessage> ObrisiPlatformu(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
                return "Nemoguće otvoriti sesiju.".ToError(403);
            SoftverskiArtefaktPodrzanePlatforme p = s.Load<SoftverskiArtefaktPodrzanePlatforme>(id);
            s.Delete(p);
            s.Flush();
        }
        catch (Exception) { return "Nemoguće obrisati platformu.".ToError(400); }
        finally { s?.Close(); s?.Dispose(); }
        return true;
    }

    #endregion
}
