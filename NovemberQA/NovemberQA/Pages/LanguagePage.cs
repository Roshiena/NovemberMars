using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NovemberQA.Utilities.WaitHelpers;
using NovemberQA.Drivers;

namespace NovemberQA.Pages
{
    public class LanguagePage : Driver
    {
        public void AddLanguages(IWebDriver driver, string languages, string level)

        {
            IWebElement langAddNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            langAddNew.Click();


            IWebElement langTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            langTextbox.SendKeys(languages);

            SelectElement chooseLanguageLevel = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")));
            chooseLanguageLevel.SelectByValue(level);

            IWebElement langAddbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            langAddbutton.Click();


        }

        public void NewLang(IWebDriver driver, string languages, string level)
        {
            IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            profileButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 7);

            IWebElement newLang = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement newLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            Assert.That(newLang.Text == languages, "Actual Language and expected language do not match");
            Assert.That(newLevel.Text == level, "Actual Level and expected level do not match");

        }


    }
}
    

