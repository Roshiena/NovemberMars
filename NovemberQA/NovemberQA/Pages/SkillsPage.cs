using NovemberQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NovemberQA.Pages
{
    public class SkillsPage : CommonDriver
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
            IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            profileButton.Click();
            //WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 7);

            IWebElement skillsButton = driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
            skillsButton.Click();
            Waits();
            //WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 7);


            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement skillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));


            Assert.That(newSkill.Text == skills, "Actual skills and expected skills do not match");
            Assert.That(skillLevel.Text == level, "Acutal level and expected level do not match");

        }

        public void EditSkills(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 20);
            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();

            IWebElement editIcon = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
            editIcon.Click();

            IWebElement skillsTextbox = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            skillsTextbox.Clear();
            skillsTextbox.SendKeys("Writing");

            SelectElement skillsLevel = new SelectElement(driver.FindElement(By.XPath("//select[@name='level']")));
            skillsLevel.SelectByValue("Beginner");

            IWebElement updateButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            updateButton.Click();

        }
        public void EditedSkills(IWebDriver driver)
        {
            // IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            //profileButton.Click();
            //WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 7);

            IWebElement skillsButton = driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
            skillsButton.Click();
            Waits();
            //WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 7);


            IWebElement editedSkill = driver.FindElement(By.XPath("//td[contains(text(),'Writing')]"));
            IWebElement editedSkillLevel = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[2]"));


            Assert.That(editedSkill.Text == "Writing", "Actual skills and expected skills do not match");
            Assert.That(editedSkillLevel.Text == "Beginner", "Acutal level and expected level do not match");

        }

        public void DeleteSkills(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 20);
            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();

            IWebElement deleteIcon = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
            deleteIcon.Click();
        }
        public void DeletedSkills(IWebDriver driver)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 20);
            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();

            IWebElement deletedSkill = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
            Assert.That(deletedSkill.Text != "Cooking", "Actual skills and expected skills do not match");
        }
    }
}