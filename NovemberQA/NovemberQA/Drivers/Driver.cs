using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovemberQA.Utilities;

namespace NovemberQA.Drivers
{
    public class Driver
    {
        public static IWebDriver driver { get; set; }

        public void Initialize()
        {

            //Defining the browser
            driver = new ChromeDriver();
            

            //Maximise the window
            driver.Manage().Window.Maximize();
        }

        //Implicit Wait
        public static void UseWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }




        //Close the browser
        public void Close()
        {
            driver.Quit();
        }

    }



}
    

