// 

using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Reflection;
using NHibernate;
using System.Linq;
using NHibernate.SqlCommand;


namespace cpnp_selenium
{
    class Program
    {
        static void Main(string[] args)
        {         
            inidata.ProcHtmlTable();

            //   foreach (List<string> ss in inidata.htable)Console.WriteLine(string.Join(",", ss.ToArray()));
            //   run_browser();
            IWebDriver brw = null;


            ConsoleKeyInfo c;
            do
            {
                run_menu();
                c = Console.ReadKey(false);
                switch (c.KeyChar)
                {
                    case '1':
                        {
                            // login to site
                            if ( brw==null)
                            {
                                brw = new FirefoxDriver();
                                cpnp_rules.login_site(brw);
                            }
                            else { Console.WriteLine("Browser is opened. "); }
                            
                            break;
                        }
                    case '2':
                        {
                            // goto att
                            walk_site(brw);
                            break;
                        }
                    case '3':
                        {
                            test_map();
                            //  db_add_records_from_htable_to_cpnp();
                            break;
                        }
                    case '4':
                        {
                            //  db_add_records_from_htable_to_cpnp();
                            db_prod1s_proc();
                            break;
                        }
                    case '9':
                        {
                            // close browser
                            brw.Quit();
                            brw = null;
                            break;
                        }
                    case 'c':
                        {
                            // close browser
                            Console.Clear();
                            break;
                        }
                }
                //Console.WriteLine("Enter to exit...");
                //Console.ReadLine();
                //Console.ReadLine();
            } while (c.Key != ConsoleKey.Escape);
            if (brw != null) { brw.Quit(); brw = null; }

        }



        static int run_menu()
        {

            Console.WriteLine("1 - Login to cpnp");
            Console.WriteLine("2 - open product");
            Console.WriteLine("3 - add url to cpnp table");
            Console.WriteLine("4 - prod1s proc");
            Console.WriteLine("9 - close browser");
            Console.WriteLine("c - clear csreen");
            Console.WriteLine("ESC - quit");
            return 1; // Console.Read();
        }

        /// <summary>
        ///  Testing method
        /// </summary>
        static void test_map()
        {

            //// example 1. list selection
            //ISession session = Models.NHibernateHelper.OpenSession();
            //var clients = session.QueryOver<CpnpProd1s>().Where(x => x.cpnp_exist == "1").List();
            //foreach (var ss in clients) { Console.WriteLine("{0}\t{1}", ss.art,ss.sname_1s); }



            //  foreach (var ss in inidata.qu_List) { Console.WriteLine("{0}\t{1}", ss.id, ss.squery); }


            //ISession session = Models.NHibernateHelper.OpenSession();
            //using (var tx = session.BeginTransaction())
            //{
            //    var entity = session.Get<CpnpProd1s>();
            //    entity.cpnp_exist = "new value";
            //    entity.cpnp_to_add = "new value";
            //    tx.Commit();
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        static void db_prod1s_proc()
        {
            CpnpArt CpnpArtAlias = null;
            CpnpProd1s CpnpProd1SAlias = null;

            ISession session = Models.NHibernateHelper.OpenSession();

            var tt = session
            .QueryOver<CpnpProd1s>(() => CpnpProd1SAlias)
            .JoinEntityAlias(
                () => CpnpArtAlias , () => CpnpProd1SAlias.art == CpnpArtAlias.art , JoinType.InnerJoin
              )
              .List();
            foreach (var ss in tt) { Console.WriteLine("{0}\t{1}\t{2}\t{3}",ss.art, ss.sname_1s, ss.cpnp_exist.ToString(), ss.cpnp_to_add.ToString()); }

            var tt2 = session
            .QueryOver<CpnpProd1s>(() => CpnpProd1SAlias)
              .List();



            Console.WriteLine("total records 1: {0}\ntotal records 2: {1}", tt.Count().ToString(), tt2.Count().ToString());


            //   foreach (var ss in inidata.qu_List) { Console.WriteLine("{0}\n{1}", ss.id, ss.squery); }

            //var result = session.CreateSQLQuery(inidata.qu_List[2].squery).List<object[]>();
            //foreach (var ss in result) {
            //    Console.WriteLine(string.Join(",", ss.ToArray()));
            //   // Console.WriteLine("{0}\t", ss[1]);
            //}




            // example. SQL query execute
            //ITransaction tx = session.BeginTransaction();
            //var updatedEntities = session.CreateSQLQuery(inidata.qu_List[1].squery).ExecuteUpdate();           
            //tx.Commit();
            //session.Close();

        }



        // join samples
        static void db_prod1s_proc_tmp()
        {

            CpnpArt CpnpArtAlias = null;
            CpnpProd1s CpnpProd1SAlias = null;
            ISession session = Models.NHibernateHelper.OpenSession();
            //IQueryOver<CpnpProd1s, CpnpProd1s> pp = 
            //    session.QueryOver<CpnpProd1s>(() => CpnpProd1SAlias)
            //    .JoinAlias(() => CpnpProd1SAlias.art,()=> CpnpArtAlias)


            //Cat cat = null;
            //Cat joinedCat = null;


            // try
            // {
            /* var tt =  session
                // .CreateSQLQuery("")

                .QueryOver<CpnpProd1s>(() => CpnpProd1SAlias)
                    .JoinEntityAlias(
                      () => CpnpArtAlias
                    , () => CpnpProd1SAlias.art == CpnpArtAlias.art
                    , JoinType.InnerJoin
                    )

                    .Select(c => CpnpArtAlias.cpnp, c => CpnpArtAlias.art
                    , c => CpnpProd1SAlias.art, c => CpnpProd1SAlias.sname_1s)
                    .List<object[]>();
            */


             //   foreach (var ss in tt) { Console.WriteLine("{0}\t{1}\t{2}", ss.art, ss.cpnp_exist, ss.sname_1s); }
             //   System.IO.File.WriteAllLines(@"d:\\aaa555.txt", tt.Select(ss => String.Format("{0}\t{1}\t{2}", ss.art, ss.cpnp_exist, ss.sname_1s)).ToArray());
               
            
            //  foreach (var ss in tt) { Console.WriteLine("{0}\t{1}\t{2}\t{3}", ss[0],ss[1],ss[2], ss[3]); }
                //System.IO.File.WriteAllLines(@"d:\\aaa444.txt", tt.Select(z => String.Format("{0}\t{1}\t{2}\t{3}", z[0], z[1], z[2], z[3])).ToArray());
                //using (ISession session = Models.NHibernateHelper.OpenSession())
                //{
                //    var testtable = session.QueryOver<CpnpProd1s>().List();
                //    foreach (var ss in testtable) { Console.WriteLine("{0}\t{2}\t{1}", ss.art, ss.sname_1s, ss.cpnp_exist); }
                //    //var list = session.QueryOver<Master>()
                //    //                     .JoinQueryOver(master => master.imagen)
                //    //                     .Where(imagen => imagen.linea.Id == 5)
                //    //                     .List();

                //}

            //}
            //catch (Exception e) { Console.WriteLine(e.ToString()); }
        }

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



        static void walk_site(IWebDriver browser)
        {
            int i = 0;
            bool isColumnName = true;
            string sstr = "2288818";  //ReformA Gelpolish Tenerife BEF28D26D853D0CDC564821B9BE2B8D8 2288818

            foreach (List<string> ss in inidata.htable)
            {
                if (isColumnName) { isColumnName = false; continue; }
                //Console.WriteLine(string.Join(",", ss.ToArray()));
                if (ss.Contains(sstr))
                {
                    Console.WriteLine(ss[2]);
                    cpnp_rules.open_product_page(browser, ss[2]);
                    break;
                }
             // if (++i > 2) break;
            }

        }




        static void logout_site(IWebDriver b)
        {
            b.Navigate().GoToUrl(inidata.ldata.url);
        }


    }
}
