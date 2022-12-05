using NovemberQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NovemberQA.Utilities.WaitHelpers;

namespace NovemberQA.Pages
{
    public class SkillsPage : Driver
    {
        public void AddSkills(IWebDriver driver, string skills, string level)
        {
            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();

            IWebElement skillsAdd = driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            skillsAdd.Click();

            IWebElement skillsTextbox = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            skillsTextbox.SendKeys(skills);

            SelectElement skillsLevel = new SelectElement(driver.FindElement(By.XPath("//select[@name='level']")));
            skillsLevel.SelectByValue(level);

            IWebElement skillsAddbutton = driver.FindElement(By.XPath("//input[@value='Add']"));
            skillsAddbutton.Click();
            

        }

        public void NewSkills(IWebDriver driver, string skills, string level)
        {

            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement skillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

            Assert.That(newSkill.Text == skills, "Actual skills and expected skills do not match");
            Assert.That(skillLevel.Text == level, "Acutal level and expected level do not match");

        }
    }
}
