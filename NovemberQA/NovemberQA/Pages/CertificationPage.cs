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
            IWebElement newCertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement newCertified = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            IWebElement newYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]"));
            Assert.That(newCertification.Text == certificate, "Actual Cetification and expected certification do not match");
            Assert.That(newCertified.Text == certified, "Actual Certified and expected certified do not match");
            Assert.That(newYear.Text == year, "Actual year and expected  year do not match");
        }
        
        
    }
}
