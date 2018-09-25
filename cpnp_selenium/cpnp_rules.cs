using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace cpnp_selenium
{
    public static class cpnp_rules
    {
        public static void login_site(IWebDriver browser)
        {
            browser.Navigate().GoToUrl(inidata.ldata.url);
            //  driver.findElement(By.xpath("element")).isDisplayed();
            if (browser.FindElement(By.XPath(@"//*[@id='username']")).Displayed)
            {
                browser.FindElement(By.XPath(@"//*[@id='username']")).SendKeys(inidata.ldata.login);
                browser.FindElement(By.XPath(@"//*[@id='whoamiForm']/input[2]")).Click();
            }

            browser.FindElement(By.XPath(@"//*[@id='password']")).SendKeys(inidata.ldata.pass);
            browser.FindElement(By.XPath(@"//*[@id='loginForm']/div/input")).Click();

            System.Threading.Thread.Sleep(3000);
            browser.Navigate().GoToUrl(inidata.cpnp_start_page);
            System.Threading.Thread.Sleep(3000);

            if (IsElementPresent(browser, By.XPath(@"/html/body/div/div[9]/a")))
            {
                browser.FindElement(By.XPath(@"/html/body/div/div[9]/a")).Click();
            }
            System.Threading.Thread.Sleep(3000);

        }



        public static void open_product_page(IWebDriver browser, string url)
        {
            //if (IsElementPresent(browser, By.XPath(@"/html/body/div/div[9]/a")))
            //{
            //    // System.Threading.Thread.Sleep(7000);
            //    browser.FindElement(By.XPath(@"/html/body/div/div[9]/a")).Click();
            //    System.Threading.Thread.Sleep(4000);
            //    browser.Navigate().GoToUrl(url);
            //    System.Threading.Thread.Sleep(4000);
            //    //browser.Navigate().GoToUrl(ss[2]);
            //    //System.Threading.Thread.Sleep(4000);
            //}
            //else
          //  {
                browser.Navigate().GoToUrl(url);
                System.Threading.Thread.Sleep(4000);
         //   }

        }

        private static bool IsElementPresent(IWebDriver browser, By by)
        {
            try
            {
                browser.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


    }
}
