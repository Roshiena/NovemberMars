using NovemberQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V105.Network;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace NovemberQA.Pages
{
    public class CertificationPage : CommonDriver
    {

        public IWebElement certificateTab => driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));
        public IWebElement certificateAddbutton => driver.FindElement(By.XPath("//thead/tr[1]/th[4]/div[1]"));
        public IWebElement certificateTextbox => driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
        public IWebElement certifiedTextbox => driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
        public IWebElement addButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        public IWebElement newCertification => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
        public IWebElement newCertified => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
        public IWebElement newYear => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
        public IWebElement certificateEditButton => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[4]/span[1]/i[1]"));
        public IWebElement updateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        public IWebElement editedCertification => driver.FindElement(By.XPath("//td[contains(text(),'Certificate in Computer Applications')]"));
        public IWebElement editedCertified => driver.FindElement(By.XPath("//td[contains(text(),'Anna University')]"));
        public IWebElement editedYear => driver.FindElement(By.XPath("//td[contains(text(),'2020')]"));
        public IWebElement deleteButton => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[4]/span[2]/i[1]"));
        public IWebElement deletedTitle => driver.FindElement(By.XPath("//td[contains(text(),'Test Analyst')]"));

        public void NavigateToCertificationPage()
        {

            certificateTab.Click();
            

        }

        public void AddCertification(string certificate, string certified, string year)
        {
            
            certificateAddbutton.Click();
            certificateTextbox.SendKeys(certificate);
            certifiedTextbox.SendKeys(certified);

            SelectElement yearDropdown = new SelectElement(driver.FindElement(By.XPath("//select[@name='certificationYear']")));
            yearDropdown.SelectByValue(year);

            addButton.Click();
            Thread.Sleep(2000);




        }

        public string GetCertificate()
        {
            //Implicit Wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            return newCertification.Text;
        }

        public string GetCertified()
        {

            return newCertified.Text;
        }

        public string GetYear()
        {

            return newYear.Text;
        }

        public void EditCertification(string certificate, string certified, string year)
        {
           
            certificateTab.Click();
            certificateEditButton.Click();
            certificateTextbox.Clear();
            certificateTextbox.SendKeys(certificate);
            certifiedTextbox.Clear();
            certifiedTextbox.SendKeys(certified);

            SelectElement yearDropdown = new SelectElement(driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/div[3]/select[1]")));
            yearDropdown.SelectByValue(year);

            updateButton.Click();

        }

        public string EditedCertificate()
        {
            //Implicit Wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return editedCertification.Text;
        }

        public string EditedCertified()
        {

            return editedCertified.Text;
        }

        public string EditedYear()
        {

            return editedYear.Text;
        }


        public void DeleteCertification()
        {
            
            certificateTab.Click();
            deleteButton.Click();

        }

       
        public string DeletedCertificate()
        {
 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return deletedTitle.Text;
        }


    }
}
