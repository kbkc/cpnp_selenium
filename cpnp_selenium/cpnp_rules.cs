using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Windows.Forms;
using System.Collections.ObjectModel;

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
            if (browser != null)
            {
                browser.Navigate().GoToUrl(url);
                System.Threading.Thread.Sleep(4000);
            }
         //   }

        }



        public static void dublicate_product_rules(IWebDriver browser)
        {
            By @by = By.XPath(@"/html/body/div/div[2]/div/a[4]");
            // find element by class & text
            //By.XPath("//a[contains(@class,'buttonPDF ')][contains(text(),'Duplicate product')]");
            //browser.FindElement(By.XPath(@"/html/body/div/div[2]/div/a[4]"))
            try
            {
                // dublicate product press
                browser.FindElement(@by).Click();
            }
            catch (NoSuchElementException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }




        /// <summary>
        /// edit and save new product as draft
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="sdata"></param>
        public static void edit_dublicated_product_rules(IWebDriver browser, List<string> sdata)
        {
            By @by = null;
            try
            {
                //  3.1 Formulation name input
                //*[@id="frameFormOther_9528BC02-CDC6-8C3E-81FEA3584AC0331C-14060B7A3CF13A67B42B8254F247AA00"]
                //< input type = "Text" name = "frameFormOther_9528BC02-CDC6-8C3E-81FEA3584AC0331C-14060B7A3CF13A67B42B8254F247AA00" id = "frameFormOther_9528BC02-CDC6-8C3E-81FEA3584AC0331C-14060B7A3CF13A67B42B8254F247AA00" value = "Gelpolish F" class="otherFrame valid" maxlength="1000">
                //0   941815
                //1   ReformA GEL POLISH Rubber Base
                //2   D:\NextcloudMike\ref_db\cpnp\task_01\img_ing\d_gp01.pdf
                //3   D:\NextcloudMike\ref_db\cpnp\task_01\img_label\941815.pdf
                //4   D:\NextcloudMike\ref_db\cpnp\task_01\img_prod\941815.jpg



                // Product name clear old and write new 
                browser.FindElement(By.XPath(@"//*[@id='productName_1']")).Clear();
                browser.FindElement(By.XPath(@"//*[@id='productName_1']")).SendKeys(sdata[1]);
                System.Threading.Thread.Sleep(2000);


                //*[@id="productName_1"]
                // open details tab
                @by = By.XPath(@"//a[contains(@class,'tabLink')][contains(text(),'Product details')]");
                browser.FindElement(@by).Click();
                System.Threading.Thread.Sleep(2000);

                // ------------------------
                //expand cat. formulation
                // ------------------------
                browser.FindElement(By.XPath(@"/html/body/div[1]/div[2]/div/form/div/div[2]/div/h3[3]/a")).Click();

                // press button browse
                browser.FindElement(By.XPath(@"/html/body/div[1]/div[2]/div/form/div/div[2]/div/div[3]/fieldset[2]/div[6]/div[2]")).Click();

                System.Threading.Thread.Sleep(1000);
                // add ingridients file
                SendKeys.SendWait(@sdata[2]);
                SendKeys.SendWait(@"{Enter}");


                // ------------------------
                //expand expand labeling:
                // ------------------------
                browser.FindElement(By.XPath(@"/html/body/div[1]/div[2]/div/form/div/div[2]/div/h3[4]/a")).Click();



                // ----- ADD LABEL FILE SECTION ----
                
                //    +    +    +    +    +    +    +    +
                // press add doc. open window to add docs
                //    +    +    +    +    +    +    +    +
                browser.FindElement(By.XPath(@"/html/body/div[1]/div[2]/div/form/div/div[2]/div/div[4]/fieldset[1]/div[1]/div[2]/button")).Click();



                //string existingWindowHandle = browser.CurrentWindowHandle;
                //string popupHandle;
                //ReadOnlyCollection<string> windowHandles = null;
               
                // %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                //     block add docs
                // press button browse

                //var yourParentElement = browser.FindElement(By.XPath("/html/body/div[6]"));
                //var children = yourParentElement.FindElements(By.XPath(".//*"));


                //browser.SwitchTo().Alert();


                if (browser.FindElement(By.XPath(@"/html/body/div[6]")).Displayed)
                {
                    // MessageBox.Show("element found");
                    System.Threading.Thread.Sleep(500);
                    if (browser.FindElement(By.XPath(@"/html/body/div[6]")).FindElement(By.XPath(@"//*[@id=""documentFrm""]")).Displayed)
                    {
                        // MessageBox.Show("document frm found");

                        System.Threading.Thread.Sleep(500);
                        if (browser.FindElement(By.XPath(@"/html/body/div[6]")).FindElement(By.XPath(@"//*[@id=""documentFrm""]")).FindElement(By.XPath(@"//*[@id=""document_1""]")).Displayed)
                        {
                            //    MessageBox.Show("document1 found");
                            System.Threading.Thread.Sleep(500);
                            browser.FindElement(By.XPath(@"/html/body/div[6]")).FindElement(By.XPath(@"//*[@id=""documentFrm""]")).FindElement(By.XPath(@"//*[@id=""document_1""]")).SendKeys(@sdata[3]);
                         //   SendKeys.SendWait(@sdata[3]);
                         //   SendKeys.SendWait(@"{Enter}");
                            //  browser.FindElement(By.XPath(@"/html/body/div[6]")).FindElement(By.XPath(@"//*[@id=""documentFrm""]")).FindElement(By.XPath(@"//*[@id=""document_1""]")).SendKeys(@"{Enter}");
                            //   browser.FindElement(By.XPath(@"/html/body/div[6]")).FindElement(By.XPath(@"//*[@id=""documentFrm""]")).FindElement(By.XPath(@"//*[@id=""document_1""]")).Click();
                        }
                    }
                }
                else MessageBox.Show("not");

 
                System.Threading.Thread.Sleep(2000);


                // add label file
                ////SendKeys.SendWait(@sdata[3]);
                ////SendKeys.SendWait(@"{Enter}");


                // press save button.
                browser.FindElement(By.XPath(@"//*[@id='addBtn']")).Click();

                //   end  block add docs
                // %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                // switch back to main window
                //browser.SwitchTo().Window(existingWindowHandle);






                System.Threading.Thread.Sleep(2000);




                // ----- ADD PRODUCT IMAGE FILE SECTION ----
                //    +    +    +    +    +    +    +    +
                // press add doc. open window to add docs
                //    +    +    +    +    +    +    +    +      
                browser.FindElement(By.XPath(@"/html/body/div[1]/div[2]/div/form/div/div[2]/div/div[4]/fieldset[2]/div[1]/div[2]/button")).Click();


                if (browser.FindElement(By.XPath(@"/html/body/div[6]")).Displayed)
                {
                    // MessageBox.Show("element found");
                    System.Threading.Thread.Sleep(500);
                    if (browser.FindElement(By.XPath(@"/html/body/div[6]")).FindElement(By.XPath(@"//*[@id=""documentFrm""]")).Displayed)
                    {
                        // MessageBox.Show("document frm found");

                        System.Threading.Thread.Sleep(500);
                        if (browser.FindElement(By.XPath(@"/html/body/div[6]")).FindElement(By.XPath(@"//*[@id=""documentFrm""]")).FindElement(By.XPath(@"//*[@id=""document_1""]")).Displayed)
                        {
                            //    MessageBox.Show("document1 found");
                            System.Threading.Thread.Sleep(500);
                            browser.FindElement(By.XPath(@"/html/body/div[6]")).FindElement(By.XPath(@"//*[@id=""documentFrm""]")).FindElement(By.XPath(@"//*[@id=""document_1""]")).SendKeys(@sdata[4]);
                            // browser.FindElement(By.XPath(@"/html/body/div[6]")).FindElement(By.XPath(@"//*[@id=""documentFrm""]")).FindElement(By.XPath(@"//*[@id=""document_1""]")).SendKeys(@"{Enter}");
                            //SendKeys.SendWait(@"{Enter}");
                            //   browser.FindElement(By.XPath(@"/html/body/div[6]")).FindElement(By.XPath(@"//*[@id=""documentFrm""]")).FindElement(By.XPath(@"//*[@id=""document_1""]")).Click();
                        }
                    }
                }
                else MessageBox.Show("not adding img");
                System.Threading.Thread.Sleep(500);

                // press save button
                browser.FindElement(By.XPath(@"//*[@id='addBtn']")).Click();

                System.Threading.Thread.Sleep(1000);

                // ------  end edit product.  ---------


                System.Threading.Thread.Sleep(1000);
                // press Save draft button
                browser.FindElement(By.XPath(@"//*[@id='submitDraftBtn']")).Click();



                System.Threading.Thread.Sleep(1000);
               // MessageBox.Show("SAVED!!!!!!!!!!");


                //// open general info tab
                //@by = By.XPath(@"//a[contains(@class,'tabLink')][contains(text(),'General information')]");
                //browser.FindElement(@by).Click();


                // -----------------------------------------------------------
                //                     edit tabs group:
                // -----------------------------------------------------------
                //// open details tab
                //@by = By.XPath(@"/html/body/div/div[2]/div/div[5]/ul/li[2]/a");
                //browser.FindElement(@by).Click();
                //System.Threading.Thread.Sleep(2000);

                //// open version tab
                //@by = By.XPath(@"/html/body/div/div[2]/div/div[5]/ul/li[3]/a");
                //browser.FindElement(@by).Click();
                //System.Threading.Thread.Sleep(2000);

                //// open first tab
                //@by = By.XPath(@"/html/body/div/div[2]/div/div[5]/ul/li[1]/a");
                //browser.FindElement(@by).Click();
                // -----------------------------------------------------------
                //                  end edit tabs group
                // -----------------------------------------------------------

                //   new WebDriverWait(browser, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementExists(@by));
            }
            catch (NoSuchElementException exception)
            {
                MessageBox.Show(exception.Message);
            }
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
