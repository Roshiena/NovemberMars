using NovemberQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
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
        public void AddCertification(IWebDriver driver, string certificate, string certified, string year)
        {
            IWebElement certificateTab = driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));
            certificateTab.Click();

            IWebElement certificateAddbutton = driver.FindElement(By.XPath("//thead/tr[1]/th[4]/div[1]"));
            certificateAddbutton.Click();
            

            IWebElement certificateTextbox = driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            certificateTextbox.SendKeys(certificate);
            

            IWebElement certifiedTextbox = driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
            certifiedTextbox.SendKeys(certified);

            SelectElement yearDropdown = new SelectElement(driver.FindElement(By.XPath("//select[@name='certificationYear']")));
            yearDropdown.SelectByValue(year);

            IWebElement addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addButton.Click();
            
        }

        public void NewCertification( IWebDriver driver, string certificate, string certified, string year)
        {
            IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            profileButton.Click();
            //WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 7);

            IWebElement certificateTab = driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));
            certificateTab.Click();
            Waits();

            IWebElement newCertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement newCertified = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            IWebElement newYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
            Assert.That(newCertification.Text == certificate, "Actual Cetification and expected certification do not match");
            Assert.That(newCertified.Text == certified, "Actual Certified and expected certified do not match");
            Assert.That(newYear.Text == year, "Actual year and expected  year do not match");
        }

        public void EditCertification(IWebDriver driver)
        {
            IWebElement certificateTab = driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));
            certificateTab.Click();

            IWebElement certificateEditButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[4]/span[1]/i[1]"));
            certificateEditButton.Click();


            IWebElement certificateTextbox = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/div[1]/input[1]"));
            certificateTextbox.Clear();
            certificateTextbox.SendKeys("Certificate in Computer Applications");


            IWebElement certifiedTextbox = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/div[2]/input[1]"));
            certifiedTextbox.Clear();
            certifiedTextbox.SendKeys("Anna University");

            SelectElement yearDropdown = new SelectElement(driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/div[3]/select[1]")));
            yearDropdown.SelectByValue("2020");

            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click();

        }

        public void EditedCertification(IWebDriver driver)
        {
            IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            profileButton.Click();
            //WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 7);

            IWebElement certificateTab = driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));
            certificateTab.Click();
            Waits();

            IWebElement newCertification = driver.FindElement(By.XPath("//td[contains(text(),'Certificate in Computer Applications')]"));
            IWebElement newCertified = driver.FindElement(By.XPath("//td[contains(text(),'Anna University')]"));
            IWebElement newYear = driver.FindElement(By.XPath("//td[contains(text(),'2020')]"));
            Assert.That(newCertification.Text == "Certificate in Computer Applications", "Actual Cetification and expected certification do not match");
            Assert.That(newCertified.Text == "Anna University", "Actual Certified and expected certified do not match");
            Assert.That(newYear.Text == "2020", "Actual year and expected  year do not match");
        }

        public void DeleteCertification(IWebDriver driver)
        {
            IWebElement certificateTab = driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));
            certificateTab.Click();

            IWebElement deleteButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[5]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[4]/span[2]/i[1]"));
            deleteButton.Click();

        }

        public void DeletedCertification(IWebDriver driver)
        {
            IWebElement certificateTab = driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));
            certificateTab.Click();
            Waits();
            IWebElement deletedTitle = driver.FindElement(By.XPath("//td[contains(text(),'Test Analyst')]"));
            Assert.That(deletedTitle.Text != "Certificate in Computer Applications", "Actual title and expected title do not match");
        }





    }
}
