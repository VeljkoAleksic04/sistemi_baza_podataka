using Antlr.Runtime.Tree;
using DigitalniRepozitorijum.Entiteti;
using DigitalniRepozitorijum.Mapiranja;
using DigitalniRepozitorijum.Utils;
using FluentNHibernate.Conventions;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum
{
    public class DTOManager
    {
        #region Publikacija
        public static List<PublikacijaPregled> vratiSvePublikacije()
        {
            List<PublikacijaPregled> publikacije = new List<PublikacijaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Publikacija> svePublikacije = from o in s.Query<DigitalniRepozitorijum.Entiteti.Publikacija>() select o;

                foreach (Publikacija p in svePublikacije)
                {
                    publikacije.Add(new PublikacijaPregled(p.Id, p.Naslov, p.Jezik, p.Status, p.Vidljivost, p.DatumObjavljivanja));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return publikacije;
        }
        public static void dodajPublikaciju(PublikacijaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Publikacija o = new Publikacija();
                o.Naslov = p.Naslov;
                o.Apstrakt = p.Apstrakt;
                o.Jezik = p.Jezik;
                o.DatumObjavljivanja = p.DatumObjavljivanja;
                o.DatumKreiranjaZapisa = p.DatumKreiranjaZapisa;
                o.Status = p.Status;
                o.Vidljivost = p.Vidljivost;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static PublikacijaBasic azurirajPublikaciju(PublikacijaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Publikacija o = s.Load<Publikacija>(p.Id);
                o.Naslov = p.Naslov;
                o.Apstrakt = p.Apstrakt;
                o.Jezik = p.Jezik;
                o.DatumObjavljivanja = p.DatumObjavljivanja;
                o.DatumKreiranjaZapisa = p.DatumKreiranjaZapisa;
                o.Status = p.Status;
                o.Vidljivost = p.Vidljivost;

                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return p;
        }
        public static PublikacijaBasic vratiPublikacijuBasic(int id)
        {
            PublikacijaBasic pb = new PublikacijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                var o = s.Get<Publikacija>(id);

                switch (o)
                {
                    case Knjiga:
                        pb = new KnjigaBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost,
                            o.DatumObjavljivanja, o.DatumKreiranjaZapisa,
                            ((Knjiga)o).Izdavac, ((Knjiga)o).MestoIzdanja);
                        break;

                    case NaucniRad:
                        pb = new NaucniRadBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost,
                            o.DatumObjavljivanja, o.DatumKreiranjaZapisa,
                            ((NaucniRad)o).DOI, ((NaucniRad)o).TipRada, ((NaucniRad)o).Stranice, ((NaucniRad)o).IdIzvora);
                        break;

                    case ObrazovniMaterijal:
                        pb = new ObrazovniMaterijalBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost,
                            o.DatumObjavljivanja, o.DatumKreiranjaZapisa);
                        break;

                    case Prezentacija:
                        pb = new PrezentacijaBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost,
                            o.DatumObjavljivanja, o.DatumKreiranjaZapisa);
                        break;

                    case PoglavljeUKnjizi:
                        pb = new PoglavljeUKnjiziBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost,
                            o.DatumObjavljivanja, o.DatumKreiranjaZapisa,
                            ((PoglavljeUKnjizi)o).Izdavac, ((PoglavljeUKnjizi)o).MestoIzdanja);
                        break;

                    case TehnickiIzvestaj:
                        pb = new TehnickiIzvestajBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost,
                            o.DatumObjavljivanja, o.DatumKreiranjaZapisa);
                        break;

                    case SoftverskiArtefakt:
                        pb = new SoftverskiArtefaktBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost,
                            o.DatumObjavljivanja, o.DatumKreiranjaZapisa,
                            ((SoftverskiArtefakt)o).ProgramskiJezik, ((SoftverskiArtefakt)o).LinkKaRepozitorijumu,
                            ((SoftverskiArtefakt)o).NacinLicenciranja);
                        break;

                    case Dataset:
                        pb = new DatasetBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost,
                            o.DatumObjavljivanja, o.DatumKreiranjaZapisa,
                            ((Dataset)o).BrojZapisa, ((Dataset)o).Velicina, ((Dataset)o).Format,
                            ((Dataset)o).LicencaKoriscenja);
                        break;

                    case DoktorskaDisertacija:
                        pb = new DoktorskaDisertacijaBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost,
                            o.DatumObjavljivanja, o.DatumKreiranjaZapisa);
                        break;
                    default:
                        MessageBox.Show("Nepoznata vrsta publikacije!");
                        break;
                }

                foreach (Verzija v in o.Verzije)
                {
                    pb.Verzije.Add(
                        new VerzijaBasic(
                            v.Id,
                            v.BrojVerzije,
                            pb,
                            v.DatumPostavljanja,
                            v.OpisIzmene,
                            v.OdgovornaOsoba
                            )
                        );
                }
                foreach (PublikacijaKljucnaRec pkr in o.KljucneReci)
                {
                    pb.KljucneReci.Add(
                        new PublikacijaKljucnaRecBasic(
                            pkr.Id,
                            pb,
                            pkr.KljucnaRec
                            )
                        );
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return pb;
        }
        public static void obrisiPublikaciju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Publikacija o = s.Load<Publikacija>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<PovezanSaPregled> VratiPovezanePublikacije(int idPublikacije1)
        {
            List<PovezanSaPregled> povezanePublikacije = new List<PovezanSaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<PovezanSa> svePovezanePublikacije = from o in s.Query<PovezanSa>() where o.Publikacija1.Id == idPublikacije1 select o;
                foreach (PovezanSa p in svePovezanePublikacije)
                {
                    povezanePublikacije.Add(new PovezanSaPregled
                    {
                        Id = p.Id,
                        IdPublikacije2 = p.IdPublikacije2,
                        Naslov = p.Publikacija1!.Naslov,
                        TipPovezanosti = p.TipPovezanosti
                    });
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return povezanePublikacije;
        }

        public static bool DodajPovezanuPublikaciju(int idPublikacije1, int idPublikacije2, string tipPovezanosti)
        {
            bool status = false;
            try
            {
                ISession s = DataLayer.GetSession();
                PovezanSa o = new PovezanSa
                {
                    IdPublikacije1 = idPublikacije1,
                    IdPublikacije2 = idPublikacije2,
                    TipPovezanosti = tipPovezanosti,
                    Publikacija1 = s.Load<Publikacija>(idPublikacije1),
                    Publikacija2 = s.Load<Publikacija>(idPublikacije2)
                };
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();

                status = true;
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return status;
            }
        }

        public static bool IzmeniPovezanuPublikaciju(int idPovezanePublikacije, string tipPovezanosti)
        {
            bool status = false;
            try
            {
                ISession s = DataLayer.GetSession();
                PovezanSa o = s.Query<PovezanSa>().FirstOrDefault(p => p.Id == idPovezanePublikacije);
                if (o != null)
                {
                    o.TipPovezanosti = tipPovezanosti;
                    s.Update(o);
                    s.Flush();
                }
                s.Close();
                status = true;
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return status;
            }
        }

        public static List<Publikacija> VratiSveOsim(int idPublikacije)
        {
            List<Publikacija> publikacije = new List<Publikacija>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Publikacija> svePublikacije = from o in s.Query<Publikacija>() where o.Id != idPublikacije select o;
                foreach (Publikacija p in svePublikacije)
                {
                    publikacije.Add(p);
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return publikacije;
        }

        public static bool ObrisiPovezanuPublikaciju(int idPovezanePublikacije)
        {
            bool status = false;
            try
            {
                ISession s = DataLayer.GetSession();
                PovezanSa o = s.Query<PovezanSa>().FirstOrDefault(p => p.Id == idPovezanePublikacije);
                if (o != null)
                {
                    s.Delete(o);
                    s.Flush();
                }
                s.Close();
                status = true;
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return status;
            }
        }

        public static PublikacijaBasic vratiCitiranuPublikaciju(int idPublikacije)
        {
            PublikacijaBasic publikacija = null;
            try
            {
                ISession s = DataLayer.GetSession();
                PovezanSa o = s.Query<PovezanSa>().FirstOrDefault(p => p.IdPublikacije1 == idPublikacije);
                if (o != null)
                {
                    publikacija = new PublikacijaBasic
                    {
                        Id = o.Publikacija2.Id,
                        Naslov = o.Publikacija2.Naslov,
                        Apstrakt = o.Publikacija2.Apstrakt,
                        Jezik = o.Publikacija2.Jezik,
                        Status = o.Publikacija2.Status,
                        Vidljivost = o.Publikacija2.Vidljivost,
                        DatumObjavljivanja = o.Publikacija2.DatumObjavljivanja,
                        DatumKreiranjaZapisa = o.Publikacija2.DatumKreiranjaZapisa
                    };
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return publikacija;
        }

        #endregion


        #region Verzija
        public static List<VerzijaPregled> vratiSveVerzije()
        {
            List<VerzijaPregled> verzije = new List<VerzijaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Verzija> sveVerzije = from o in s.Query<Verzija>() select o;

                foreach (Verzija v in sveVerzije)
                {
                    verzije.Add(new VerzijaPregled(v.Id, v.BrojVerzije, v.DatumPostavljanja, v.OpisIzmene, v.OdgovornaOsoba));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return verzije;
        }
        public static void dodajVerziju(VerzijaBasic vb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Verzija o = new Verzija();
                o.BrojVerzije = vb.BrojVerzije;
                o.Publikacija = s.Load<Publikacija>(vb.Publikacija.Id);
                o.DatumPostavljanja = vb.DatumPostavljanja;
                o.OpisIzmene = vb.OpisIzmene;
                o.OdgovornaOsoba = vb.OdgovornaOsoba;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static VerzijaBasic azurirajVerziju(VerzijaBasic vb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Verzija o = s.Load<Verzija>(vb.Id);
                o.BrojVerzije = vb.BrojVerzije;
                o.Publikacija = s.Load<Publikacija>(vb.Publikacija.Id);
                o.DatumPostavljanja = vb.DatumPostavljanja;
                o.OpisIzmene = vb.OpisIzmene;
                o.OdgovornaOsoba = vb.OdgovornaOsoba;

                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return vb;
        }
        public static VerzijaBasic vratiVerziju(int id)
        {
            VerzijaBasic vb = new VerzijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Verzija o = s.Load<Verzija>(id);
                PublikacijaBasic pb = new PublikacijaBasic(o.Publikacija.Id, o.Publikacija.Naslov, o.Publikacija.Apstrakt, o.Publikacija.Jezik, o.Publikacija.Status, o.Publikacija.Vidljivost, o.Publikacija.DatumObjavljivanja, o.Publikacija.DatumKreiranjaZapisa);
                vb = new VerzijaBasic(o.Id, o.BrojVerzije, pb, o.DatumPostavljanja, o.OpisIzmene, o.OdgovornaOsoba);
                foreach (Fajl v in o.Fajlovi)
                {
                    vb.Fajlovi.Add(
                        new FajlBasic(
                            v.Id,
                            v.Putanja,
                            vb
                            )
                        );
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return vb;
        }
        public static void obrisiVerziju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Verzija o = s.Load<Verzija>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region PublikacijaKljucnaRec
        public static List<PublikacijaKljucnaRecPregled> vratiSvePublikacijaKljucnaRec()
        {
            List<PublikacijaKljucnaRecPregled> publikacijaKljucneReci = new List<PublikacijaKljucnaRecPregled>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<PublikacijaKljucnaRec> svePublikacijaKljucneReci = from o in s.Query<PublikacijaKljucnaRec>() select o;

                foreach (PublikacijaKljucnaRec p in svePublikacijaKljucneReci)
                {
                    publikacijaKljucneReci.Add(new PublikacijaKljucnaRecPregled(p.Id, p.KljucnaRec));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return publikacijaKljucneReci;
        }
        public static void dodajPublikacijaKljucnaRec(PublikacijaKljucnaRecBasic pkrb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PublikacijaKljucnaRec o = new PublikacijaKljucnaRec();
                o.Publikacija = s.Load<Publikacija>(pkrb.Publikacija.Id);
                o.KljucnaRec = pkrb.KljucnaRec;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static PublikacijaKljucnaRecBasic azurirajPublikacijaKljucnaRec(PublikacijaKljucnaRecBasic pkrb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PublikacijaKljucnaRec o = s.Load<PublikacijaKljucnaRec>(pkrb.Id);
                o.Publikacija = s.Load<Publikacija>(pkrb.Publikacija.Id);
                o.KljucnaRec = pkrb.KljucnaRec;

                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return pkrb;
        }
        public static PublikacijaKljucnaRecBasic vratiPublikacijaKljucnaRec(int id)
        {
            PublikacijaKljucnaRecBasic pkrb = new PublikacijaKljucnaRecBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                PublikacijaKljucnaRec o = s.Load<PublikacijaKljucnaRec>(id);

                PublikacijaBasic pb = new PublikacijaBasic(o.Publikacija.Id, o.Publikacija.Naslov, o.Publikacija.Apstrakt, o.Publikacija.Jezik, o.Publikacija.Status, o.Publikacija.Vidljivost, o.Publikacija.DatumObjavljivanja, o.Publikacija.DatumKreiranjaZapisa);
                pkrb = new PublikacijaKljucnaRecBasic(o.Id, pb, o.KljucnaRec);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return pkrb;
        }
        public static void obrisiPublikacijaKljucnaRec(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PublikacijaKljucnaRec o = s.Load<PublikacijaKljucnaRec>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region Knjiga
        public static List<KnjigaPregled> vratiSveKnjige()
        {
            List<KnjigaPregled> knjige = new List<KnjigaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Knjiga> sveKnjige = from o in s.Query<DigitalniRepozitorijum.Entiteti.Knjiga>() select o;

                foreach (Knjiga k in sveKnjige)
                {
                    knjige.Add(new KnjigaPregled(k.Id, k.Naslov, k.Jezik, k.Status, k.Vidljivost, k.DatumObjavljivanja, k.Izdavac, k.MestoIzdanja));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return knjige;
        }
        public static void dodajKnjigu(KnjigaBasic kb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Knjiga o = new Knjiga();
                o.Naslov = kb.Naslov;
                o.Apstrakt = kb.Apstrakt;
                o.Jezik = kb.Jezik;
                o.DatumObjavljivanja = kb.DatumObjavljivanja;
                o.DatumKreiranjaZapisa = kb.DatumKreiranjaZapisa;
                o.Status = kb.Status;
                o.Vidljivost = kb.Vidljivost;
                o.Izdavac = kb.Izdavac;
                o.MestoIzdanja = kb.MestoIzdanja;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static KnjigaBasic azurirajKnjigu(KnjigaBasic kb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Knjiga o = s.Load<Knjiga>(kb.Id);
                o.Naslov = kb.Naslov;
                o.Apstrakt = kb.Apstrakt;
                o.Jezik = kb.Jezik;
                o.DatumObjavljivanja = kb.DatumObjavljivanja;
                o.DatumKreiranjaZapisa = kb.DatumKreiranjaZapisa;
                o.Status = kb.Status;
                o.Vidljivost = kb.Vidljivost;
                o.Izdavac = kb.Izdavac;
                o.MestoIzdanja = kb.MestoIzdanja;

                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return kb;
        }
        public static KnjigaBasic vratiKnjigu(int id)
        {
            KnjigaBasic kb = new KnjigaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Knjiga o = s.Load<Knjiga>(id);
                kb = new KnjigaBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost, o.DatumObjavljivanja, o.DatumKreiranjaZapisa, o.Izdavac, o.MestoIzdanja);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return kb;
        }
        public static void obrisiKnjigu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Knjiga o = s.Load<Knjiga>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region PoglavljeUKnjizi
        public static List<PoglavljeUKnjiziPregled> vratiSvePoglavljaUKnjizi()
        {
            List<PoglavljeUKnjiziPregled> poglavljaUKnjizi = new List<PoglavljeUKnjiziPregled>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<PoglavljeUKnjizi> svePoglavljaUKnjizi = from o in s.Query<DigitalniRepozitorijum.Entiteti.PoglavljeUKnjizi>() select o;

                foreach (PoglavljeUKnjizi p in svePoglavljaUKnjizi)
                {
                    poglavljaUKnjizi.Add(new PoglavljeUKnjiziPregled(p.Id, p.Naslov, p.Jezik, p.Status, p.Vidljivost, p.DatumObjavljivanja, p.Izdavac, p.MestoIzdanja));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return poglavljaUKnjizi;
        }
        public static void dodajPoglavljeUKnjizi(PoglavljeUKnjiziBasic pb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PoglavljeUKnjizi o = new PoglavljeUKnjizi();
                o.Naslov = pb.Naslov;
                o.Apstrakt = pb.Apstrakt;
                o.Jezik = pb.Jezik;
                o.DatumObjavljivanja = pb.DatumObjavljivanja;
                o.DatumKreiranjaZapisa = pb.DatumKreiranjaZapisa;
                o.Status = pb.Status;
                o.Vidljivost = pb.Vidljivost;
                o.Izdavac = pb.Izdavac;
                o.MestoIzdanja = pb.MestoIzdanja;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static PoglavljeUKnjiziBasic azurirajPoglavljeUKnjizi(PoglavljeUKnjiziBasic pb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PoglavljeUKnjizi o = s.Load<PoglavljeUKnjizi>(pb.Id);
                o.Naslov = pb.Naslov;
                o.Apstrakt = pb.Apstrakt;
                o.Jezik = pb.Jezik;
                o.DatumObjavljivanja = pb.DatumObjavljivanja;
                o.DatumKreiranjaZapisa = pb.DatumKreiranjaZapisa;
                o.Status = pb.Status;
                o.Vidljivost = pb.Vidljivost;
                o.Izdavac = pb.Izdavac;
                o.MestoIzdanja = pb.MestoIzdanja;

                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return pb;
        }
        public static PoglavljeUKnjiziBasic vratiPoglavljeUKnjizi(int id)
        {
            PoglavljeUKnjiziBasic pb = new PoglavljeUKnjiziBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                PoglavljeUKnjizi o = s.Load<PoglavljeUKnjizi>(id);
                pb = new PoglavljeUKnjiziBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost, o.DatumObjavljivanja, o.DatumKreiranjaZapisa, o.Izdavac, o.MestoIzdanja);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return pb;
        }
        public static void obrisiPoglavljeUKnjizi(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PoglavljeUKnjizi o = s.Load<PoglavljeUKnjizi>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region DoktorskaDisertacija
        public static List<DoktorskaDisertacijaPregled> vratiSveDoktorskeDisertacije()
        {
            List<DoktorskaDisertacijaPregled> doktorskeDisertacije = new List<DoktorskaDisertacijaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<DoktorskaDisertacija> sveDoktorskeDisertacije = from o in s.Query<DigitalniRepozitorijum.Entiteti.DoktorskaDisertacija>() select o;

                foreach (DoktorskaDisertacija d in sveDoktorskeDisertacije)
                {
                    doktorskeDisertacije.Add(new DoktorskaDisertacijaPregled(d.Id, d.Naslov, d.Jezik, d.Status, d.Vidljivost, d.DatumObjavljivanja));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return doktorskeDisertacije;
        }
        public static void dodajDoktorskuDisertaciju(DoktorskaDisertacijaBasic db)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DoktorskaDisertacija o = new DoktorskaDisertacija();
                o.Naslov = db.Naslov;
                o.Apstrakt = db.Apstrakt;
                o.Jezik = db.Jezik;
                o.DatumObjavljivanja = db.DatumObjavljivanja;
                o.DatumKreiranjaZapisa = db.DatumKreiranjaZapisa;
                o.Status = db.Status;
                o.Vidljivost = db.Vidljivost;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static DoktorskaDisertacijaBasic azurirajDoktorskuDisertaciju(DoktorskaDisertacijaBasic db)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DoktorskaDisertacija o = s.Load<DoktorskaDisertacija>(db.Id);
                o.Naslov = db.Naslov;
                o.Apstrakt = db.Apstrakt;
                o.Jezik = db.Jezik;
                o.DatumObjavljivanja = db.DatumObjavljivanja;
                o.DatumKreiranjaZapisa = db.DatumKreiranjaZapisa;
                o.Status = db.Status;
                o.Vidljivost = db.Vidljivost;

                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return db;
        }
        public static DoktorskaDisertacijaBasic vratiDoktorskuDisertaciju(int id)
        {
            DoktorskaDisertacijaBasic db = new DoktorskaDisertacijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                DoktorskaDisertacija o = s.Load<DoktorskaDisertacija>(id);
                db = new DoktorskaDisertacijaBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost, o.DatumObjavljivanja, o.DatumKreiranjaZapisa);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return db;
        }
        public static void obrisiDoktorskuDisertaciju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DoktorskaDisertacija o = s.Load<DoktorskaDisertacija>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region ObrazovniMaterijal
        public static List<ObrazovniMaterijalPregled> vratiSveObrazovneMaterijale()
        {
            List<ObrazovniMaterijalPregled> obrazovniMaterijali = new List<ObrazovniMaterijalPregled>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ObrazovniMaterijal> sviObrazovniMaterijali = from o in s.Query<DigitalniRepozitorijum.Entiteti.ObrazovniMaterijal>() select o;

                foreach (ObrazovniMaterijal o in sviObrazovniMaterijali)
                {
                    obrazovniMaterijali.Add(new ObrazovniMaterijalPregled(o.Id, o.Naslov, o.Jezik, o.Status, o.Vidljivost, o.DatumObjavljivanja));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return obrazovniMaterijali;
        }
        public static void dodajObrazovniMaterijal(ObrazovniMaterijalBasic ob)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ObrazovniMaterijal o = new ObrazovniMaterijal();
                o.Naslov = ob.Naslov;
                o.Apstrakt = ob.Apstrakt;
                o.Jezik = ob.Jezik;
                o.DatumObjavljivanja = ob.DatumObjavljivanja;
                o.DatumKreiranjaZapisa = ob.DatumKreiranjaZapisa;
                o.Status = ob.Status;
                o.Vidljivost = ob.Vidljivost;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static ObrazovniMaterijalBasic azurirajObrazovniMaterijal(ObrazovniMaterijalBasic ob)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ObrazovniMaterijal o = s.Load<ObrazovniMaterijal>(ob.Id);
                o.Naslov = ob.Naslov;
                o.Apstrakt = ob.Apstrakt;
                o.Jezik = ob.Jezik;
                o.DatumObjavljivanja = ob.DatumObjavljivanja;
                o.DatumKreiranjaZapisa = ob.DatumKreiranjaZapisa;
                o.Status = ob.Status;
                o.Vidljivost = ob.Vidljivost;

                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ob;
        }
        public static ObrazovniMaterijalBasic vratiObrazovniMaterijal(int id)
        {
            ObrazovniMaterijalBasic ob = new ObrazovniMaterijalBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ObrazovniMaterijal o = s.Load<ObrazovniMaterijal>(id);
                ob = new ObrazovniMaterijalBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost, o.DatumObjavljivanja, o.DatumKreiranjaZapisa);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ob;
        }
        public static void obrisiObrazovniMaterijal(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ObrazovniMaterijal o = s.Load<ObrazovniMaterijal>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region Prezentacija
        public static List<PrezentacijaPregled> vratiSvePrezentacije()
        {
            List<PrezentacijaPregled> prezentacije = new List<PrezentacijaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Prezentacija> svePrezentacije = from o in s.Query<DigitalniRepozitorijum.Entiteti.Prezentacija>() select o;

                foreach (Prezentacija p in svePrezentacije)
                {
                    prezentacije.Add(new PrezentacijaPregled(p.Id, p.Naslov, p.Jezik, p.Status, p.Vidljivost, p.DatumObjavljivanja));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return prezentacije;
        }
        public static void dodajPrezentaciju(PrezentacijaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prezentacija o = new Prezentacija();
                o.Naslov = p.Naslov;
                o.Apstrakt = p.Apstrakt;
                o.Jezik = p.Jezik;
                o.DatumObjavljivanja = p.DatumObjavljivanja;
                o.DatumKreiranjaZapisa = p.DatumKreiranjaZapisa;
                o.Status = p.Status;
                o.Vidljivost = p.Vidljivost;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static PrezentacijaBasic azurirajPrezentaciju(PrezentacijaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prezentacija o = s.Load<Prezentacija>(p.Id);
                o.Naslov = p.Naslov;
                o.Apstrakt = p.Apstrakt;
                o.Jezik = p.Jezik;
                o.DatumObjavljivanja = p.DatumObjavljivanja;
                o.DatumKreiranjaZapisa = p.DatumKreiranjaZapisa;
                o.Status = p.Status;
                o.Vidljivost = p.Vidljivost;

                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return p;
        }
        public static PrezentacijaBasic vratiPrezentaciju(int id)
        {
            PrezentacijaBasic pb = new PrezentacijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Prezentacija o = s.Load<Prezentacija>(id);
                pb = new PrezentacijaBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost, o.DatumObjavljivanja, o.DatumKreiranjaZapisa);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return pb;
        }
        public static void obrisiPrezentaciju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prezentacija o = s.Load<Prezentacija>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region TehnickiIzvestaj
        public static List<TehnickiIzvestajPregled> vratiSveTehnickeIzvestaje()
        {
            List<TehnickiIzvestajPregled> tehnickiIzvestaji = new List<TehnickiIzvestajPregled>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<TehnickiIzvestaj> sviTehnickiIzvestaji = from o in s.Query<DigitalniRepozitorijum.Entiteti.TehnickiIzvestaj>() select o;

                foreach (TehnickiIzvestaj t in sviTehnickiIzvestaji)
                {
                    tehnickiIzvestaji.Add(new TehnickiIzvestajPregled(t.Id, t.Naslov, t.Jezik, t.Status, t.Vidljivost, t.DatumObjavljivanja));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return tehnickiIzvestaji;
        }
        public static void dodajTehnickiIzvestaj(TehnickiIzvestajBasic tb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickiIzvestaj o = new TehnickiIzvestaj();
                o.Naslov = tb.Naslov;
                o.Apstrakt = tb.Apstrakt;
                o.Jezik = tb.Jezik;
                o.DatumObjavljivanja = tb.DatumObjavljivanja;
                o.DatumKreiranjaZapisa = tb.DatumKreiranjaZapisa;
                o.Status = tb.Status;
                o.Vidljivost = tb.Vidljivost;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static TehnickiIzvestajBasic azurirajTehnickiIzvestaj(TehnickiIzvestajBasic tb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickiIzvestaj o = s.Load<TehnickiIzvestaj>(tb.Id);
                o.Naslov = tb.Naslov;
                o.Apstrakt = tb.Apstrakt;
                o.Jezik = tb.Jezik;
                o.DatumObjavljivanja = tb.DatumObjavljivanja;
                o.DatumKreiranjaZapisa = tb.DatumKreiranjaZapisa;
                o.Status = tb.Status;
                o.Vidljivost = tb.Vidljivost;

                s.Update(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return tb;
        }
        public static TehnickiIzvestajBasic vratiTehnickiIzvestaj(int id)
        {
            TehnickiIzvestajBasic tb = new TehnickiIzvestajBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickiIzvestaj o = s.Load<TehnickiIzvestaj>(id);
                tb = new TehnickiIzvestajBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost, o.DatumObjavljivanja, o.DatumKreiranjaZapisa);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return tb;
        }
        public static void obrisiTehnickiIzvestaj(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickiIzvestaj o = s.Load<TehnickiIzvestaj>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Fajl
        public static List<FajlPregled> vratiSveFajlove()
        {
            List<FajlPregled> fajlovi = new List<FajlPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Fajl> sviFajlovi = from o in s.Query<Fajl>() select o;

                foreach (Fajl f in sviFajlovi)
                {
                    fajlovi.Add(new FajlPregled(f.Id, f.Putanja));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return fajlovi;
        }
        public static void dodajFajl(FajlBasic fb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Fajl f = new Fajl();

                f.Putanja = fb.Putanja;
                f.Verzija = s.Load<Verzija>(fb.Verzija.Id);

                s.SaveOrUpdate(f);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static FajlBasic azurirajFajl(FajlBasic fb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Fajl f = s.Load<Fajl>(fb.Id);

                f.Putanja = fb.Putanja;
                f.Verzija = s.Load<Verzija>(fb.Verzija.Id);

                s.Update(f);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return fb;
        }
        public static FajlBasic vratiFajl(int id)
        {
            FajlBasic fb = new FajlBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                Fajl f = s.Load<Fajl>(id);

                VerzijaBasic vb = new VerzijaBasic(f.Verzija.Id, f.Verzija.BrojVerzije, vratiPublikacijuBasic(f.Verzija.Publikacija.Id), f.Verzija.DatumPostavljanja, f.Verzija.OpisIzmene, f.Verzija.OdgovornaOsoba);
                fb = new FajlBasic(f.Id, f.Putanja, vb);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return fb;
        }
        public static void obrisiFajl(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Fajl f = s.Load<Fajl>(id);

                s.Delete(f);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        public static void dodajInstituciju(InstitucijaBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Institucija o = new Entiteti.Institucija();
                o.Naziv = dto.Naziv;
                o.Adresa = dto.Adresa;
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju institucije: " + ex.Message);
            }
        }

        public static List<InstitucijaPregled> vratiSveInstitucije()
        {
            List<InstitucijaPregled> lista = new List<InstitucijaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                var rezultati = from o in s.Query<Entiteti.Institucija>() select o;
                foreach (var o in rezultati)
                    lista.Add(new InstitucijaPregled(o.Id, o.Naziv, o.Adresa));
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return lista;
        }

        public static InstitucijaBasic vratiInstituciju(int id)
        {
            InstitucijaBasic dto = new InstitucijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Institucija o = s.Load<Entiteti.Institucija>(id);
                dto.Id = o.Id; 
                dto.Naziv = o.Naziv; 
                dto.Adresa = o.Adresa;

                foreach (var km in o.KontaktMailovi)
                    dto.KontaktMailovi.Add(new InstitucijaKontaktMailBasic(km.Id, dto, km.KontaktMail));
                foreach (var kt in o.KontaktTelefoni)
                    dto.KontaktTelefoni.Add(new InstitucijaKontaktTelBasic(kt.Id, dto, kt.KontaktTel));
                foreach (var no in o.NaucneOblasti)
                    dto.NaucneOblasti.Add(new InstitucijaNaucnaOblastBasic(no.Id, dto, no.NaucnaOblast));

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dto;
        }

        public static void azurirajInstituciju(InstitucijaBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Institucija o = s.Load<Entiteti.Institucija>(dto.Id);
                o.Naziv = dto.Naziv;
                o.Adresa = dto.Adresa;
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void obrisiInstituciju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Institucija o = s.Load<Entiteti.Institucija>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        #region InstitucijaKontaktMail

        public static List<InstitucijaKontaktMailPregled> vratiSveKontaktMailove(int idInstitucije)
        {
            List<InstitucijaKontaktMailPregled> lista = new List<InstitucijaKontaktMailPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<InstitucijaKontaktMail> rezultati =
                    from o in s.Query<InstitucijaKontaktMail>()
                    where o.Institucija.Id == idInstitucije
                    select o;

                foreach (var o in rezultati)
                    lista.Add(new InstitucijaKontaktMailPregled(o.Id, o.KontaktMail));

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return lista;
        }

        public static void dodajKontaktMail(InstitucijaKontaktMailBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                InstitucijaKontaktMail o = new InstitucijaKontaktMail();
                o.Institucija = s.Load<Institucija>(dto.Institucija.Id);
                o.KontaktMail = dto.KontaktMail;
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void azurirajKontaktMail(InstitucijaKontaktMailBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                InstitucijaKontaktMail o = s.Load<InstitucijaKontaktMail>(dto.Id);
                o.KontaktMail = dto.KontaktMail;
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static InstitucijaKontaktMailBasic vratiKontaktMail(int id)
        {
            InstitucijaKontaktMailBasic dto = new InstitucijaKontaktMailBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                InstitucijaKontaktMail o = s.Load<InstitucijaKontaktMail>(id);
                InstitucijaBasic ib = new InstitucijaBasic(o.Institucija.Id, o.Institucija.Naziv, o.Institucija.Adresa);
                dto = new InstitucijaKontaktMailBasic(o.Id, ib, o.KontaktMail);
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dto;
        }

        public static void obrisiKontaktMail(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                InstitucijaKontaktMail o = s.Load<InstitucijaKontaktMail>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion


        #region InstitucijaKontaktTel

        public static List<InstitucijaKontaktTelPregled> vratiSveKontaktTelefone(int idInstitucije)
        {
            List<InstitucijaKontaktTelPregled> lista = new List<InstitucijaKontaktTelPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<InstitucijaKontaktTel> rezultati =
                    from o in s.Query<InstitucijaKontaktTel>()
                    where o.Institucija.Id == idInstitucije
                    select o;

                foreach (var o in rezultati)
                    lista.Add(new InstitucijaKontaktTelPregled(o.Id, o.KontaktTel));

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return lista;
        }

        public static void dodajKontaktTelefon(InstitucijaKontaktTelBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                InstitucijaKontaktTel o = new InstitucijaKontaktTel();
                o.Institucija = s.Load<Institucija>(dto.Institucija.Id);
                o.KontaktTel = dto.KontaktTel;
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void azurirajKontaktTelefon(InstitucijaKontaktTelBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                InstitucijaKontaktTel o = s.Load<InstitucijaKontaktTel>(dto.Id);
                o.KontaktTel = dto.KontaktTel;
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static InstitucijaKontaktTelBasic vratiKontaktTelefon(int id)
        {
            InstitucijaKontaktTelBasic dto = new InstitucijaKontaktTelBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                InstitucijaKontaktTel o = s.Load<InstitucijaKontaktTel>(id);
                InstitucijaBasic ib = new InstitucijaBasic(o.Institucija.Id, o.Institucija.Naziv, o.Institucija.Adresa);
                dto = new InstitucijaKontaktTelBasic(o.Id, ib, o.KontaktTel);
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dto;
        }

        public static void obrisiKontaktTelefon(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                InstitucijaKontaktTel o = s.Load<InstitucijaKontaktTel>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion


        #region InstitucijaNaucnaOblast

        public static List<InstitucijaNaucnaOblastPregled> vratiSveNaucneOblasti(int idInstitucije)
        {
            List<InstitucijaNaucnaOblastPregled> lista = new List<InstitucijaNaucnaOblastPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<InstitucijaNaucnaOblast> rezultati =
                    from o in s.Query<InstitucijaNaucnaOblast>()
                    where o.Institucija.Id == idInstitucije
                    select o;

                foreach (var o in rezultati)
                    lista.Add(new InstitucijaNaucnaOblastPregled(o.Id, o.NaucnaOblast));

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return lista;
        }

        public static void dodajNaucnuOblast(InstitucijaNaucnaOblastBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                InstitucijaNaucnaOblast o = new InstitucijaNaucnaOblast();
                o.Institucija = s.Load<Institucija>(dto.Institucija.Id);
                o.NaucnaOblast = dto.NaucnaOblast;
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void azurirajNaucnuOblast(InstitucijaNaucnaOblastBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                InstitucijaNaucnaOblast o = s.Load<InstitucijaNaucnaOblast>(dto.Id);
                o.NaucnaOblast = dto.NaucnaOblast;
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static InstitucijaNaucnaOblastBasic vratiNaucnuOblast(int id)
        {
            InstitucijaNaucnaOblastBasic dto = new InstitucijaNaucnaOblastBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                InstitucijaNaucnaOblast o = s.Load<InstitucijaNaucnaOblast>(id);
                InstitucijaBasic ib = new InstitucijaBasic(o.Institucija.Id, o.Institucija.Naziv, o.Institucija.Adresa);
                dto = new InstitucijaNaucnaOblastBasic(o.Id, ib, o.NaucnaOblast);
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dto;
        }

        public static void obrisiNaucnuOblast(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                InstitucijaNaucnaOblast o = s.Load<InstitucijaNaucnaOblast>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion


        #region Istrazivac

        public static List<IstrazivacPregled> vratiSveIstrazivace()
        {
            List<IstrazivacPregled> lista = new List<IstrazivacPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                var rezultati = from o in s.Query<Istrazivac>() select o;

                foreach (var o in rezultati)
                    lista.Add(new IstrazivacPregled(o.Id, o.Ime, o.Prezime,
                        o.DatumRodjenja, o.Drzava, o.StatusNaloga, o.NaucnoZvanje, o.NaucnaOblast));

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return lista;
        }

        public static void dodajIstrazivaca(IstrazivacBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Istrazivac o = new Istrazivac();
                o.Ime = dto.Ime;
                o.Prezime = dto.Prezime;
                o.DatumRodjenja = dto.DatumRodjenja;
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

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void azurirajIstrazivaca(IstrazivacBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Istrazivac o = s.Load<Istrazivac>(dto.Id);
                o.Ime = dto.Ime;
                o.Prezime = dto.Prezime;
                o.DatumRodjenja = dto.DatumRodjenja;
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

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static IstrazivacBasic vratiIstrazivaca(int id)
        {
            IstrazivacBasic dto = new IstrazivacBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Istrazivac o = s.Load<Istrazivac>(id);
                dto = new IstrazivacBasic(o.Id, o.Ime, o.Prezime, o.DatumRodjenja,
                    o.Drzava, o.StatusNaloga, o.NaucnoZvanje, o.NaucnaOblast,
                    o.JeAutor, o.JeRecenzent, o.JeUrednik, o.JeAdmin, o.JeRukovodilacProjekta,
                    o.ORCID, o.OblastEkspertize, o.UredjivackaSekcija, o.AdministratorskaOvlascenja);

                foreach (var e in o.Emailovi)
                    dto.Emailovi.Add(new IstrazivacEmailBasic(e.Id, dto, e.Email));
                foreach (var t in o.Telefoni)
                    dto.Telefoni.Add(new IstrazivacTelefonBasic(t.Id, dto, t.Telefon));

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dto;
        }

        public static void obrisiIstrazivaca(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Istrazivac o = s.Load<Istrazivac>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        public static Istrazivac VratiIstrazivacaPoId(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Istrazivac i = s.Get<Istrazivac>(id);

                if (i == null) throw new Exception("Nije pronadjen istrazivac...");

                return i;
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska u vracanju istraživača...\n{ex.Message}");
            }
        }

        #endregion


        #region IstrazivacEmail

        public static List<IstrazivacEmailPregled> vratiSveEmailoveIstrazivaca(int idIstrazivaca)
        {
            List<IstrazivacEmailPregled> lista = new List<IstrazivacEmailPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<IstrazivacEmail> rezultati =
                    from o in s.Query<IstrazivacEmail>()
                    where o.Istrazivac.Id == idIstrazivaca
                    select o;

                foreach (var o in rezultati)
                    lista.Add(new IstrazivacEmailPregled(o.Id, o.Email));

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return lista;
        }

        public static void dodajEmailIstrazivaca(IstrazivacEmailBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IstrazivacEmail o = new IstrazivacEmail();
                o.Istrazivac = s.Load<Istrazivac>(dto.Istrazivac.Id);
                o.Email = dto.Email;
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void azurirajEmailIstrazivaca(IstrazivacEmailBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IstrazivacEmail o = s.Load<IstrazivacEmail>(dto.Id);
                o.Email = dto.Email;
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static IstrazivacEmailBasic vratiEmailIstrazivaca(int id)
        {
            IstrazivacEmailBasic dto = new IstrazivacEmailBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                IstrazivacEmail o = s.Load<IstrazivacEmail>(id);
                IstrazivacBasic ib = new IstrazivacBasic(o.Istrazivac.Id, o.Istrazivac.Ime,
                    o.Istrazivac.Prezime, o.Istrazivac.DatumRodjenja, o.Istrazivac.Drzava,
                    o.Istrazivac.StatusNaloga, o.Istrazivac.NaucnoZvanje, o.Istrazivac.NaucnaOblast,
                    o.Istrazivac.JeAutor, o.Istrazivac.JeRecenzent, o.Istrazivac.JeUrednik,
                    o.Istrazivac.JeAdmin, o.Istrazivac.JeRukovodilacProjekta,
                    o.Istrazivac.ORCID, o.Istrazivac.OblastEkspertize,
                    o.Istrazivac.UredjivackaSekcija, o.Istrazivac.AdministratorskaOvlascenja);
                dto = new IstrazivacEmailBasic(o.Id, ib, o.Email);
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dto;
        }

        public static void obrisiEmailIstrazivaca(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IstrazivacEmail o = s.Load<IstrazivacEmail>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion


        #region IstrazivacTelefon

        public static List<IstrazivacTelefonPregled> vratiSveTelefoneIstrazivaca(int idIstrazivaca)
        {
            List<IstrazivacTelefonPregled> lista = new List<IstrazivacTelefonPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<IstrazivacTelefon> rezultati =
                    from o in s.Query<IstrazivacTelefon>()
                    where o.Istrazivac.Id == idIstrazivaca
                    select o;

                foreach (var o in rezultati)
                    lista.Add(new IstrazivacTelefonPregled(o.Id, o.Telefon));

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return lista;
        }

        public static void dodajTelefonIstrazivaca(IstrazivacTelefonBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IstrazivacTelefon o = new IstrazivacTelefon();
                o.Istrazivac = s.Load<Istrazivac>(dto.Istrazivac.Id);
                o.Telefon = dto.Telefon;
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void azurirajTelefonIstrazivaca(IstrazivacTelefonBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IstrazivacTelefon o = s.Load<IstrazivacTelefon>(dto.Id);
                o.Telefon = dto.Telefon;
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static IstrazivacTelefonBasic vratiTelefonIstrazivaca(int id)
        {
            IstrazivacTelefonBasic dto = new IstrazivacTelefonBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                IstrazivacTelefon o = s.Load<IstrazivacTelefon>(id);
                IstrazivacBasic ib = new IstrazivacBasic(o.Istrazivac.Id, o.Istrazivac.Ime,
                    o.Istrazivac.Prezime, o.Istrazivac.DatumRodjenja, o.Istrazivac.Drzava,
                    o.Istrazivac.StatusNaloga, o.Istrazivac.NaucnoZvanje, o.Istrazivac.NaucnaOblast,
                    o.Istrazivac.JeAutor, o.Istrazivac.JeRecenzent, o.Istrazivac.JeUrednik,
                    o.Istrazivac.JeAdmin, o.Istrazivac.JeRukovodilacProjekta,
                    o.Istrazivac.ORCID, o.Istrazivac.OblastEkspertize,
                    o.Istrazivac.UredjivackaSekcija, o.Istrazivac.AdministratorskaOvlascenja);
                dto = new IstrazivacTelefonBasic(o.Id, ib, o.Telefon);
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dto;
        }

        public static void obrisiTelefonIstrazivaca(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IstrazivacTelefon o = s.Load<IstrazivacTelefon>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion


        #region Angazovanje

        public static List<AngazovanjePregled> vratiSveAngazovanjaIstrazivaca(int idIstrazivaca)
        {
            List<AngazovanjePregled> lista = new List<AngazovanjePregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Angazovanje> rezultati =
                    from o in s.Query<Angazovanje>()
                    where o.Istrazivac.Id == idIstrazivaca
                    select o;

                foreach (var o in rezultati)
                    lista.Add(new AngazovanjePregled(o.Id, o.Institucija.Id, o.Istrazivac.Id,
                          o.Institucija.Naziv, o.Istrazivac.Ime + " " + o.Istrazivac.Prezime, o.OrganizacionaJedinica, o.TipAngazovanja,
                          o.NazivPozicije, o.DatumPocetka, o.DatumZavrsetka));

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return lista;
        }

        public static List<AngazovanjePregled> vratiSveAngazovanjaInstitucije(int idInstitucije)
        {
            List<AngazovanjePregled> lista = new List<AngazovanjePregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Angazovanje> rezultati =
                    from o in s.Query<Angazovanje>()
                    where o.Institucija.Id == idInstitucije
                    select o;

                foreach (var o in rezultati)
                 lista.Add(new AngazovanjePregled(o.Id, o.Institucija.Id, o.Istrazivac.Id,
                          o.Institucija.Naziv, o.Istrazivac.Ime + " " + o.Istrazivac.Prezime, o.OrganizacionaJedinica, o.TipAngazovanja,
                          o.NazivPozicije, o.DatumPocetka, o.DatumZavrsetka));

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return lista;
        }

        public static void dodajAngazovanje(AngazovanjeBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Angazovanje o = new Angazovanje();
                o.Institucija = s.Get<Institucija>(dto.IdInstitucije);
                o.Istrazivac = s.Get<Istrazivac>(dto.IdIstrazivaca);
                o.OrganizacionaJedinica = dto.OrganizacionaJedinica;
                o.TipAngazovanja = dto.TipAngazovanja;
                o.NazivPozicije = dto.NazivPozicije;
                o.DatumPocetka = dto.DatumPocetka;
                o.DatumZavrsetka = dto.DatumZavrsetka;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void azurirajAngazovanje(AngazovanjeBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Angazovanje o = s.Load<Angazovanje>(dto.Id);
                o.Institucija = s.Load<Institucija>(dto.IdInstitucije);
                o.Istrazivac = s.Load<Istrazivac>(dto.IdIstrazivaca);
                o.OrganizacionaJedinica = dto.OrganizacionaJedinica;
                o.TipAngazovanja = dto.TipAngazovanja;
                o.NazivPozicije = dto.NazivPozicije;
                o.DatumPocetka = dto.DatumPocetka;
                o.DatumZavrsetka = dto.DatumZavrsetka;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static AngazovanjeBasic vratiAngazovanje(int idAngazovanja)
        {
            AngazovanjeBasic dto = new AngazovanjeBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Angazovanje o = s.Load<Angazovanje>(idAngazovanja);
                dto = new AngazovanjeBasic(o.Id, o.Institucija.Id, o.Istrazivac.Id,
                    o.Institucija.Naziv, o.Istrazivac.Ime + " " + o.Istrazivac.Prezime,
                    o.NazivPozicije, o.DatumPocetka,
                    o.OrganizacionaJedinica, o.TipAngazovanja, o.DatumZavrsetka);

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dto;
        }

        public static void obrisiAngazovanje(int idAngazovanja)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Angazovanje o = s.Load<Angazovanje>(idAngazovanja);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion


        #region Autorstvo

        public static List<AutorstvoBasic> vratiSveAutorePublikacije(int idPublikacije)
        {
            List<AutorstvoBasic> lista = new List<AutorstvoBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Autorstvo> rezultati =
                    from o in s.Query<Autorstvo>()
                    where o.Publikacija.Id == idPublikacije
                    select o;

                foreach (var o in rezultati)
                    lista.Add(new AutorstvoBasic(o.Id, o.Publikacija.Id, o.Autor.Id,
                        o.Publikacija.Naslov, o.Autor.Ime + " " + o.Autor.Prezime,
                        o.RedosledAutora, o.TipDoprinosa, o.Uloga));

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return lista;
        }

        public static List<AutorstvoBasic> vratiSvePublikacijeAutora(int idAutora)
        {
            List<AutorstvoBasic> lista = new List<AutorstvoBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Autorstvo> rezultati =
                    from o in s.Query<Autorstvo>()
                    where o.Autor.Id == idAutora
                    select o;

                foreach (var o in rezultati)
                    lista.Add(new AutorstvoBasic(o.Id, o.Publikacija.Id, o.Autor.Id,
                        o.Publikacija.Naslov, o.Autor.Ime + " " + o.Autor.Prezime,
                        o.RedosledAutora, o.TipDoprinosa, o.Uloga));

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return lista;
        }

        public static void dodajAutorstvo(AutorstvoBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Autorstvo o = new Autorstvo();
                o.Publikacija = s.Load<Publikacija>(dto.IdPublikacije);
                o.Autor = s.Load<Istrazivac>(dto.IdAutora);
                o.RedosledAutora = dto.RedosledAutora;
                o.TipDoprinosa = dto.TipDoprinosa;
                o.Uloga = dto.Uloga;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void azurirajAutorstvo(AutorstvoBasic dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Autorstvo o = s.Load<Autorstvo>(dto.Id);
                o.Publikacija = s.Load<Publikacija>(dto.IdPublikacije);
                o.Autor = s.Load<Istrazivac>(dto.IdAutora);
                o.RedosledAutora = dto.RedosledAutora;
                o.TipDoprinosa = dto.TipDoprinosa;
                o.Uloga = dto.Uloga;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static AutorstvoBasic vratiAutorstvo(int idAutorstva)
        {
            AutorstvoBasic dto = new AutorstvoBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Autorstvo o = s.Load<Autorstvo>(idAutorstva);
                dto = new AutorstvoBasic(o.Id, o.Publikacija.Id, o.Autor.Id,
                    o.Publikacija.Naslov, o.Autor.Ime + " " + o.Autor.Prezime,
                    o.RedosledAutora, o.TipDoprinosa, o.Uloga);

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dto;
        }

        public static void obrisiAutorstvo(int idAutorstva)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Autorstvo o = s.Load<Autorstvo>(idAutorstva);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion
        
        
        
        #region NaucniRad

        public static List<NaucniRad> VratiNaucneRadove()
        {
            List<NaucniRad> listaNaucnihRadova = new List<NaucniRad>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var naucniRadovi = sesija.Query<NaucniRad>().ToList();
                foreach (var naucniRad in naucniRadovi)
                {
                    listaNaucnihRadova.Add(naucniRad);
                }

                sesija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Poruka greske: {ex.Message}", "Greska sa preuzimanjem naucnih radova iz baze...", MessageBoxButtons.OK,  MessageBoxIcon.Error);
            }
            return listaNaucnihRadova;
        }
        
        public static List<NaucniRadPregled> VratiNaucneRadoveZaPrikaz()
        {
            List<NaucniRadPregled> listaNaucnihRadova = new List<NaucniRadPregled>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var naucniRadovi = sesija.Query<NaucniRad>().ToList();
                foreach (var naucniRad in naucniRadovi)
                {
                    NaucniRadPregled obj = new NaucniRadPregled
                    {
                        Id = naucniRad.Id,
                        Naslov = naucniRad.Naslov,
                        DOI = naucniRad.DOI,
                        Stranice = naucniRad.Stranice,
                        TipRada = naucniRad.TipRada,
                        Izvor = naucniRad.Izvor?.Id ?? 0
                    };
                    listaNaucnihRadova.Add(obj);
                }

                sesija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Poruka greske: {ex.Message}", "Greska sa preuzimanjem naucnih radova iz baze...", MessageBoxButtons.OK,  MessageBoxIcon.Error);
            }
            return listaNaucnihRadova;
        }

        public static NaucniRad VratiNaucniRadPoId(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                NaucniRad nr = s.Get<NaucniRad>(id);

                if (nr == null) throw new Exception("Nije pronadjen naucni rad...");

                return nr;
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska u vracanju naucnog rada...\n{ex.Message}");
            }
        }

        public static void IzmeniNaucniRad(NaucniRadBasic nr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                NaucniRad nrnovi = s.Get<NaucniRad>(nr.Id);

                nrnovi.DOI = nr.DOI;
                nrnovi.Stranice = nr.Stranice;
                nrnovi.TipRada = nr.TipRada;
                nrnovi.Apstrakt = nr.Apstrakt;
                nrnovi.DatumKreiranjaZapisa = nr.DatumKreiranjaZapisa;
                nrnovi.DatumObjavljivanja = nr.DatumObjavljivanja;
                nrnovi.Jezik = nr.Jezik;
                nrnovi.Vidljivost = nr.Vidljivost;
                nrnovi.Naslov = nr.Naslov;
                nrnovi.Status = nr.Status;
                nrnovi.Izvor = s.Load<Izvor>(nr.IdIzvora);

                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                throw new Exception($"Greska pri izmeni naucnog rada...\n{ex.Message}");
            }
        }
        public static Izvor VratiIzvorPoId(int? IdNaucnogRada)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (IdNaucnogRada == null) throw new Exception("IdNaucnogRada nije pronadjen => null je");
                var izvor = s.Query<NaucniRad>().Where(nr => nr.Id == IdNaucnogRada).Select(nr => nr.Izvor).FirstOrDefault();

                return izvor;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static bool ObrisiNaucniRad(int? radId)
        {
            bool status = false;
            if (radId == null)
            {
                return status; 
            }
            try
            {
                ISession s = DataLayer.GetSession();
                var naucniRad = s.Load<NaucniRad>(radId);
                s.Delete(naucniRad);
                s.Flush();
                s.Close();

                status = true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Poruka exceptiona: {ex.Message}");
            }

            return status;
        }

        public static bool DodajNaucniRad(NaucniRad nr)
        {
            bool status = false;
            try
            {
                ISession s = DataLayer.GetSession();

                NaucniRad novi = new NaucniRad
                {
                    IdIzvora = nr.IdIzvora,
                    Izvor = s.Load<Izvor>(nr.IdIzvora),
                    Stranice = nr.Stranice,
                    TipRada = nr.TipRada,
                    DOI = nr.DOI,
                    Apstrakt = nr.Apstrakt,
                    Vidljivost = nr.Vidljivost,
                    DatumKreiranjaZapisa = nr.DatumKreiranjaZapisa,
                    DatumObjavljivanja = nr.DatumObjavljivanja,
                    Jezik = nr.Jezik,
                    Naslov = nr.Naslov,
                    Status = nr.Status ?? Konstante.StatusiPublikacije[0]
                };

                s.SaveOrUpdate(novi);
                s.Flush();
                s.Close();

                status = true;
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException;
                var innerInfo = inner != null
                    ? $"INNER: {inner.GetType().FullName}\n{inner.Message}\n{inner.StackTrace}"
                    : "(nema inner exception)";
                throw new Exception(
                    $"Greska pri dodavanju naucnog rada...\n" +
                    $"EX: {ex.GetType().FullName}\n{ex.Message}\n" +
                    innerInfo,
                    ex);  // <-- prosleđuj originalni exception kao inner
            }

            return status;
        }
        
        #endregion
        
        #region Dataset

        public static List<Dataset> VratiDatasetove()
        {
            List<Dataset> listaDatasetova = new List<Dataset>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var datasetovi = sesija.Query<Dataset>().ToList();
                foreach (var dataset in datasetovi)
                {
                    listaDatasetova.Add(dataset);
                }

                sesija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Poruka greske: {ex.Message}", "Greska sa preuzimanjem dataseta iz baze...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaDatasetova;
        }

        public static List<DatasetPregled> VratiDataseteZaPrikaz()
        {
            List<DatasetPregled> listaDatasetova = new List<DatasetPregled>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var datasetovi = sesija.Query<Dataset>().ToList();
                foreach (var dataset in datasetovi)
                {
                    DatasetPregled obj = new DatasetPregled
                    {
                        Id = dataset.Id,
                        Naslov = dataset.Naslov,
                        Format = dataset.Format,
                        BrojZapisa = dataset.BrojZapisa,
                        Velicina = dataset.Velicina
                    };
                    listaDatasetova.Add(obj);
                }

                sesija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Poruka greske: {ex.Message}", "Greska sa preuzimanjem dataseta iz baze...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaDatasetova;
        }

        public static Dataset VratiDatasetPoId(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Dataset ds = s.Get<Dataset>(id);

                if (ds == null) throw new Exception("Nije pronadjen dataset...");

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska u vracanju dataseta...\n{ex.Message}");
            }
        }

        public static bool DodajDataset(Dataset dataset)
        {
            bool status = false;
            try
            {
                ISession s = DataLayer.GetSession();

                Dataset novi = new Dataset
                {
                    Naslov = dataset.Naslov,
                    Apstrakt = dataset.Apstrakt,
                    Jezik = dataset.Jezik,
                    DatumKreiranjaZapisa = dataset.DatumKreiranjaZapisa,
                    DatumObjavljivanja = dataset.DatumObjavljivanja,
                    Status = dataset.Status,
                    Vidljivost = dataset.Vidljivost,
                    BrojZapisa = dataset.BrojZapisa,
                    Velicina = dataset.Velicina,
                    Format = dataset.Format,
                    LicencaKoriscenja = dataset.LicencaKoriscenja
                };

                s.SaveOrUpdate(novi);
                s.Flush();
                s.Close();

                status = true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska pri dodavanju dataseta...\n{ex.Message}");
            }

            return status;
        }

        public static void IzmeniDataset(DatasetBasic dataset)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Dataset dsnovi = s.Get<Dataset>(dataset.Id);

                dsnovi.Naslov = dataset.Naslov;
                dsnovi.Apstrakt = dataset.Apstrakt;
                dsnovi.Jezik = dataset.Jezik;
                dsnovi.DatumKreiranjaZapisa = dataset.DatumKreiranjaZapisa;
                dsnovi.DatumObjavljivanja = dataset.DatumObjavljivanja;
                dsnovi.Status = dataset.Status;
                dsnovi.Vidljivost = dataset.Vidljivost;
                dsnovi.BrojZapisa = dataset.BrojZapisa;
                dsnovi.Velicina = dataset.Velicina;
                dsnovi.Format = dataset.Format;
                dsnovi.LicencaKoriscenja = dataset.LicencaKoriscenja;

                s.SaveOrUpdate(dsnovi);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska pri izmeni dataseta...\n{ex.Message}");
            }
        }

        public static bool ObrisiDataset(int? datasetId)
        {
            bool status = false;
            if (datasetId == null)
            {
                return status;
            }
           
            try
            {
                ISession s = DataLayer.GetSession();

                s.Delete(s.Load<Dataset>(datasetId));
                s.Flush();
                s.Close();

                status = true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Poruka exceptiona: {ex.Message}");
            }

            return status;
        }

        #endregion

        
        #region SoftverskiArtefakt

        public static List<SoftverskiArtefakt> VratiSoftverskiArtefakte()
        {
            List<SoftverskiArtefakt> listaArtefakata = new List<SoftverskiArtefakt>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var artefakti = sesija.Query<SoftverskiArtefakt>().ToList();
                foreach (var artefakt in artefakti)
                {
                    listaArtefakata.Add(artefakt);
                }

                sesija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Poruka greske: {ex.Message}", "Greska sa preuzimanjem softverskih artefakata iz baze...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaArtefakata;
        }

        public static List<SoftverskiArtefaktPregled> VratiSoftverskiArtefakteZaPrikaz()
        {
            List<SoftverskiArtefaktPregled> listaArtefakata = new List<SoftverskiArtefaktPregled>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var artefakti = sesija.Query<SoftverskiArtefakt>().ToList();
                foreach (var artefakt in artefakti)
                {
                    SoftverskiArtefaktPregled obj = new SoftverskiArtefaktPregled
                    {
                        Id = artefakt.Id,
                        Naslov = artefakt.Naslov,
                        ProgramskiJezik = artefakt.ProgramskiJezik,
                        LinkKaRepozitorijumu = artefakt.LinkKaRepozitorijumu
                    };
                    listaArtefakata.Add(obj);
                }

                sesija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Poruka greske: {ex.Message}", "Greska sa preuzimanjem softverskih artefakata iz baze...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaArtefakata;
        }

        public static SoftverskiArtefakt VratiSoftverskiArtefaktPoId(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SoftverskiArtefakt sa = s.Get<SoftverskiArtefakt>(id);

                if (sa == null) throw new Exception("Nije pronadjen softverski artefakt...");

                return sa;
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska u vracanju softverskog artefakta...\n{ex.Message}");
            }
        }

        public static bool DodajSoftverskiArtefakt(SoftverskiArtefakt artefakt)
        {
            bool status = false;
            try
            {
                ISession s = DataLayer.GetSession();

                SoftverskiArtefakt novi = new SoftverskiArtefakt
                {
                    Naslov = artefakt.Naslov,
                    Apstrakt = artefakt.Apstrakt,
                    Jezik = artefakt.Jezik,
                    DatumKreiranjaZapisa = artefakt.DatumKreiranjaZapisa,
                    DatumObjavljivanja = artefakt.DatumObjavljivanja,
                    Status = artefakt.Status,
                    Vidljivost = artefakt.Vidljivost,
                    ProgramskiJezik = artefakt.ProgramskiJezik,
                    LinkKaRepozitorijumu = artefakt.LinkKaRepozitorijumu,
                    NacinLicenciranja = artefakt.NacinLicenciranja
                };

                s.SaveOrUpdate(novi);
                s.Flush();
                s.Close();

                status = true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska pri dodavanju softverskog artefakta...\n{ex.Message}");
            }

            return status;
        }

        public static void IzmeniSoftverskiArtefakt(SoftverskiArtefaktBasic artefakt)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SoftverskiArtefakt sanova = s.Get<SoftverskiArtefakt>(artefakt.Id);

                sanova.Naslov = artefakt.Naslov;
                sanova.Apstrakt = artefakt.Apstrakt;
                sanova.Jezik = artefakt.Jezik;
                sanova.DatumKreiranjaZapisa = artefakt.DatumKreiranjaZapisa;
                sanova.DatumObjavljivanja = artefakt.DatumObjavljivanja;
                sanova.Status = artefakt.Status;
                sanova.Vidljivost = artefakt.Vidljivost;
                sanova.ProgramskiJezik = artefakt.ProgramskiJezik;
                sanova.LinkKaRepozitorijumu = artefakt.LinkKaRepozitorijumu;
                sanova.NacinLicenciranja = artefakt.NacinLicenciranja;

                s.SaveOrUpdate(sanova);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska pri izmeni softverskog artefakta...\n{ex.Message}");
            }
        }

        public static bool ObrisiSoftverskiArtefakt(int? artefaktId)
        {
            bool status = false;
            if (artefaktId == null)
            {
                return status;
            }
            try
            {
                ISession s = DataLayer.GetSession();
               
                s.Delete(s.Load<SoftverskiArtefakt>(artefaktId));
                s.Flush();
                s.Close();

                status = true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Poruka exceptiona: {ex.Message}");
            }

            return status;
        }
        public static void DodajPodrzanuPlatformu(int idPublikacije, string nazivPlatforme)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                SoftverskiArtefaktPodrzanePlatforme sapp = new SoftverskiArtefaktPodrzanePlatforme
                {
                    PodrzanaPlatforma = nazivPlatforme,
                    SoftverskiArtefakt = session.Get<SoftverskiArtefakt>(idPublikacije)
                };

                session.SaveOrUpdate(sapp);
                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Dogodila se greska pri dodavanju nove platforme softverskog artefakta..." + ex.Message + "\n" + ex.InnerException);
            }
        }
        public static void IzmeniPodrzanuPlatformu(int idPlatforme, string nazivPlatforme)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                SoftverskiArtefaktPodrzanePlatforme sapp = session.Get<SoftverskiArtefaktPodrzanePlatforme>(idPlatforme);
                sapp.PodrzanaPlatforma = nazivPlatforme;

                session.SaveOrUpdate(sapp);
                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Dogodila se greska pri izmeni platforme softverskog artefakta..." + ex.Message + "\n" + ex.InnerException);
            }
        }
        public static void ObrisiPodrzanuPlatformu(int idPlatforme)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                SoftverskiArtefaktPodrzanePlatforme sapp = session.Get<SoftverskiArtefaktPodrzanePlatforme>(idPlatforme);
                session.Delete(sapp);
                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Dogodila se greska pri brisanju platforme softverskog artefakta..." + ex.Message + "\n" + ex.InnerException);
            }
        }
        public static string GetPodrzanaPlatforma(int idPlatforme)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                SoftverskiArtefaktPodrzanePlatforme sapp = session.Get<SoftverskiArtefaktPodrzanePlatforme>(idPlatforme);
                return sapp.PodrzanaPlatforma;
            }
            catch (Exception ex)
            {
                throw new Exception("Dogodila se greska pri preuzimanju naziva platforme..." + ex.Message + "\n" + ex.InnerException);
            }
        }
        #endregion


        #region RundeRecenzije

        public static List<RundaRecenzije> VratiRundeRecenzije()
        {
            List<RundaRecenzije> listaRundi = new List<RundaRecenzije>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var runde = sesija.Query<RundaRecenzije>().ToList();
                foreach (var runda in runde)
                {
                    listaRundi.Add(runda);
                }

                sesija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Poruka greske: {ex.Message}", "Greska sa preuzimanjem rundi recenzije iz baze...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaRundi;
        }

        public static List<RundaRecenzijePregled> VratiRundeRecenzijeZaPrikaz(int idPublikacije)
        {
            List<RundaRecenzijePregled> listaRundi = new List<RundaRecenzijePregled>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var runde = sesija.Query<RundaRecenzije>()
                    .Where(r => r.Publikacija.Id == idPublikacije)
                    .ToList();
                foreach (var runda in runde)
                {
                    RundaRecenzijePregled obj = new RundaRecenzijePregled
                    {
                        Id = runda.Id,
                        BrojRunde = runda.BrojRunde,
                        IdPublikacije = runda.Publikacija?.Id ?? runda.IdPublikacije,
                        IdUrednika = runda.Urednik?.Id ?? runda.IdUrednika,
                        Datum = runda.Datum,
                        KonacnaOdluka = runda.KonacnaOdluka ?? ""
                    };
                    listaRundi.Add(obj);
                }

                sesija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Poruka greske: {ex.Message}", "Greska sa preuzimanjem rundi recenzije iz baze...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaRundi;
        }

        public static RundaRecenzije VratiRunduRecenzijePoId(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                RundaRecenzije rr = s.Get<RundaRecenzije>(id);

                if (rr == null) throw new Exception("Nije pronadjena runda recenzije...");

                return rr;
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska u vracanju runde recenzije...\n{ex.Message}");
            }
        }

        public static bool DodajRunduRecenzije(RundaRecenzije runda)
        {
            bool status = false;
            try
            {
                ISession s = DataLayer.GetSession();

                RundaRecenzije nova = new RundaRecenzije
                {
                    BrojRunde = runda.BrojRunde,
                    IdPublikacije = runda.IdPublikacije,
                    IdUrednika = runda.IdUrednika,
                    Datum = runda.Datum,
                    KonacnaOdluka = runda.KonacnaOdluka
                };

                if (runda.IdPublikacije != 0)
                    nova.Publikacija = s.Load<Publikacija>(runda.IdPublikacije);

                if (runda.IdUrednika != 0)
                    nova.Urednik = s.Load<Istrazivac>(runda.IdUrednika);


                s.SaveOrUpdate(nova);
                s.Flush();
                s.Close();

                status = true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska pri dodavanju runde recenzije...\n{ex.Message}");
            }

            return status;
        }

        public static void IzmeniRunduRecenzije(RundaRecenzijeBasic runda)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                RundaRecenzije rrova = s.Get<RundaRecenzije>(runda.Id);

                rrova.BrojRunde = runda.BrojRunde;
                rrova.IdPublikacije = runda.IdPublikacije;
                rrova.IdUrednika = runda.IdUrednika;
                rrova.Datum = runda.Datum;
                rrova.KonacnaOdluka = runda.KonacnaOdluka;

                s.SaveOrUpdate(rrova);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska pri izmeni runde recenzije...\n{ex.Message}");
            }
        }

        public static bool ObrisiRunduRecenzije(int? rundaId)
        {
            bool status = false;
            if (rundaId == null)
            {
                return status;
            }
            try
            {
                ISession s = DataLayer.GetSession();
                using var tx = s.BeginTransaction();

                var runda = s.Get<RundaRecenzije>(rundaId);
                if (runda != null)
                {
                    // assuming runda.VrsteRecenziju is the collection of child entities
                    foreach (var child in runda.Recenzije.ToList())
                        s.Delete(child);

                    s.Delete(runda);
                }

                tx.Commit();

                status = true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Poruka exceptiona: {ex.Message}", ex);
            }

            return status;
        }

        public static List<IstrazivacPregled> VratiIstrazivacaRundeRecenzije(int idRunde)
        {
            List<IstrazivacPregled> listaIstrazivaca = new List<IstrazivacPregled>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var recenzenti = sesija.Query<RundaRecenzije>().Where(rr => rr.Id == idRunde).ToList();
                foreach (var recenzent in recenzenti)
                {
                    IstrazivacPregled ip = new IstrazivacPregled
                    {
                        Id = recenzent.IdUrednika,
                        Ime = recenzent.Urednik!.Ime,
                        Prezime = recenzent.Urednik.Prezime,
                        DatumRodjenja = recenzent.Urednik.DatumRodjenja,
                        Drzava = recenzent.Urednik.Drzava,
                        NaucnaOblast = recenzent.Urednik.NaucnaOblast,
                        NaucnoZvanje = recenzent.Urednik.NaucnoZvanje,
                        StatusNaloga = recenzent.Urednik.StatusNaloga
                    };
                    listaIstrazivaca.Add(ip);
                }
                sesija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Poruka greske: {ex.Message}", "Greska sa preuzimanjem istrazivaca runde recenzije iz baze...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaIstrazivaca;
        }

        #endregion


        #region Citati

        public static List<CitatBasic> VratiCitatePoPublikaciji(int idPublikacije)
        {
            List<CitatBasic> listaCitata = new List<CitatBasic>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var citati = sesija.Query<Citira>().Where(c => c.PubCitira.Id == idPublikacije).ToList();
                foreach (var citat in citati)
                {
                    CitatBasic cb = new CitatBasic
                    {
                        Id = citat.Id,
                        PubCitira = new PublikacijaBasic(citat.PubCitira.Id, citat.PubCitira.Naslov, citat.PubCitira.Apstrakt, citat.PubCitira.Jezik, citat.PubCitira.Status, citat.PubCitira.Vidljivost, citat.PubCitira.DatumObjavljivanja, citat.PubCitira.DatumKreiranjaZapisa),
                        PubCitirana = new PublikacijaBasic(citat.PubCitirana.Id, citat.PubCitirana.Naslov, citat.PubCitirana.Apstrakt, citat.PubCitirana.Jezik, citat.PubCitirana.Status, citat.PubCitirana.Vidljivost, citat.PubCitirana.DatumObjavljivanja, citat.PubCitirana.DatumKreiranjaZapisa),
                        MestoCitiranja = citat.MestoCitiranja,
                        TekstualniKontekst = citat.TekstualniKontekst,
                        TipCitata = citat.TipCitata
                    };
                    listaCitata.Add(cb);
                }

                sesija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Poruka greske: {ex.Message}", "Greska sa preuzimanjem citata iz baze...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaCitata;
        }

        public static CitatBasic VratiCitatPoId(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Citira c = s.Get<Citira>(id);

                if (c == null) throw new Exception("Nije pronadjen citat...");

                CitatBasic cb = new CitatBasic
                {
                    Id = c.Id,
                    PubCitira = new PublikacijaBasic(c.PubCitira.Id, c.PubCitira.Naslov, c.PubCitira.Apstrakt, c.PubCitira.Jezik, c.PubCitira.Status, c.PubCitira.Vidljivost, c.PubCitira.DatumObjavljivanja, c.PubCitira.DatumKreiranjaZapisa),
                    PubCitirana = new PublikacijaBasic(c.PubCitirana.Id, c.PubCitirana.Naslov, c.PubCitirana.Apstrakt, c.PubCitirana.Jezik, c.PubCitirana.Status, c.PubCitirana.Vidljivost, c.PubCitirana.DatumObjavljivanja, c.PubCitirana.DatumKreiranjaZapisa),
                    MestoCitiranja = c.MestoCitiranja,
                    TekstualniKontekst = c.TekstualniKontekst,
                    TipCitata = c.TipCitata
                };

                return cb;
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska u vracanju citata...\n{ex.Message}");
            }
        }

        public static bool DodajCitat(CitatBasic citat)
        {
            bool status = false;
            try
            {
                ISession s = DataLayer.GetSession();

                Citira novi = new Citira
                {
                    PubCitira = s.Load<Publikacija>(citat.PubCitira.Id),
                    PubCitirana = s.Load<Publikacija>(citat.PubCitirana.Id),
                    TipCitata = citat.TipCitata,
                    MestoCitiranja = citat.MestoCitiranja,
                    TekstualniKontekst = citat.TekstualniKontekst
                };

                s.SaveOrUpdate(novi);
                s.Flush();
                s.Close();

                status = true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska pri dodavanju citata...\n{ex.Message}");
            }

            return status;
        }

        public static void IzmeniCitat(CitatBasic citat)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Citira cnova = s.Get<Citira>(citat.Id);

                if(cnova == null) throw new Exception("Nije pronadjen citat za izmenu...");

                cnova.TekstualniKontekst = citat.TekstualniKontekst;
                cnova.MestoCitiranja = citat.MestoCitiranja;
                cnova.TipCitata = citat.TipCitata;

                s.SaveOrUpdate(cnova);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska pri izmeni citata...\n{ex.Message}");
            }
        }

        public static bool ObrisiCitat(int? citatId)
        {
            bool status = false;
            if (citatId == null)
            {
                return status;
            }
            try
            {
                ISession s = DataLayer.GetSession();
                
                s.Delete(s.Load<Citira>(citatId));
                s.Flush();
                s.Close();

                status = true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Poruka exceptiona: {ex.Message}");
            }

            return status;
        }

        #endregion

        #region KnjigaUrednici

        public static List<KnjigaUrednici> VratiUrednikeKnjige(int idKnjige)
        {
            List<KnjigaUrednici> listaUrednika = new List<KnjigaUrednici>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var urednici = sesija.Query<KnjigaUrednici>().Where(ku => ku.Knjiga.Id == idKnjige).ToList();
                foreach (var urednik in urednici)
                {
                    listaUrednika.Add(urednik);
                }

                sesija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Poruka greske: {ex.Message}", "Greska sa preuzimanjem urednika knjige iz baze...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaUrednika;
        }

        public static KnjigaUrednici VratiUredikaKnijePoId(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KnjigaUrednici ku = s.Get<KnjigaUrednici>(id);

                if (ku == null) throw new Exception("Nije pronadjen urednik knjige...");

                return ku;
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska u vracanju urednika knjige...\n{ex.Message}");
            }
        }

        public static bool DodajUredikaKnjige(KnjigaUrednici urednik)
        {
            bool status = false;
            try
            {
                ISession s = DataLayer.GetSession();

                KnjigaUrednici novi = new KnjigaUrednici
                {
                    Knjiga = urednik.Knjiga,
                    Urednik = urednik.Urednik
                };

                s.SaveOrUpdate(novi);
                s.Flush();
                s.Close();

                status = true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska pri dodavanju urednika knjige...\n{ex.Message}");
            }

            return status;
        }

        public static void IzmeniUredikaKnjige(KnjigaUredniciBasic urednik)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KnjigaUrednici kunova = s.Get<KnjigaUrednici>(urednik.Id);

                kunova.Urednik = urednik.Urednik;

                s.SaveOrUpdate(kunova);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska pri izmeni urednika knjige...\n{ex.Message}");
            }
        }

        public static bool ObrisiUredikaKnjige(int? uredikaId)
        {
            bool status = false;
            if (uredikaId == null)
            {
                return status;
            }
            try
            {
                ISession s = DataLayer.GetSession();
                using var tx = s.BeginTransaction();

                var q = s.CreateQuery("delete from KnjigaUrednici where Id = :id");
                q.SetParameter("id", uredikaId);

                q.ExecuteUpdate();
                tx.Commit();

                status = true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Poruka exceptiona: {ex.Message}");
            }

            return status;
        }

        #endregion

        #region PoglavljeUrednici

        public static List<PoglavljeUrednici> VratiUrednikePoglavlja(int idPoglavlja)
        {
            List<PoglavljeUrednici> listaUrednika = new List<PoglavljeUrednici>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var urednici = sesija.Query<PoglavljeUrednici>().Where(pu => pu.PoglavljeUKnjizi.Id == idPoglavlja).ToList();
                foreach (var urednik in urednici)
                {
                    listaUrednika.Add(urednik);
                }

                sesija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Poruka greske: {ex.Message}", "Greska sa preuzimanjem urednika poglavlja iz baze...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaUrednika;
        }

        public static PoglavljeUrednici VratiUrednikaPoglavljaPoId(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PoglavljeUrednici pu = s.Get<PoglavljeUrednici>(id);

                if (pu == null) throw new Exception("Nije pronadjen urednik poglavlja...");

                return pu;
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska u vracanju urednika poglavlja...\n{ex.Message}");
            }
        }

        public static bool DodajUrednikaPoglavlja(PoglavljeUrednici urednik)
        {
            bool status = false;
            try
            {
                ISession s = DataLayer.GetSession();

                PoglavljeUrednici novi = new PoglavljeUrednici
                {
                    PoglavljeUKnjizi = urednik.PoglavljeUKnjizi,
                    Urednik = urednik.Urednik
                };

                s.SaveOrUpdate(novi);
                s.Flush();
                s.Close();

                status = true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska pri dodavanju urednika poglavlja...\n{ex.Message}");
            }

            return status;
        }

        public static void IzmeniUrednikaPoglavlja(PoglavljeUredniciBasic urednik)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PoglavljeUrednici punova = s.Get<PoglavljeUrednici>(urednik.Id);

                punova.Urednik = urednik.Urednik;

                s.SaveOrUpdate(punova);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Greska pri izmeni urednika poglavlja...\n{ex.Message}");
            }
        }

        public static bool ObrisiUrednikaPoglavlja(int? uredikaId)
        {
            bool status = false;
            if (uredikaId == null)
            {
                return status;
            }
            try
            {
                ISession s = DataLayer.GetSession();
                using var tx = s.BeginTransaction();

                var q = s.CreateQuery("delete from PoglavljeUrednici where Id = :id");
                q.SetParameter("id", uredikaId);

                q.ExecuteUpdate();
                tx.Commit();

                status = true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Poruka exceptiona: {ex.Message}");
            }

            return status;
        }

        

        #endregion



    }
}
