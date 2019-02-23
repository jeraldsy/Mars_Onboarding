using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowPages.Utils
{
  public class LoginPage
    {
        public static void LoginStep()
        {
            Driver.NavigateUrl();
            Thread.Sleep(1000);

            //Click Sign In
            Driver.driver.FindElement(By.CssSelector("#home > div > div > div.ui.secondary.menu.inverted > div > a")).Click();

            //Enter Username
            Driver.driver.FindElement(By.CssSelector("body > div.ui.page.modals.dimmer.transition.visible.active > div > div > div:nth-child(1) > div > div:nth-child(2) > input[type='text']")).SendKeys("jerald_d_sy@yahoo.com");

            //Enter password
            Driver.driver.FindElement(By.CssSelector("body > div.ui.page.modals.dimmer.transition.visible.active > div > div > div:nth-child(1) > div > div:nth-child(3) > input[type='password']")).SendKeys("asdf123");
            Thread.Sleep(1000);
            //Click on Login Button
            Driver.driver.FindElement(By.CssSelector("body > div.ui.page.modals.dimmer.transition.visible.active > div > div > div:nth-child(1) > div > div:nth-child(5) > button")).Click();

            //string msg = "Add New Job";
            //string Actualmsg = Driver.driver.FindElement(By.XPath("//*[@id='addnewjob']")).Text;

            //if (msg == Actualmsg)
            //{
                //Console.WriteLine("Test Passed");
                //CommonMethods.ExtentReports();
                //Thread.Sleep(500);
                //test = CommonMethods.extent.StartTest("Login with valid data");
                //Thread.Sleep(1000);
                //CommonMethods.test.Log(LogStatus.Pass, "Test Passed");
                //SaveScreenShotClass.SaveScreenshot(Driver.driver, "HomePage");
            //}
            //else
            //{
                //Console.WriteLine("Test Failed");
                //CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
            //}
        }

    }
}
