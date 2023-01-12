using NovemberQA.Input;
using NovemberQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NovemberQA.Utilities.WaitHelpers;
using TechTalk.SpecFlow;

namespace NovemberQA.Pages
{
    public class LoginPage : CommonDriver
    {
       public IWebElement signIn => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
       public IWebElement emailId => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
       public IWebElement passwordTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));

       public IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));


        public void LoginSteps(IWebDriver driver)
        {
           
        //navigate to URL
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            try
            {

                //Enter valid username and valid password
                signIn.Click();
                emailId.SendKeys(LoginCredentials.userName);
                passwordTextbox.SendKeys(LoginCredentials.passWord);

                //Click login button
                loginButton.Click();
                WaitToBeVisible(driver, "XPath", "//a[contains(text(),'Mars Logo')]", 20);

            }
            catch (Exception ex)
            {
                Assert.Fail("Unable to launch Mars portal", ex.Message);
            }

        }
    }
}
