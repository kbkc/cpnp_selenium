using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Reflection;
using NHibernate;
using NHibernate.SqlCommand;

namespace cpnp_selenium
{
    public static class ProcClasses
    {
        public static IWebDriver brw = null;


        public static string login_to_cpnp()
        {
            string s;
            if (brw == null)
            {
                brw = new FirefoxDriver();
                cpnp_rules.login_site(brw);
                s = "\nBrowser is opened";
            }
            else
            {
                s = "\nClose previous opened browser. ";
            }
            return s;
        }

        static void logout_from_cpnp(IWebDriver b)
        {
            b.Navigate().GoToUrl(inidata.ldata.url);
        }



        public static string open_product(IWebDriver browser, string cpnp_num)
        {
            int i = 0;
            bool isColumnName = true;
            // string cpnp_num = "2288818";  //ReformA Gelpolish Tenerife BEF28D26D853D0CDC564821B9BE2B8D8 2288818
            string log = "\r\n open " + cpnp_num + "\r\n";
            foreach (List<string> ss in inidata.htable)
            {
                log += "\r\n " + ss[2];
                if (isColumnName) { isColumnName = false; continue; }
                //Console.WriteLine(string.Join(",", ss.ToArray()));
                if (ss.Contains(cpnp_num))
                {
                    log += "\r\n Bingo! \r\n";
                    //  Console.WriteLine(ss[2]);
                    cpnp_rules.open_product_page(browser, ss[2]);
                    break;
                }
                // if (++i > 2) break;
            }
            return log;
        }

        public static string dublicate_product(IWebDriver browser)
        {
            // string cpnp_num = "2288818";  //ReformA Gelpolish Tenerife BEF28D26D853D0CDC564821B9BE2B8D8 2288818
            string log = "\r\n dublicate product \r\n";
            cpnp_rules.dublicate_product_rules(browser);
            // cpnp_rules.edit_dublicated_product_rules(browser);
            return log;
        }


        //public static string edit_dublicated_product(IWebDriver browser,)
        //{
        //    // string cpnp_num = "2288818";  //ReformA Gelpolish Tenerife BEF28D26D853D0CDC564821B9BE2B8D8 2288818
        //    string log = "\r\n change dublicated product \r\n";
        //  //  cpnp_rules.edit_dublicated_product_rules(browser,listprod);
        //    return log;
        //}





        static void db_add_records_from_htable_to_cpnp()
        {
            // insert data from htable class to table 'cpnp'
            using (ISession session = Models.NHibernateHelper.OpenSession())
            using (ITransaction tx = session.BeginTransaction())
            {
                //  var testtable = session.QueryOver<Cpnp>().List();

                //  foreach (var ss in testtable){   Console.WriteLine("{0}\t{1}", ss.cpnpVal, ss.sname); }
                //foreach (List<string> ss in inidata.htable.Skip(1)){  Console.WriteLine("{0}\t{1}\t{2}", ss[0], ss[1], ss[2]);}
                foreach (List<string> ss in inidata.htable.Skip(1))
                {
                    Cpnp cc = new Cpnp();
                    cc.cpnpVal = ss[0];
                    cc.sname = ss[1];
                    cc.url = ss[2];
                    session.Save(cc);
                }
                tx.Commit();
            }
        }


    }
}
