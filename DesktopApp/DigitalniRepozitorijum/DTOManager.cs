using DigitalniRepozitorijum.Entiteti;
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
        public static PublikacijaBasic vratiPublikaciju(int id)
        {
            PublikacijaBasic pb = new PublikacijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Publikacija o = s.Load<Publikacija>(id);
                pb = new PublikacijaBasic(o.Id, o.Naslov, o.Apstrakt, o.Jezik, o.Status, o.Vidljivost, o.DatumObjavljivanja, o.DatumKreiranjaZapisa);

                foreach (Verzija v in o.Verzije)
                {
                    pb.Verzije.Add(
                        new VerzijaBasic(
                            v.Id,
                            v.BrojVerzije,
                            pb, // ili pb ako želiš referencu nazad
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


    }
}