using DigitalniRepozitorijum.Mapiranja;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalniRepozitorijum
{
    class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock = new object();

        public static ISession GetSession()
        {
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                    {
                        _factory = CreateSessionFactory();
                    }
                }
            }

            return _factory.OpenSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                    .ShowSql()
                    .ConnectionString(c =>
                        c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=;Password=")); // UNETI SVOJU SIFRU ZA RAD SA BAZOM

                return Fluently.Configure()
                    .Database(cfg)
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<PublikacijaMap>())
                    .BuildSessionFactory();
            }
            catch (Exception ex)
            {
                Exception e = ex;
                while (e != null)
                {
                    MessageBox.Show(ex.InnerException?.ToString());
                    e = e.InnerException;
                }
                throw;
            }
        }
    }
}
