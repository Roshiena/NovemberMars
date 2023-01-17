using NovemberQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
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
        public IWebElement skillsTab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        public IWebElement skillsAdd => driver.FindElement(By.XPath("//div[@class='ui teal button']"));
        public IWebElement skillsTextbox => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        public IWebElement skillsAddbutton => driver.FindElement(By.XPath("//input[@value='Add']"));
        public IWebElement profileButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
        public IWebElement skillsButton => driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));

        public IWebElement newSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        public IWebElement skillLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

        public IWebElement updateButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]"));

        public IWebElement editIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[(3)]/tr/td[3]/span[1]/i"));
        public IWebElement editedSkillsTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[(3)]/tr/td/div/div[1]/input"));
        
        public IWebElement editedSkill => driver.FindElement(By.XPath("//td[contains(text(),'Writing')]"));
        public IWebElement editedSkillLevel => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[3]/tr[1]/td[2]"));
        public IWebElement deleteIcon => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
        public IWebElement deletedSkill => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));



        public void AddSkills(string skills, string level)
        {

            skillsTab.Click();

            skillsAdd.Click();

            skillsTextbox.SendKeys(skills);

            SelectElement skillsLevel = new SelectElement(driver.FindElement(By.XPath("//select[@name='level']")));
            skillsLevel.SelectByValue(level);


            skillsAddbutton.Click();
            Thread.Sleep(1000);
        }

        public string GetSkills()
        {

            

            WaitHelpers.WaitToBeVisible(driver ,"XPath", "//td[contains(text(),'Cooking')]", 10);

            return newSkill.Text;

        }

        public string GetLevel()
        {
            return skillLevel.Text;
        }

        public void EditSkills(string skills, string level)
        {

            //Thread.Sleep(1000);
            skillsTab.Click();
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//td[contains(text(),'PetCare')]", 20);
        
            
            editIcon.Click();
            editedSkillsTextbox.Clear();
            editedSkillsTextbox.SendKeys(skills);

            SelectElement skillsLevel = new SelectElement(driver.FindElement(By.XPath("//select[@name='level']")));
            skillsLevel.SelectByValue(level);


            updateButton.Click();

            //WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[1]", 20);

        }
        public string EditedSkills()
        {
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//td[contains(text(),'PetCare')]", 10);
            return editedSkill.Text;
        }

        public string EditedLevel()
        {
            return editedSkillLevel.Text;
        }

        public void DeleteSkills()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 20);

            skillsTab.Click();

            deleteIcon.Click();
        }
        public string DeletedSkills()
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 20);

            skillsTab.Click();

            return deletedSkill.Text;



        }
    }
}