using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using MySql.Data.MySqlClient;

namespace cpnp_selenium.Models
{
    public class NHibernateHelper
    {
        public static ISession OpenSession()
        {
            string conn_str = "server=dedivirt793.your-server.de;user id=dediviqpv_14;"
                + "password=QpSt76L1PXcaaRmQ ;persistsecurityinfo=True;port=3306;"
                + "database=dediviqpv_db14;SslMode=none"
                ;
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MySQLConfiguration.Standard
                .ConnectionString(conn_str).ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Cpnp>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CpnpArt>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CpnpProd1s>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CpnpQueries>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, false))
                // .ExposeConfiguration(BuildSchema)
                .BuildSessionFactory();

            return sessionFactory.OpenSession();
        }
    }
}