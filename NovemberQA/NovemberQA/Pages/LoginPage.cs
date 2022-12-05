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

namespace NovemberQA.Pages
{
    public class LoginPage : Driver
    {
        public void LoginSteps(IWebDriver driver)
        {

            //navigate to URL
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            try
            {

                //Enter valid username and valid password
                IWebElement signIn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
                signIn.Click();

                IWebElement emailId = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                emailId.SendKeys(LoginCredentials.userName);

                IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                passwordTextbox.SendKeys(LoginCredentials.passWord);

                //Click login button

                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();
                Wait.WaitToBeVisible(driver, "XPath", "//a[contains(text(),'Mars Logo')]", 20);

            }
            catch (Exception ex)
            {
                Assert.Fail("Unable to launch Mars portal", ex.Message);
            }

        }
    }
}
