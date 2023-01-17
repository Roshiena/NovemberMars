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
        public IWebElement langAddNew => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public IWebElement langTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        public IWebElement langAddbutton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        public IWebElement profileButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
        public IWebElement newLang => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        public IWebElement newLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
        public IWebElement editButton => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
        public IWebElement editedLangTextbox => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
        public IWebElement updateButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]"));
        public IWebElement editedLang => driver.FindElement(By.XPath("//td[normalize-space()='French']"));
        public IWebElement delLang => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));


        public void AddLanguages(string languages, string level)

        {
            
            langAddNew.Click();
            langTextbox.SendKeys(languages);

            SelectElement chooseLanguageLevel = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")));
            chooseLanguageLevel.SelectByValue(level);

            langAddbutton.Click();


        }

        public string GetLanguage()
        {
            
            profileButton.Click();
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//td[normalize-space()='Arabic']", 10);
            return newLang.Text;

            

        }

        public string GetLevel()
        {
            return newLevel.Text;
        }

        public void EditLanguages(string languages, string level)

        {
            
            WaitToBeClickable(driver, "XPath", "//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]", 30);
            
            editButton.Click();
           
            editedLangTextbox.Clear();
            editedLangTextbox.SendKeys(languages);

            SelectElement chooseLanguageLevel = new SelectElement(driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select")));
            chooseLanguageLevel.SelectByValue(level);

            
            updateButton.Click();
            
            


        }

        public string EditedLang()
        {
            Thread.Sleep(1000);
            //WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]", 30);
            
            profileButton.Click();
            WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 25);

            return editedLang.Text;
   
            
           
        }

        public string EditedLevel()
        {
            return newLevel.Text;
        }



        public void DeleteLanguages()

        {
            IWebElement deleteIcon = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[3]/tr[1]/td[3]/span[2]/i[1]"));
            deleteIcon.Click();


        }

        public string DeletedLang()

        {
            
            profileButton.Click();
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 7);

            return delLang.Text;
            
           

        }


    }
}
    

