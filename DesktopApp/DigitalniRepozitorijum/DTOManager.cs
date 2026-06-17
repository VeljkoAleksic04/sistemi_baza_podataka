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


    }
}
