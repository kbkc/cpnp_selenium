using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//using LinqToExcel;
using Microsoft.Office.Interop.Excel;
using NHibernate;
using System.Linq;
using NHibernate.SqlCommand;


namespace cpnp_selenium
{
    public static class inidata
    {
        public static string CfgFileName = "app_cfg.xml";
        public static LoginData ldata;
        public static string data_file_name = "";
        public static string sheet_name = "";
        public static string cpnp_start_page = "";
        public static List<List<string>> htable = new List<List<string>>();
        public static IList<CpnpQueries> qu_List = null;

        public static List<ProdData> pdl = new List<ProdData>();


        static inidata()
        {
            // XDocument 
            XDocument xml = XDocument.Load(CfgFileName);
            // Query the data and write out a subset of contacts
            try
            {
                data_file_name = xml.Root.Element("data_file_name").Value.ToString();
                sheet_name = xml.Root.Element("sheet_name").Value.ToString();
                cpnp_start_page = xml.Root.Element("cpnp_start_page").Value.ToString();

                XNamespace ns = xml.Root.Name.Namespace;

                var ms = xml.Root.Element("login_data");
                    ldata = new LoginData()
                    {
                        url = ms.Element("url").Value.ToString(),
                        login = ms.Element("login").Value.ToString(),
                        pass = ms.Element("pw").Value.ToString()
                    };
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                //error_flag = true;
                //mail_message += "\n XML read error {0} Exception caught." + e;
                //    Console.ReadKey();
            }

            try
            {
                using (ISession session = Models.NHibernateHelper.OpenSession())
                {
                    qu_List = session.QueryOver<CpnpQueries>().List();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                //error_flag = true;
                //mail_message += "\n XML read error {0} Exception caught." + e;
                //    Console.ReadKey();
            }

        }




        public static void ProcXlsx()
        {
          //  //var sData = new ExcelQueryFactory(data_file_name);
          //  //var rows = from row in sData.Worksheet(sheet_name) select row;
          //  //foreach (var a in rows)   {
          //  //    string artistInfo = "Artist Name: {0}; Album: {1}";
          //  //    Console.WriteLine(string.Format(artistInfo, a[1], a[2]));
          //  //}

          //  Workbook workbook = new Workbook();

          //  workbook.//.LoadFromFile(data_file_name);

          //  Worksheet sheet = workbook.Worksheets[0];

          //  Console.WriteLine( sheet.HyperLinks[0].Address);
          ////  textBox2.Text = sheet.HyperLinks[1].Address;
        }


        public static void ProcHtmlTable()
        {
            htable = HtmlParse.GetTable(data_file_name);
         }

    }
 
    public class LoginData
    {
        public string url { get; set; }
        public string login { get; set; }
        public string pass { get; set; }
    }

    public class ProdData
    {
        public string CPNPRef { get; set; }
        public string ProdName { get; set; }
        public string url { get; set; }
        public string RespPerson { get; set; }
        public string Category { get; set; }
        public string FormName { get; set; }
        public string Version { get; set; }
        public string NotificationDate { get; set; }
        public string Status { get; set; }

    };


}
