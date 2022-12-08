using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NovemberQA.Pages;

namespace NovemberQA.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;


        public static void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);


        }

        public static void Waits()
        {
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

        }



        public static void Close()
        {
            driver.Quit();
        }

    }



}


