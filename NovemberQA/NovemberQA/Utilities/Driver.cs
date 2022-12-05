using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberQA.Utilities
{
    public class Driver
    {
        public static IWebDriver driver;

        public void Initialize()
        {

            //Defining the browser
            driver = new ChromeDriver();


            //Maximise the window
            driver.Manage().Window.Maximize();
        }

        

        //Close the browser
        public void Close()
        {
            driver.Quit();
        }

    }



}


