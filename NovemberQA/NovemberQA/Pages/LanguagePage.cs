using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NovemberQA.Utilities.WaitHelpers;
using NovemberQA.Utilities;
using System.Reflection.Emit;

namespace NovemberQA.Pages
{
    public class LanguagePage : CommonDriver
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
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 7);

            IWebElement newLang = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement newLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            Assert.That(newLang.Text == languages, "Actual Language and expected language do not match");
            Assert.That(newLevel.Text == level, "Actual Level and expected level do not match");

        }

        public void EditLanguages(IWebDriver driver)

        {
            WaitToBeClickable(driver, "XPath", "//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]", 20);
            IWebElement editButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
            editButton.Click();
           
            IWebElement langTextbox = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
           
            langTextbox.Clear();
            langTextbox.SendKeys("French");

            SelectElement chooseLanguageLevel = new SelectElement(driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select")));
            chooseLanguageLevel.SelectByValue("Conversational");

            IWebElement updateButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            updateButton.Click();
            


        }

        public void EditedLang(IWebDriver driver)
        {
            WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]", 20);
            IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            profileButton.Click();
            WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 7);

            
            IWebElement editedLang = driver.FindElement(By.XPath("//td[normalize-space()='French']"));
            Assert.That(editedLang.Text == "French", "Actual Language and expected language do not match");
           
        }

        public void DeleteLanguages(IWebDriver driver)

        {
            IWebElement deleteIcon = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[3]/tr[1]/td[3]/span[2]/i[1]"));
            deleteIcon.Click();


        }

        public void DeletedLang(IWebDriver driver)

        {
            IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            profileButton.Click();
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 7);

            IWebElement delLang = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Assert.That(delLang.Text != "Hindi", "Actual Language and expected language do not match");
           

        }


    }
}
    

