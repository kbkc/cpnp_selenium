using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace cpnp_selenium
{
    class HtmlParse
    {
        public static string html_ffn { get; set; }
        public static List<List<string>> html_table = new List<List<string>>();



        public static List<List<string>> GetTable(string ffn)
        {
          //  var html = new HtmlDocument();
          //  html.Load(ffn); // load a file
          //  html.LoadHtml(new WebClient().DownloadString("http://www.somedomain.com")); // load a string


            HtmlDocument doc = new HtmlDocument();
            //doc.LoadHtml(@"<html><body><p><table id=""foo""><tr><th>hello</th></tr><tr><td>world</td></tr></table></body></html>");
            doc.Load(ffn); // load a file
            string stmp = "";
            foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//table"))
            {
               // Console.WriteLine("Found: " + table.Id);
                foreach (HtmlNode row in table.SelectNodes("tr"))
                {
                    List<string> ls = new List<string>();
                    foreach (HtmlNode cell in row.SelectNodes("th|td"))
                    {
                        var hrefs = cell.Descendants("a").Select(node => node.GetAttributeValue("href", "")).ToList();
                        stmp = string.Join(Environment.NewLine, hrefs);
                        ls.Add(System.Net.WebUtility.HtmlDecode( cell.InnerText));
                      //  Console.WriteLine("cell: " + cell.InnerText);
                        if (stmp !=string.Empty) { ls.Add(stmp); stmp = ""; }
                    }
                    html_table.Add(ls);
                }
            }
            return html_table;
        }

    }
}
