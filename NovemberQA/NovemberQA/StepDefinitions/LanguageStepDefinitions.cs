using NovemberQA.Pages;
using NovemberQA.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NovemberQA.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        LanguagePage languagePageObj = new LanguagePage();

        [Given(@"I logged into portal successfully")]
        public void GivenILoggedIntoPortalSuccessfully()
        {
            
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I add '([^']*)' and '([^']*)' to the profile")]
        public void WhenIAddAndToTheProfile(string languages, string level)
        {
            
            languagePageObj.AddLanguages(driver, languages, level);
        }

        [Then(@"The '([^']*)' and '([^']*)' should be added successfully")]
        public void ThenTheAndShouldBeAddedSuccessfully(string languages, string level)
        {
            
            languagePageObj.NewLang(driver, languages, level);
            
        }
    }
}