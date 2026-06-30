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

                VerzijaBasic vb = new VerzijaBasic(f.Verzija.Id, f.Verzija.BrojVerzije, vratiPublikaciju(f.Verzija.Publikacija.Id), f.Verzija.DatumPostavljanja, f.Verzija.OpisIzmene, f.Verzija.OdgovornaOsoba);
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
                    where o.Id.Istrazivac.Id == idIstrazivaca
                    select o;

                foreach (var o in rezultati)
                    lista.Add(new AngazovanjePregled(o.Id.Institucija.Id, o.Id.Istrazivac.Id,
                        o.Id.Institucija.Naziv, o.Id.Istrazivac.Ime + " " + o.Id.Istrazivac.Prezime,
                        o.NazivPozicije, o.DatumPocetka));

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
                    where o.Id.Institucija.Id == idInstitucije
                    select o;

                foreach (var o in rezultati)
                    lista.Add(new AngazovanjePregled(o.Id.Institucija.Id, o.Id.Istrazivac.Id,
                        o.Id.Institucija.Naziv, o.Id.Istrazivac.Ime + " " + o.Id.Istrazivac.Prezime,
                        o.NazivPozicije, o.DatumPocetka));

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
                o.Id.Institucija = s.Load<Institucija>(dto.IdInstitucije);
                o.Id.Istrazivac = s.Load<Istrazivac>(dto.IdIstrazivaca);
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

                AngazovanjeId key = new AngazovanjeId();
                key.Institucija = s.Load<Institucija>(dto.IdInstitucije);
                key.Istrazivac = s.Load<Istrazivac>(dto.IdIstrazivaca);

                Angazovanje o = s.Load<Angazovanje>(key);
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

        public static AngazovanjeBasic vratiAngazovanje(int idInstitucije, int idIstrazivaca)
        {
            AngazovanjeBasic dto = new AngazovanjeBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                AngazovanjeId key = new AngazovanjeId();
                key.Institucija = s.Load<Institucija>(idInstitucije);
                key.Istrazivac = s.Load<Istrazivac>(idIstrazivaca);

                Angazovanje o = s.Load<Angazovanje>(key);
                dto = new AngazovanjeBasic(o.Id.Institucija.Id, o.Id.Istrazivac.Id,
                    o.Id.Institucija.Naziv, o.Id.Istrazivac.Ime + " " + o.Id.Istrazivac.Prezime,
                    o.NazivPozicije, o.DatumPocetka,
                    o.OrganizacionaJedinica, o.TipAngazovanja, o.DatumZavrsetka);

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dto;
        }

        public static void obrisiAngazovanje(int idInstitucije, int idIstrazivaca)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AngazovanjeId key = new AngazovanjeId();
                key.Institucija = s.Load<Institucija>(idInstitucije);
                key.Istrazivac = s.Load<Istrazivac>(idIstrazivaca);

                Angazovanje o = s.Load<Angazovanje>(key);
                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion


        #region Autorstvo

        public static List<AutorstvoPregled> vratiSveAutorePublikacije(int idPublikacije)
        {
            List<AutorstvoPregled> lista = new List<AutorstvoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Autorstvo> rezultati =
                    from o in s.Query<Autorstvo>()
                    where o.Id.Publikacija.Id == idPublikacije
                    select o;

                foreach (var o in rezultati)
                    lista.Add(new AutorstvoPregled(o.Id.Publikacija.Id, o.Id.Autor.Id,
                        o.Id.Publikacija.Naslov, o.Id.Autor.Ime + " " + o.Id.Autor.Prezime,
                        o.RedosledAutora));

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return lista;
        }

        public static List<AutorstvoPregled> vratiSvePublikacijeAutora(int idAutora)
        {
            List<AutorstvoPregled> lista = new List<AutorstvoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Autorstvo> rezultati =
                    from o in s.Query<Autorstvo>()
                    where o.Id.Autor.Id == idAutora
                    select o;

                foreach (var o in rezultati)
                    lista.Add(new AutorstvoPregled(o.Id.Publikacija.Id, o.Id.Autor.Id,
                        o.Id.Publikacija.Naslov, o.Id.Autor.Ime + " " + o.Id.Autor.Prezime,
                        o.RedosledAutora));

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
                o.Id.Publikacija = s.Load<Publikacija>(dto.IdPublikacije);
                o.Id.Autor = s.Load<Istrazivac>(dto.IdAutora);
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

                AutorstvoId key = new AutorstvoId();
                key.Publikacija = s.Load<Publikacija>(dto.IdPublikacije);
                key.Autor = s.Load<Istrazivac>(dto.IdAutora);

                Autorstvo o = s.Load<Autorstvo>(key);
                o.RedosledAutora = dto.RedosledAutora;
                o.TipDoprinosa = dto.TipDoprinosa;
                o.Uloga = dto.Uloga;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static AutorstvoBasic vratiAutorstvo(int idPublikacije, int idAutora)
        {
            AutorstvoBasic dto = new AutorstvoBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                AutorstvoId key = new AutorstvoId();
                key.Publikacija = s.Load<Publikacija>(idPublikacije);
                key.Autor = s.Load<Istrazivac>(idAutora);

                Autorstvo o = s.Load<Autorstvo>(key);
                dto = new AutorstvoBasic(o.Id.Publikacija.Id, o.Id.Autor.Id,
                    o.Id.Publikacija.Naslov, o.Id.Autor.Ime + " " + o.Id.Autor.Prezime,
                    o.RedosledAutora, o.TipDoprinosa, o.Uloga);

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dto;
        }

        public static void obrisiAutorstvo(int idPublikacije, int idAutora)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AutorstvoId key = new AutorstvoId();
                key.Publikacija = s.Load<Publikacija>(idPublikacije);
                key.Autor = s.Load<Istrazivac>(idAutora);

                Autorstvo o = s.Load<Autorstvo>(key);
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
                var naucniRadovi = from n in sesija.Query<NaucniRad>() select n;
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

        // public static Izvor VratiIzvorPoId(int idIzvora)
        // {
        //     
        // }
        //
        #endregion
        
        #region Dataset
        
        #endregion
        
        #region SoftverskiArtefakt
        
        #endregion
        
        #region Recenzije
        
        #endregion
        
        #region Citati
        
        #endregion

    }
}